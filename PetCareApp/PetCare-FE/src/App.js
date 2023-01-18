/* eslint-disable jsx-a11y/iframe-has-title */
/* eslint-disable jsx-a11y/anchor-is-valid */

import './App.css';
import { useState } from 'react';
import Home from './components/Common/Home';
import Login from './components/Login/Login';
import About from './components/Common/About';
import NavBar from './components/Common/NavBar';
import Doctor from './components/Doctors/Doctor';
import PetsList from './components/Pets/PetsList';
import { AuthContext } from './contexts/AuthContext';
import Calendar from './components/Calendar/Calendar';
import DoctorsList from './components/Doctors/DoctorsList';
import { BrowserRouter, Route, Routes, useNavigate } from 'react-router-dom';
import HeadContactInfo from './components/Common/HeadContactInfo';
import ErrorPage from './Error/ErrorPage';
import { toast, ToastContainer } from 'react-toastify';
import useLocalStorage from './Hooks/useLocalStorage'

const initialAuthState = {
  accessToken: '',
  username: '',
  userId: '',
};

function App() {
  const [user, setUser] = useLocalStorage('user', initialAuthState)
  
  const onLogin = (authData) => {
    console.log('onLogin', authData)
    setUser(authData)
    toast("You were loged in");
  }

  const onLogout = () => {
    setUser(initialAuthState);
  }

  return (
    <AuthContext.Provider value={{ user, onLogin, onLogout }}>
      <BrowserRouter>
        <HeadContactInfo />
        <ToastContainer />
        <div className='main-body'>
          <NavBar username={user.username} onLogout={onLogout}/>
          <Routes>
            <Route path="/doctors/*" element={<DoctorsList />} />
            <Route path="/about" element={<About />} />
            <Route path="/doctors/doctor/:id" element={<Doctor />} />
            <Route path="/pets" element={<PetsList />} errorElement={<ErrorPage />}/>
            <Route path="/" element={<Home />} />
            <Route path="/calendar" element={<Calendar />} errorElement={<ErrorPage />}/>
            <Route path="/login" element={<Login />} />
            {/* <Route path="*" element={<Page404 />} /> */}
          </Routes>
        </div>
      </BrowserRouter>
    </AuthContext.Provider>
  );
}

export default App;
