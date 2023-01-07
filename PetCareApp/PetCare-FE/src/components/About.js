import './About.css'

const About = () => {
  return (
    <div className="container-fluid py-5">
      <div className="container">
        <div className="row gx-5">
          <div className="col-lg-5 mb-5 mb-lg-0" style={{ minHeight: '500px' }}>
            <div className="position-relative h-100">
              <img className="happy-pup-image" alt='Happy pup' src="img/happy-pets.jpg" style={{ objectFit: 'cover' }} />
            </div>
          </div>
          <div className="col-lg-7">
            <div className="border-start border-5 border-primary ps-5 mb-5">
              <h6 className="text-primary text-uppercase">About Us</h6>
              <h1 className="display-5 text-uppercase mb-0">We Keep Your Pets Happy All Time</h1>
            </div>
            <h4 className="text-body mb-4">
              About us
              "Pet Care" Veterinary Clinic is a 24/7 hospital for small animals, working without a day off. Realized as such from the 
              project, through construction, equipment and commissioning. This is one of the largest and most modernly equipped veterinary 
              clinics in Bulgaria. We have state-of-the-art technical equipment for emergency medical care, diagnostics, and surgical 
              treatment. On an area of over 400 sq.m. are located: a reception area with reception and registration, two manipulation 
              rooms, a laboratory for clinical diagnostics, offices, an imaging room, an operating room, resuscitation. The clinic has an 
              excellently prepared team that attends year-round courses, seminars and symposia all over the world in order to keep up with the
              latest trends in veterinary medicine. We have the first doctor in Bulgaria, certified as an expert in the field of TBD/Hip 
              Dysplasia/ and a member of the GRSK (German Association of Radiologists for Genetic Diseases of the Musculoskeletal System and 
              Bones). This organization is a leader in the field of X-ray research and diagnosis of genetically inherited diseases of the 
              musculoskeletal system and bones. It is also officially recognized by FCI and IEWG.Animals examined in our clinic are issued an 
              international certificate certifying the results of the conducted examinations.
            </h4>
            <div className="bg-light p-4">
              <ul className="nav nav-pills justify-content-between mb-3" id="pills-tab" role="tablist">
                <li className="nav-item w-50" role="presentation">
                  <button className="nav-link text-uppercase w-100 active" id="pills-1-tab" data-bs-toggle="pill"
                    data-bs-target="#pills-1" type="button" role="tab" aria-controls="pills-1"
                    aria-selected="true">Our Mission</button>
                </li>
                <li className="nav-item w-50" role="presentation">
                  <button className="nav-link text-uppercase w-100" id="pills-2-tab" data-bs-toggle="pill"
                    data-bs-target="#pills-2" type="button" role="tab" aria-controls="pills-2"
                    aria-selected="false">Our Vission</button>
                </li>
              </ul>
              <div className="tab-content" id="pills-tabContent">
                <div className="tab-pane fade show active" id="pills-1" role="tabpanel" aria-labelledby="pills-1-tab">
                  <h5 className="mb-0">
                    Your go-to resource for vet-approved pet care guidance. Designed to give you the confidence and know-how to always keep your pet at their best.
                  </h5>
                </div>
                <div className="tab-pane fade" id="pills-2" role="tabpanel" aria-labelledby="pills-2-tab">
                  <h5 className="mb-0">
                    Everything we do at Pet Care – from the way we greet you on the phone, to the way we introduce a new service or train a new team member, is underpinned by the following seven core values:
                    <ul className="our-vission-list">
                      <li>
                        <p>
                          Excellence
                        </p>
                      </li>
                      <li>
                        <p>
                          Care
                        </p>
                      </li>
                      <li>
                        <p>
                          Innovation
                        </p>
                      </li>
                      <li>
                        <p>
                          Professionalism
                        </p>
                      </li>
                      <li>
                        <p>
                          Consistency
                        </p>
                      </li>
                      <li>
                        <p>
                          Enjoyment
                        </p>
                      </li>
                      <li>
                        <p>
                          Excellence
                        </p>
                      </li>
                    </ul>
                    To provide innovative, high-quality, consistent, pet friendly health care that will make your pet want to come back again and again.
                  </h5>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};

export default About;