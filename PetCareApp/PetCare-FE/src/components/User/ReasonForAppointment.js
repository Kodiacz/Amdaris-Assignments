import './ReasonForAppointment.css'
import { useCallback, useContext, useEffect, useState } from "react"
import * as petServices from '../../services/petServices'
import { MenuItem, Select, TextField } from "@mui/material"
import { AuthContext } from '../../contexts/AuthContext'

const ReasonForAppointment = ({
    setResultFromInput,
    setPet
}) => {
    const [pets, setPets] = useState([]);
    const { user } = useContext(AuthContext);

    const handleInput = useCallback(e => {
        setResultFromInput(e.target.value);
    }, [setResultFromInput])

    const handleSelect = useCallback(
      (e) => {
        console.log(e.target.value)
        setPet(e.target.value);
      },
      [setPet],
    )
    
    
    useEffect(() => {
      const getPets = async () => {
        const responseResult = await petServices.getAllPet(user.userId, user.accessToken);
        setPets(responseResult);
      }

      getPets();
    }, [])
    
    
    return (
        <div className="reason-for-appointment-container">
            <TextField
                sx={{width: '200px'}}
                labelId="demo-simple-select-helper-label"
                id="demo-simple-select-helper"
                label="Select Pet"
                select
                onChange={(e) => handleSelect(e)}
            >
                {pets.map(p => <MenuItem key={p.id} value={p}>{p.name}</MenuItem>)}
                
            </TextField>
            <label className="reason-for-appointment-label">Reason For Appointment</label>
            <TextField multiline={true} minRows={9} fullWidth={true} onBlur={(e) => handleInput(e)} />
        </div>
    )
}

export default ReasonForAppointment