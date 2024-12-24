import { useEffect, useState } from "react"
import { ICuisine } from "./DataInterfaces"
import { fetchCuisineTypes } from "./DataUtil";
import CuisineItem from "./CuisineItem";

interface Props {
    Id: (CuisineTypeId: number) => void;
    setIsRecipeEdit: (value: boolean) => void;
}

export default function CuisineList({ Id, setIsRecipeEdit }: Props) {

    const [cuisinelist, setCuisineList] = useState<ICuisine[]>([]);
    const [selectedCuisineTypeId, setSelectedCuisineTypeId] = useState(0);

    useEffect(() => {
        const fetchdata = async () => {
            const data = await fetchCuisineTypes();
            setCuisineList(data);
            if (data.length > 0) {
                handleSelectedCuisine(data[0]);
            }
        }
        fetchdata();
    }, []);

    function handleSelectedCuisine(cuisine: ICuisine) {
        setSelectedCuisineTypeId(cuisine.cuisineTypeId);
        Id(selectedCuisineTypeId);
        setIsRecipeEdit(false);
    }

    return (
        <div>
            <button className="btn btn-primary bg-dark m-2 " type="button" data-bs-toggle="collapse" data-bs-target="#collapse" aria-expanded="false" aria-controls="collapse">{">"}</button>

            <div className="collapse collapse-horizontal show" id="collapse">
                <div className="btn-group btn-group-toggle " style={{ display: "flex", flexDirection: "column" }} data-toggle="buttons">
                    {cuisinelist.map(c =>
                        <CuisineItem key={c.cuisineTypeId} cuisine={c} onSelected={handleSelectedCuisine} />)}
                </div>
            </div>
        </div>
    )
}