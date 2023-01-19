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
import PetSideBar from './components/Pets/PetSideBar';
import CreatePet from './components/Pets/CreatePet';

const initialAuthState = {
  accessToken: '',
  username: '',
  userId: '',
  userProfilePicturePath: '',
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
    toast("You were loged out")
  }

  return (
    <AuthContext.Provider value={{ user, onLogin, onLogout }}>
      <BrowserRouter>
        <HeadContactInfo />
        <div className='main-body'>
          <NavBar username={user.username} onLogout={onLogout} profilePicture={user.profilePicture}/>
          <Routes>
            <Route path="/" element={<Home />} />
            <Route path="/about" element={<About />} />
            <Route path="/doctors/*" element={<DoctorsList />} />
            <Route path="/doctors/doctor/:id" element={<Doctor />} />
            <Route path="/pets/*" element={<PetSideBar />} errorElement={<ErrorPage />}>
              <Route path='my-pets' element={<PetsList />}/>
              <Route path='create-pet' element={<CreatePet />}/>
            </Route>
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
