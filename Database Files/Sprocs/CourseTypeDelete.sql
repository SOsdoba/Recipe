create or alter procedure dbo.CourseTypeDelete(
	@CourseId int = 0,
	@Message varchar(500) = '' output
)
as 
begin
	declare @return int = 0

	delete MealCourseRecipes from MealCourseRecipes mcr join MealCourse mc on mc.mealcourseid = mcr.mealcourseid where mc.CourseId = @CourseId
	delete MealCourse from MealCourse mc  where mc.CourseId = @CourseId	
	delete Course where CourseId = @CourseId
	
	return @return
end 
go
