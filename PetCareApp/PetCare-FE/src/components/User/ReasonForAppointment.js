import { TextField } from "@mui/material"
import { useCallback } from "react"
import './ReasonForAppointment.css'

const ReasonForAppointment = ({
    setResultFromInput,
}) => {
    const getValue = useCallback(e => {
        setResultFromInput(e.target.value)
      }, [setResultFromInput])
    
    return (
        <div className="reason-for-appointment-container">
            <select>Select Your Pet</select>
            <label className="reason-for-appointment-label">Reason For Appointment</label>
            <TextField multiline={true} minRows={9} fullWidth={true} onBlur={(e) => getValue(e)} />
        </div>
    )
}

export default ReasonForAppointment