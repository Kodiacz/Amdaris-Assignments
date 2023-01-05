import ContactInfo from "./ContactInfo"
// bi bi-geo-alt fs-1 text-primary me-3
function HeadContactInfo() {
    return <div className="container-fluid border-bottom d-none d-lg-block">
        <div className="row gx-0">
          <ContactInfo location={"OUR OFFICE"} styleClassName={"geo-alt"} innerText={"123 Street, New York, USA"}/>
          <ContactInfo location={"EMAIL US"} styleClassName={"envelope-open"} innerText={"info@example.com"}/>
          <ContactInfo location={"CALL US"} styleClassName={"phone-vibrate"} innerText={"+012 345 6789"}/>
          {/* <div className="col-lg-4 text-center border-start border-end py-2">
            <div className="d-inline-flex align-items-center">
              <i className="bi bi-envelope-open fs-1 text-primary me-3"></i>
              <div className="text-start">
                <h6 className="text-uppercase mb-1">Email Us</h6>
                <span>info@example.com</span>
              </div>
            </div>
          </div>
          <div className="col-lg-4 text-center py-2">
            <div className="d-inline-flex align-items-center">
              <i className="bi bi-phone-vibrate fs-1 text-primary me-3"></i>
              <div className="text-start">
                <h6 className="text-uppercase mb-1">Call Us</h6>
                <span>+012 345 6789</span>
              </div>
            </div>
          </div> */}
        </div>
      </div>
}

export default HeadContactInfo;