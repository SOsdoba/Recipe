create or alter proc dbo.RecipeStepsDelete(
	@DirectionsId int = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	delete Directions where DirectionsId = @DirectionsId

	return @return
end
go

