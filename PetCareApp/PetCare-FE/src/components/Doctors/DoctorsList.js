import './DoctorsList.css'
import DoctorCard from './DoctorCard';
import { CircularProgress } from '@mui/material';
import { GetAllDoctors } from './DoctorsServices.js';

function DoctorsList() {
    const { state: doctors, isLoading, error } = GetAllDoctors();

    console.log(doctors)
    console.log(isLoading)
    console.log(error)

    return (
        <div className="doctor-list-container">
            {isLoading
                ? <div className="doctors-load">
                    <CircularProgress color='success' size={120} thickness={1} />
                </div>
                : doctors.map(d => <DoctorCard key={d.id} doctor={d} />)
            }
        </div>
    );
}

export default DoctorsList;