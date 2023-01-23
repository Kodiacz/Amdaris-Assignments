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
    const res = await fetch(`${baseUrl}/UpdateSchedule`, {
        method: 'PUT',
        headers: {
            'Content-Type': 'application/json',
            'Authorization': `Bearer ${accessToken}`,
        },
        body: JSON.stringify(bodyData),
    });

    if (res.ok) {
        return 'schedule changed'
    } else {
        return res.status
    }
}

export const addPatientToDoctor = async (bodyData, accessToken) => {
    debugger
    const res = await fetch(`${baseUrl}/AddPatient`, {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json',
            'Authorization': `Bearer ${accessToken}`,
        },
        body: JSON.stringify(bodyData),
    });

    if (res.ok) {
        return 'patient added to docotrs patients list'
    } else {
        return res.status
    }
}