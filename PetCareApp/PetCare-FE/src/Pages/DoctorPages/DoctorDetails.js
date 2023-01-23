import "./DoctorDetails.css"
import { Button } from "@mui/material"
import AddIcon from '@mui/icons-material/Add';
import Alerts from "../../components/Alert/Alerts"
import { useState, useEffect, useContext } from "react"
import { AuthContext } from '../../contexts/AuthContext'
import Calendar from "../../components/Calendar/Calendar"
import DoctorCard from "../../components/Doctors/DoctorCard"
import * as ownerServices from "../../services/ownerServcies"
import * as doctorsServices from "../../services/doctorsServices"
import ReasonForAppointment from "../../components/User/ReasonForAppointment"

const DoctorDetails = ({
    doctor,
}) => {
    const [pet, setPet] = useState();
    const { user } = useContext(AuthContext);
    const [rerender, setRerender] = useState({});
    const [newSchedule, setNewSchedule] = useState();
    const [doctorSchedule, setDoctorSchedule] = useState([]);
    const [resultFromInput, setResultFromInput] = useState();
    const [alertState, setAlertState] = useState({
        openValue: false,
        severityValue: '',
        titleValue: '',
        titleType: '',
    })

    useEffect(() => {
        console.log('use effect')
        doctorsServices.getDoctorSchedule(doctor.id)
            .then(res => setDoctorSchedule(res))
            .catch(err => console.log(err))
    }, [rerender])

    const disableButton = () => (user.username && newSchedule && resultFromInput && pet) ? false : true

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

    const fetchData = async () => {
        const updateScheduleResult = await doctorsServices.updateDoctorSchedule(newSchedule, user.accessToken);
        
        const fetchAddPatientToDoctorData = {
            patientId: pet.id,
            doctorId: doctor.id,
        }
        const fetchAddPatientToDoctor = await doctorsServices.addPatientToDoctor(fetchAddPatientToDoctorData, user.accessToken);
        console.log(newSchedule);
        const appointmentData = {
            dateOfAppointment: newSchedule.date.toISOString().slice(0, 10),
            reasonForAppointment: resultFromInput,
            ownerId: user.userId,
            petName: pet.name,
            doctorFullName: `${doctor.firstName} ${doctor.lastName}`
        }
        console.log(appointmentData);

        const fetchAddAppointmentResult = await ownerServices.updateOwnerAppointments(appointmentData, user.accessToken);
        setRerender(fetchAddAppointmentResult);

        setAlertState(state => {
            return {
                openValue: true,
                severityValue: 'success',
                titleValue: 'You have made an appointment for this date successfully',
                titleType: 'Success'
            }
        });
    }
    return (
        <>
            {
                user.username
                    ? <ReasonForAppointment setPet={setPet} input={resultFromInput} setResultFromInput={setResultFromInput} />
                    : ""
            }
            <div className="doctor-calendar">
                <Alerts 
                openValue={alertState.openValue} 
                severityValue={alertState.severityValue} 
                titleValue={alertState.titleValue}
                titleType={alertState.titleType} 
                closeAlert={setAlertState} />
                <Calendar availableDays={availableDays} setNewSchedule={setNewSchedule} setAlertState={setAlertState} />
                <div className="make-appointment-div">
                    {
                        user.username
                            ? <Button
                                startIcon={<AddIcon />}
                                disabled={disableButton()}
                                variant="outlined"
                                type='submit'
                                className="make-appointent-button"
                                size="large"
                                value={'Make Appointment'}
                                onClick={fetchData}
                            >
                                Make Appointment
                            </Button>
                            : ""
                    }
                </div>
            </div>
            <div className="detailed-doctor">
                <DoctorCard doctor={doctor} />
            </div>
        </>
    )
}

export default DoctorDetails;