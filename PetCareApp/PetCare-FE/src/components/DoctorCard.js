// function Doctor({
//     doctor,
// }) {
//     return (
//         <>
//             <tr>
//                 <td>{doctor.firstName} {doctor.lastName}</td>
//                 <td>{doctor.phonenumber}</td>
//                 <td>{doctor.jobDescription}</td>
//                 <td>{doctor.isAvailable ? 'Yes' : 'No'} </td>
//             </tr>
//         </>
//     )
// }

// export default Doctor;

import * as React from 'react';
import Card from '@mui/material/Card';
import CardContent from '@mui/material/CardContent';
import CardMedia from '@mui/material/CardMedia';
import Typography from '@mui/material/Typography';
import { Button, CardActionArea, CardActions } from '@mui/material';

function DoctorCard({
    doctor
}) {
  return (
    <Card sx={{ maxWidth: 345 }}>
      <CardActionArea>
        <CardMedia
          component="img"
          height="140"
          image="/static/images/cards/contemplative-reptile.jpg"
          alt="green iguana"
        />
        <CardContent>
          <Typography gutterBottom variant="h5" component="div">
            {doctor.firstName} {doctor.lastName}
          </Typography>
          <Typography variant="body2" color="text.secondary">
            Lizards are a widespread group of squamate reptiles, with over 6,000
            species, ranging across all continents except Antarctica
          </Typography>
        </CardContent>
      </CardActionArea>
      <CardActions>
        <Button size="small" color="primary">
          Share
        </Button>
      </CardActions>
    </Card>
  );
}

export default DoctorCard;