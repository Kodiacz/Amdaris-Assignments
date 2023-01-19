import { useState, useEffect } from "react"
import Calendar from "../../components/Calendar/Calendar"
import DoctorCard from "../../components/Doctors/DoctorCard"
import "./DoctorDetails.css"
import * as doctorsServices from "../../services/doctorsServices"

const DoctorDetails = ({
    doctor,
}) => {
    
    const [doctorSchedule, setDoctorSchedule] = useState([]);
    
    useEffect(() => {
        doctorsServices.getDoctorSchedule(doctor.id)
        .then(res => setDoctorSchedule(res))
        .catch(err => console.log(err))
    }, [])
    

    const scheduleDays = [...doctorSchedule].map(d => (
        {
            date: Number(d.date.slice(8, 10)),
            month: Number(d.date.slice(5, 7)),
            isAvailable: d.isAvailable,
        }
    ))
        
    let availableDays = scheduleDays.filter((sd) => sd.isAvailable)
    
    return (
        <>
            <div className="doctor-calendar">
                <Calendar availableDays={availableDays} />
            </div>
            <div className="detailed-doctor">
                <DoctorCard  doctor={doctor} />
            </div>
        </>
    )
}

export default DoctorDetails;