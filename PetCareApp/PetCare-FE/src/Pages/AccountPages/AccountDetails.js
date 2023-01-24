import './AccountDetails.css'
import { useContext, useEffect, useState } from 'react';
import Box from '@mui/material/Box';
import Card from '@mui/material/Card';
import { ButtonGroup, Divider, TextField } from '@mui/material';
import Button from '@mui/material/Button';
import Typography from '@mui/material/Typography';
import CardActions from '@mui/material/CardActions';
import CardContent from '@mui/material/CardContent';
import * as ownerServices from '../../services/ownerServcies'
import { AuthContext } from '../../contexts/AuthContext'

export default function AccountDetails() {
    const [owner, setOwner] = useState({})
    const { user, setProfilePicture } = useContext(AuthContext)

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
        setProfilePicture(state => {
            return owner.profileImageFilePath
        });
    }, [])

    const handleUpload = async (e) => {
        e.preventDefault();

        const formData = new FormData(e.target);
        const uploadPicture = formData.get("uploadPicture");

        try {
            const uploadFileData = new FormData();
            uploadFileData.append('file', uploadPicture);
            uploadFileData.append('entityId', owner.id);

            if (uploadPicture.name) {
                const resultUploadOwnerPicture = await ownerServices.uploadOwnerPicture(uploadFileData, user.accessToken);
            }
        } catch (err) {
            console.log(err);
        }
    }
    console.log(owner);
    return (
        <div className='account-details-container'>
            <Box sx={{ minWidth: 275 }}>
                <Card variant="outlined">
                    <CardContent>
                        <Typography variant='h5'>
                            {`First and Last name: ${owner.firstName} ${owner.lastName}`}
                        </Typography>
                        <Divider />
                        <Typography variant='h5'>
                            {`email: ${owner.email}`}
                        </Typography>
                        <Divider />
                        <Typography variant='h5'>
                            {`${owner.phonenumber}`}
                        </Typography>
                        <Divider />
                    </CardContent>
                    <CardActions>
                        {/* <Button variant='outlined' size="large">Change Profile Picture</Button> */}
                        <form method='post' onSubmit={(e) => handleUpload(e)}>
                            <ButtonGroup
                                disableElevation
                                variant="contained"
                                aria-label="Disabled elevation buttons"
                            >
                                <TextField
                                    type='file'
                                    name='uploadPicture'
                                />
                                <Button type='submit'>Upload</Button>
                            </ButtonGroup>
                        </form>
                    </CardActions>
                </Card>
            </Box>
        </div>
    );
}