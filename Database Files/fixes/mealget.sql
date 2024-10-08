use RecipeDB
go

create or alter procedure dbo.MealGet(
	@MealId int = 0, 
	@All bit = 0
)
as
begin

	select m.mealid, m.MealName, Creator = concat(u.firstname, ' ' , u.lastname), NumCalories = sum(r.calories), NumCourses = count(distinct mc.CourseId), NumRecipes = count(distinct mcr.RecipeId), m.mealactive, m.datemealcreated, m.mealdesc, m.usersid, m.MealPicture
	from meal m
	join users u
	on u.usersid = m.usersid
	left join MealCourse mc
	on m.mealid = mc.mealid
	left join MealCourseRecipes mcr
	on mc.MealCourseId = mcr.MealCourseId
	left join recipe r
	on r.recipeid = mcr.RecipeId
	where m.mealid = @MealId
	or @All = 1
	group by m.mealid, m.mealname, u.firstname, u.lastname, m.mealactive, m.datemealcreated, m.mealdesc, m.usersid, m.MealPicture

end
go

exec MealGet @All = 1

