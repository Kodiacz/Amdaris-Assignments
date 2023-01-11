/* eslint-disable jsx-a11y/anchor-is-valid */

import { Link, NavLink } from 'react-router-dom'

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
                    <NavLink to="/about" activeClassName="active" className="nav-item nav-link">About</NavLink>
                    <NavLink to="/" activeClassName="active" className="nav-item nav-link">Home</NavLink>
                    <NavLink to="product.html" activeClassName="active" className="nav-item nav-link">Shop</NavLink>
                    <div className="nav-item dropdown">
                        <a className="nav-link dropdown-toggle" data-bs-toggle="dropdown">Pages</a>
                        <div className="dropdown-menu m-0">
                            <Link to="pets" className="dropdown-item">Pets</Link>
                            <Link to="doctors" className="dropdown-item">Doctors Теам</Link>
                        </div>
                    </div>
                    <Link to="contact.html" className="nav-item nav-link nav-contact bg-primary text-white px-5 ms-lg-5">Sign In <i className="bi bi-arrow-right"></i></Link>
                </div>
            </div>
        </nav>
    )
}

export default NavBar;