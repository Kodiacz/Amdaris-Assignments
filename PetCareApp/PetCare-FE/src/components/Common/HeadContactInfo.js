import ContactInfoItem from "./ContactInfoItem"

function HeadContactInfo() {
    return <div className="container-fluid border-bottom d-none d-lg-block">
        <div className="row gx-0">
          <ContactInfoItem titleText={"OUR OFFICE"} styleClassName={"geo-alt"} spanText={"1 Blue Light Street, Sofia, Bulgaria"}/>
          <ContactInfoItem titleText={"EMAIL US"} styleClassName={"envelope-open"} spanText={"petcare@gmail.com"}/>
          <ContactInfoItem titleText={"CALL US"} styleClassName={"phone-vibrate"} spanText={"+012 345 6789"}/>
        </div>
      </div>
}

export default HeadContactInfo;