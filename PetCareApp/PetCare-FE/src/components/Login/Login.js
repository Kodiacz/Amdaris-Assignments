import { Link } from "react-router-dom"
import LoginIcon from '@mui/icons-material/Login';
import VpnKeyIcon from '@mui/icons-material/VpnKey';
import PersonIcon from '@mui/icons-material/Person';
import "./Login.css"

function Login() {
    const onFormSubmit = (e) => {
        e.preventDefault();

        let formData = new FormData(e.target);

        let username = formData.get('username');
        let password = formData.get('password');

        console.log(username);
        console.log(password);
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
                    <input onChange={(e) => handleChange(e)} id="password" type="text" name="password" required />
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