import './DoctorsList.css'
import DoctorCard from './DoctorCard';
import { CircularProgress } from '@mui/material';
import { GetAllDoctors } from './DoctorsServices.js';
import { Outlet } from 'react-router-dom';

function DoctorsList() {
    const { state: doctors, isLoading } = GetAllDoctors();

    return (
        <div className="doctor-list-container">
            { isLoading
                ? <div className="doctors-load">
                    <CircularProgress color='success' size={120} thickness={1} />
                </div>
                : doctors.map(d => <DoctorCard key={d.id} doctor={d} />)
            }
        </div>
    );
}

export default DoctorsList;