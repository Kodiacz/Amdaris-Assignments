const baseUrl = 'https://localhost:7038/api/Owner';

export const updateOwnerAppointments = async (bodyData, accessToken) => {
    debugger;
    const res = await fetch(`${baseUrl}/AddAppointmentToOwnerById`, {
        method: 'POST',
        header: {
            'Content-Type': 'application/json',
        },
        'Authorization': `Bearer ${accessToken}`,
        body: JSON.stringify(bodyData),
    })

    return await res.json();
}

