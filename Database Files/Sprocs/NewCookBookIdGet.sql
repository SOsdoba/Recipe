create or alter procedure dbo.NewCookBookIdGet(
	@CookBookId int = 0 output, 
	@All bit = 0
)
as
begin
	select top 1 c.cookbookid
	from CookBooks c
	where @All = 1
	order by c.cookbookid desc
end
go

exec NewCookBookIdGet @All = 1
