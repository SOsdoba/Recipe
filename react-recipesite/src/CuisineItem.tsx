import { ICuisine } from "./DataInterfaces"

interface Props {
    cuisine: ICuisine;
    onSelected: (cuisine: ICuisine) => void;
}

export default function CuisineItem({ cuisine, onSelected }: Props) {
    return (
        <div>
            <label onClick={() => { onSelected(cuisine) }} className="btn btn-secondary bg-light active" style={{ width: 140, color: "black" }}>
                <input type="radio" name="options" id="option1" /> {cuisine.cuisineType}
                <img src={`/images/CountryFlags/${cuisine.cuisineType}.jpg`} alt={cuisine.cuisineType} className="p-2" height={90} width={120} />
            </label>
        </div >
    )
}