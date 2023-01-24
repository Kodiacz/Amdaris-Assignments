import './PetsList.css'
import PetCard from '../../components/Pets/PetCard';
import * as authServices from '../../services/petServices'
import { useContext, useEffect, useState } from 'react';
import { AuthContext } from '../../contexts/AuthContext';
import { CircularProgress } from '@mui/material';

function PetsList() {
    const [pets, setPets] = useState([]);
    const [isLoading, setIsLoading] = useState(true);
    const [countOfPets, setCountOfPets] = useState(pets.length);
    const { user } = useContext(AuthContext);
    
    useEffect(() => {
        setTimeout(() => {
            fetchPets(user?.userId, user?.accessToken)
        }, 1000)
    }, [countOfPets])

    async function fetchPets(userId, accessToken) {
        try {
            const data = await authServices.getAllPet(userId, accessToken);

            setPets(data);
            setIsLoading(false);
        } catch (err) {
            console.log(err)
        }
    }
    
    return (
        <div className="pet-container">
            {
                isLoading
                    ? <div className='pet-loading-circle'>
                        <CircularProgress color='success' size={120} thickness={1} />
                      </div>
                    : pets.map(p => <PetCard key={p.id} pet={p} renderButton={true} setCountOfPets={setCountOfPets}/>)
            }
        </div>
    );
}

export default PetsList;