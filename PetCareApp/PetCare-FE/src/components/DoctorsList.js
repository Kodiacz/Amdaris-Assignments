import './DoctorsList.css'
import DoctorCard from './DoctorCard';
import { useEffect, useState } from 'react';
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

    debugger
    return (
        <div className="doctor-list-container">
            {doctors.map(d => <DoctorCard key={d.id} doctor={d} />)}
        </div>
    );
}

export default DoctorsList;