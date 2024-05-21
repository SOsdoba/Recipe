create or alter function dbo.IsDeleteAllowed(@Recipeid int)
returns varchar(70)
as
begin

	declare @value varchar(70) = ''
	if exists(select * from Recipe r where r.Recipestatus = 'Draft' and r.recipeid = @RecipeId)
	begin
		select @value = 'Cannot delete recipe that is currently drafted.'
	end
	else if exists (select * from Recipe r where GETDATE() - ArchiveDate < 30 and r.RecipeId = @Recipeid)
	begin
		select @value = 'Cannot delete a recipe that is archived for less than 30 days.'
	end
	return @value
end
go
