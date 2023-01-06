import Doctor from './Doctor';
import { useEffect, useState } from 'react';
import styles from './DoctorsList.module.css'

function DoctorsList() {
    const [doctors, setDoctors] = useState([]);

    useEffect(() => {
        getDoctors()
    }, [])

    async function getDoctors() {
        const resp = await fetch(`https://localhost:7038/api/Doctor/GetAll`);
        const data = await resp.json();
        console.log(data);
        setDoctors(data);
    }

    return (
        <>
            <div>
                <table className={styles.table}>
                    <tr>
                        <th className={styles.th}>Full Name</th>
                        <th>Phonenumber</th>
                        <th>Job Description</th>
                        <th>Available</th>
                    </tr>
                    {doctors.map(d => <Doctor tdSyle={styles.td} key={d.id} doctor={d} />)}
                </table>
            </div>
        </>

        
    );
}

export default DoctorsList;