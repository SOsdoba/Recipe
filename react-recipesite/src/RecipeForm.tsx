import { useEffect, useState } from "react";
import { FieldValues, useForm } from "react-hook-form"
import { blankrecipe, deleteRecipe, fetchCuisineTypes, fetchUsers, postRecipe } from "./DataUtil";
import { ICuisine, IRecipe, IUser } from "./DataInterfaces";

interface Props {
    recipe: IRecipe;
    onSelectedForEdit: (recipe: IRecipe) => void;
}

export default function RecipeForm({ recipe, onSelectedForEdit }: Props) {

    const formatDate = (date: string | null): string => {
        if (!date) return "";
        const d = new Date(date);
        return isNaN(d.getTime()) ? "" : d.toISOString().split("T")[0];
    }

    const formatForPost = (date: string | null): string | null => {
        return date == "" ? null : date;
    };

    const formattedRecipe = {
        ...recipe,
        draftDate: formatDate(recipe.draftDate),
        publishDate: formatDate(recipe.publishDate),
        archiveDate: formatDate(recipe.archiveDate)
    };

    const { register, handleSubmit, reset } = useForm({ defaultValues: formattedRecipe });
    const [users, setUsers] = useState<IUser[]>([]);
    const [cuisinetypes, setCuisineTypes] = useState<ICuisine[]>([]);
    const [errormsg, setErrorMsg] = useState("");

    useEffect(() => {
        const fetchdata = async () => {
            const users = await fetchUsers();
            const cuisines = await fetchCuisineTypes();
            setUsers(users);
            setCuisineTypes(cuisines);
            reset(formattedRecipe);
        }
        fetchdata();
    }, [reset]);

    useEffect(() => {
        reset(recipe);
    }
        , [recipe]);

    const submitForm = async (data: FieldValues) => {
        const updatedRecipeForPost = {
            ...data,
            draftDate: formatForPost(data.draftDate),
            publishDate: formatForPost(data.publishDate),
            archiveDate: formatForPost(data.archiveDate)
        }
        const r = await postRecipe(updatedRecipeForPost);
        setErrorMsg(r.errorMessage);
        const formattedRecipe = {
            ...r,
            draftDate: formatDate(r.draftDate),
            publishDate: formatDate(r.publishDate),
            archiveDate: formatDate(r.archiveDate)
        }
        reset(formattedRecipe);
        onSelectedForEdit(formattedRecipe);
    };


    const onDelete = async () => {

        const r = await deleteRecipe(recipe.recipeId);
        setErrorMsg(r.errorMessage);
        if (r.errorMessage == "") {
            reset(blankrecipe)
        }
    }

    return (
        <div className="bg-dark mt-4 p-4 m-4" style={{ color: "white" }}>
            <div className="row">
                <div className="col-12">
                    <h2 id="msg">{errormsg}</h2>
                </div>
            </div>
            <div className="row" >
                <div className="col-12 ">
                    <form onSubmit={handleSubmit(submitForm)} className="needs-validation">
                        <div className="mb-3" hidden>
                            <label htmlFor="recipeId" className="form-label">Recipe ID:</label>
                            <input id="recipeId" type="number" {...register("recipeId")} className="form-control" />
                        </div>

                        <div className="mb-3">
                            <label htmlFor="recipeName" className="form-label">Recipe Name:</label>
                            <input id="recipeName" type="text" {...register("recipeName")} className="form-control" required />
                        </div>

                        <div className="mb-3 mt-3">
                            <label htmlFor="usersId" className="form-label">User:</label>
                            <select id="usersId" {...register("usersId", { valueAsNumber: true })} className="form-select">
                                <option value="0"></option>
                                {users.map(u => <option key={u.usersId} value={u.usersId}>{u.userName}</option>)}
                            </select>
                        </div>

                        <div className="mb-3">
                            <label htmlFor="cuisineTypeId" className="form-label">Cuisine Type:</label>
                            <select {...register("cuisineTypeId", { valueAsNumber: true })} className="form-select">
                                <option value="0"></option>
                                {cuisinetypes.map(c => <option key={c.cuisineTypeId} value={c.cuisineTypeId}>{c.cuisineType}</option>)}
                            </select>
                        </div>

                        <div className="mb-3">
                            <label htmlFor="calories" className="form-label">Calories:</label>
                            <input id="calories" type="number" {...register("calories")} className="form-control" required />
                        </div>

                        <div className="mb-3">
                            <label htmlFor="draftDate" className="form-label">Draft Date: </label>
                            <input id="draftDate" type="string" {...register("draftDate")} className="form-control"
                                required />
                        </div>
                        <div className="mb-3">
                            <label htmlFor="publishDate" className="form-label">Publish Date: </label>
                            <input id="publishDate" type="string" {...register("publishDate")} className="form-control"
                            />
                        </div>
                        <div className="mb-3">
                            <label htmlFor="archiveDate" className="form-label">Archive Date: </label>
                            <input id="archiveDate" type="string" {...register("archiveDate")} className="form-control"
                            />
                        </div>
                        <div className="mb-3">
                            <label htmlFor="recipeStatus" className="form-label">Recipe Status:</label>
                            <input id="recipeStatus" type="text" {...register("recipeStatus")} className="form-control" readOnly
                            />
                        </div>
                        <div className="mb-3" hidden>
                            <label htmlFor="recipePicture" className="form-label">Recipe Picture:</label>
                            <input id="recipePicture" {...register("recipePicture")} type="text" className="form-control" />
                        </div>

                        <button type="submit" className="btn btn-primary m-2">Submit</button>
                        <button onClick={onDelete} type="button" className="btn btn-danger" id="btndelete">Delete</button>
                    </form>
                </div>
            </div>
        </div>
    )
}