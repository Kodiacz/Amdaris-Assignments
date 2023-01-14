import Calendar from "..//Calendar/Calendar"
import MediaCard from "../Test"
import DoctorCard from "./DoctorCard"
import "./DoctorDetails.css"
import { GetDoctorSchedule } from "./DoctorsServices"

const DoctorDetails = ({
    doctor,
}) => {
    const { state: doctorSchedule } = GetDoctorSchedule(doctor.id)

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