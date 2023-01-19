import Login from '../../components/Login/Login';
import { useState } from 'react';
import Modal from '@mui/material/Modal';
import Button from '@mui/material/Button';
import LoginIcon from '@mui/icons-material/Login';


function LoginModal({
    buttonText
}) {
    const [open, setOpen] = useState(false);
    const handleOpen = () => setOpen(true);
    const handleClose = () => setOpen(false);
    
    return (
        <div>
            <a onClick={handleOpen}>Sign In <LoginIcon/></a>
            <Modal
                open={open}
                onClose={handleClose}
                aria-labelledby="modal-modal-title"
                aria-describedby="modal-modal-description"
            >
                <Login closeModal={handleClose} />
            </Modal>
        </div>
    );
}

export default LoginModal