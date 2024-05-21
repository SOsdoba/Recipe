create or alter procedure dbo.CuisineTypeDelete(
	@CuisineTypeId int = 0,
	@Message varchar(500) = '' output
)
as 
begin
	declare @return int = 0
	delete MealCourseRecipes from MealCourseRecipes mcr join Recipe r on r.recipeid = mcr.RecipeId where r.cuisinetypeid = @CuisineTypeId
	delete CookBookRecipes from CookBookRecipes c join Recipe r on r.recipeid = c.recipeid where r.cuisinetypeid = @Cuisinetypeid
	delete Directions from Directions d join Recipe r on r.recipeid = d.recipeid where r.cuisinetypeid = @CuisineTypeId
	delete RecipeIngredient from RecipeIngredient ri join Recipe r on r.recipeid = ri.recipeid where r.cuisinetypeid = @CuisineTypeId
	delete Recipe where CuisineTypeId = @CuisineTypeId
	delete CuisineType where CuisineTypeId = @CuisineTypeId
	
		
	return @return
end 
go