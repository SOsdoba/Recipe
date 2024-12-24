import { IRecipe } from "./DataInterfaces";

interface Props {
    recipe: IRecipe;
    onSelectedForEdit: (recipe: IRecipe) => void;
}

export default function RecipeCard({ recipe, onSelectedForEdit }: Props) {
    return (
        <>
            <div className="card m-4 bg-dark" style={{ width: 210, color: "white" }} >
                <img src={`/images/RecipeImages/${recipe.recipePicture}`} onError={(e) => { e.currentTarget.src = "/images/RecipeImages/test.jpg" }} className="card-img-top" style={{ height: 170 }} alt={recipe.recipeName} />
                <div className="card-body">
                    <p className="card-text fs-5" style={{ textAlign: "center", height: 40 }}>{recipe.recipeName}</p>
                    <button onClick={() => { onSelectedForEdit(recipe) }} className="btn btn-light" style={{ textAlign: "center" }}>Edit</button>
                </div>
            </div>
        </>
    )
}