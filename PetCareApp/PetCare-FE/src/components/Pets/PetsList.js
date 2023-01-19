import './PetsList.css'
import PetCard from './PetCard';
import * as authServices from '../../services/petServices'
import { useContext, useEffect, useState } from 'react';
import { AuthContext } from '../../contexts/AuthContext';
import Login from '../Login/Login'

function PetsList() {
    const [pets, setPets] = useState([]);
    const { user } = useContext(AuthContext);

    console.log(user?.accessToken)
    useEffect(() => {
        fetchPets(user?.userId, user?.accessToken)
    }, [])

    async function fetchPets(userId, accessToken) {
        try {
            // const response = await axios.get(`https://localhost:7038/api/Pet/GetAll`, accessToken)
            const data = await authServices.getAllPet(userId, accessToken);

            setPets(data);
        } catch (err) {
            console.log(err)
        }
    }
    console.log(pets);
    return (
        <div className="pet-container">
            {pets.map(p => <PetCard key={p.id} pet={p} />)}
        </div>
    );
}

export default PetsList;