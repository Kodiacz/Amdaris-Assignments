import './PetsList.css'
import Pet from './Pet';
import * as authServices from '../../services/petServices'
import { useContext, useEffect, useState } from 'react';
import { AuthContext } from '../../contexts/AuthContext';
import Login from '../Login/Login'

function PetsList() {
    const [pets, setPets] = useState([]);
    const { user } = useContext(AuthContext);
    
    console.log(user?.accessToken)
    useEffect(() => {
        fetchPets(user?.accessToken)
    }, [])

    async function fetchPets(accessToken) {
        try{
            // const response = await axios.get(`https://localhost:7038/api/Pet/GetAll`, accessToken)
            const data = await authServices.getAllPet(accessToken);
            ;
            setPets(data);
        } catch(err) {
            console.log(await err)
        }
    }

    return (
        <div className="pet-list-container">
            <table className="pet-list-table">
                <tr>
                    <th>Name</th>
                    <th>Age</th>
                    <th>Owner</th>
                    <th>Type</th>
                    <th>Breed</th>
                </tr>
                {pets.map(p => <Pet key={p.id} pet={p} />)}
            </table>
        </div>
    );
}

export default PetsList;