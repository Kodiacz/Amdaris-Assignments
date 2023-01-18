import Button from '@mui/material/Button';
import Modal from '@mui/material/Modal';
import { useState } from 'react';
import Login from './Login';


function LoginModal({
    buttonText
}) {
    const [open, setOpen] = useState(false);
    const handleOpen = () => setOpen(true);
    const handleClose = () => setOpen(false);
    
    return (
        <div>
            <a onClick={handleOpen}>{buttonText ?? ""}</a>
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