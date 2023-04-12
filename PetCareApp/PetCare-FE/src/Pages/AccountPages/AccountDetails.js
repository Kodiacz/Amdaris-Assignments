import './AccountDetails.css'
import { useCallback, useContext, useEffect, useRef, useState } from 'react';
import Box from '@mui/material/Box';
import Card from '@mui/material/Card';
import { ButtonGroup, Divider, Paper, TextField } from '@mui/material';
import Button from '@mui/material/Button';
import Typography from '@mui/material/Typography';
import CardActions from '@mui/material/CardActions';
import CardContent from '@mui/material/CardContent';
import * as ownerServices from '../../services/ownerServcies'
import { AuthContext } from '../../contexts/AuthContext'
import { Link, Navigate, Outlet, useNavigate } from 'react-router-dom';

function changeStateValue(callBack, value) {
    callBack(state => value);
}

const tipografyStyle = {
    padding: '10px 0'
}

export default function AccountDetails() {
    const [owner, setOwner] = useState({})
    const [reFetch, setReFetch] = useState(false)
    const { user, setProfilePicture, profilePicture } = useContext(AuthContext)
    const navigateToEdid = useNavigate();

    const getOwner = async (ownerId, accessToken) => {
        const getOwnerResult = await ownerServices.getOwnerById(ownerId, accessToken);

        setOwner(state => {
            return {
                ...getOwnerResult
            }
        })
    }

    useEffect(() => {
        getOwner(user.userId, user.accessToken);
    }, [reFetch])

    useEffect(() => {
        if (owner.profileImageFilePath) {
            changeStateValue(setProfilePicture, owner.profileImageFilePath)
        }
    }, [owner])

    const handleUpload = async (e) => {
        ;
        e.preventDefault();
        const formData = new FormData(e.target);
        const uploadPicture = formData.get('uploadPicture');

        try {
            const uploadFileData = new FormData();
            uploadFileData.append('file', uploadPicture);
            uploadFileData.append('entityId', owner.id);

            if (uploadPicture.name) {
                ownerServices.uploadOwnerPicture(uploadFileData, user.accessToken);
            }
        } catch (err) {
            console.log(err);
        }
    }

    const navigateToEdit = () => {

    }

    return (
        <div className='account-details-container'>
            <Paper elevation={24}>
                <Box sx={{ minWidth: 275 }}>
                    <Card variant="outlined">
                        <CardContent>
                            <Typography sx={tipografyStyle} variant='h5'>
                                First and Last name:
                            </Typography>
                            <Typography variant='h5'>
                                {`${owner.firstName} ${owner.lastName}`}
                            </Typography>
                            <Divider />
                            <Typography sx={tipografyStyle} variant='h5'>
                                Email:
                            </Typography>
                            <Typography variant='h6'>
                                {`${owner.email}`}
                            </Typography>
                            <Divider />
                            <Typography sx={tipografyStyle} variant='h5'>
                                Phone number:
                            </Typography>
                            <Typography variant='h5'>
                                {`${owner.phonenumber}`}
                            </Typography>
                            <Divider />
                        </CardContent>
                        <CardActions>
                            <ButtonGroup
                                disableElevation
                                variant="contained"
                                aria-label="Disabled elevation buttons"
                            >
                                <form method='post' onSubmit={(e) => handleUpload(e)}>
                                    <TextField
                                        type='file'
                                        name='uploadPicture'
                                    />
                                    <Button type='submit' size='large'>Upload</Button>
                                </form>
                            </ButtonGroup>
                        </CardActions>
                    </Card>
                    <Button variant="contained" color="primary" onClick={() => {
                        navigateToEdid('/my-account/account-details/edit-account')
                    }}>
                        Edit Account
                    </Button>
                </Box>
            </Paper>
            <div className='edit-user-outlet-div'>
                <Outlet context={{owner, setReFetch}}/>
            </div>
        </div>
    );
}