import './PetsList.css'
import PetCard from './PetCard';
import * as authServices from '../../services/petServices'
import { useContext, useEffect, useState } from 'react';
import { AuthContext } from '../../contexts/AuthContext';
import Login from '../Login/Login'
import { CircularProgress } from '@mui/material';

function PetsList() {
    const [pets, setPets] = useState([]);
    const [isLoading, setIsLoading] = useState(true);
    const { user } = useContext(AuthContext);

    console.log(user?.accessToken)
    useEffect(() => {
        setTimeout(() => {
            fetchPets(user?.userId, user?.accessToken)
        }, 1000)
    }, [])

    async function fetchPets(userId, accessToken) {
        try {
            // const response = await axios.get(`https://localhost:7038/api/Pet/GetAll`, accessToken)
            const data = await authServices.getAllPet(userId, accessToken);

            setPets(data);
            setIsLoading(false);
        } catch (err) {
            console.log(err)
        }
    }
    console.log(pets);
    return (
        <div className="pet-container">
            {
                isLoading
                    ? <div className='pet-loading-circle'>
                        <CircularProgress color='success' size={120} thickness={1} />
                      </div>
                    : pets.map(p => <PetCard key={p.id} pet={p} />)
            }
        </div>
    );
}

export default PetsList;