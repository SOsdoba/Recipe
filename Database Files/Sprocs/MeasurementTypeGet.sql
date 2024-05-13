create or alter procedure dbo.MeasurementTypeGet(
	@MeasurementTypeId int = 0, 
	@All bit = 0, 
	@Message varchar(500) = '' output
)

as
begin
	declare @return int = 0
	
	select @All = isnull(@All,0), @MeasurementTypeId =isnull(@MeasurementTypeId, 0)

	select m.MeasurementTypeid, m.MeasurementType
	from MeasurementType m
	where MeasurementTypeid = @MeasurementTypeId
	or @All = 1

	return @return
end

exec MeasurementTypeGet @All = 1 