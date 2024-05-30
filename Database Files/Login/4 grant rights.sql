use RecipeDB
go
--select concat('grant execute on ', r.ROUTINE_NAME, ' to recipeapprole')
--from INFORMATION_SCHEMA.ROUTINES r

grant execute on CuisineTypeGet to recipeapprole
grant execute on CreateCookBook to recipeapprole
grant execute on RecipeGet to recipeapprole
grant execute on UsersGet to recipeapprole
grant execute on RecipeIngredientGet to recipeapprole
grant execute on IngredientGet to recipeapprole
grant execute on MeasurementTypeGet to recipeapprole
grant execute on CookBookRecipesGet to recipeapprole
grant execute on CookBookUpdate to recipeapprole
grant execute on RecipeUpdate to recipeapprole
grant execute on RecipeStepsGet to recipeapprole
grant execute on RecipeIngredientDelete to recipeapprole
grant execute on RecipeStepsDelete to recipeapprole
grant execute on CookBookRecipesDelete to recipeapprole
grant execute on CalorieTotal to recipeapprole
grant execute on RecipeStepsUpdate to recipeapprole
grant execute on RecipeIngredientsUpdate to recipeapprole
grant execute on RecipeDesc to recipeapprole
grant execute on CookBookRecipesUpdate to recipeapprole
grant execute on CookBookDelete to recipeapprole
grant execute on PartyDesc to recipeapprole
grant execute on CourseGet to recipeapprole
grant execute on UsersUpdate to recipeapprole
grant execute on CuisineTypeUpdate to recipeapprole
grant execute on IngredientUpdate to recipeapprole
grant execute on MeasurementTypeUpdate to recipeapprole
grant execute on CourseUpdate to recipeapprole
grant execute on CourseTypeUpdate to recipeapprole
grant execute on CourseTypeGet to recipeapprole
grant execute on DashboardGet to recipeapprole
grant execute on MealGet to recipeapprole
grant execute on UsersDelete to recipeapprole
grant execute on CuisineTypeDelete to recipeapprole
grant execute on IngredientDelete to recipeapprole
grant execute on MeasurementTypeDelete to recipeapprole
grant execute on CloneRecipe to recipeapprole
grant execute on CourseTypeDelete to recipeapprole
grant execute on RecipeDelete to recipeapprole
grant execute on CookBookGet to recipeapprole