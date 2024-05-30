use RecipeDB 
go

delete CookBookRecipes
delete CookBooks
delete MealCourseRecipes
delete MealCourse
delete Meal
delete Directions
delete RecipeIngredient
delete MeasurementType
delete Recipe
delete Ingredient
delete CuisineType
delete Course
delete Users 

insert Users(FirstName, LastName, Username)
select 'John', 'K', 'johnk'
union select 'Steve', 'S', 'steves'
union select 'Joshua', 'D', 'joshuad'
union select 'Samuel', 'R', 'samuelr'
union select 'David', 'F', 'davidf'
union select 'Steve', 'W', 'stevew'

insert Course(CourseType, CourseSequence)
select 'Appetizer', 1
union select 'Main', 2
union select 'Dessert', 3

insert CuisineType(CuisineType)
select 'American'
union select 'French'
union select 'English'

insert Ingredient(IngredientName)
select 'Sugar'
union select 'Oil'
union select 'Flour'
union select 'Vanilla Sugar'
union select 'Baking Powder'
union select 'Baking Soda'
union select 'Chocolate Chips'
union select 'Granny Smith Apple'
union select 'Vanilla Yogurt'
union select 'Orange Juice'
union select 'Honey'
union select 'Ice Cubes'
union select 'Bread'
union select 'Butter'
union select 'Shredded Cheese'
union select 'Crushed Garlic'
union select 'Black Pepper'
union select 'Salt'
union select 'Vanilla Pudding'
union select 'Eggs'
union select 'Whipped Cream Cheese'
union select 'Sour Cream Cheese'
union select 'Milk'
union select 'Milk Chocolate'
union select 'Mozzarella Cheese'
union select 'Bread Crumbs'
union select 'Garlic Powder'
union select 'Confectionar''s Sugar'
union select 'Vanilla Extract'

insert Recipe(UsersId, CuisineTypeId, RecipeName, Calories, DraftDate, PublishDate, ArchiveDate)
select (select u.usersid from users u where u.Username = 'joshuad'), (select c.cuisinetypeid from cuisinetype c where c.cuisinetype = 'American'), 'Chocolate Chip Cookies', 100, '07-05-2019', null, null
union select (select u.usersid from users u where u.Username = 'steves'), (select c.cuisinetypeid from cuisinetype c where c.cuisinetype = 'French'), 'Apple Yogurt Smoothie', 75, '03-05-2017', '04-10-2017', null
union select (select u.usersid from users u where u.Username = 'davidf'), (select c.cuisinetypeid from cuisinetype c where c.cuisinetype = 'English'), 'Cheese Bread', 50, '07-20-2019', null, '02-20-2020'
union select (select u.usersid from users u where u.Username = 'samuelr'), (select c.cuisinetypeid from cuisinetype c where c.cuisinetype = 'American'), 'Butter Muffins', 85, '07-21-2016', '03-20-2020', '04-10-2020'
union select (select u.usersid from users u where u.Username = 'samuelr'), (select c.cuisinetypeid from cuisinetype c where c.cuisinetype = 'American'), 'Hot Chocolate', 60, '08-12-2017', '01-22-2022', '04-11-2022'
union select (select u.usersid from users u where u.Username = 'samuelr'), (select c.cuisinetypeid from cuisinetype c where c.cuisinetype = 'English'), 'Mozzarella Stick', 45, '01-13-2010', '11-22-2020', null
union select (select u.usersid from users u where u.Username = 'davidf'), (select c.cuisinetypeid from cuisinetype c where c.cuisinetype = 'French'), 'Cream Cheese Frosting', 30, '12-10-2018', '12-01-2021', null

insert MeasurementType(MeasurementType)
select 'Cup'
union select 'tsp'
union select 'tbsp'
union select 'club'
union select 'oz'
union select 'clove'
union select 'pinch'
union select 'stick'

