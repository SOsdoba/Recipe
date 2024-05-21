create or alter proc dbo.CookBookRecipesGet(
	@CookBookRecipeId int = 0,
	@CookBookId int = 0,
	@RecipeId int = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select cr.CookBookRecipesId, cr.cookbookid, cr.recipeid, cr.CookBookRecipeSequence
	from CookBookRecipes cr
	where @CookBookId = cr.cookbookid
	order by cr.CookBookRecipeSequence
	
	return @return
end
go

exec CookBookRecipesGet