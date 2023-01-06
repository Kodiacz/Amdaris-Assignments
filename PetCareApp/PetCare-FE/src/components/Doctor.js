function Doctor({
    doctor,
    tdStyle,
}) {
    return (
        <>
            <tr>
                <td className={tdStyle}>{doctor.firstName} {doctor.lastName}</td>
                <td className={tdStyle}>{doctor.phonenumber}</td>
                <td className={tdStyle}>{doctor.jobDescription}</td>
                <td className={tdStyle}>{doctor.isAvailable ? 'Yes' : 'No'} </td>
            </tr>
        </>
    )
}

export default Doctor;