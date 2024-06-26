create or alter proc dbo.RecipeStepsGet(
	@RecipeId int = 0,
	@Direction varchar(200) = ' ',
	@All int = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select d.Recipeid, d.Direction, Sequence = d.SequenceOfDirections, d.directionsid
	from directions d
	where @recipeid = d.recipeid
	or @All = 1
	order by d.sequenceofdirections

	return @return

end
go

exec RecipeStepsGet @All = 1