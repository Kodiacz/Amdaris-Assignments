import Card from '@mui/material/Card';
import Button from '@mui/material/Button';
import { useNavigate } from 'react-router-dom';
import Typography from '@mui/material/Typography';
import CardActions from '@mui/material/CardActions';
import CardContent from '@mui/material/CardContent';
import * as petServices from '../../services/petServices'
import defaultPicture from '../../default-images/default-image.jpg'
import { Divider, List, ListItem, ListItemText } from '@mui/material';
import { configureImagePath } from '../../Utils/configureImagePath.js';
import { AuthContext } from '../../contexts/AuthContext'
import { useCallback, useContext } from 'react';
import DeletePetDialog from '../Dialog/DeletePetDialog';

export default function PetCard({
    pet,
    renderButton,
    setCountOfPets,
}) {
    const {user} = useContext(AuthContext);
    const navigate = useNavigate();
    const navigateToEdit = () => {
        navigate(`/my-account/edit-pet/${pet.id}`)
    };
    
    const imagePath = configureImagePath(pet.imageFilePath)
    
    const style = {
        width: '100%',
        maxWidth: 360,
        bgcolor: 'background.paper',
    };

    const handleDeletePet = useCallback(
      async () => {
          const deletePetResult = await petServices.deletePet(pet.id, user.accessToken);
          debugger;
          setCountOfPets(state => state - 1);
      }, [setCountOfPets])
    
    
    
    return (
        <div className='pet-card'>
            <Card sx={{ maxWidth: 345 }}>
                <img
                    alt='Pet'
                    src={imagePath ?? defaultPicture}
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
                    {/* { renderButton ? <Button size="large" onClick={handleDeletePet}>Delete Pet</Button> : '' } */}
                    { renderButton ? <DeletePetDialog handleDeletePet={handleDeletePet}></DeletePetDialog>: '' }
                    { renderButton ? <Button size="large" onClick={navigateToEdit}>Edit</Button> : '' }
                </CardActions>
            </Card>
        </div>
    );
}