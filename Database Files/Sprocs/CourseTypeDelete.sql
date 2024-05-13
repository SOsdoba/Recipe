create or alter procedure dbo.CourseTypeDelete(
	@CourseId int = 0,
	@Message varchar(500) = '' output
)
as 
begin
	declare @return int = 0, @deleteallowed varchar (60)

	select @deleteallowed = isnull(dbo.isdeleteallowed(@CourseId), '')

	if @deleteallowed <> ''
	begin
		select @return = 1, @Message = @deleteallowed 
		goto finished
	end

	begin try
		begin tran
			delete Course where CourseId = @CourseId
		commit
	end try
	begin catch
		rollback;
		throw
	end catch

	finished:
	return @return
end 
go


