import { CircularProgress } from "@mui/material";
import { useParams } from "react-router-dom";
import DoctorCard from "./DoctorCard"
import { GetDoctor } from "./DoctorsServices";
import DoctorDetails from "./DoctorDetails";
import "./DoctorDetails.css"

const Doctor = () => {
    const id = useParams();
    const { state: doctor, isLoading } = GetDoctor(id.id);
    console.log(id.id)
    console.log(doctor)
    return (
        <div className="doctors-details-container">
            {isLoading
                ? <div className="doctor-load">
                    <CircularProgress color='success' size={120} thickness={1} />
                </div>
                : <DoctorDetails doctor={doctor} />
            }
        </div>
    )
}

export default Doctor;