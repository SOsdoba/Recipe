create or alter function dbo.RecipeDesc(@RecipeId int)
returns varchar(250)
as
begin
	declare @value varchar (250)

	select @value = concat(r.recipename, ' (', c.cuisinetype, ')', concat(' has ', count( distinct ri.IngredientId), ' ingredient(s) and '), count(distinct d.directionsid), ' step(s).')	
	from recipe r
	join cuisinetype c
	on c.cuisinetypeid = r.cuisinetypeid
	left join recipeingredient ri 
	on r.recipeid = ri.recipeid
	left join directions d 
	on d.recipeid = r.recipeid
	where r.recipeid = @recipeid
	group by r.recipename, c.cuisinetype
	
	return @value
end
go

select RecipeDesc = dbo.RecipeDesc(r.recipeid), r.*
from recipe r
