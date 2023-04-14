const baseUrl = 'https://localhost:7038/api/Pet';

const returnFetchedResult = async (response) => {
    if (response.ok) {
        return await response.json();
    } else {
        throw Error(`${response.status} ${response.statusText}`)
    }
}

export const getAllPet = async (userId, accessToken) => {
    const response = await fetch(`https://localhost:7038/api/Owner/GetAllOwnerPets/${userId}`, {
        method: 'GET',
        headers: {
            'content-type': 'application/json',
            'Authorization': `Bearer ${accessToken}`,
        },
    });

    return await returnFetchedResult(response);
}

export const getPetById = async (petId, accessToken) => {
    const response = await fetch(`${baseUrl}/GetById/${petId}`, {
        method: 'GET',
        headers: {
            'content-type': 'application/json',
            'Authorization': `Bearer ${accessToken}`,
        },
    });

    return await returnFetchedResult(response);
}

export const createPet = async (bodyData, accessToken) => {
    const response = await fetch(`${baseUrl}/Create`, {
        method: 'POST',
        headers: {
            'content-type': 'application/json',
            'Authorization': `Bearer ${accessToken}`,
        },
        body: JSON.stringify(bodyData),
    });

    return await returnFetchedResult(response)
}

export const uploadPetPicture = async (bodyData, accessToken) => {
    debugger
    const response = await fetch(`${baseUrl}/UploadPetPicture`, {
        method: 'POST',
        headers: {
            'Authorization': `Bearer ${accessToken}`,
        },
        body: bodyData,
    });

   return await returnFetchedResult(response)
}

export const updatePet = async (petId, bodyData, accessToken) => {
    
    const response = await fetch(`${baseUrl}/Update/${petId}`, {
        method: 'PUT',
        headers: {
            'content-type': 'application/json',
            'Authorization': `Bearer ${accessToken}`,
        },
        body: JSON.stringify(bodyData),
    });
    
    return await response.text();
}

export const partialUpdate = async (petId, bodyData, accessToken) => {
    
    const response = await fetch(`${baseUrl}/PartialUpdate/${petId}`, {
        method: 'PATCH',
        headers: {
            'content-type': 'application/json',
            'Authorization': `Bearer ${accessToken}`,
        },
        body: JSON.stringify(bodyData),
    });
    
    return await response.text();
}

export const deletePet = async (petId, accessToken) => {
    const response = await fetch(`${baseUrl}/Delete/${petId}`, {
        method: 'DELETE',
        headers: {
            'Content-Type': 'application/json',
            'Authorization': `Bearer ${accessToken}`,
        },  
    });

    return await response.text();
}