declare @Message varchar (500) = '', @return int, @usersid int, @Cuisinetypeid int, @recipeid int

select top 1 @recipeid = recipeid from recipe r
select @usersid = max(r.usersid) from recipe r
select @Cuisinetypeid = max(r.cuisinetypeid) from recipe r

exec @return = RecipeUpdate
	@RecipeId = @recipeid output,
	@Usersid = @usersid,
	@cuisinetypeid = @cuisinetypeid,
	@recipename = 'Fluff',
	@calories = 40,
	@draftdate = null,
	@publishdate = null,
	@archivedate = null,
	@Message = @Message output

select @return, @Message, @recipeid

select top 1 * from Recipe r where recipeid = @recipeid