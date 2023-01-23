import './MyAppointments.css'
import Paper from '@mui/material/Paper';
import Table from '@mui/material/Table';
import TableRow from '@mui/material/TableRow';
import { styled } from '@mui/material/styles';
import TableBody from '@mui/material/TableBody';
import TableHead from '@mui/material/TableHead';
import { useContext, useEffect, useState } from 'react';
import { AuthContext } from '../../contexts/AuthContext';
import TableContainer from '@mui/material/TableContainer';
import * as ownerServcies from '../../services/ownerServcies';
import TableCell, { tableCellClasses } from '@mui/material/TableCell';

const StyledTableCell = styled(TableCell)(({ theme }) => ({
    [`&.${tableCellClasses.head}`]: {
        backgroundColor: theme.palette.common.black,
        color: theme.palette.common.white,
    },
    [`&.${tableCellClasses.body}`]: {
        fontSize: 14,
    },
}));

const StyledTableRow = styled(TableRow)(({ theme }) => ({
    '&:nth-of-type(odd)': {
        backgroundColor: theme.palette.action.hover,
    },
    // hide last border
    '&:last-child td, &:last-child th': {
        border: 0,
    },
}));

export default function MyAppointments() {
    const [appointents, setAppointments] = useState([]);
    const { user } = useContext(AuthContext);

    useEffect(() => {
        fetchData(user.userId, user.accessToken)
    }, []);


    const fetchData = async (userId, accessToken) => {
        const getOwnerAppointmentsResult = await ownerServcies.getOwnerAppointments(userId, accessToken);

        setAppointments(state => {
            return [
                ...state,
                ...getOwnerAppointmentsResult,
            ]
        })
    }
    console.log(appointents)
    return (
        <div className='my-appointments-table'>
            <TableContainer component={Paper}>
                <Table sx={{ minWidth: 550 }} aria-label="customized table">
                    <TableHead>
                        <TableRow>
                            <StyledTableCell>Pet Name</StyledTableCell>
                            <StyledTableCell align="left">Doctor Name</StyledTableCell>
                            <StyledTableCell align="left">Reason</StyledTableCell>
                            <StyledTableCell align="left">Date</StyledTableCell>
                        </TableRow>
                    </TableHead>
                    <TableBody>
                        {appointents?.map(a => (
                            <StyledTableRow key={a.name}>
                                <StyledTableCell component="th" scope="row">{a.petName}</StyledTableCell>
                                <StyledTableCell align="left">{a.doctorFullName}</StyledTableCell>
                                <StyledTableCell align="left">{a.reasonForAppointment}</StyledTableCell>
                                <StyledTableCell align="left">{a.dateOfAppointment.slice(0, 10)}</StyledTableCell>
                            </StyledTableRow>
                        ))}
                    </TableBody>
                </Table>
            </TableContainer>
        </div>
    );
}