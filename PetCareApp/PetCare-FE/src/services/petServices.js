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

export const createPet = async (bodyData, accessToken) => {
    const response = await fetch(`https://localhost:7038/api/Pet/Create`, {
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
    const response = await fetch(`https://localhost:7038/api/Pet/UploadPetPicture`, {
        method: 'POST',
        headers: {
            'Authorization': `Bearer ${accessToken}`,
        },
        body: bodyData,
    });

   return await returnFetchedResult(response)
}