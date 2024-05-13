create or alter procedure dbo.RecipeStepsUpdate(
	@DirectionsId int output,
	@RecipeId int,
	@Direction varchar(100),
	@Sequence int,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0
	
	select @DirectionsId = isnull(@DirectionsId,0)

	if @DirectionsId = 0
	begin
		insert Directions(RecipeId, Direction, SequenceOfDirections)
		values (@RecipeId, @Direction, @Sequence)

		select @Directionsid = SCOPE_IDENTITY()
	end
	else
	begin
		update Directions
		set
			RecipeId = @RecipeID,
			Direction = @Direction,
			SequenceOfDirections = @Sequence
			where Directionsid = @Directionsid
		end
	return @return
end
go

