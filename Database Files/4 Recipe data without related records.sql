use RecipeDB 
go

insert Users(FirstName, LastName, Username)
select 'Peter', 'V', 'peterv'
union select 'Scott', 'W', 'scottw'
union select 'Noah', 'B', 'noahb'

insert CuisineType(CuisineType)
select 'Mexican'
union select 'Belgian'
union select 'Russian'

insert Recipe(UsersId, CuisineTypeId, RecipeName, Calories, DraftDate, PublishDate, ArchiveDate)
select (select u.usersid from users u where u.Username = 'peterv'), (select c.cuisinetypeid from cuisinetype c where c.cuisinetype = 'russian'), 'Boiled Potatoes', 90, '05-13-2012', '05-13-2014', null
union select (select u.usersid from users u where u.Username = 'peterv'), (select c.cuisinetypeid from cuisinetype c where c.cuisinetype = 'mexican'), 'Orange Smoothie', 60, '02-27-2023', null, '02-28-2023'
union select (select u.usersid from users u where u.Username = 'scottw'), (select c.cuisinetypeid from cuisinetype c where c.cuisinetype = 'belgian'), 'Belgian Chocolate', 150, '12-01-2020', '02-28-2021', null
union select (select u.usersid from users u where u.Username = 'scottw'), (select c.cuisinetypeid from cuisinetype c where c.cuisinetype = 'mexican'), 'Quesdillas', 110, '01-23-2001', null, '02-18-2012'
union select (select u.usersid from users u where u.Username = 'noahb'), (select c.cuisinetypeid from cuisinetype c where c.cuisinetype = 'belgian'), 'Chocolate Mousse', 135, '01-07-2006', null, '02-28-2009'
union select (select u.usersid from users u where u.Username = 'noahb'), (select c.cuisinetypeid from cuisinetype c where c.cuisinetype = 'russian'), 'Liquor', 40, '12-07-2012', '09-28-2015', null