; with x as (
   select RecipeName = 'Chocolate Chip Cookies', IngredientName = 'Sugar', MeasurementType = 'Cup', Amount = 1, SequenceOfIngredients = 1
   union select'Chocolate Chip Cookies', 'Oil', 'Cup', 1.5, 2
   union select'Chocolate Chip Cookies', 'Eggs', '', 3, 3
   union select'Chocolate Chip Cookies', 'Flour', 'Cup', 2, 4
   union select'Chocolate Chip Cookies', 'Vanilla Sugar', 'tsp', 1, 5
   union select'Chocolate Chip Cookies', 'Baking Powder', 'tsp', 2, 6
   union select'Chocolate Chip Cookies', 'Baking Soda', 'tsp', 1.5, 7
   union select'Chocolate Chip Cookies', 'Chocolate Chips', 'cup', 1, 8
   union select'Apple Yogurt Smoothie', 'Granny Smith Apple', '', 3, 1
   union select'Apple Yogurt Smoothie', 'Vanilla Yogurt', 'cup', 2, 2
   union select'Apple Yogurt Smoothie', 'Sugar', 'tsp', 2, 3
   union select'Apple Yogurt Smoothie', 'Orange Juice', 'cup', 1.5, 4
   union select'Apple Yogurt Smoothie', 'Honey', 'tbsp', 2, 5
   union select'Apple Yogurt Smoothie', 'Ice Cubes', '', 5, 6
   union select 'Cheese Bread', 'Bread', 'club', 1, 1
   union select 'Cheese Bread', 'Butter', 'oz', 4, 2
   union select 'Cheese Bread', 'Shredded Cheese', 'oz', 8, 3
   union select 'Cheese Bread', 'Crushed Garlic', 'clove', 2, 4
   union select 'Cheese Bread', 'Black Pepper', 'tsp', .25, 5
   union select 'Cheese Bread', 'Salt', 'pinch', 1, 6
   union select 'Butter Muffins', 'Butter', 'stick', 1, 1
   union select 'Butter Muffins', 'Sugar', 'cup', 3, 2
   union select 'Butter Muffins', 'Vanilla Pudding', 'tbsp', 2, 3
   union select 'Butter Muffins', 'Eggs', '', 4, 4
   union select 'Butter Muffins', 'Whipped Cream Cheese', 'oz', 8, 5
   union select 'Butter Muffins', 'Sour Cream Cheese', 'oz', 8, 6
   union select 'Butter Muffins', 'Flour', 'cup', 1, 7
   union select 'Butter Muffins', 'Baking Powder', 'tsp', 2, 8
   union select 'Hot Chocolate', 'Milk', 'cup', 1, 1
   union select 'Hot Chocolate', 'Milk Chocolate', 'oz', 6, 2
   union select 'Mozzarella Stick', 'Mozzarella Cheese', 'stick', 5, 1
   union select 'Mozzarella Stick', 'Eggs', '', 2, 2
   union select 'Mozzarella Stick', 'Bread Crumbs', 'cup', 1, 3
   union select 'Mozzarella Stick', 'Oil', 'tbsp', 2, 4
   union select 'Mozzarella Stick', 'Garlic Powder', 'tsp', 1, 5
   union select 'Mozzarella Stick', 'Salt', 'tsp', 2, 6
   union select 'Cream Cheese Frosting', 'Whipped Cream Cheese', 'oz', 8, 1
   union select 'Cream Cheese Frosting', 'Butter', 'oz', 8, 2
   union select 'Cream Cheese Frosting', 'Confectionar''s Sugar', 'cup', 2, 3
   union select 'Cream Cheese Frosting', 'Vanilla Extract', 'tsp', 2, 4
)
insert RecipeIngredient(RecipeId, IngredientId, MeasurementTypeId, Amount, SequenceOfIngredients)
select r.recipeid, i.ingredientid, m.MeasurementTypeId, x.amount, x.SequenceOfIngredients
from x 
join Recipe r 
on r.recipename = x.RecipeName
join Ingredient i 
on i.ingredientname = x.IngredientName
join MeasurementType m 
on m.MeasurementType = x.MeasurementType

