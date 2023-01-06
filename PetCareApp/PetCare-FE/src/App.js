/* eslint-disable jsx-a11y/anchor-is-valid */
import logo from './logo.svg';
import './App.css';
import DoctorsList from './components/DoctorsList.js'
import HeadContactInfo from './components/HeadContactInfo';

function App() {
  return (
    <div>
      <div className="container-fluid bg-primary py-5 mb-5 hero-header">
        <div className="container py-5">
          <div className="row justify-content-start">
            <div className="col-lg-8 text-center text-lg-start">
              <h1 className="display-1 text-uppercase text-dark mb-lg-4">Pet Care</h1>
              <h1 className="text-uppercase text-white mb-lg-4">Make Your Pets Happy</h1>
              <p className="fs-4 text-white mb-lg-4">Dolore tempor clita lorem rebum kasd eirmod dolore diam eos kasd. Kasd clita ea justo est sed kasd erat clita sea</p>
              <div className="d-flex align-items-center justify-content-center justify-content-lg-start pt-5">
                <a href="" className="btn btn-outline-light border-2 py-md-3 px-md-5 me-5">Read More</a>
                <button type="button" className="btn-play" data-bs-toggle="modal"
                  data-src="https://www.youtube.com/embed/DWRcNpR6Kdc" data-bs-target="#videoModal">
                  <span></span>
                </button>
                <h5 className="font-weight-normal text-white m-0 ms-4 d-none d-sm-block">Play Video</h5>
              </div>
            </div>
          </div>
        </div>
      </div>


      <div className="modal fade" id="videoModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div className="modal-dialog">
          <div className="modal-content rounded-0">
            <div className="modal-header">
              <h5 className="modal-title" id="exampleModalLabel">Youtube Video</h5>
              <button type="button" className="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
            </div>
            <div className="modal-body">
              <div className="ratio ratio-16x9">
                <iframe className="embed-responsive-item" src="" id="video" allowfullscreen allowscriptaccess="always"
                  allow="autoplay"></iframe>
              </div>
            </div>
          </div>
        </div>
      </div>


      <div className="container-fluid py-5">
        <div className="container">
          <div className="row gx-5">
            <div className="col-lg-5 mb-5 mb-lg-0" style={{ minHeight: '500px' }}>
              <div className="position-relative h-100">
                <img alt='' className="position-absolute w-100 h-100 rounded" src="img/happy-pets.jpg" style={{ objectFit: 'cover' }} />
              </div>
            </div>
            <div className="col-lg-7">
              <div className="border-start border-5 border-primary ps-5 mb-5">
                <h6 className="text-primary text-uppercase">About Us</h6>
                <h1 className="display-5 text-uppercase mb-0">We Keep Your Pets Happy All Time</h1>
              </div>
              <h4 className="text-body mb-4">Diam dolor diam ipsum tempor sit. Clita erat ipsum et lorem stet no labore lorem sit clita duo justo magna dolore</h4>
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
                    <p className="mb-0">Tempor erat elitr at rebum at at clita aliquyam consetetur. Diam dolor diam ipsum et, tempor voluptua sit consetetur sit. Aliquyam diam amet diam et eos sadipscing labore. Clita erat ipsum et lorem et sit, sed stet no labore lorem sit. Sanctus clita duo justo et tempor consetetur takimata eirmod, dolores takimata consetetur invidunt magna dolores aliquyam dolores dolore. Amet erat amet et magna</p>
                  </div>
                  <div className="tab-pane fade" id="pills-2" role="tabpanel" aria-labelledby="pills-2-tab">
                    <p className="mb-0">Tempor erat elitr at rebum at at clita aliquyam consetetur. Diam dolor diam ipsum et, tempor voluptua sit consetetur sit. Aliquyam diam amet diam et eos sadipscing labore. Clita erat ipsum et lorem et sit, sed stet no labore lorem sit. Sanctus clita duo justo et tempor consetetur takimata eirmod, dolores takimata consetetur invidunt magna dolores aliquyam dolores dolore. Amet erat amet et magna</p>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>


      <div className="container-fluid py-5">
        <div className="container">
          <div className="border-start border-5 border-primary ps-5 mb-5" style={{ maxWidth: '600px' }}>
            <h6 className="text-primary text-uppercase">Services</h6>
            <h1 className="display-5 text-uppercase mb-0">Our Excellent Pet Care Services</h1>
          </div>
          <div className="row g-5">
            <div className="col-md-6">
              <div className="service-item bg-light d-flex p-4">
                <i className="flaticon-house display-1 text-primary me-4"></i>
                <div>
                  <h5 className="text-uppercase mb-3">Pet Boarding</h5>
                  <p>Kasd dolor no lorem sit tempor at justo rebum rebum stet justo elitr dolor amet sit</p>
                  <a className="text-primary text-uppercase" href="">Read More<i className="bi bi-chevron-right"></i></a>
                </div>
              </div>
            </div>
            <div className="col-md-6">
              <div className="service-item bg-light d-flex p-4">
                <i className="flaticon-food display-1 text-primary me-4"></i>
                <div>
                  <h5 className="text-uppercase mb-3">Pet Feeding</h5>
                  <p>Kasd dolor no lorem sit tempor at justo rebum rebum stet justo elitr dolor amet sit</p>
                  <a className="text-primary text-uppercase" href="">Read More<i className="bi bi-chevron-right"></i></a>
                </div>
              </div>
            </div>
            <div className="col-md-6">
              <div className="service-item bg-light d-flex p-4">
                <i className="flaticon-grooming display-1 text-primary me-4"></i>
                <div>
                  <h5 className="text-uppercase mb-3">Pet Grooming</h5>
                  <p>Kasd dolor no lorem sit tempor at justo rebum rebum stet justo elitr dolor amet sit</p>
                  <a className="text-primary text-uppercase" href="">Read More<i className="bi bi-chevron-right"></i></a>
                </div>
              </div>
            </div>
            <div className="col-md-6">
              <div className="service-item bg-light d-flex p-4">
                <i className="flaticon-cat display-1 text-primary me-4"></i>
                <div>
                  <h5 className="text-uppercase mb-3">Pet Training</h5>
                  <p>Kasd dolor no lorem sit tempor at justo rebum rebum stet justo elitr dolor amet sit</p>
                  <a className="text-primary text-uppercase" href="">Read More<i className="bi bi-chevron-right"></i></a>
                </div>
              </div>
            </div>
            <div className="col-md-6">
              <div className="service-item bg-light d-flex p-4">
                <i className="flaticon-dog display-1 text-primary me-4"></i>
                <div>
                  <h5 className="text-uppercase mb-3">Pet Exercise</h5>
                  <p>Kasd dolor no lorem sit tempor at justo rebum rebum stet justo elitr dolor amet sit</p>
                  <a className="text-primary text-uppercase" href="">Read More<i className="bi bi-chevron-right"></i></a>
                </div>
              </div>
            </div>
            <div className="col-md-6">
              <div className="service-item bg-light d-flex p-4">
                <i className="flaticon-vaccine display-1 text-primary me-4"></i>
                <div>
                  <h5 className="text-uppercase mb-3">Pet Treatment</h5>
                  <p>Kasd dolor no lorem sit tempor at justo rebum rebum stet justo elitr dolor amet sit</p>
                  <a className="text-primary text-uppercase" href="">Read More<i className="bi bi-chevron-right"></i></a>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>


      <div className="container-fluid py-5">
        <div className="container">
          <div className="border-start border-5 border-primary ps-5 mb-5" style={{ maxWidth: '600px' }}>
            <h6 className="text-primary text-uppercase">Products</h6>
            <h1 className="display-5 text-uppercase mb-0">Products For Your Best Friends</h1>
          </div>
          <div className="owl-carousel product-carousel">
            <div className="pb-5">
              <div className="product-item position-relative bg-light d-flex flex-column text-center">
                <img alt='' className="img-fluid mb-4" src="img/product-1.png" />
                <h6 className="text-uppercase">Quality Pet Foods</h6>
                <h5 className="text-primary mb-0">$199.00</h5>
                <div className="btn-action d-flex justify-content-center">
                  <a className="btn btn-primary py-2 px-3" href=""><i className="bi bi-cart"></i></a>
                  <a className="btn btn-primary py-2 px-3" href=""><i className="bi bi-eye"></i></a>
                </div>
              </div>
            </div>
            <div className="pb-5">
              <div className="product-item position-relative bg-light d-flex flex-column text-center">
                <img alt='' className="img-fluid mb-4" src="img/product-2.png" />
                <h6 className="text-uppercase">Quality Pet Foods</h6>
                <h5 className="text-primary mb-0">$199.00</h5>
                <div className="btn-action d-flex justify-content-center">
                  <a className="btn btn-primary py-2 px-3" href=""><i className="bi bi-cart"></i></a>
                  <a className="btn btn-primary py-2 px-3" href=""><i className="bi bi-eye"></i></a>
                </div>
              </div>
            </div>
            <div className="pb-5">
              <div className="product-item position-relative bg-light d-flex flex-column text-center">
                <img alt='' className="img-fluid mb-4" src="img/product-3.png" />
                <h6 className="text-uppercase">Quality Pet Foods</h6>
                <h5 className="text-primary mb-0">$199.00</h5>
                <div className="btn-action d-flex justify-content-center">
                  <a className="btn btn-primary py-2 px-3" href=""><i className="bi bi-cart"></i></a>
                  <a className="btn btn-primary py-2 px-3" href=""><i className="bi bi-eye"></i></a>
                </div>
              </div>
            </div>
            <div className="pb-5">
              <div className="product-item position-relative bg-light d-flex flex-column text-center">
                <img alt='' className="img-fluid mb-4" src="img/product-4.png" />
                <h6 className="text-uppercase">Quality Pet Foods</h6>
                <h5 className="text-primary mb-0">$199.00</h5>
                <div className="btn-action d-flex justify-content-center">
                  <a className="btn btn-primary py-2 px-3" href=""><i className="bi bi-cart"></i></a>
                  <a className="btn btn-primary py-2 px-3" href=""><i className="bi bi-eye"></i></a>
                </div>
              </div>
            </div>
            <div className="pb-5">
              <div className="product-item position-relative bg-light d-flex flex-column text-center">
                <img alt='' className="img-fluid mb-4" src="img/product-2.png" />
                <h6 className="text-uppercase">Quality Pet Foods</h6>
                <h5 className="text-primary mb-0">$199.00</h5>
                <div className="btn-action d-flex justify-content-center">
                  <a className="btn btn-primary py-2 px-3" href=""><i className="bi bi-cart"></i></a>
                  <a className="btn btn-primary py-2 px-3" href=""><i className="bi bi-eye"></i></a>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>


      <div className="container-fluid bg-offer my-5 py-5">
        <div className="container py-5">
          <div className="row gx-5 justify-content-start">
            <div className="col-lg-7">
              <div className="border-start border-5 border-dark ps-5 mb-5">
                <h6 className="text-dark text-uppercase">Special Offer</h6>
                <h1 className="display-5 text-uppercase text-white mb-0">Save 50% on all items your first order</h1>
              </div>
              <p className="text-white mb-4">Eirmod sed tempor lorem ut dolores sit kasd ipsum. Dolor ea et dolore et at sea ea at dolor justo ipsum duo rebum sea. Eos vero eos vero ea et dolore eirmod et. Dolores diam duo lorem. Elitr ut dolores magna sit. Sea dolore sed et.</p>
              <a href="" className="btn btn-light py-md-3 px-md-5 me-3">care Now</a>
              <a href="" className="btn btn-outline-light py-md-3 px-md-5">Read More</a>
            </div>
          </div>
        </div>
      </div>


      <div className="container-fluid py-5">
        <div className="container">
          <div className="border-start border-5 border-primary ps-5 mb-5" style={{ maxWidth: '600px' }}>
            <h6 className="text-primary text-uppercase">Pricing Plan</h6>
            <h1 className="display-5 text-uppercase mb-0">Competitive Pricing For Pet Services</h1>
          </div>
          <div className="row g-5">
            <div className="col-lg-4">
              <div className="bg-light text-center pt-5 mt-lg-5">
                <h2 className="text-uppercase">Basic</h2>
                <h6 className="text-body mb-5">The Best Choice</h6>
                <div className="text-center bg-primary p-4 mb-2">
                  <h1 className="display-4 text-white mb-0">
                    <small className="align-top"
                      style={{ fontSize: '22px', lineHeight: '45px' }}>$</small>49<small
                        className="align-bottom" style={{ fontSize: '16px', lineHeight: '40px' }}>/
                      Mo</small>
                  </h1>
                </div>
                <div className="text-center p-4">
                  <div className="d-flex align-items-center justify-content-between mb-1">
                    <span>HTML5 & CSS3</span>
                    <i className="bi bi-check2 fs-4 text-primary"></i>
                  </div>
                  <div className="d-flex align-items-center justify-content-between mb-1">
                    <span>Bootstrap v5</span>
                    <i className="bi bi-check2 fs-4 text-primary"></i>
                  </div>
                  <div className="d-flex align-items-center justify-content-between mb-1">
                    <span>Responsive Layout</span>
                    <i className="bi bi-x fs-4 text-danger"></i>
                  </div>
                  <div className="d-flex align-items-center justify-content-between mb-1">
                    <span>Browsers Compatibility</span>
                    <i className="bi bi-x fs-4 text-danger"></i>
                  </div>
                  <a href="" className="btn btn-primary text-uppercase py-2 px-4 my-3">Order Now</a>
                </div>
              </div>
            </div>
            <div className="col-lg-4">
              <div className="bg-light text-center pt-5">
                <h2 className="text-uppercase">Standard</h2>
                <h6 className="text-body mb-5">The Best Choice</h6>
                <div className="text-center bg-dark p-4 mb-2">
                  <h1 className="display-4 text-white mb-0">
                    <small className="align-top"
                      style={{ fontSize: '22px', lineHeight: '45px' }}>$</small>99<small
                        className="align-bottom" style={{ fontSize: '16px', lineHeight: '40px' }}>/
                      Mo</small>
                  </h1>
                </div>
                <div className="text-center p-4">
                  <div className="d-flex align-items-center justify-content-between mb-1">
                    <span>HTML5 & CSS3</span>
                    <i className="bi bi-check2 fs-4 text-primary"></i>
                  </div>
                  <div className="d-flex align-items-center justify-content-between mb-1">
                    <span>Bootstrap v5</span>
                    <i className="bi bi-check2 fs-4 text-primary"></i>
                  </div>
                  <div className="d-flex align-items-center justify-content-between mb-1">
                    <span>Responsive Layout</span>
                    <i className="bi bi-check2 fs-4 text-primary"></i>
                  </div>
                  <div className="d-flex align-items-center justify-content-between mb-1">
                    <span>Browsers Compatibility</span>
                    <i className="bi bi-x fs-4 text-danger"></i>
                  </div>
                  <a href="" className="btn btn-primary text-uppercase py-2 px-4 my-3">Order Now</a>
                </div>
              </div>
            </div>
            <div className="col-lg-4">
              <div className="bg-light text-center pt-5 mt-lg-5">
                <h2 className="text-uppercase">Extended</h2>
                <h6 className="text-body mb-5">The Best Choice</h6>
                <div className="text-center bg-primary p-4 mb-2">
                  <h1 className="display-4 text-white mb-0">
                    <small className="align-top"
                      style={{ fontSize: '22px', lineHeight: '45px' }}>$</small>149<small
                        className="align-bottom" style={{ fontSize: '16px', lineHeight: '40px' }}>/
                      Mo</small>
                  </h1>
                </div>
                <div className="text-center p-4">
                  <div className="d-flex align-items-center justify-content-between mb-1">
                    <span>HTML5 & CSS3</span>
                    <i className="bi bi-check2 fs-4 text-primary"></i>
                  </div>
                  <div className="d-flex align-items-center justify-content-between mb-1">
                    <span>Bootstrap v5</span>
                    <i className="bi bi-check2 fs-4 text-primary"></i>
                  </div>
                  <div className="d-flex align-items-center justify-content-between mb-1">
                    <span>Responsive Layout</span>
                    <i className="bi bi-check2 fs-4 text-primary"></i>
                  </div>
                  <div className="d-flex align-items-center justify-content-between mb-1">
                    <span>Browsers Compatibility</span>
                    <i className="bi bi-check2 fs-4 text-primary"></i>
                  </div>
                  <a href="" className="btn btn-primary text-uppercase py-2 px-4 my-3">Order Now</a>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>


      <div className="container-fluid py-5">
        <div className="container">
          <div className="border-start border-5 border-primary ps-5 mb-5" style={{ maxWidth: '600px' }}>
            <h6 className="text-primary text-uppercase">Team Members</h6>
            <h1 className="display-5 text-uppercase mb-0">Qualified Pets Care Professionals</h1>
          </div>
          <div className="owl-carousel team-carousel position-relative" style={{ paddingRight: '25px' }}>
            <div className="team-item">
              <div className="position-relative overflow-hidden">
                <img alt='' className="img-fluid w-100" src="img/team-1.jpg" />
                <div className="team-overlay">
                  <div className="d-flex align-items-center justify-content-start">
                    <a className="btn btn-light btn-square mx-1" href="#"><i className="bi bi-twitter"></i></a>
                    <a className="btn btn-light btn-square mx-1" href="#"><i className="bi bi-facebook"></i></a>
                    <a className="btn btn-light btn-square mx-1" href="#"><i className="bi bi-linkedin"></i></a>
                  </div>
                </div>
              </div>
              <div className="bg-light text-center p-4">
                <h5 className="text-uppercase">Full Name</h5>
                <p className="m-0">Designation</p>
              </div>
            </div>
            <div className="team-item">
              <div className="position-relative overflow-hidden">
                <img alt='' className="img-fluid w-100" src="img/team-2.jpg" />
                <div className="team-overlay">
                  <div className="d-flex align-items-center justify-content-start">
                    <a className="btn btn-light btn-square mx-1" href="#"><i className="bi bi-twitter"></i></a>
                    <a className="btn btn-light btn-square mx-1" href="#"><i className="bi bi-facebook"></i></a>
                    <a className="btn btn-light btn-square mx-1" href="#"><i className="bi bi-linkedin"></i></a>
                  </div>
                </div>
              </div>
              <div className="bg-light text-center p-4">
                <h5 className="text-uppercase">Full Name</h5>
                <p className="m-0">Designation</p>
              </div>
            </div>
            <div className="team-item">
              <div className="position-relative overflow-hidden">
                <img alt='' className="img-fluid w-100" src="img/team-3.jpg" />
                <div className="team-overlay">
                  <div className="d-flex align-items-center justify-content-start">
                    <a className="btn btn-light btn-square mx-1" href="#"><i className="bi bi-twitter"></i></a>
                    <a className="btn btn-light btn-square mx-1" href="#"><i className="bi bi-facebook"></i></a>
                    <a className="btn btn-light btn-square mx-1" href="#"><i className="bi bi-linkedin"></i></a>
                  </div>
                </div>
              </div>
              <div className="bg-light text-center p-4">
                <h5 className="text-uppercase">Full Name</h5>
                <p className="m-0">Designation</p>
              </div>
            </div>
            <div className="team-item">
              <div className="position-relative overflow-hidden">
                <img alt='' className="img-fluid w-100" src="img/team-4.jpg" />
                <div className="team-overlay">
                  <div className="d-flex align-items-center justify-content-start">
                    <a className="btn btn-light btn-square mx-1" href="#"><i className="bi bi-twitter"></i></a>
                    <a className="btn btn-light btn-square mx-1" href="#"><i className="bi bi-facebook"></i></a>
                    <a className="btn btn-light btn-square mx-1" href="#"><i className="bi bi-linkedin"></i></a>
                  </div>
                </div>
              </div>
              <div className="bg-light text-center p-4">
                <h5 className="text-uppercase">Full Name</h5>
                <p className="m-0">Designation</p>
              </div>
            </div>
            <div className="team-item">
              <div className="position-relative overflow-hidden">
                <img alt='' className="img-fluid w-100" src="img/team-5.jpg" />
                <div className="team-overlay">
                  <div className="d-flex align-items-center justify-content-start">
                    <a className="btn btn-light btn-square mx-1" href="#"><i className="bi bi-twitter"></i></a>
                    <a className="btn btn-light btn-square mx-1" href="#"><i className="bi bi-facebook"></i></a>
                    <a className="btn btn-light btn-square mx-1" href="#"><i className="bi bi-linkedin"></i></a>
                  </div>
                </div>
              </div>
              <div className="bg-light text-center p-4">
                <h5 className="text-uppercase">Full Name</h5>
                <p className="m-0">Designation</p>
              </div>
            </div>
          </div>
        </div>
      </div>


      <div className="container-fluid bg-testimonial py-5" style={{ margin: '45px 0' }}>
        <div className="container py-5">
          <div className="row justify-content-end">
            <div className="col-lg-7">
              <div className="owl-carousel testimonial-carousel bg-white p-5">
                <div className="testimonial-item text-center">
                  <div className="position-relative mb-4">
                    <img alt='' className="img-fluid mx-auto" src="img/testimonial-1.jpg" />
                    <div className="position-absolute top-100 start-50 translate-middle d-flex align-items-center justify-content-center bg-white" style={{ width: '45px', height: '45px' }}>
                      <i className="bi bi-chat-square-quote text-primary"></i>
                    </div>
                  </div>
                  <p>Dolores sed duo clita tempor justo dolor et stet lorem kasd labore dolore lorem ipsum. At lorem lorem magna ut et, nonumy et labore et tempor diam tempor erat. Erat dolor rebum sit ipsum.</p>
                  <hr className="w-25 mx-auto" />
                  <h5 className="text-uppercase">Client Name</h5>
                  <span>Profession</span>
                </div>
                <div className="testimonial-item text-center">
                  <div className="position-relative mb-4">
                    <img alt='' className="img-fluid mx-auto" src="img/testimonial-2.jpg" />
                    <div className="position-absolute top-100 start-50 translate-middle d-flex align-items-center justify-content-center bg-white" style={{ width: '45px', height: '45px' }}>
                      <i className="bi bi-chat-square-quote text-primary"></i>
                    </div>
                  </div>
                  <p>Dolores sed duo clita tempor justo dolor et stet lorem kasd labore dolore lorem ipsum. At lorem lorem magna ut et, nonumy et labore et tempor diam tempor erat. Erat dolor rebum sit ipsum.</p>
                  <hr className="w-25 mx-auto" />
                  <h5 className="text-uppercase">Client Name</h5>
                  <span>Profession</span>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>


      <div className="container-fluid py-5">
        <div className="container">
          <div className="border-start border-5 border-primary ps-5 mb-5" style={{ maxWidth: '600p' }}>
            <h6 className="text-primary text-uppercase">Latest Blog</h6>
            <h1 className="display-5 text-uppercase mb-0">Latest Articles From Our Blog Post</h1>
          </div>
          <div className="row g-5">
            <div className="col-lg-6">
              <div className="blog-item">
                <div className="row g-0 bg-light overflow-hidden">
                  <div className="col-12 col-sm-5 h-100">
                    <img alt='' className="img-fluid h-100" src="img/blog-1.jpg" style={{ objectFit: 'cover' }} />
                  </div>
                  <div className="col-12 col-sm-7 h-100 d-flex flex-column justify-content-center">
                    <div className="p-4">
                      <div className="d-flex mb-3">
                        <small className="me-3"><i className="bi bi-bookmarks me-2"></i>Web Design</small>
                        <small><i className="bi bi-calendar-date me-2"></i>01 Jan, 2045</small>
                      </div>
                      <h5 className="text-uppercase mb-3">Dolor sit magna rebum clita rebum dolor</h5>
                      <p>Ipsum sed lorem amet dolor amet duo ipsum amet et dolore est stet tempor eos dolor</p>
                      <a className="text-primary text-uppercase" href="">Read More<i className="bi bi-chevron-right"></i></a>
                    </div>
                  </div>
                </div>
              </div>
            </div>
            <div className="col-lg-6">
              <div className="blog-item">
                <div className="row g-0 bg-light overflow-hidden">
                  <div className="col-12 col-sm-5 h-100">
                    <img alt='' className="img-fluid h-100" src="img/blog-2.jpg" style={{ objectFit: 'cover' }} />
                  </div>
                  <div className="col-12 col-sm-7 h-100 d-flex flex-column justify-content-center">
                    <div className="p-4">
                      <div className="d-flex mb-3">
                        <small className="me-3"><i className="bi bi-bookmarks me-2"></i>Web Design</small>
                        <small><i className="bi bi-calendar-date me-2"></i>01 Jan, 2045</small>
                      </div>
                      <h5 className="text-uppercase mb-3">Dolor sit magna rebum clita rebum dolor</h5>
                      <p>Ipsum sed lorem amet dolor amet duo ipsum amet et dolore est stet tempor eos dolor</p>
                      <a className="text-primary text-uppercase" href="">Read More<i className="bi bi-chevron-right"></i></a>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>



  );
}

export default App;
