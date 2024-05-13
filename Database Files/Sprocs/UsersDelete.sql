create or alter procedure dbo.UsersDelete(
	@UsersId int = 0,
	@Message varchar(500) = '' output
)
as 
begin
	declare @return int = 0, @deleteallowed varchar (60)

	select @deleteallowed = isnull(dbo.isdeleteallowed(@UsersId), '')

	if @deleteallowed <> ''
	begin
		select @return = 1, @Message = @deleteallowed 
		goto finished
	end

	begin try
		begin tran
			delete Users where UsersId = @UsersId
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