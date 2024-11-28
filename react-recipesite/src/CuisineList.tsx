import { useEffect, useState } from "react"
import { ICuisine } from "./DataInterfaces"
import { fetchCuisineTypes } from "./DataUtil";
import CuisineItem from "./CuisineItem";

interface Props {
    Id: (CuisineTypeId: number) => void;
}

export default function CuisineList({ Id }: Props) {

    const [cuisinelist, setCuisineList] = useState<ICuisine[]>([]);
    const [selectedCuisineTypeId, setSelectedCuisineTypeId] = useState(0);

    useEffect(() => {
        const fetchdata = async () => {
            const data = await fetchCuisineTypes();
            setCuisineList(data);
            if (data.length > 0) {
                handleSelectedCuisine(data[0].cuisineTypeId);
            }
        }
        fetchdata();
    }, []);

    function handleSelectedCuisine(cuisineTypeId: number) {
        setSelectedCuisineTypeId(cuisineTypeId);
        Id(selectedCuisineTypeId);
    }

    return (
        <div>
            <button className="btn btn-primary m-2 bg-dark " type="button" data-bs-toggle="collapse" data-bs-target="#collapse" aria-expanded="false" aria-controls="collapse">{">"}</button>
            <div className="collapse collapse-horizontal" id="collapse">
                <div className="btn-group btn-group-toggle" style={{ display: "flex", flexDirection: "column" }} data-toggle="buttons">
                    {cuisinelist.map(c =>
                        <CuisineItem key={c.cuisineTypeId} cuisine={c} onSelected={handleSelectedCuisine} />)}
                </div>
            </div>
        </div>
    )
}