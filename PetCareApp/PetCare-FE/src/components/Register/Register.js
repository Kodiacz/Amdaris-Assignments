import { Link, Navigate, useFetchers, useNavigate } from "react-router-dom"
import PhoneIphoneIcon from '@mui/icons-material/PhoneIphone';
import AlternateEmailIcon from '@mui/icons-material/AlternateEmail';
import BadgeIcon from '@mui/icons-material/Badge';
import LoginIcon from '@mui/icons-material/Login';
import VpnKeyIcon from '@mui/icons-material/VpnKey';
import PersonIcon from '@mui/icons-material/Person';
import { AuthContext } from "../../contexts/AuthContext";
import { useContext, useEffect, useState } from "react";
import * as authServices from '../../services/authServices'
import "./Register.css"
import { Password } from "@mui/icons-material";

function Register({
    closeModal,
}) {
    const { onRegister } = useContext(AuthContext);
    const [error, setError] = useState(null);
    const navigate = useNavigate();

    
    const onFormSubmit = async (e) => {
        debugger;
        e.preventDefault();
        
        let formData = new FormData(e.target);
        
        const registerData = {
            'username': formData.get('register-username'),
            'password': formData.get('register-password'),
            'confirmPassword': formData.get('confirmPassword'),
            'email': formData.get('email'),
            'firstName': formData.get('firstName'),
            'lastName': formData.get('lastName'),
            'phonenumber': formData.get('phonenumber'),
        }
        
        const registeredUser = await authServices.register(registerData)
        console.log(registerData);
    }

    const handleChange = (e) => {
        const name = e.target.name;
        const key = e.target.key;
    }

    return (
        <div className="register-center">
            <h1>Sign Up</h1>
            <span className='error-span' hidden={error ? false : true}>Username or Password are incorrect</span>
            <form method="post" onSubmit={(e) => onFormSubmit(e)}>
                <div className="field-wraper">
                    <div className="input-filed-first-part">
                        <div className="text-field">
                            <input onChange={(e) => handleChange(e)} id="register-username" type="text" name="register-username" autoComplete="off" required />
                            <span></span>
                            <label htmlFor="register-username">Username <PersonIcon /></label>
                        </div>
                        <div className="text-field">
                            <input onChange={(e) => handleChange(e)} id="register-password" type="register-password" name="register-password" autoComplete="new-password" required />
                            <span></span>
                            <label htmlFor="register-password">Password <VpnKeyIcon /></label>
                        </div>
                        <div className="text-field">
                            <input onChange={(e) => handleChange(e)} id="firstName" type="firstName" name="firstName" autoComplete="off" required />
                            <span></span>
                            <label htmlFor="firstName">First Name <BadgeIcon /></label>
                        </div>
                    </div>
                    <div className="input-filed-second-part">
                        <div className="text-field">
                            <input onChange={(e) => handleChange(e)} id="email" type="email" name="email" autoComplete="off" required />
                            <span></span>
                            <label htmlFor="email">Email <AlternateEmailIcon /></label>
                        </div>
                        <div className="text-field">
                            <input onChange={(e) => handleChange(e)} id="confirmPassword" type="confirmPassword" name="confirmPassword" autoComplete="new-password" required />
                            <span></span>
                            <label htmlFor="confirmPassword">Confirm Password <VpnKeyIcon /></label>
                        </div>
                        <div className="text-field">
                            <input onChange={(e) => handleChange(e)} id="lastName" type="lastName" name="lastName" autoComplete="off" required />
                            <span></span>
                            <label htmlFor="lastName">Last Name <BadgeIcon /></label>
                        </div>
                    </div>
                </div>
                        <div className="text-field">
                            <input onChange={(e) => handleChange(e)} id="phonenumber" type="phonenumber" name="phonenumber" autoComplete="off" required />
                            <span></span>
                            <label htmlFor="phonenumber">Phonenumber <PhoneIphoneIcon /></label>
                        </div>
                <input type="submit" key="Sign up" />
            </form>
        </div>
    )
}

export default Register;