insert Directions(RecipeId, Direction, SequenceOfDirections)
select r.recipeid, 'First combine sugar, oil and eggs in a bowl', 1 from recipe r where r.recipename = 'Chocolate Chip Cookies'
union select r.recipeid, 'mix well', 2 from recipe r where r.recipename = 'Chocolate Chip Cookies'
union select r.recipeid, 'add flour, vanilla sugar, baking powder and baking soda', 3 from recipe r where r.recipename = 'Chocolate Chip Cookies'
union select r.recipeid, 'beat for 5 minutes', 4 from recipe r where r.recipename = 'Chocolate Chip Cookies'
union select r.recipeid, 'add chocolate chips', 5 from recipe r where r.recipename = 'Chocolate Chip Cookies'
union select r.recipeid, 'freeze for 1-2 hours', 6 from recipe r where r.recipename = 'Chocolate Chip Cookies'
union select r.recipeid, 'roll into balls and place spread out on a cookie sheet', 7 from recipe r where r.recipename = 'Chocolate Chip Cookies'
union select r.recipeid, 'bake on 350 for 10 min', 8 from recipe r where r.recipename = 'Chocolate Chip Cookies'
union select r.recipeid, 'Peel the apples and dice', 1 from recipe r where r.recipename = 'Apple Yogurt Smoothie'
union select r.recipeid, 'Combine all ingredients in bowl except for apples and ice cubes', 2 from recipe r where r.recipename = 'Apple Yogurt Smoothie'
union select r.recipeid, 'mix until smooth', 3 from recipe r where r.recipename = 'Apple Yogurt Smoothie'
union select r.recipeid, 'add apples and ice cubes', 4 from recipe r where r.recipename = 'Apple Yogurt Smoothie'
union select r.recipeid, 'pour into glasses', 5 from recipe r where r.recipename = 'Apple Yogurt Smoothie'
union select r.recipeid, 'Slit bread every 3/4 inch', 1 from recipe r where r.recipename = 'Cheese Bread'
union select r.recipeid, 'Combine all ingredients in bowl', 2 from recipe r where r.recipename = 'Cheese Bread'
union select r.recipeid, 'fill slits with cheese mixture', 3 from recipe r where r.recipename = 'Cheese Bread'
union select r.recipeid, 'wrap bread into a foil and bake for 30 minutes.', 4 from recipe r where r.recipename = 'Cheese Bread'
union select r.recipeid, 'Cream butter with sugars', 1 from recipe r where r.recipename = 'Butter Muffins'
union select r.recipeid, 'Add eggs and mix well', 2 from recipe r where r.recipename = 'Butter Muffins'
union select r.recipeid, 'Slowly add rest of ingredients and mix well', 3 from recipe r where r.recipename = 'Butter Muffins'
union select r.recipeid, ' fill muffin pans 3/4 full and bake for 30 minutes', 4 from recipe r where r.recipename = 'Butter Muffins'
union select r.recipeid, ' Heat milk over fire until it comes to a boil', 1 from recipe r where r.recipename = 'Hot Chocolate'
union select r.recipeid, ' Break the chocolate into bits and place into a cup', 2 from recipe r where r.recipename = 'Hot Chocolate'
union select r.recipeid, ' Pour the boiled milk over the chocolate', 3 from recipe r where r.recipename = 'Hot Chocolate'
union select r.recipeid, 'Pour the boiled milk over the chocolate', 4 from recipe r where r.recipename = 'Hot Chocolate'
union select r.recipeid, 'Cut the mozzarella sticks into 3 inch sticks', 1 from recipe r where r.recipename = 'Mozzarella Stick'
union select r.recipeid, 'Dip into whipped eggs', 2 from recipe r where r.recipename = 'Mozzarella Stick'
union select r.recipeid, 'Add the garlic powder and salt to bread crumbs', 3 from recipe r where r.recipename = 'Mozzarella Stick'
union select r.recipeid, 'Dip the cheese stick into the bread crumbs', 4 from recipe r where r.recipename = 'Mozzarella Stick'
union select r.recipeid, 'Fry for 2 minutes on each side', 5 from recipe r where r.recipename = 'Mozzarella Stick'
union select r.recipeid, 'Cream the cream chesse and butter until smooth', 1 from recipe r where r.recipename = 'Cream Cheese Frosting'
union select r.recipeid, 'Add confectionar''s sugar and vanilla and cream until smooth', 2 from recipe r where r.recipename = 'Cream Cheese Frosting'
union select r.recipeid, 'Refrigarate until use', 3 from recipe r where r.recipename = 'Cream Cheese Frosting'

insert Meal(UsersId, MealName, MealActive, DateMealCreated)
select u.usersid, 'Breakfast Bash', 0, '02-03-2003' from users u where u.username = 'steves'
union select u.usersid, 'Lunch IT', 1, '02-19-2021' from users u where u.username = 'samuelr'
union select u.usersid, 'Dinner Done', 1, '10-03-2015' from users u where u.username = 'samuelr'

