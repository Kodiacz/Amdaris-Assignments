import { IconButton } from '@mui/material';
import Collapse from '@mui/material/Collapse';
import CloseIcon from '@mui/icons-material/Close';
import Alert from '@mui/material/Alert';
import AlertTitle from '@mui/material/AlertTitle';
import Stack from '@mui/material/Stack';
import { useState } from 'react';

export default function Alerts({
    openValue,
    severityValue,
    titleValue,
    titleType,
    closeAlert,
}) {
    return (
        <Stack sx={{ width: '100%', ['margin-top']: '20px'}} spacing={2}>
            <Collapse in={openValue}>
                <Alert
                    action={
                        <IconButton
                            aria-label="close"
                            color="inherit"
                            size="small"
                            onClick={() => {
                                closeAlert(state => {
                                    return {
                                        ...state,
                                        openValue: false,
                                    }
                                });
                            }}
                        >
                            <CloseIcon fontSize="inherit" />
                        </IconButton>
                    }
                    severity={severityValue}
                >
                    <AlertTitle>{titleType}</AlertTitle>
                    {titleValue}
                </Alert>
            </Collapse>
        </Stack>
    );
}