/* eslint-disable no-unused-vars */
/* eslint-disable jsx-a11y/anchor-is-valid */

function FooterContactInfo() {
    return (
        <footer className="site-footer">
                <div className="container-fluid bg-light">
                    <div className="container-fluid pt-5">
                        <div className="row g-3">
                            <div className="col-lg-3 col-md-6">
                                <h5 className="text-uppercase border-start border-5 border-primary ps-3 mb-4">Get In Touch</h5>
                                <p className="mb-2"><i className="bi bi-geo-alt text-primary me-2"></i>1 Blue Light Street, Sofia, Bulgaria</p>
                                <p className="mb-2"><i className="bi bi-envelope-open text-primary me-2"></i>petcare@gmail.com</p>
                                <p className="mb-0"><i className="bi bi-telephone text-primary me-2"></i>+012 345 67890</p>
                            </div>
                            <div className="col-lg-3 col-md-6">
                                <h6 className="text-uppercase mt-4 mb-3">Follow Us</h6>
                                <div className="d-flex">
                                    <a className="btn btn-outline-primary btn-square me-2" href="#"><i className="bi bi-twitter"></i></a>
                                    <a className="btn btn-outline-primary btn-square me-2" href="#"><i className="bi bi-facebook"></i></a>
                                    <a className="btn btn-outline-primary btn-square me-2" href="#"><i className="bi bi-linkedin"></i></a>
                                    <a className="btn btn-outline-primary btn-square" href="#"><i className="bi bi-instagram"></i></a>
                                </div>
                            </div>
                            <div className="col-12 text-center text-body">
                                <a className="text-body" href="">Terms & Conditions</a>
                                <span className="mx-1">|</span>
                                <a className="text-body" href="">Privacy Policy</a>
                                <span className="mx-1">|</span>
                                <a className="text-body" href="">Customer Support</a>
                                <span className="mx-1">|</span>
                                <a className="text-body" href="">Payments</a>
                                <span className="mx-1">|</span>
                                <a className="text-body" href="">Help</a>
                                <span className="mx-1">|</span>
                                <a className="text-body" href="">FAQs</a>
                            </div>
                        </div>
                    </div>
                </div>
                <div className="container-fluid bg-dark text-white-50">
                    <div className="container">
                        <div className="row">
                            <div className="col-md-6 text-center text-md-start">
                                <p className="mb-md-0">&copy; <a className="text-white" href="#">Pet Care</a>. All Rights Reserved.</p>
                            </div>
                            <div className="col-md-6 text-center text-md-end">
                                <p className="mb-0">Designed by <a className="text-white" href="https://htmlcodex.com">HTML Codex</a></p>
                            </div>
                        </div>
                    </div>
                </div>


                <a href="#" className="btn btn-primary py-3 fs-4 back-to-top"><i className="bi bi-arrow-up"></i></a>
        </footer>
    )
}

export default FooterContactInfo;