import { Button, ButtonGroup, Card, CardActions, CardContent, Divider, Paper, TextField } from '@mui/material'
import { Box } from '@mui/system'
import React, { useContext, useEffect, useState } from 'react'
import { useNavigate, useOutletContext } from 'react-router-dom'
import './EditUser.css'
import { AuthContext } from '../../contexts/AuthContext'
import * as ownerServices from '../../services/ownerServcies'

const textFieldStyle = {
  padding: '20px'
}

const EditUser = () => {
  const {user} = useContext(AuthContext)
  const { owner, setReFetch } = useOutletContext()
  const [inputState, setInputState] = useState({})
  const navigate = useNavigate();

  useEffect(() => {
    setInputState(prevState => {
      return {
        fullName: `${owner.firstName} ${owner.lastName}`,
        email: owner.email,
        phonenumber: owner.phonenumber,
      }
    })
  }, [owner])


  const handleOnChange = (e) => {
    setInputState(prevState => {
      return {
        ...prevState,
        [e.target.name]: e.target.value,
      }
    })
  };

  const handleSubmit = async (e) => {
    e.preventDefault();
    console.log(e.target)
    const formData = new FormData(e.target);
    const firstName = formData.get('fullName').split(' ')[0];
    const lastName = formData.get('fullName').split(' ')[1];
    const email = formData.get('email');
    const phonenumber = formData.get('phonenumber');

    const partialUpdateData = [
      {
        "path": "firstName",
        "op": "replace",
        "value": firstName,
      },
      {
        "path": "lastName",
        "op": "replace",
        "value": lastName,
      },
      {
        "path": "email",
        "op": "replace",
        "value": email,
      },
      {
        "path": "phonenumber",
        "op": "replace",
        "value": phonenumber,
      },
    ]

    const resultFromPatchUpdate = await ownerServices.partialUpdate(owner.id, partialUpdateData, user.accessToken)
    setReFetch(true);
  };

  const CloseEditComponent = () => {
    navigate('/my-account/account-details')
  }
  
  return (
    <div>
      <Paper elevation={24}>
        <Box sx={{ minWidth: 275 }}>
          <Card variant="outlined">
            <form method='post' onSubmit={(e) => handleSubmit(e)}>
              <CardContent>
                <TextField
                  name='fullName'
                  sx={textFieldStyle}
                  placeholder={'First and Last name'}
                  value={inputState?.fullName}
                  onChange={(e) => handleOnChange(e)}
                  required
                />
                <Divider />
                <TextField
                  name='email'
                  sx={textFieldStyle}
                  placeholder={'Email'}
                  value={inputState?.email}
                  onChange={(e) => handleOnChange(e)}
                  required
                />
                <Divider />
                <TextField
                  name='phonenumber'
                  sx={textFieldStyle}
                  placeholder={'Phone number'}
                  value={inputState?.phonenumber}
                  onChange={(e) => handleOnChange(e)}
                  required
                />
                <Divider />
              </CardContent>
              <CardActions>
                <ButtonGroup
                  disableElevation
                  variant="contained"
                  aria-label="Disabled elevation buttons"
                >
                  <Button type='submit' size='large'>Save changes</Button>
                  <Button type='click' size='large' onClick={(CloseEditComponent)}>Close</Button>
                </ButtonGroup>
              </CardActions>
            </form>
          </Card>
        </Box>
      </Paper>
    </div >
  )
}

export default EditUser