import { useState, useEffect, useContext } from "react"
import Calendar from "../../components/Calendar/Calendar"
import DoctorCard from "../../components/Doctors/DoctorCard"
import "./DoctorDetails.css"
import * as doctorsServices from "../../services/doctorsServices"
import * as ownerServices from "../../services/ownerServcies"
import ReasonForAppointment from "../../components/User/ReasonForAppointment"
import { AuthContext } from '../../contexts/AuthContext'
import { Newspaper } from "@mui/icons-material"
import { Button } from "@mui/material"

const DoctorDetails = ({
    doctor,
}) => {
    const [doctorSchedule, setDoctorSchedule] = useState([]);
    const [resultFromInput, setResultFromInput] = useState();
    const [newSchedule, setNewSchedule] = useState({});
    const { user } = useContext(AuthContext);
    console.log(newSchedule);
    useEffect(() => {
        doctorsServices.getDoctorSchedule(doctor.id)
            .then(res => setDoctorSchedule(res))
            .catch(err => console.log(err))
    }, [])

    const scheduleDays = [...doctorSchedule].map(d => (
        {
            scheduleId: d.id,
            date: Number(d.date.slice(8, 10)),
            month: Number(d.date.slice(5, 7)),
            isAvailable: d.isAvailable,
            doctorId: d.doctorId,
            fullName: d.fullName,
        }
    ))

    let availableDays = scheduleDays.filter((sd) => sd.isAvailable)

    const fetchData = () => {
        debugger;
        const updateScheduleResult = doctorsServices.updateDoctorSchedule(newSchedule, user.accessToken)

        const appointmentData = {
            date: new Date().toLocaleDateString(),
            reasonForAppointment: resultFromInput,
            ownerId: user.userId,
        }
        const getchAddAppointmentResult = ownerServices.updateOwnerAppointments(appointmentData, user.accessToken)
    }

    return (
        <>
            <ReasonForAppointment input={resultFromInput} setResultFromInput={setResultFromInput} />
            <div className="doctor-calendar">
                <Calendar availableDays={availableDays} setNewSchedule={setNewSchedule} />
                <div className="make-appointment-div">
                    <button type='submit' className="make-appointent-button" size="large" value={'Make Appointment'} onClick={fetchData}>
                        Make Appointment
                    </button>
                </div>
            </div>
            <div className="detailed-doctor">
                <DoctorCard doctor={doctor} />
            </div>
        </>
    )
}

export default DoctorDetails;