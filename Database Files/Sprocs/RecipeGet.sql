use RecipeDB
go
create or alter procedure dbo.RecipeGet(@RecipeId int = 0, @All bit = 0, @RecipeName varchar(20) = '')
as 
begin
	select r.recipeid, r.recipename, r.calories, r.draftdate, r.publishdate, r.archivedate, r.recipestatus, r.recipepicture
	from Recipe r
	where r.recipeid = @recipeid
	or @All = 1
	or (@RecipeName  <> '' and r.RecipeName like '%' + @RecipeName + '%')
end
go
/*
exec RecipeGet
exec RecipeGet @All = 1

exec RecipeGet @RecipeName = ''
exec RecipeGet @RecipeName = 'h'
exec RecipeGet @RecipeName = null

declare @recipeid int
select top 1 @recipeid = r.recipeid from Recipe r
exec RecipeGet @recipeid = @recipeid
*/