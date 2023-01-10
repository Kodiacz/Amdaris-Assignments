const DoctorCard = ({
  doctor
}) => {
  
  function configureImagePath(path) {
    path = path.replace(`\\\\`, `\\`);
    let index = path.indexOf(`img`);
    path = path.slice(index, path.length + 1)
    return path
  }

  const imagePath =configureImagePath(doctor.imageFilePath)
  
  return (
    <div className="row-doctor-card-container">
      <div className="col-doctor-card-container">
        <div className="doctor-card-container">
          <img src={imagePath} alt="Avatar" style={{ width: '280px', height: '280px' }} />
            <h4 className="doctos-full-name"><b>{doctor.firstName} {doctor.lastName}</b></h4>
            <button className="doctor-more-info-btn" type="button">Read more</button>
        </div>
      </div>
    </div>
  );
}

export default DoctorCard;