create or alter proc dbo.CourseTypeUpdate(
	@CourseId int output,
	@CourseType varchar(20),
	@CourseSequence int = 0,
	@Message varchar (500) = '' output
)
as 
begin
	declare @return int = 0

	select @CourseId = isnull(@CourseId, 0)

	if @CourseId = 0
	begin
		select @CourseId = SCOPE_IDENTITY()
		insert Course(CourseType, CourseSequence)
		values(@CourseType, @CourseSequence)
	end
	else
	begin 
		update Course
		set
		CourseType = @CourseType,
		CourseSequence = @CourseSequence
		where CourseId = @CourseId
	end

	return @return
end 
go



