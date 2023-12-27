set nocount on 

declare @recipeid int

select top 1 @RecipeId = r.RecipeId
from Recipe r
left join Directions d
on d.RecipeId = r.RecipeId
left join RecipeIngredient i
on r.RecipeId = i.RecipeId
left join MealCourseRecipes m
on m.RecipeId = r.RecipeId
left join CookBookRecipes c
on c.RecipeId = r.RecipeId
where c.RecipeId is null
and m.RecipeId is null
order by r.RecipeId

select 'Recipe', r.RecipeId, r.recipename from Recipe r where r.RecipeId = @RecipeId
union select 'Directions', d.directionsid, d.Direction from Directions d where d.RecipeId = @RecipeId
union select 'RecipeIngredient', ri.recipeingredientid, i.ingredientname from RecipeIngredient ri join ingredient i on i.ingredientid = ri.ingredientid where ri.recipeid = @RecipeId

exec RecipeDelete @RecipeId = @RecipeId

select 'Recipe', r.RecipeId, r.recipename from Recipe r where r.RecipeId = @RecipeId
union select 'Directions', d.directionsid, d.Direction from Directions d where d.RecipeId = @RecipeId
union select 'RecipeIngredient', ri.recipeingredientid, i.ingredientname from RecipeIngredient ri join ingredient i on i.ingredientid = ri.ingredientid where ri.recipeid = @RecipeId
