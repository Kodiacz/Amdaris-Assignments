import * as React from 'react';
import PropTypes from 'prop-types';
import LinearProgress from '@mui/material/LinearProgress';
import Typography from '@mui/material/Typography';
import Box from '@mui/material/Box';
import { useState } from 'react';
import { useEffect } from 'react';

const stepValues = {
    1: 'choose a date and click OK',
    2: 'select your pet for appointment',
    3: 'type a reason for the appointment',
    4: 'click on Make Appointment button'
}

function LinearProgressWithLabel(props) {
  return (
    <Box sx={{ display: 'flex', alignItems: 'center' }}>
      <Box sx={{ width: '100%', mr: 1 }}>
        <LinearProgress variant="determinate" {...props} />
      </Box>
      <Box sx={{ minWidth: 35 }}>
        <Typography variant="body2" color="text.secondary">{`${Math.round(
          props.value,
        )}%`}</Typography>
      </Box>
    </Box>
  );
}

LinearProgressWithLabel.propTypes = {
  /**
   * The value of the progress indicator for the determinate and buffer variants.
   * Value between 0 and 100.
   */
  value: PropTypes.number.isRequired,
};

export default function LinearWithValueLabel({
    nextStep,
}) {
  const [progress, setProgress] = useState(0);
  const [steps, setSteps] = useState(1);

  useEffect(() => {
    const timer = setInterval(() => {
      setProgress((prevProgress) => (prevProgress >= 99 ? 100 : prevProgress + 33));
    }, 800);
    return () => {
      clearInterval(timer);
    };
  }, []);

  return (
    <Box sx={{ width: '100%' }}>
        <label style={{color: 'black', fontSize: '25px', marginBottom: '20px'}}>steps: {stepValues[steps]}</label>
      <LinearProgressWithLabel value={progress} />
    </Box>
  );
}