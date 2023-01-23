const baseUrl = 'https://localhost:7038/api/Owner';

export const updateOwnerAppointments = async (bodyData, accessToken) => {
    debugger;
    const res = await fetch(`${baseUrl}/AddAppointmentToOwnerById`, {
        method: 'POST',
        headers: {
            'content-type': 'application/json',
            'Authorization': `Bearer ${accessToken}`,
        },
        body: JSON.stringify(bodyData),
    })

    if (res.ok) {
        return await 'appointment added';
    } else {
        return await res.status
    }
}

export const getOwnerAppointments = async (ownerId, accessToken) => {
    debugger;
    const res = await fetch(`${baseUrl}/GetOwnerAppointments/${ownerId}`, {
        method: 'GET',
        headers: {
            'content-type': 'application/json',
            'Authorization': `Bearer ${accessToken}`,
        },
    });

    if (res.ok) {
        return await res.json();
    } else {
        throw res.statusText;
    };
}