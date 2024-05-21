create or alter procedure dbo.IngredientGet(
	@IngredientId int = 0, 
	@All bit = 0, 
	@IncludeBlank bit = 0,
	@Message varchar(500) = '' output
)

as
begin
	declare @return int = 0

	select @All = isnull(@All,0), @IngredientId = isnull(@IngredientId,0), @IncludeBlank = isnull(@IncludeBlank,0)

	select i.ingredientid, i.ingredientname
	from Ingredient i
	where Ingredientid = @IngredientId
	or @All = 1
	union select 0, ' '
	where @IncludeBlank = 1
	order by i.ingredientname
	

	return @return
end

exec IngredientGet @All = 1

