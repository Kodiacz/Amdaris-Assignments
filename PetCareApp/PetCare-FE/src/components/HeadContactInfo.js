import ContactInfoItem from "./ContactInfoItem"

function HeadContactInfo() {
    return <div className="container-fluid border-bottom d-none d-lg-block">
        <div className="row gx-0">
          <ContactInfoItem titleText={"OUR OFFICE"} styleClassName={"geo-alt"} spanText={"123 Street, New York, USA"}/>
          <ContactInfoItem titleText={"EMAIL US"} styleClassName={"envelope-open"} spanText={"info@example.com"}/>
          <ContactInfoItem titleText={"CALL US"} styleClassName={"phone-vibrate"} spanText={"+012 345 6789"}/>
        </div>
      </div>
}

export default HeadContactInfo;