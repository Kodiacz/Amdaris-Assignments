/* eslint-disable jsx-a11y/anchor-is-valid */

import { Link } from 'react-router-dom'

function NavBar() {
    return (
        <nav className="navbar navbar-expand-lg bg-white navbar-light shadow-sm py-3 py-lg-0 px-3 px-lg-0">
            <a href="index.html" className="navbar-brand ms-lg-5">
                <h1 className="m-0 text-uppercase text-dark"><i className="bi bi-shop fs-1 text-primary me-3"></i>Pet Care</h1>
            </a>
            <button className="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarCollapse">
                <span className="navbar-toggler-icon"></span>
            </button>
            <div className="collapse navbar-collapse" id="navbarCollapse">
                <div className="navbar-nav ms-auto py-0">
                    <Link to="/" className="nav-item nav-link">Home</Link>
                    <Link to="/about" className="nav-item nav-link">About</Link>
                    <Link to="service.html" className="nav-item nav-link">Service</Link>
                    <Link to="product.html" className="nav-item nav-link">Shop</Link>
                    <div className="nav-item dropdown">
                        <a className="nav-link dropdown-toggle" data-bs-toggle="dropdown">Pages</a>
                        <div className="dropdown-menu m-0">
                            <Link to="pets" className="dropdown-item">Pets</Link>
                            <Link to="doctors" className="dropdown-item">Doctors Теам</Link>
                            <Link to="price.html" className="dropdown-item">Pricing Plan</Link>
                            <Link to="team.html" className="dropdown-item">The Team</Link>
                            <Link to="testimonial.html" className="dropdown-item">Testimonial</Link>
                            <Link to="blog.html" className="dropdown-item">Blog Grid</Link>
                            <Link to="detail.html" className="dropdown-item">Blog Detail</Link>
                        </div>
                    </div>
                    <Link to="contact.html" className="nav-item nav-link nav-contact bg-primary text-white px-5 ms-lg-5">Sign In <i className="bi bi-arrow-right"></i></Link>
                </div>
            </div>
        </nav>
    )
}

export default NavBar;