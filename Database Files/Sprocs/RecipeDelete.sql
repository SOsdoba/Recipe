create or alter procedure dbo.RecipeDelete(
	@RecipeId int,
	@Message varchar(500) = '' output
)
as 
begin
	declare @return int = 0

	if exists(select * from recipe r where (r.RecipeStatus = 'published' or datediff(day, r.archivedate, getdate())  < 30) and r.RecipeId = @RecipeId)
	begin
		select @return = 1, @Message = 'Cannot delete recipe that is published or archived for less than 30 days.'
		goto finished
	end

	begin try
		begin tran
			delete Directions where RecipeId = @recipeid
			delete RecipeIngredient where RecipeId = @recipeid
			delete Recipe where RecipeId = @recipeid
		commit
	end try
	begin catch
		rollback;
		throw
	end catch

	finished:
	return @return
end 
go
