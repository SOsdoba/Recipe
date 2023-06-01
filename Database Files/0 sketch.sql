/*
Users
    FirstName varchar(30)
    LastName varchar(30)
    Username varchar(50) unique 

-- SM Sequence should be a normal column, you don't know the types of courses you'll need for the meal. (there's a 5 course meal, 7 course meal. But the order is always the same)
Course
    CourseType varchar(20) unique 
    CourseSequence int unique
-- SM Both should be unique on it's own
   
CuisineType
    CuisineType varchar(30) unique

Ingredient
    IngredientName varchar(30) unique
    IngredientPicture as ingredient-name.jpg

Recipes
    CuisineTypeId (fk cuisinetype)
    UserID (fk Users)
    RecipeName varchar(40) unique
-- SM Remove this column
    Calories int
    DraftDate datetime default getdate()
    PublishDate datetime (allows null)
    ArchiveDate datetime (allows null)
    RecipeStatus as 
        (when publishdate is null and archivedate is null then draft), 
        (when publishdate is greater than draft date and archive date is null then publish), 
        (when archivedate is greater than publish date and draftdate then archive)
    RecipePicture as recipe-name.jpg

MeasurementType
    MeasurementType varchar(20)

RecipeIngredient
    RecipeId
    IngredientID
    MeasurementTypeId
    Amount
    SequenceOfIngredients int 
    unique sequenceofingredients, recipeid 

-- SM No need for master table of directions. Even if it says "add suger" in 2 recipes, there's no connection between them.

Directions
    RecipeId (fk recipes)
    Direction varchar(30)
    SequenceofDirections int 
    unique sequenceofdirections, recipeid

Meal
    UserID (fk Users)
    MealName unique
    Active boolean
    DateMealCreated datetime defualt getdate()
    MealPicure as meal-name.jpg

MealCourse
    MealId (fk meal)
    CourseId (fk course)
-- SM This column should be in MealCourseRecipe table.
    unique (meal, course)

MealCourseRecipes
    MealCourseID (fk mealcourse)
    RecipeId (fk recipes)
    IsMain bit
    unique mealcourse, recipe

CookBooks
    UserID (fk Users)
    CookBookName varchar(100) unique 
    Price decimal
    Active boolean 
    DateBookCreated datetime default getdate()
    CookBookPicture as cookbook-name.jpg

CookBookRecipes
    CookBookId (fk cookbook)
    RecipesId  (fk recipe)
    Sequence int 
    unique cookbook, sequence
    unique cookbook, recipe




*/