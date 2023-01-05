function Doctor({
    doctor
}) {
    return (
        <>
            <tr>
                <td>{doctor.firstName} {doctor.lastName}</td>
                <td>{doctor.age}</td>
                <td>{doctor.phonenumber}</td>
                <td>{doctor.jobDescription}</td>
                <td>{doctor.isAvailable ? 'Yes' : 'No'} </td>
            </tr>
        </>
    )
}

export default Doctor;