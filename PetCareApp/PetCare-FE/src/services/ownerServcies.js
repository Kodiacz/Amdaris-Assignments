const baseUrl = 'https://localhost:7038/api/Owner';

export const getOwnerById = async (ownerId, accessToken) => {
    
    const res = await fetch(`${baseUrl}/GetById/${ownerId}`, {
        method: 'GET',
        headers: {
            'content-type': 'application/json',
            'Authorization': `Bearer ${accessToken}`,
        },
    })

    if (res.ok) {
        return await res.json();
    } else {
        return await res.status
    }
}

export const updateOwnerAppointments = async (bodyData, accessToken) => {
    
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

export const uploadOwnerPicture = async (bodyData, accessToken) => {
    const response = await fetch(`${baseUrl}/UploadOwnerPicture`, {
        method: 'POST',
        headers: {
            'Authorization': `Bearer ${accessToken}`,
        },
        body: bodyData,
    });

    if (response.ok) {
        return await response.json();
    } else {
        throw response.statusText;
    };
}

export const partialUpdate = async (ownerId, bodyData, accessToken) => {
    debugger
    const response = await fetch(`${baseUrl}/PartialUpdate/${ownerId}`, {
        method: 'PATCH',
        headers: {
            'content-type': 'application/json',
            'Authorization': `Bearer ${accessToken}`,
        },
        body: JSON.stringify(bodyData),
    });
    
    return await response.text();
}