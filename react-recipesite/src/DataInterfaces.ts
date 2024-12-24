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
    vegan: string,
    userName: string,
    recipePicture: string,
    errorMessage: string
}

export interface IUser {
    usersId: number;
    userName: string;
}
