import './DoctorsList.css'
import DoctorCard from './DoctorCard';
import { useEffect, useState } from 'react';
import axios from 'axios';
import { CircularProgress } from '@mui/material';

function DoctorsList() {
    const [doctors, setDoctors] = useState([]);

    useEffect(() => {
        getDoctors()
    }, [])

    async function getDoctors() {
        const result = await axios.get(`https://localhost:7038/api/Doctor/GetAll`)
        setDoctors(result.data);
    }
    const random = Math.random()
    return (
        <div className="doctor-list-container">
            {random > 0.5 ? doctors.map(d => <DoctorCard key={d.id} doctor={d} />) : <CircularProgress />}
        </div>
    );
}

export default DoctorsList;