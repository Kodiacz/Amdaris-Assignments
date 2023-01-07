import './DoctorsList.css'
import Doctor from './Doctor';
import { useEffect, useState } from 'react';
import styles from './DoctorsList.module.css'
import axios from 'axios';

function DoctorsList() {
    const [doctors, setDoctors] = useState([]);

    useEffect(() => {
        getDoctors()
    }, [])

    async function getDoctors() {
        const result = await axios.get(`https://localhost:7038/api/Doctor/GetAll`)
        setDoctors(result.data);
    }

    return (
        <div className="doctor-list-container">
            <table className="doctor-list-table">
                <tr>
                    <th className={styles.th}>Full Name</th>
                    <th>Phonenumber</th>
                    <th>Job Description</th>
                    <th>Available</th>
                </tr>
                {doctors.map(d => <Doctor tdSyle={styles.td} key={d.id} doctor={d} />)}
            </table>
        </div>
    );
}

export default DoctorsList;