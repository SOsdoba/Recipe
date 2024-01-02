declare @Message varchar(500) = '', 
	@return int, 
	@Usersid int, 
	@cuisinetypeid int, 
	@recipeid int, 
	@RecipeName varchar (40),
	@Calories int,
	@DraftDate datetime,
	@PublishDate datetime, 
	@ArchiveDate datetime

select top 1
	@recipeid = r.recipeid,
	@usersid = r.usersid,
	@cuisinetypeid = r.cuisinetypeid,
	@recipename = r.recipename,
	@calories = r.calories,
	@draftdate = r.draftdate,
	@publishdate = r.publishdate,
	@archivedate = r.archivedate
from recipe r

exec @return = RecipeUpdate
	@RecipeId = @recipeid output,
	@Usersid = @usersid,
	@cuisinetypeid = @cuisinetypeid,
	@recipename = @recipename,
	@calories = @calories,
	@draftdate = @draftdate,
	@publishdate = @publishdate,
	@archivedate = @archivedate,
	@Message = @Message output

select @return, @Message, @recipeid

select top 1 * from Recipe r where Recipeid = @recipeid