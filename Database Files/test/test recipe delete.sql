declare @recipeid int

select top 1  @recipeid = r.recipeid
from recipe r
left join recipeingredient ri
on ri.recipeid = r.recipeid
left join directions d
on d.recipeid = r.recipeid
where ri.recipeingredientid is null
and d.direction is null
order by r.recipeid

select * from Recipe r where r.RecipeId = @recipeid

exec RecipeDelete @recipeid = @recipeid

select * from Recipe r where r.RecipeId = @recipeid
