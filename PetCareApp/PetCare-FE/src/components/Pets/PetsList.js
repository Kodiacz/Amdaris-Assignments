import './PetsList.css'
import Pet from './Pet';
import { useEffect, useState } from 'react';
import axios from 'axios';

function PetsList() {
    const [pets, setDoctors] = useState([]);

    useEffect(() => {
        getPets()
    }, [])

    async function getPets() {
        const result = await axios.get(`https://localhost:7038/api/Pet/GetAll`)
        setDoctors(result.data);
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