import Pet from './Pet';
import { useEffect, useState } from 'react';

function PetList() {
    const [pets, setDoctors] = useState([]);

    useEffect(() => {
        getPets()
    }, [])

    async function getPets() {
        const resp = await fetch(`https://localhost:7038/api/Pet/GetAll`);
        const data = await resp.json();
        console.log(data);
        setDoctors(data);
    }

    return (
        <>
            {/* <button type="button" onClick={handleSubmit}>Click here</button> */}
            <div>
                <table>
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
        </>
    );
}

export default PetList;