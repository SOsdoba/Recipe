import { useState } from 'react';
import './assets/css/bootstrap.min.css'
import CuisineList from './CuisineList'
import MainScreen from './MainScreen'
import Navbar from './Navbar'

function App() {
  const [isrecipeedit, setIsRecipeEdit] = useState(false);
  const [selectedCuisineTypeId, setSelectedCuisineTypeId] = useState(0);
  const handleCuisineSelect = (cuisineTypeId: number) => {
    setSelectedCuisineTypeId(cuisineTypeId);
  }

  return (
    <div>
      <div className="row">
        <Navbar />
      </div>
      <div className="row">
        <div className=" col-3 p-1">
          <CuisineList setIsRecipeEdit={setIsRecipeEdit} Id={handleCuisineSelect} />
        </div>
        <div className="col-9">
          <MainScreen isRecipeEdit={isrecipeedit} setIsRecipeEdit={setIsRecipeEdit} cuisinetypeId={selectedCuisineTypeId} />
        </div>
      </div>
    </div>
  )
}

export default App
