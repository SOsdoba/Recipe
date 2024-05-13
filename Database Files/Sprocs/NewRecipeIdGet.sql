create or alter procedure dbo.NewRecipeIdGet(
	@RecipeId int = 0 output, 
	@All bit = 0
)
as
begin
	select top 1 r.RecipeId 
	from recipe r
	where @All = 1
	order by r.recipeid desc
end
go

exec NewRecipeIdGet @All = 1
