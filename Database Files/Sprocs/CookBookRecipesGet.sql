create or alter proc dbo.CookBookRecipesGet(
	@CookBookRecipeId int = 0,
	@CookBookId int = 0,
	@RecipeId int = 0,
	@All int = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @All = isnull(@All,0)

	select cr.CookBookRecipesId, c.cookbookid, r.recipeid, cr.CookBookRecipeSequence
	from CookBooks c
	left join CookBookRecipes cr
	on c.cookbookid = cr.CookBookId
	left join Recipe r
	on r.recipeid = cr.RecipeId
	where @CookBookId = c.cookbookid
	or @All = 1
	order by cr.CookBookRecipeSequence
	
	return @return

end
go

exec CookBookRecipesGet @All = 1