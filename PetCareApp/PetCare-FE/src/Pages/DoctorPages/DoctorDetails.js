import { useState, useEffect, useContext } from "react"
import Calendar from "../../components/Calendar/Calendar"
import DoctorCard from "../../components/Doctors/DoctorCard"
import "./DoctorDetails.css"
import * as doctorsServices from "../../services/doctorsServices"
import * as ownerServices from "../../services/ownerServcies"
import ReasonForAppointment from "../../components/User/ReasonForAppointment"
import { AuthContext } from '../../contexts/AuthContext'
import { Newspaper } from "@mui/icons-material"
import AddIcon from '@mui/icons-material/Add';
import { Alert, Button, Divider } from "@mui/material"
import Alerts from "../../components/Alert/Alerts"

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
        // const updateScheduleResult = await doctorsServices.updateDoctorSchedule(newSchedule, user.accessToken)

        // const appointmentData = {
        //     dateOfAppointment: newSchedule.date,
        //     reasonForAppointment: resultFromInput,
        //     ownerId: user.userId,
        // }

        // const fetchAddAppointmentResult = await ownerServices.updateOwnerAppointments(appointmentData, user.accessToken);
        // setRerender(fetchAddAppointmentResult);
        // console.log('fetchData', fetchAddAppointmentResult)
        setAlertState(state => {
            return {
                openValue: true,
                severityValue: 'success',
                titleValue: 'You have made an appointment for this date successfully',
                titleType: 'Success'
            }
        })
    }
    console.log(alertState)
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
                    {/* <button type='submit' className="make-appointent-button" size="large" value={'Make Appointment'} onClick={fetchData}>
                        Make Appointment
                    </button> */}
                </div>
            </div>
            <div className="detailed-doctor">
                <DoctorCard doctor={doctor} />
            </div>
        </>
    )
}

export default DoctorDetails;