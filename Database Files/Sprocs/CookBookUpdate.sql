create or alter proc dbo.CookBookUpdate(
	@CookBookid int output,
	@CookBookName varchar(50),
	@UsersId int, 
	@Price int,
	@DateBookCreated datetime output,
	@CookBookActive bit = 0,
	@Message varchar (500) = '' output
)
as 
begin
	declare @return int = 0
	
	select @cookbookid = isnull(@cookbookid, 0), @DateBookCreated = isnull(@DateBookCreated, getdate()), @CookBookActive = isnull(@CookBookActive,0)

	if @CookBookid = 0
	begin
		select @DateBookCreated = getdate()
		insert CookBooks(CookBookName, UsersId, Price, DateBookCreated, CookBookActive)
		values(@CookBookName, @UsersId, @Price, @DateBookCreated, @CookBookActive)
		select @CookBookid= SCOPE_IDENTITY()
	end
	else
	begin 
		update CookBooks
		set
		CookBookName = @CookBookName,
		UsersId = @UsersId,
		Price = @Price,
		DateBookCreated = @DateBookCreated, 
		CookBookActive = @CookBookActive
		where CookBookId = @CookBookid
	end

	return @return
end 
go