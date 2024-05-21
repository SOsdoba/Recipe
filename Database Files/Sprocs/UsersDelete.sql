create or alter procedure dbo.UsersDelete(
	@UsersId int = 0,
	@Message varchar(500) = '' output
)
as 
begin
	declare @return int = 0
	
			delete CookBookRecipes from CookBookRecipes cr join CookBooks c on c.cookbookid = cr.cookbookid where c.UsersId = @UsersId
			delete CookBookRecipes from CookBookRecipes cr join Recipe r on r.recipeid  = cr.recipeid where r.usersid = @Usersid
			delete CookBooks where UsersId = @UsersId
			delete MealCourseRecipes from MealCourseRecipes mcr join Recipe r on r.recipeid = mcr.RecipeId where r.UsersId = @UsersId
			delete MealCourseRecipes from MealCourseRecipes mcr join MealCourse mc on mc.MealCourseId = mcr.MealCourseId join meal m on m.mealid = mc.MealId where m.UsersId = @UsersId
			delete MealCourse from MealCourse mc join Meal m on m.MealId = mc.MealId where m.UsersId = @UsersId
			delete Meal from Meal where UsersId = @UsersId
			delete Directions from Directions d join recipe r on r.recipeid = d.recipeid where r.UsersId = @UsersId
			delete RecipeIngredient from RecipeIngredient ri join Recipe r on r.recipeid = ri.RecipeId where r.UsersId = @UsersId
			delete Recipe where UsersId = @UsersId
			delete Users where UsersId = @UsersId
	
	return @return
end 
go
