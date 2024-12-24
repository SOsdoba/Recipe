import { useEffect, useState } from "react";
import { blankrecipe, fetchRecipes } from "./DataUtil";
import { IRecipe } from "./DataInterfaces";
import RecipeCard from "./RecipeCard";
import RecipeForm from "./RecipeForm";

interface Props {
    cuisinetypeId: number;
    isRecipeEdit: boolean;
    setIsRecipeEdit: (value: boolean) => void;
}

export default function MainScreen({ cuisinetypeId, isRecipeEdit, setIsRecipeEdit }: Props) {

    const [recipelist, setrecipelist] = useState<IRecipe[]>([]);
    const [recipeforedit, setRecipeForEdit] = useState(blankrecipe);

    useEffect(() => {
        if (cuisinetypeId > 0) {

            setRecipeForEdit(blankrecipe);
            const fetchdata = async () => {
                const data = await fetchRecipes(cuisinetypeId);
                setrecipelist(data);
            }
            fetchdata();
            setIsRecipeEdit(false);
        }
    }, [cuisinetypeId]);

    const handleSelectedForEdit = (recipe: IRecipe) => {
        setRecipeForEdit(recipe);
        setIsRecipeEdit(true);
    }

    return (
        <div className="row">
            <div className="row">
                <div className="col text-end" >
                    <button type="button" onClick={() => { setIsRecipeEdit(false), handleSelectedForEdit(blankrecipe) }} className=" btn bg-dark m-4 ms-auto" style={{ color: "white" }}>New Recipe</button>
                </div>
            </div>
            <div className="row">
                {isRecipeEdit ?
                    <div className="col-12 ms-auto"><RecipeForm onSelectedForEdit={handleSelectedForEdit} recipe={recipeforedit == undefined ? blankrecipe : recipeforedit} /></div> :
                    recipelist.map(r =>
                        <div className="col-md-4 col-lg-3  m-3" >
                            <RecipeCard key={r.recipeId} recipe={r} onSelectedForEdit={handleSelectedForEdit} />
                        </div>
                    )}
            </div>
        </div>
    )
}