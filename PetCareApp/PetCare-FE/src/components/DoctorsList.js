import Doctor from './Doctor';
import { useState } from 'react';

function DoctorsList() {
    const [doctors, setDoctors] = useState([]);

    async function handleSubmit() {
        const resp = await fetch(`https://localhost:7038/api/Doctor/GetAll`);
        const data = await resp.json();

        setDoctors(data);
    }

    return (
        <>
            <button type="button" onClick={handleSubmit}>Click here</button>
            <div>
                {doctors.map(d => <Doctor name={d.firstName} />)}
            </div>
        </>
    );
}

export default DoctorsList;