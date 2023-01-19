import { CircularProgress, setRef } from "@mui/material";
import { useParams } from "react-router-dom";
import * as doctorsServices from "../../services/doctorsServices";
import DoctorDetails from "../../Pages/DoctorPages/DoctorDetails";
import "../../Pages/DoctorPages/DoctorDetails.css"
import { useState, useEffect, useCallback } from "react";

const Doctor = () => {

    const params = useParams();
    const [doctor, setDoctor] = useState({});
    const [isLoading, setIsLoading] = useState(true);
    const [error, setErorr] = useState(null);

    const fetchData = useCallback(async () => {
        const data = await doctorsServices.getById(params.id); 
        setDoctor(data);
        setIsLoading(false);
    }, []);

    useEffect(() => {
        console.log("rerere")
        fetchData()
    }, [])

    return (
        <div className="doctors-details-container">
            {isLoading
                ? <div className="doctor-load">
                    <CircularProgress color='success' size={120} thickness={1} />
                </div>
                : <DoctorDetails doctor={doctor} />
            }
        </div>
    )
}

export default Doctor;