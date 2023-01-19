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