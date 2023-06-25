use RecipeDB
go
create or alter procedure dbo.RecipeGet(@RecipeId int = 0, @RecipeName varchar(20) = '', @All bit = 0)
as 
begin
	select r.recipeid, r.usersid, r.cuisinetypeid, r.recipename, r.calories, r.draftdate, r.publishdate, r.archivedate, r.recipestatus, r.recipepicture
	from Recipe r
	where r.recipeid = @RecipeId
	or (@RecipeName  <> '' and r.RecipeName like '%' + @RecipeName + '%')
	or @All = 1
end
go
/*
exec RecipeGet
exec RecipeGet @All = 1

exec RecipeGet @RecipeName = ''
exec RecipeGet @RecipeName = 'h'
exec RecipeGet @RecipeName = null

declare @RecipeId int
select top 1 @RecipeId = r.recipeid from Recipe r
exec RecipeGet @RecipeId = @RecipeId
*/