insert MealCourse(MealId, CourseId)
select (select m.mealid from meal m where m.MealName = 'Breakfast Bash'), (select c.CourseId from course c where CourseType = 'Main') 
union select (select m.mealid from meal m where m.MealName = 'Breakfast Bash'), (select c.CourseId from course c where CourseType = 'Appetizer')
union select (select m.mealid from meal m where m.MealName = 'Breakfast Bash'), (select c.CourseId from course c where CourseType = 'Dessert')
union select (select m.mealid from meal m where m.MealName = 'Lunch IT'), (select c.CourseId from course c where CourseType = 'Main')
union select (select m.mealid from meal m where m.MealName = 'Lunch IT'), (select c.CourseId from course c where CourseType = 'Dessert')
union select (select m.mealid from meal m where m.MealName = 'Dinner Done'), (select c.CourseId from course c where CourseType = 'Appetizer')
union select (select m.mealid from meal m where m.MealName = 'Dinner Done'), (select c.CourseId from course c where CourseType = 'Main')

; with x as (
   select MealName = 'Breakfast Bash' , CourseType = 'Main', RecipeName = 'Cheese Bread', IsMain = 1
   union select 'Breakfast Bash' , 'Main', 'Butter Muffins', 0
   union select 'Breakfast Bash', 'Appetizer', 'Apple Yogurt Smoothie', 1
   union select 'Breakfast Bash', 'Dessert', 'Hot Chocolate', 0
   union select 'Lunch IT', 'Main', 'Apple Yogurt Smoothie', 1
   union select 'Dinner Done', 'Appetizer', 'Butter Muffins', 1
   union select 'Dinner Done', 'Main', 'Apple Yogurt Smoothie', 1
   union select 'Dinner Done', 'Main', 'Butter Muffins', 1
   union select 'Dinner Done', 'Main', 'Cream Cheese Frosting', 0
   
)
insert MealCourseRecipes(MealCourseId, RecipeId, IsMain)
select mc.MealCourseId, r.recipeid, x.ismain 
from x 
join Recipe r 
on r.RecipeName = x.recipename 
join Meal m 
on m.MealName = x.mealname 
join course c 
on c.CourseType = x.coursetype
join MealCourse mc 
on c.CourseId = mc.CourseId
and m.MealId = mc.MealId

insert CookBooks(UsersId, CookBookName, Price, CookBookActive, DateBookCreated)
select u.usersid, 'Treats for Two', 30, 1, '02-03-2023' from Users u where u.username = 'stevew'
union select u.usersid, 'Whip-It-Up', 35, 0, '01-03-2021' from Users u where u.username = 'stevew'
union select u.usersid, 'The Dessert Table', 45, 1, '02-17-2022' from Users u where u.username = 'johnk'
union select u.usersid, 'Tasty', 50, 1, '03-21-2020' from Users u where u.username = 'johnk'

; with x as (
   select CookBookName = 'Treats for Two', RecipeName = 'Hot Chocolate', CookBookRecipeSequence = 1
   union select CookBookName = 'Treats for Two', RecipeName = 'Apple Yogurt Smoothie', CookBookRecipeSequence = 2
   union select CookBookName = 'Treats for Two', RecipeName = 'Cheese Bread', CookBookRecipeSequence = 3
   union select CookBookName = 'Treats for Two', RecipeName = 'Butter Muffins', CookBookRecipeSequence = 4
   union select CookBookName = 'Whip-It-Up', RecipeName = 'Cheese Bread', CookBookRecipeSequence = 1
   union select CookBookName = 'Whip-It-Up', RecipeName = 'Butter Muffins', CookBookRecipeSequence = 2
   union select CookBookName = 'Whip-It-Up', RecipeName = 'Mozzarella Stick', CookBookRecipeSequence = 3
   union select CookBookName = 'The Dessert Table', RecipeName = 'Apple Yogurt Smoothie', CookBookRecipeSequence = 1
   union select CookBookName = 'The Dessert Table', RecipeName = 'Butter Muffins', CookBookRecipeSequence = 2
   union select CookBookName = 'The Dessert Table', RecipeName = 'Cheese Bread', CookBookRecipeSequence = 3
   union select CookBookName = 'Tasty', RecipeName = 'Mozzarella Sticks', CookBookRecipeSequence = 1
   union select CookBookName = 'Tasty', RecipeName = 'Butter Muffins', CookBookRecipeSequence = 2
   union select CookBookName = 'Tasty', RecipeName = 'Cream Cheese Frosting', CookBookRecipeSequence = 3
   union select CookBookName = 'Tasty', RecipeName = 'Hot Chocolate', CookBookRecipeSequence = 4
)
insert CookBookRecipes(CookBookId, RecipeId, CookBookRecipeSequence)
select c.CookBookId, r.RecipeId, x.CookBookRecipeSequence 
from x
join CookBooks c 
on c.CookBookName = x.CookBookName
join Recipe r 
on r.RecipeName = x.RecipeName 