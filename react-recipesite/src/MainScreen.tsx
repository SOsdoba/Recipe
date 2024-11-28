import { useEffect, useState } from "react";
import { fetchRecipes } from "./DataUtil";
import { IRecipe } from "./DataInterfaces";
import RecipeCard from "./RecipeCard";

interface Props {
    cuisinetypeId: number;
}

export default function MainScreen({ cuisinetypeId }: Props) {

    const [recipelist, setrecipelist] = useState<IRecipe[]>([]);

    useEffect(() => {
        if (cuisinetypeId > 0) {
            const fetchdata = async () => {
                const data = await fetchRecipes(cuisinetypeId);
                setrecipelist(data);
            }
            fetchdata();
        }
    }, [cuisinetypeId]);

    return (
        <div className="row">
            {recipelist.map(r =>
                <div className="col-lg-3 col-md-5 col-6 m-3" >
                    <RecipeCard key={r.recipeId} recipe={r} />
                </div>
            )}
        </div>

    )
}