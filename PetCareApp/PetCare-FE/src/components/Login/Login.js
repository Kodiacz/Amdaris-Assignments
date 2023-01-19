import { Link, Navigate, useFetchers, useNavigate } from "react-router-dom"
import LoginIcon from '@mui/icons-material/Login';
import VpnKeyIcon from '@mui/icons-material/VpnKey';
import PersonIcon from '@mui/icons-material/Person';
import { AuthContext } from "../../contexts/AuthContext.js";
import { useContext, useEffect, useState } from "react";
import * as authServices from '../../services/authServices.js'
import "./Login.css"

function Login({
    closeModal,
}) {
    const { onLogin } = useContext(AuthContext);
    const [error, setError] = useState(null);
    const navigate = useNavigate();

    const getUser = async (data) => {
        authServices.login(data)
        .then(res =>  {
            onLogin(res);
            navigate('/pets')
        })
        .catch(err => setError(err));
    }
    
    const onFormSubmit = async (e) => {
        e.preventDefault();

        let formData = new FormData(e.target);

        let username = formData.get('username');
        let password = formData.get('password');

        const data = {
            username,
            password,
        }
        getUser(data);
        // 
        if (!error){
            
            closeModal();
        } else {
            
        }
        
    }

    const handleChange = (e) => {
        const name = e.target.name;
        const value = e.target.value;
    }

    return (
        <div className="center">
            <h1>Sign in</h1>
            <form method="post" onSubmit={(e) => onFormSubmit(e)}>
                <div className="text-field">
                    <input onChange={(e) => handleChange(e)} id="username" type="text" name="username" required />
                    <span></span>
                    <label htmlFor="username">Username <PersonIcon /></label>
                </div>
                <div className="text-field">
                    <input onChange={(e) => handleChange(e)} id="password" type="password" name="password" required />
                    <span></span>
                    <label htmlFor="password">Password <VpnKeyIcon /></label>
                </div>
                <div className="pass">Forgot Password?</div>
                <input type="submit" value="Sign in" />
                <div className="signup-link">
                    Not a member? <Link to="/register">Signup <LoginIcon /></Link>
                </div>
            </form>
        </div>
    )
}

export default Login;