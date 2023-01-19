import { Link } from "react-router-dom";
import defaultImage from '../../default-images/default-image.jpg'
import { configureImagePath } from "../../Utils/configureImagePath";

const DoctorCard = ({
  doctor,
  renderButton,
}) => {
  
  const imagePath = configureImagePath(doctor.imageFilePath)
  
  return (
    <div className="row-doctor-card-container">
      <div className="col-doctor-card-container">
        <div className="doctor-card-container">
          <img src={imagePath ?? defaultImage} alt="Avatar" style={{ width: '280px', height: '280px' }} />
          <h4 className="doctos-full-name"><b>{doctor.firstName} {doctor.lastName}</b></h4>
          { renderButton 
            ? <Link to={`doctor\\${doctor.id}`} className="doctor-more-info-btn" type="button">Read more</Link> 
            : "" 
          }
        </div>
      </div>
    </div>
  );
}

export default DoctorCard;