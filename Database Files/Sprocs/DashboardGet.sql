create or alter proc dbo.DashboardGet(
	@Message varchar(500) = '' output
)
as 
begin 
	declare @return int = 0

		select DashboardType = 'Recipes', DashboardNumber = count(*) from Recipe r
		union select DashboardType = 'Meals', DashboardNumber = count(*) from Meal m
		union select DashboardType = 'Cookbooks', DashboardNumber = count(*) from CookBooks c

	return @return
end 
go

--exec DashboardGet