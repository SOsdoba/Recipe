create or alter function dbo.IsDeleteAllowed(@Recipeid int)
returns varchar(60)
as
begin
	declare @value varchar(60) = ''
	if exists(select * from recipe r join directions d on d.recipeid = @Recipeid )
	begin
		select @value = 'Cannot delete recipe that has steps.'
	end
	return @value
end
go


select dbo.IsDeleteAllowed(r.recipeid), d.directionsid, *
from recipe r
left join Directions d
on d.RecipeId =  r.recipeid

