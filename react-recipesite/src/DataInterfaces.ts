export interface ICuisine {
    cuisineTypeId: number;
    cuisineType: string;
}

export interface IRecipe {
    recipeId: number,
    usersId: number,
    cuisineTypeId: number,
    recipeName: string,
    calories: number,
    draftDate: string,
    publishDate: string,
    archiveDate: string,
    recipeStatus: string,
    vegan: boolean,
    recipePicture: string
}