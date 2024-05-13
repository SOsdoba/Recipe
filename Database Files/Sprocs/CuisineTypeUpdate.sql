create or alter proc dbo.CuisineTypeUpdate(
	@CuisineTypeid int output,
	@CuisineType varchar(30),
	@Message varchar (500) = '' output
)
as 
begin
	declare @return int = 0

	select @cuisinetypeid = isnull(@cuisinetypeid, 0)

	if @CuisineTypeId = 0
	begin
		select @cuisinetypeid= SCOPE_IDENTITY()
		insert CuisineType(CuisineType)
		values(@CuisineType)
	end
	else
	begin 
		update CuisineType
		set
		CuisineType = @CuisineType
		where CuisineTypeId = @CuisineTypeId
	end

	return @return
end 
go
