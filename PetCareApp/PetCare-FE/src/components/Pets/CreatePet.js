import './CreatePet.css'
import * as React from 'react';
import Box from '@mui/material/Box';
import TextField from '@mui/material/TextField';
import { Button } from '@mui/material';

export default function BasicTextFields() {
  const onFormSubmit = (e) => {
    console.log(e);
    e.preventDefault();

    const formData = new FormData(e.target)

    console.log(formData);
  }

  return (
    <form method='post' onSubmit={(e) => onFormSubmit(e)}>
      <Box
        component="form"
        sx={{
          '& > :not(style)': { m: 1, width: '25ch' },
        }}
        noValidate
        autoComplete="off"
      >
        <div className='input-container'>
          <TextField className='input-field' id="outlined-basic" label="Pet Name" variant="outlined" autoFocus={true} name='pet-name' />
          <TextField className='input-field' id="outlined-basic" label="Outlined" variant="outlined" />
          <TextField className='input-field' id="outlined-basic" label="Outlined" variant="outlined" />
        </div>
      </Box>
      <div className='button-container'>
        <Button variant="outlined" type='submit'>Submit</Button>
      </div>
    </form>
  );
}