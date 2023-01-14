import { useFetch } from "../../Utils/useFetch.js";

function GetAllDoctors() {
    return useFetch('https://localhost:7038/api/Doctor/GetAll');
}

function GetDoctor(doctorId) {
    return useFetch(`https://localhost:7038/api/Doctor/GetById/${doctorId}`);
}

function GetDoctorSchedule(doctorId) {
    return useFetch(`https://localhost:7038/api/Doctor/GetScheduleByDoctorId/${doctorId}`);
}

export { 
    GetAllDoctors, 
    GetDoctor,
    GetDoctorSchedule, 
};