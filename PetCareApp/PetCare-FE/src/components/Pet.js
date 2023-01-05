function Pet({
    pet
}) {
    return (
        <>
            <tr>
                <td>{pet.name}</td>
                <td>{pet.age}</td>
                <td>{pet.ownerFullName}</td>
                <td>{pet.type} </td>
                <td>{pet.breed}</td>
            </tr>
        </>
    )
}

export default Pet;