import { Link, Outlet, useParams } from "react-router-dom";
import { configureImagePath } from "../../Utils/configureImagePath";

const DoctorCard = ({
  doctor
}) => {
  const imagePath = configureImagePath(doctor.imageFilePath)
  console.log(imagePath)
  
  return (
    <div className="row-doctor-card-container">
      <div className="col-doctor-card-container">
        <div className="doctor-card-container">
          <img src={imagePath} alt="Avatar" style={{ width: '280px', height: '280px' }} />
          <h4 className="doctos-full-name"><b>{doctor.firstName} {doctor.lastName}</b></h4>
          <Link to={`doctor\\${doctor.id}`} className="doctor-more-info-btn" type="button">Read more</Link>
        </div>
      </div>
    </div>
  );
}

export default DoctorCard;