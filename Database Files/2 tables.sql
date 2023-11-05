--YF Excellent! some points in the code, nothing major just some comments
--and your image columns should all be persisted

use RecipeDB 
go 

drop table if exists CookBookRecipes 
drop table if exists CookBooks
drop table if exists MealCourseRecipes 
drop table if exists MealCourse
drop table if exists Meal
drop table if exists Directions 
drop table if exists RecipeIngredient
drop table if exists MeasurementType
drop table if exists Recipe
drop table if exists Ingredient 
drop table if exists CuisineType
drop table if exists Course 
drop table if exists Users

create table dbo.Users (
    UsersId int not null identity primary key, 
    FirstName varchar(30) not null 
        constraint ck_Users_FirstName_cannot_be_blank check(FirstName <> ''),
    LastName varchar(30) not null 
        constraint ck_Users_LastName_cannot_be_blank check(LastName <> ''),
    Username varchar(50) not null 
        constraint ck_Users_Username_cannot_be_blank check(UserName <> '')
        constraint u_Users_Username unique 
)
go 

create table dbo.Course (
    CourseId int not null identity primary key, 
    CourseType varchar(20) not null 
        constraint ck_Course_CourseType_cannot_be_blank check(CourseType <> '')
        constraint u_Course_CourseType unique,
    CourseSequence int not null 
        constraint ck_Course_CourseSequence_must_be_greater_than_0 check(CourseSequence > 0)
        constraint u_Course_CourseSequence unique,
)
go 

create table dbo.CuisineType (
    CuisineTypeId int not null identity primary key, 
    CuisineType varchar(30) not null 
        constraint ck_CuisineType_cannot_be_blank check(CuisineType <> '')
        constraint u_CuisineType unique
)
go 

create table dbo.Ingredient (
    IngredientId int not null identity primary key, 
    IngredientName varchar(40) not null 
        constraint ck_Ingredient_IngredientName_cannot_be_blank check(IngredientName <> '')
        constraint u_Ingredient_IngredientName unique,
    IngredientPicture as concat('Ingredient-', replace(IngredientName, ' ', '-'), '.jpg') persisted
)
go 

create table dbo.Recipe (
--table should be singular since each row represents one recipe
    RecipeId int not null identity primary key, 
    UsersId int not null constraint fk_Users_Recipe foreign key references Users(UsersId), 
    CuisineTypeId int not null constraint fk_CuisineType_Recipe foreign key references CuisineType(CuisineTypeId),
    RecipeName varchar(40) not null 
        constraint ck_Recipe_RecipeName_cannot_be_blank check(RecipeName <> '')
        constraint u_Recipe_RecipeName unique,
    Calories int not null 
        constraint ck_Calories_must_be_greater_than_0 check(Calories > 0),
    DraftDate datetime not null default getdate()
        constraint ck_Recipe_DraftDate_cannot_be_blank check(DraftDate <> ''),
    PublishDate datetime,
        constraint ck_Recipe_PublishDate_cannot_be_blank check(PublishDate <> ''),
    ArchiveDate datetime,
        constraint ck_Recipe_ArchiveDate_cannot_be_blank check(ArchiveDate <> ''),
    RecipeStatus as case 
        when PublishDate is null and ArchiveDate is null then 'Draft'
        when PublishDate > DraftDate and ArchiveDate is null then 'Published'
        when ArchiveDate > PublishDate and ArchiveDate > DraftDate then 'Archived'
        when ArchiveDate > DraftDate and PublishDate is null then 'Archived'
        when PublishDate > ArchiveDate then 'Published'
        end persisted,
    RecipePicture as concat('Recipe-', replace(RecipeName, ' ', '-'), '.jpg') persisted,
--YF Add some constraints about dates to ensure publish/archive are after draft and all dates are not in the future
        constraint ck_Recipe_DraftDate_must_be_before_publishdate check(publishdate > draftdate),
        constraint ck_Recipe_DraftDate_cannot_be_in_the_future check(draftdate <= getdate()),
        constraint ck_Recipe_PublishDate_cannot_be_in_the_future check(publishdate <= getdate()),
        constraint ck_Recipe_ArchiveDate_cannot_be_in_the_future check(archivedate <= getdate())
)
go 

create table dbo.MeasurementType (
    MeasurementTypeId int not null identity primary key, 
    MeasurementType varchar(20) not null  
        constraint u_MeasurementType unique
)
go 

