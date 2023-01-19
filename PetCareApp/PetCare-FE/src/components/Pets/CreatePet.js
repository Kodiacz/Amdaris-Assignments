import './CreatePet.css'
import { Controller, useFormContext } from 'react-hook-form'
import Box from '@mui/material/Box';
import TextField from '@mui/material/TextField';
import { Button, Divider } from '@mui/material';
import { useState } from 'react';

export default function CreatePet() {
  const [invalidField, setInvalidField] = useState({
    name: false,
    age: false,
    type: false,
    breed: false,
  })

  const inputFieldStyle = {
    margin: '0.5rem',
  }

  const constants = {
    name: {
      maxLenght: 35,
      errorMessage: 'name should be less then 35 charackters'
    },
    age: {
      minValue: 1,
      errorMessage: 'age should be non negative number and bigger then 0'
    },
    type: {
      maxLenght: 20,
      errorMessage: 'type should be less then 20 charackter'
    },
    breed: {
      maxLenght: 20,
      errorMessage: 'type should be less then 20 charackter'
    },
  }

  const onFormSubmit = (e) => {
    console.log(e.target);
    e.preventDefault();

    const formData = new FormData(e.target)
    let {
      name,
      age,
      type,
      breed,
      uploadPicture,
    } = Object.fromEntries(formData);

    e.target.reset();
  }

  const onChange = (e) => {
    if (e.target.value.length > constants[e.target.name].maxLenght || (e.target.name === 'age' && e.target.value < 1)) {
      setInvalidField((state) => {
        return {
          ...state,
          [e.target.name]: true
        }
      });
      console.log(invalidField[e.target.name])
    } else {
      setInvalidField((state) => {
        return {
          ...state,
          [e.target.name]: false
        }
      });
    }
  }

  return (
    <div className='create-pet-form-div'>
      <h3>Add your pet</h3>
      <div className='form-container'>
        {/* <Box
        component="form"
        sx={{
          '& > :not(style)': { m: 1, width: '25ch' },
        }}
        noValidate
        autoComplete="off"
      > */}
        <form method='post' onSubmit={(e) => onFormSubmit(e)}>
          <div className='input-container'>

            <span
              hidden={
                invalidField?.name
                  ? false
                  : true
              }
              style={{ color: 'red', 'padding-bottom': '10px' }}>
              {constants.name.errorMessage}
            </span>
            <TextField
              sx={inputFieldStyle}
              id="outlined-basic"
              label="Pet Name"
              variant="outlined"
              autoFocus={true}
              name='name'
              onChange={(e) => onChange(e)}
              error={invalidField?.name}
              required
            />

            <span
              hidden={
                invalidField?.age
                  ? false
                  : true
              }
              style={{ color: 'red', 'padding-bottom': '10px' }}>
              {constants.age.errorMessage}
            </span>

            <Divider size={10} />

            <TextField
              sx={inputFieldStyle}
              label="Age"
              variant="outlined"
              name='age'
              type='number'
              error={invalidField?.age}
              onChange={(e) => onChange(e)}
              required
            />

            <Divider size={10} />

            <span
              hidden={
                invalidField?.type
                  ? false
                  : true
              }
              style={{ color: 'red', 'padding-bottom': '10px' }}>
              {constants.type.errorMessage}
            </span>
            <TextField
              sx={inputFieldStyle}
              label="Type"
              variant="outlined"
              name='type'
              error={invalidField?.type}
              onChange={(e) => onChange(e)}
              required
            />

            <Divider size={10} />

            <span
              hidden={
                invalidField?.breed
                  ? false
                  : true
              }
              style={{ color: 'red', 'padding-bottom': '10px' }}>
              {constants.breed.errorMessage}
            </span>
            <TextField
              sx={inputFieldStyle}
              label="Breed"
              variant="outlined"
              name='breed'
              error={invalidField?.breed}
              onChange={(e) => onChange(e)}
              required
            />

            <Divider size={10} />

            <TextField
              sx={inputFieldStyle}
              type='file'
              name='uploadPicture'
              required
            />

            <div className='button-container'>
            <Button
              variant="outlined"
              type='submit'
              fullWidth
              size='large'
              disabled={Object.values(invalidField).some(x => x)}
            >
              Submit
            </Button>
            </div>
          </div>
        </form>
      </div>
      {/* </Box> */}
    </div >
  );
}