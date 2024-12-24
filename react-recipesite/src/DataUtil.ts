import { FieldValues } from "react-hook-form";
import { ICuisine, IRecipe, IUser } from "./DataInterfaces";

let baseurl = import.meta.env.VITE_API_URL;


async function fetchData<T>(url: string): Promise<T> {
    url = baseurl + url;
    const c = await fetch(url);
    const data = await c.json();
    return data;
}

async function deleteData<T>(url: string): Promise<T> {
    url = baseurl + url;
    const c = await fetch(url, { method: "DELETE" });
    const data = await c.json();
    return data;
}

async function postData<T>(url: string, form: FieldValues): Promise<T> {
    url = baseurl + url;
    const r = await fetch(url, {
        method: "POST",
        body: JSON.stringify(form),
        headers: {
            "Content-Type": "application/json"
        }
    });
    const data = await r.json();
    return data;
}

export async function fetchCuisineTypes() {
    return await fetchData<ICuisine[]>("Cuisine");
}

export async function fetchUsers() {
    return await fetchData<IUser[]>("Users");
}

export async function fetchRecipes(cuisinetypeId: number) {

    return await fetchData<IRecipe[]>(`Recipe/getbycuisine/${cuisinetypeId}`)
}

export async function postRecipe(form: FieldValues) {
    return postData<IRecipe>("Recipe", form);
}

export async function deleteRecipe(recipeid: number) {
    return deleteData<IRecipe>(`Recipe?recipeid=${recipeid}`);
}

export const blankrecipe: IRecipe = {
    recipeId: 0,
    usersId: 0,
    cuisineTypeId: 0,
    recipeName: "",
    calories: 0,
    draftDate: "",
    publishDate: "",
    archiveDate: "",
    recipeStatus: "",
    recipePicture: "",
    vegan: "",
    userName: "",
    errorMessage: ""
};