/* eslint-disable jsx-a11y/anchor-is-valid */
import LoginModal from '../../Pages/AccountPages/LoginModal';
import { Link, NavLink } from 'react-router-dom'
import Avatar from '@mui/material/Avatar';
import LoginIcon from '@mui/icons-material/Login';
import LogoutIcon from '@mui/icons-material/Logout';
import Toastche from '../Login/Toast';
import defaultProfilePicture from '../../default-images/default-user-pic.jpg'

function NavBar({
    username,
    onLogout,
    profilePicture,
}) {
    console.log(username);
    let guestNavigation = (
        <div className='guest-div'>
            <a className="nav-item nav-link nav-contact bg-primary text-white px-5 ms-lg-5 login-logout"><LoginModal /></a>
        </div>
    );

    let userNavigation = (
        <div className='user-div'>
            <h5>Welcome, {username}</h5>
            <Avatar
                alt="Avatar"
                src={profilePicture ?? defaultProfilePicture}
                sx={{ width: 70, height: 70 }}
            />
            <a className="nav-item nav-link nav-contact bg-primary text-white px-5 ms-lg-5 login-logout" onClick={onLogout}>Logout <LogoutIcon /></a>
        </div>
    )


    return (
        <nav className="navbar navbar-expand-lg bg-white navbar-light shadow-sm py-3 py-lg-0 px-3 px-lg-0">
            <a href="/" className="navbar-brand ms-lg-5">
                <h1 className="m-0 text-uppercase text-dark"><i className="bi bi-shop fs-1 text-primary me-3"></i>Pet Care</h1>
            </a>
            <button className="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarCollapse">
                <span className="navbar-toggler-icon"></span>
            </button>
            <div className="collapse navbar-collapse" id="navbarCollapse">
                <div className="navbar-nav ms-auto py-0">
                    <Toastche></Toastche>
                    <NavLink to="/about" activeClassName="active" className="nav-item nav-link">About</NavLink>
                    <NavLink to="/" activeClassName="active" className="nav-item nav-link">Home</NavLink>
                    <NavLink to="/shop" activeClassName="active" className="nav-item nav-link">Shop</NavLink>
                    <div className="nav-item dropdown">
                        <a className="nav-link dropdown-toggle" data-bs-toggle="dropdown">Pages</a>
                        <div className="dropdown-menu m-0">
                            {username ? <Link to="pets" className="dropdown-item">My Account</Link> : ""}
                            <Link to="doctors" className="dropdown-item">Vets</Link>
                        </div>
                    </div>
                    {
                        username
                            ? userNavigation
                            : guestNavigation
                    }
                </div>
            </div>
        </nav>
    )
}

export default NavBar;