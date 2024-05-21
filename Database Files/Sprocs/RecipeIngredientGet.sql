create or alter proc dbo.RecipeIngredientGet(
	@RecipeIngredientId int = 0,
	@RecipeId int = 0,
	@All bit = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @All = isnull(@All, 0), @RecipeIngredientId = isnull(@RecipeIngredientId,0), @RecipeId = isnull(@recipeid, 0)

	select  ri.recipeingredientid, ri.MeasurementTypeid, ri.RecipeId, ri.IngredientId, ri.Amount, IngredientSequence = ri.SequenceOfIngredients
	from RecipeIngredient ri
	where ri.RecipeIngredientId = @RecipeIngredientId
	or @All = 1
	or ri.RecipeId = @RecipeId
	order by ri.SequenceOfIngredients

	return @return
end
go

exec RecipeIngredientGet @All = 1