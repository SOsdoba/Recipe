create or alter procedure dbo.RecipeDelete(
	@RecipeId int,
	@Message varchar(500) = '' output
)
as 
begin
	declare @return int = 0, @deleteallowed varchar(60)

	select @deleteallowed = isnull(dbo.isdeleteallowed(@recipeid), '')

	if @deleteallowed <> ''
	begin
		select @return = 1, @Message = @deleteallowed
		goto finished
	end

	begin try
		begin tran
			delete MealCourseRecipes where RecipeId = @RecipeId
			delete CookBookRecipes where RecipeId = @RecipeId
			delete RecipeIngredient where RecipeId = @RecipeId
			delete Directions where RecipeId = @recipeid
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
