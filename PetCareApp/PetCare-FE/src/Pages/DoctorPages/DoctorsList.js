import './DoctorsList.css'
import DoctorCard from '../../components/Doctors/DoctorCard';
import { CircularProgress } from '@mui/material';
import * as doctorsServices from '../../services/doctorsServices.js';
import { useState, useEffect } from 'react';

function DoctorsList() {
    const [doctors, setDoctors] = useState([]);
    const [isLoading, setIsLoading] = useState(true);
    const [error, setErorr] = useState(null);

    useEffect(() => {
        const fetch = () => {
            setTimeout(() => {
                doctorsServices.getAll()
                    .then(res => setDoctors(res))
                    .catch(err => setErorr(err));
                setIsLoading(false);
            }, 1000)
        }
        fetch();
    }, [])

    return (
        <div className="doctor-list-container">
            {isLoading
                ? <div className="doctors-load">
                    <CircularProgress color='success' size={120} thickness={1} />
                </div>
                : doctors.map(d => <DoctorCard key={d.id} renderButton={true} buttonkey={d.id} doctor={d} />)
            }
        </div>
    );
}

export default DoctorsList;