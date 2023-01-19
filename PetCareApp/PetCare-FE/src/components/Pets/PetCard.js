import * as React from 'react';
import Card from '@mui/material/Card';
import CardActions from '@mui/material/CardActions';
import CardContent from '@mui/material/CardContent';
import CardMedia from '@mui/material/CardMedia';
import Button from '@mui/material/Button';
import Typography from '@mui/material/Typography';
import defaultPicture from '../../default-images/default-image.jpg'
import { Divider, List, ListItem, ListItemText } from '@mui/material';
import { configureImagePath } from '../../Utils/configureImagePath.js';

export default function PetCard({
    pet
}) {
    const imagePath = configureImagePath(pet.imageFilePath)
    debugger;
    const style = {
        width: '100%',
        maxWidth: 360,
        bgcolor: 'background.paper',
    };

    return (
        <div className='pet-card'>
            <Card sx={{ maxWidth: 345 }}>
                <img
                    alt='Pet'
                    src={imagePath}
                    style={{ height: 220, width: 345 }}
                />
                {/* <CardMedia
                    sx={{}}
                    image={imagePath}
                    title="Pet"
                /> */}
                <CardContent>
                    <Typography gutterBottom variant="h5" component="div">
                        <List sx={style} component="nav" aria-label="mailbox folders">
                            <ListItem>
                                <h4>Name: {pet.name}</h4>
                            </ListItem>
                            <Divider />
                            <ListItem>
                                <h4>Type: {pet.type}</h4>
                            </ListItem>
                            <Divider />
                            <ListItem>
                                <h4>Breed: {pet.breed}</h4>
                            </ListItem>
                            <Divider />
                        </List>
                    </Typography>
                </CardContent>
                <CardActions>
                    <Button size="small">Check Status</Button>
                    <Button size="small">Edit</Button>
                </CardActions>
            </Card>
        </div>
    );
}