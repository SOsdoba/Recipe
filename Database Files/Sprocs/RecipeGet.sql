create or alter procedure dbo.RecipeGet(@RecipeId int = 0, @All bit = 0)
as 
begin

	select r.RecipeId, r.RecipeName, r.RecipeStatus, RecipeUser = concat(u.FirstName, ' ',u.LastName), r.Calories,
		r.usersid, r.cuisinetypeid, r.draftdate, r.publishdate, r.archivedate, NumIngredients = count(ri.IngredientId), r.recipepicture
	from Recipe r
	join users u
	on u.usersid = r.UsersId
	left join RecipeIngredient ri
	on ri.RecipeId = r.RecipeId
	where r.recipeid = @RecipeId
	or @All = 1
	group by r.recipeid, r.recipename, r.RecipeStatus, u.FirstName, u.LastName, r.Calories, r.UsersId, r.CuisineTypeId, r.DraftDate, r.PublishDate, r.ArchiveDate, r.recipepicture
	order by r.recipestatus desc
end
go

--exec RecipeGet
exec RecipeGet @All = 1

--declare @RecipeId int
--select  @RecipeId = r.recipeid from Recipe r
--exec RecipeGet @RecipeId = @RecipeId
