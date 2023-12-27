declare @recipeid int

select top 1 @recipeid = r.recipeid
from recipe r
join mealcourserecipes m
on m.recipeid = r.recipeid
order by r.recipeid

select * from Recipe r where r.recipeid = @RecipeId

exec RecipeDelete @RecipeId = @Recipeid

select * from Recipe r where r.recipeid = @recipeid
