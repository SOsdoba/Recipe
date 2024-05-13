use RecipeDB
go
create or alter procedure dbo.RecipeListGet(@RecipeId int = 0,  @All bit = 0)
as 
begin
	select RecipeId = r.recipeid, RecipeName = r.recipename, RecipeStatus = r.recipestatus, RecipeUser = concat(u.FirstName, ' ',u.LastName), Calories = r.calories, NumIngredients = count(ri.IngredientId)
	from Recipe r
	join users u
	on u.usersid = r.UsersId
	left join RecipeIngredient ri
	on ri.RecipeId = r.RecipeId
	where r.recipeid = @RecipeId
	or @All = 1
	group by r.recipeid, r.recipename, r.recipestatus, r.Calories, u.FirstName, u.LastName
	order by r.RecipeStatus desc 
end
go

exec RecipeListGet @All = 1