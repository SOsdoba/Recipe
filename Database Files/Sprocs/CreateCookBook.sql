create or alter proc dbo.CreateCookBook (
	@CookBookId int = null output,
	@UsersId int,
	@Message varchar(500) = '' output
)
as 
begin
	declare @return int = 0
	
		insert CookBooks(UsersId, CookBookName, Price)
		select u.UsersId, CookBookName = concat('Recipes by ', u.firstname, ' ', u.lastname), Price = count(r.RecipeId) * 1.33
		from users u
		left join recipe r
		on r.UsersId = u.UsersId
		where @UsersId = u.UsersId
		group by u.usersid, u.firstname, u.lastname

		select @CookBookId = SCOPE_IDENTITY()
		
		insert CookBookRecipes(CookBookId, RecipeId, CookBookRecipeSequence)
		select @Cookbookid, r.RecipeId, 
			CookBookRecipeSequence = ROW_NUMBER() over (order by r.recipename)
		from Recipe r
		where r.usersid = @UsersId
		group by r.recipeid, r.recipename
						
	return @return
end
go
/*
exec CreateCookBook
@UsersId = 8
*/