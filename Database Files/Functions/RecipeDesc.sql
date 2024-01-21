create or alter function dbo.RecipeDesc(@RecipeId int)
returns varchar(150)
as
begin
	declare @value varchar (150)
	declare @valueone varchar (150)
	declare @valuetwo varchar (150)
	--[Recipe] ([cuisine]) has [num ingredients] ingredients and [num steps] steps.

	select @valueone = concat(r.recipename, ' (', c.cuisinetype, ')', concat(' has ', count(ri.ingredientid), ' ingredient(s)' ))	
	from recipe r
	join cuisinetype c
	on c.cuisinetypeid = r.cuisinetypeid
	left join recipeingredient ri 
	on r.recipeid = ri.recipeid
	where r.recipeid = @recipeid
	group by r.recipename, c.cuisinetype

	select @valuetwo = concat(' and ', count(d.directionsid), ' step(s).')
	from recipe r
	left join directions d 
	on d.recipeid = r.recipeid
	where r.recipeid = @recipeid
	group by r.recipeid

	set @value = @valueone + @valuetwo
	return @value
end
go

select RecipeDesc = dbo.RecipeDesc(r.recipeid), r.*
from recipe r
