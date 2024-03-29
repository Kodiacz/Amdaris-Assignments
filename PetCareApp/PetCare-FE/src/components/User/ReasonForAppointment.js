import './ReasonForAppointment.css'
import { useCallback, useContext, useEffect, useState } from "react"
import * as petServices from '../../services/petServices'
import { MenuItem, Select, TextField, Tooltip } from "@mui/material"
import { AuthContext } from '../../contexts/AuthContext'
import { Link } from 'react-router-dom'

const selectToolTipTitle = (
  <h4 style={{ color: "white" }}>
    If you dont have any pets simply click <Link to='/my-account/create-pet'>here</Link>
  </h4>);

const ReasonForAppointment = ({
  setResultFromInput,
  setPet
}) => {
  const [pets, setPets] = useState([]);
  const [maxCaracters, setMaxCaracters] = useState(400);
  const [inputLenght, setInputLength] = useState(0);

  const { user } = useContext(AuthContext);

  const handleInput = useCallback(e => {
      setResultFromInput(e.target.value);
  }, [setResultFromInput])

  const handleSelect = useCallback(
    (e) => {
      setPet(e.target.value);
    },
    [setPet],
  )

  const handleOnChange = (e) => {
    let currentLength = e.target.value.length;
    let value;
    console.log(maxCaracters)
    setMaxCaracters(prevState => {
      if (currentLength === 0) {
        setInputLength(0);
        return 400;
      } 
      
      if (inputLenght > currentLength) {
        setInputLength(currentLength);
        value = prevState + (inputLenght - currentLength);
      } 
      
      if (inputLenght < currentLength) {
        setInputLength(currentLength);
        value = prevState - (currentLength - inputLenght);
      }

      return value > 0 ? value : 0;
    });
  }

  useEffect(() => {
    const getPets = async () => {
      const responseResult = await petServices.getAllPet(user.userId, user.accessToken);
      setPets(responseResult);
    }

    getPets();
  }, [])


  return (
    <div className="reason-for-appointment-container">
      <Tooltip title={selectToolTipTitle} placement="right">
        <TextField
          sx={{ width: '200px' }}
          labelId="demo-simple-select-helper-label"
          id="demo-simple-select-helper"
          label="Select Pet"
          select
          onChange={(e) => handleSelect(e)}
        >
          {pets.map(p => <MenuItem key={p.id} value={p}>{p.name}</MenuItem>)}

        </TextField>
      </Tooltip>
      <label className="reason-for-appointment-label">Reason For Appointment</label>
      <TextField
        multiline={true}
        minRows={9}
        fullWidth={true}
        onChange={(e => handleOnChange(e))}
        onBlur={(e) => handleInput(e)}
        on
      />
      <label style={{color: maxCaracters <= 0 ? 'red' : ''}}>Maximum characters {maxCaracters}</label>
    </div>
  )
}

export default ReasonForAppointment