create table dbo.RecipeIngredient (
    RecipeIngredientId int not null identity primary key, 
    RecipeId int not null constraint fk_Recipe_RecipeIngredient foreign key references Recipe(RecipeId),
    IngredientId int not null constraint fk_Ingredient_RecipeIngredient foreign key references Ingredient(IngredientId),
    MeasurementTypeId int not null constraint fk_MeasurementType_RecipeIngredient foreign key references MeasurementType(MeasurementTypeId),
    Amount decimal (4,2) not null 
        constraint ck_RecipeIngredient_Amount_must_be_greater_than_0 check(Amount > 0),
    SequenceOfIngredients int 
        constraint ck_RecipeIngredient_SequenceOfIngredient_must_be_greater_than_0 check(SequenceOfIngredients > 0),
    constraint u_RecipeIngredient_RecipeId_SequenceOfIngredients unique(RecipeId, SequenceofIngredients)
)
go 

create table dbo.Directions (
    DirectionsId int not null identity primary key, 
    RecipeId int not null constraint fk_Recipe_Directions foreign key references Recipe(RecipeId),
    Direction varchar(300) not null 
--YF I would make the varchar limit larger, just in case its a long step. 100 char is not wrong, but not a lot 
        constraint ck_Directions_cannot_be_blank check(Direction <> ''),
    SequenceOfDirections int 
        constraint ck_Directions_SequenceOfDirections_must_be_greater_than_0 check(SequenceOfDirections > 0),
    constraint u_Directions_RecipeId_SequenceOfDirections unique(RecipeId, SequenceOfDirections)
)
go 

create table dbo.Meal (
    MealId int not null identity primary key, 
    UsersId int not null constraint fk_Users_Meal foreign key references Users(UsersId),
    MealName varchar(50) not null 
        constraint ck_Meal_MealName_cannot_be_blank check(MealName <> '')
        constraint u_Meal_MealName unique,
    MealActive bit not null default 0,
    DateMealCreated datetime not null default getdate()
        constraint ck_Meal_DateMealCreated_cannot_be_blank check(DateMealCreated <> ''),
    MealPicture as concat('Meal-', replace(MealName, ' ', '-'), '.jpg') persisted 
)
go 

create table dbo.MealCourse (
    MealCourseId int not null identity primary key, 
    MealId int not null constraint fk_Meal_MealCourse foreign key references Meal(MealId),
    CourseId int not null constraint fk_Course_MealCourse foreign key references Course(CourseId),
    constraint u_MealCourse_MealId_CourseId unique(MealId, CourseId)
)
go 

create table dbo.MealCourseRecipes (
    MealCourseRecipesId int not null identity primary key, 
    MealCourseId int not null constraint fk_MealCourse_MealCourseRecipes foreign key references MealCourse(MealCourseId),
    RecipeId int not null constraint fk_Recipe_MealCourseRecipes foreign key references Recipe(RecipeId),
    IsMain bit null default 0,
    constraint u_MealCourseRecipes_RecipeId_MealCourseId unique(RecipeId, MealCourseId)
)
go 

create table dbo.CookBooks (
    CookBookId int not null identity primary key, 
    UsersId int not null constraint fk_Users_CookBooks foreign key references Users(UsersId),
    CookBookName varchar(100) not null 
        constraint ck_CookBooks_CookBookName_cannot_be_blank check(CookBookName <> '')
        constraint u_CookBooks_CookBookName unique,
    Price decimal(5,2) not null 
        constraint ck_CookBooks_Price_must_be_greater_than_0 check(Price > 0),
    CookBookActive bit not null default 0,
    DateBookCreated date not null default getdate()
        constraint ck_DateBookCreated_cannot_be_blank check(DateBookCreated <> ''),
    CookBookPicture as concat('CookBook-', replace(CookBookName, ' ', '-'), '.jpg') persisted 
)
go 

create table dbo.CookBookRecipes (
    CookBookRecipesId int not null identity primary key, 
    CookBookId int not null constraint fk_CookBooks_CookBookRecipes foreign key references CookBooks(CookBookId),
    RecipeId int not null constraint fk_Recipe_CookBookRecipes foreign key references Recipe(RecipeId),
    CookBookRecipeSequence int not null 
        constraint ck_CookBookRecipeSequence_must_be_greater_than_0 check(CookBookRecipeSequence > 0 ),
    constraint u_CookBookRecipes_CookBookId_Sequence unique(CookBookId, CookBookRecipeSequence)
)
