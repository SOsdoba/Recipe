import { IRecipe } from "./DataInterfaces";

interface Props {
    recipe: IRecipe;
}

export default function RecipeCard({ recipe }: Props) {


    return (
        <>
            <div className="card m-4 bg-dark" style={{ width: 210, color: "white" }} >
                <img src={`/images/RecipeImages/${(recipe.recipePicture).includes("food") ? "test.jpg" : recipe.recipePicture}`} className="card-img-top" style={{ height: 170 }} alt={recipe.recipeName} />
                <div className="card-body">
                    <p className="card-text fs-5" style={{ textAlign: "center", height: 40 }}>{recipe.recipeName}</p>
                </div>
            </div>

        </>
    )
}