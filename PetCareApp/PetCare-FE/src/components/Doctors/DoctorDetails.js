import Calendar from "..//Calendar/Calendar"
import "./DoctorDetails.css"

const DoctorDetails = ({
    doctor,
}) => {
    return (
        <>
            <div className="doctor-calendar">
                <Calendar />
            </div>
            <div className="detailed-doctor">
                <h1>{doctor.firstName}</h1>
            </div>
        </>
    )
}

export default DoctorDetails;