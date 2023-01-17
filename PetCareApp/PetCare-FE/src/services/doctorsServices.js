// import { useAxiosGet } from "../../Utils/useFetch";

// function GetAllDoctors() {
//     return useAxiosGet('https://localhost:7038/api/Doctor/GetAll');
// }

// function GetDoctor(doctorId) {
//     return useAxiosGet(`https://localhost:7038/api/Doctor/GetById/${doctorId}`);
// }

// function GetDoctorSchedule(doctorId) {
//     return useAxiosGet(`https://localhost:7038/api/Doctor/GetScheduleByDoctorId/${doctorId}`);
// }

// export { 
//     GetAllDoctors, 
//     GetDoctor,
//     GetDoctorSchedule, 
// };

const baseUrl = 'https://localhost:7038/';

export const getAll = async () => {
    const res = await fetch(`${baseUrl}api/Doctor/GetAll`, {
        method: 'GET',
        headers: {
            'Content-Type': 'application/json',
        }
    });

    return await res.json();
}

export const getById = async (doctorId) => {
    const res = await fetch(`${baseUrl}api/Doctor/GetById/${doctorId}`, {
        method: 'GET',
        headers: {
            'Content-Type': 'application/json',
        }
    });
    
    return await res.json();
}

export const getDoctorSchedule = async (doctorId) => {
    const res = await fetch(`${baseUrl}api/Doctor/GetScheduleByDoctorId/${doctorId}`, {
        method: 'GET',
        headers: {
            'Content-Type': 'application/json',
        }
    });
    
    return await res.json();
}