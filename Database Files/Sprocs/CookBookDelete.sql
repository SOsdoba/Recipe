create or alter procedure dbo.CookBookDelete(
	@CookBookId int = 0,
	@Message varchar(500) = '' output
)
as 
begin
	declare @return int = 0
	
	begin try
		begin tran
		    delete CookBookRecipes where CookBookId = @CookBookId
			delete CookBooks where CookBookId = @CookBookId
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

--select * from cookbooks c where c.cookbookid = 67

--use RecipeDB
--go
--exec CookBookDelete
--@CookBookId = 67,
--@Message = null

--select * from cookbooks c where c.cookbookid = 67

