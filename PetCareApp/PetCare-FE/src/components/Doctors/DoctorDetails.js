import Calendar from "..//Calendar/Calendar"
import MediaCard from "../Test"
import DoctorCard from "./DoctorCard"
import "./DoctorDetails.css"
import { GetDoctorSchedule } from "./DoctorsServices"

const DoctorDetails = ({
    doctor,
}) => {
    const { state: doctorSchedule } = GetDoctorSchedule(doctor.id)

    const scheduleDays = doctorSchedule.map(s => s.date.slice(8, 10))
    let availableDays = scheduleDays.filter((sd, i) => {
        if (doctorSchedule[i].isAvailable) {
            return sd
        }
    })

    availableDays = availableDays.map(a => Number(a));

    return (
        <>
            <div className="doctor-calendar">
                <Calendar availableDays={availableDays} />
            </div>
            <div className="detailed-doctor">
                <MediaCard doctor={doctor}/>
            </div>
        </>
    )
}

export default DoctorDetails;