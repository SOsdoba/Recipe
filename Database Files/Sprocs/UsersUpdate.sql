create or alter proc dbo.UsersUpdate(
	@Usersid int output,
	@FirstName varchar(30),
	@LastName varchar(30),
	@UserName varchar(50),
	@Message varchar (500) = '' output
)
as 
begin
	declare @return int = 0

	select @usersid = isnull(@usersid, 0)

	if @Usersid = 0
	begin
		select @Usersid= SCOPE_IDENTITY()
		insert Users(FirstName, LastName, UserName)
		values(@FirstName, @LastName, @UserName)
	end
	else
	begin 
		update Users
		set
		FirstName = @FirstName,
		LastName = @LastName,
		UserName = @UserName
		where UsersId = @Usersid
	end

	return @return
end 
go
