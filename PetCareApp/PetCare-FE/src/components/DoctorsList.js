import Doctor from './Doctor';
import { useEffect, useState } from 'react';

function DoctorsList() {
    const [doctors, setDoctors] = useState([]);

    useEffect(() => {
        handleSubmit()
    }, [])

    async function handleSubmit() {
        const resp = await fetch(`https://localhost:7038/api/Doctor/GetAll`);
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
                        <th>Full Name</th>
                        <th>Age</th>
                        <th>Phonenumber</th>
                        <th>Job Description</th>
                        <th>Available</th>
                    </tr>
                    {doctors.map(d => <Doctor key={d.id} doctor={d} />)}
                </table>
            </div>
        </>
    );
}

export default DoctorsList;