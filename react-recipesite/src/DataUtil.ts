import { ICuisine, IRecipe } from "./DataInterfaces";

const baseurl = "https://recipeapiso.azurewebsites.net/api/";
async function fetchData<T>(url: string): Promise<T> {
    url = baseurl + url;
    const c = await fetch(url);
    const data = await c.json();
    return data;
}

export async function fetchCuisineTypes() {
    return await fetchData<ICuisine[]>("Cuisine");
}

export async function fetchRecipes(cuisinetypeId: number) {
    return await fetchData<IRecipe[]>(`Recipe/getbycuisine/${cuisinetypeId}`)
    //https://recipeapiso.azurewebsites.net/api/Recipe/getbycuisine/American
}