create or alter procedure dbo.IngredientDelete(
	@IngredientId int = 0,
	@Message varchar(500) = '' output
)
as 
begin
	declare @return int = 0, @deleteallowed varchar (60)

	select @deleteallowed = isnull(dbo.isdeleteallowed(@IngredientId), '')

	if @deleteallowed <> ''
	begin
		select @return = 1, @Message = @deleteallowed 
		goto finished
	end

	begin try
		begin tran
			delete Ingredient where IngredientId = @IngredientId
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