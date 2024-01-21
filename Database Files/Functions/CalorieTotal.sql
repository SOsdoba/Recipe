create or alter function dbo.CalorieTotal(@mealid int)
returns int 
as 
begin
	declare @value int

	select @value =  sum(r.calories)
	from meal m 
	join mealcourse mc
	on m.mealid = mc.mealid
	join mealcourserecipes mcr
	on mcr.mealcourseid = mc.mealcourseid
	join recipe r
	on r.recipeid = mcr.recipeid
	where m.mealid = @mealid
	group by m.mealname

	return @value
end
go

select CalorieTotal = dbo.calorietotal(m.mealid), m.*
from meal m