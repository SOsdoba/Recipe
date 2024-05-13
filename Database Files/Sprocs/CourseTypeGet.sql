use RecipeDB
go
create or alter procedure dbo.CourseTypeGet(@CourseId int = 0, @CourseType varchar(30) = '',@CourseSequence int = 0, @All bit = 0)
as 
begin
	select CourseId = c.CourseId, CourseType = c.coursetype, c.CourseSequence
	from Course c
	where c.CourseId = @CourseId
	or @All = 1
end
go

exec CourseTypeGet @All = 1