create or alter proc dbo.RecipeIngredientDelete(
	@RecipeIngredientId int = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	delete RecipeIngredient where RecipeIngredientId = @RecipeIngredientId

	return @return
end
go
/*
exec RecipeIngredientDelete
@RecipeIngredientId = 641,
@Message = null

select  *
from recipe r
join RecipeIngredient i
on i.RecipeId = r.RecipeId
where i.recipeingredientid = 641
*/
