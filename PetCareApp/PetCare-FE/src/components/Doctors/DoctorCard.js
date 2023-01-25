import { Link } from "react-router-dom";
import defaultImage from '../../default-images/default-image.jpg'
import { configureImagePath } from "../../Utils/configureImagePath"
import Accordion from '@mui/material/Accordion';
import AccordionSummary from '@mui/material/AccordionSummary';
import AccordionDetails from '@mui/material/AccordionDetails';
import Typography from '@mui/material/Typography';
import ExpandMoreIcon from '@mui/icons-material/ExpandMore';
import { Paper } from "@mui/material";

const DoctorCard = ({
  doctor,
  renderButton,
  renderAccordion,
}) => {
  const accordion = (
    <>
      <Accordion square={true} sx={{ width: '300px' }}>
        <AccordionSummary
          expandIcon={<ExpandMoreIcon />}
          aria-controls="panel1a-content"
          id="panel1a-header"
        >
          <Typography variant="h5">Specialty</Typography>
        </AccordionSummary>
        <AccordionDetails>
          <Typography variant="h6">
            {doctor.jobDescription}
          </Typography>
        </AccordionDetails>
      </Accordion>
      <Accordion square={true} sx={{ width: '300px' }}>
        <AccordionSummary
          expandIcon={<ExpandMoreIcon />}
          aria-controls="panel1a-content"
          id="panel1a-header"
        >
          <Typography variant="h5">Phonenumber</Typography>
        </AccordionSummary>
        <AccordionDetails>
          <Typography variant="h6">
            {doctor.phonenumber}
          </Typography>
        </AccordionDetails>
      </Accordion>
    </>
  );

  const imagePath = configureImagePath(doctor.imageFilePath)

  return (
    <Paper elevation={24}>
      <div className="row-doctor-card-container">
        <div className="col-doctor-card-container">
          <div className="doctor-card-container">
            <img src={imagePath ?? defaultImage} alt="Avatar" style={{ width: '280px', height: '280px' }} />
            <h4 className="doctos-full-name"><b>{doctor.firstName} {doctor.lastName}</b></h4>
            {renderButton
              ? <Link to={`doctor\\${doctor.id}`} className="doctor-more-info-btn" type="button">Read more</Link>
              : ""
            }
            {renderAccordion
              ? accordion
              : ''
            }
          </div>
        </div>
      </div>
    </Paper>
  );
}

export default DoctorCard;