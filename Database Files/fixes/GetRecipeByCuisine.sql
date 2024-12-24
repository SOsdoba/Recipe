create or alter procedure dbo.GetRecipeByCuisine(
	@CuisineTypeId varchar(50) = '',
	@All int = 1,
	@Message varchar(1000) = '' output
)
as 
begin

	select @CuisineTypeId = isnull(@CuisineTypeId, 0)	

	select r.RecipeId, r.recipename, r.usersid, r.calories, r.vegan, r.recipestatus, r.CuisineTypeId, c.cuisinetype, r.recipepicture, r.draftDate, r.publishDate, r.archiveDate
	from recipe r
	join cuisinetype c
	on r.cuisinetypeid = c.cuisinetypeid	
	where c.cuisinetypeid = @CuisineTypeId
	group by r.RecipeId, r.recipename, r.usersid, r.calories, r.vegan, r.recipestatus, r.CuisineTypeId, c.cuisinetype, r.recipepicture, r.draftDate, r.publishDate, r.archiveDate

end 
go
--exec GetRecipeByCuisine
--exec GetRecipeByCuisine @CuisineTypeId = 1


