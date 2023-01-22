const baseUrl = 'https://localhost:7038/api/Doctor';

export const getAll = async () => {
    const res = await fetch(`${baseUrl}/GetAll`, {
        method: 'GET',
        headers: {
            'Content-Type': 'application/json',
        }
    });

    return await res.json();
}

export const getById = async (doctorId) => {
    const res = await fetch(`${baseUrl}/GetById/${doctorId}`, {
        method: 'GET',
        headers: {
            'Content-Type': 'application/json',
        }
    });
    
    return await res.json();
}

export const getDoctorSchedule = async (doctorId) => {
    const res = await fetch(`${baseUrl}/GetScheduleByDoctorId/${doctorId}`, {
        method: 'GET',
        headers: {
            'Content-Type': 'application/json',
        }
    });
    
    return await res.json();
}

export const updateDoctorSchedule = async (bodyData, accessToken) => {
    debugger;
    const res = await fetch(`${baseUrl}/UpdateSchedule/`, {
        method: 'PUT',
        headers: {
            'Content-Type': 'application/json',
        },
        'Authorization': `Bearer ${accessToken}`,
        body: JSON.stringify(bodyData),
    });

    return await res.json();
}