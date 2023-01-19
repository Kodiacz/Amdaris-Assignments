export const getAllPet = async (userId, accessToken) => {
    const response = await fetch(`https://localhost:7038/api/Owner/GetAllOwnerPets/${userId}`, {
        method: 'GET',
        headers: {
            'content-type': 'application/json',
            'Authorization': `Bearer ${accessToken}`,
        },
    });
    
    if (response.ok) {
        return await response.json();
    } else {
        throw Error(`${response.status} ${response.statusText}`)
    }
}