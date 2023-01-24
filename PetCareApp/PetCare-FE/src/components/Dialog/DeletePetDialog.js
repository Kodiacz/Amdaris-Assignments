import { forwardRef, useCallback, useState } from 'react';
import Slide from '@mui/material/Slide';
import Button from '@mui/material/Button';
import Dialog from '@mui/material/Dialog';
import DialogTitle from '@mui/material/DialogTitle';
import DialogActions from '@mui/material/DialogActions';
import DialogContent from '@mui/material/DialogContent';
import DialogContentText from '@mui/material/DialogContentText';

const Transition = forwardRef(function Transition(props, ref) {
  return <Slide direction="up" ref={ref} {...props} />;
});

export default function DeletePetDialog({
  handleDeletePet,
}) {
  const [open, setOpen] = useState(false);
  const [buttonColor, setButtonColor] = useState('blue');

  const handleClickOpen = () => {
    setOpen(true);
  };

  const handleDisagree = () => {
    setOpen(false);
  };

  const handleAgree = useCallback(
    () => {
      handleDeletePet();
      setOpen(false);
    },
    [handleDeletePet],
  );


  return (
    <div>
      <Button
        variant="outlined" size='large'
        style={{ color: `${buttonColor}` }}
        onMouseOver={() => setButtonColor('red')}
        onMouseLeave={() => setButtonColor('blue')}
        onClick={handleClickOpen}>
        Delete Pet
      </Button>
      <Dialog
        open={open}
        TransitionComponent={Transition}
        keepMounted
        onClose={handleDisagree}
        aria-describedby="alert-dialog-slide-description"
      >
        <DialogTitle>Are you sure you want to delete this pet</DialogTitle>
        <DialogContent>
        </DialogContent>
        <DialogActions>
          <Button onClick={handleDisagree}>Disagree</Button>
          <Button onClick={handleAgree}>Agree</Button>
        </DialogActions>
      </Dialog>
    </div>
  );
}