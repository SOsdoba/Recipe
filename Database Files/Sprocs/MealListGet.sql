use RecipeDB
go

create or alter procedure dbo.MealListGet(@MealId int = 0, @All bit = 0)
as
begin
	select m.mealid, MealName = m.mealname, Creator = concat(u.firstname, ' ' , u.lastname), NumCalories = sum(r.calories), NumCourses = count(distinct mc.CourseId), NumRecipes = count(distinct mcr.RecipeId)
	from meal m
	join users u
	on u.usersid = m.usersid
	left join MealCourse mc
	on m.mealid = mc.mealid
	left join MealCourseRecipes mcr
	on mc.MealCourseId = mcr.MealCourseId
	left join recipe r
	on r.recipeid = mcr.RecipeId
	group by m.mealid, m.mealname, u.firstname, u.lastname
	order by m.MealName
end
go

exec MealListGet @All = 1









