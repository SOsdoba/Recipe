create or alter procedure dbo.RecipeGet(@RecipeId int = 0, @All bit = 0)
as 
begin
	select RecipeId = r.recipeid, RecipeName = r.recipename, RecipeStatus = r.recipestatus, RecipeUser = concat(u.FirstName, ' ',u.LastName), Calories = r.calories,
		r.usersid, r.cuisinetypeid, r.draftdate, r.publishdate, r.archivedate,
		IsDeleteAllowed = dbo.IsDeleteAllowed(r.recipeid)		
	from Recipe r
	join users u
	on u.usersid = r.UsersId
	left join RecipeIngredient ri
	on ri.RecipeId = r.RecipeId
	where r.recipeid = @RecipeId
	or @All = 1
	group by r.recipeid, r.recipename, r.RecipeStatus, u.FirstName, u.LastName, r.Calories, r.UsersId, r.CuisineTypeId, r.DraftDate, r.PublishDate, r.ArchiveDate

end
go

--exec RecipeGet
exec RecipeGet @All = 1

--declare @RecipeId int
--select  @RecipeId = r.recipeid from Recipe r
--exec RecipeGet @RecipeId = @RecipeId
