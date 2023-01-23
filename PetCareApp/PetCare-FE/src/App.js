/* eslint-disable jsx-a11y/iframe-has-title */
/* eslint-disable jsx-a11y/anchor-is-valid */

import './App.css';
import { useState } from 'react';
import ErrorPage from './Error/ErrorPage';
import Home from './Pages/CommonPages/Home';
import About from './Pages/CommonPages/About';
import NavBar from './components/Common/NavBar';
import Doctor from './components/Doctors/Doctor';
import PetsList from './Pages/PetPages/PetsList';
import { AuthContext } from './contexts/AuthContext';
import Calendar from './components/Calendar/Calendar';
import DoctorsList from './Pages/DoctorPages/DoctorsList';
import HeadContactInfo from './components/Common/HeadContactInfo';
import { toast, ToastContainer } from 'react-toastify';
import useLocalStorage from './Hooks/useLocalStorage'
import MyAccountSideBar from './components/User/MyAccountSideBar';
import CreatePet from './Pages/PetPages/CreatePet';
import EditPet from './Pages/PetPages/EditPet';
import Register from './components/Register/Register';
import UserSettings from './components/User/UserSettings';
import MyAppointments from './Pages/AccountPages/MyAppointments'
import { BrowserRouter, Route, Routes } from 'react-router-dom';

const initialAuthState = {
  accessToken: '',
  username: '',
  userId: '',
  userProfilePicturePath: '',
};

function App() {
  const [user, setUser] = useLocalStorage('user', initialAuthState)
  
  const onLogin = (authData) => {
    
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
          {/* <NavBar username={user.username} onLogout={onLogout} profilePicture={user.profilePicture}/> */}
          <Routes>
            <Route path="/" element={<Home />} />
            <Route path="/about" element={<About />} />
            <Route path="/doctors/*" element={<DoctorsList />} />
            <Route path="/doctors/doctor/:doctorId" element={<Doctor />} />
            <Route path="/my-account/*" element={<MyAccountSideBar />} errorElement={<ErrorPage />}>
              <Route path='my-pets' element={<PetsList />}/>
              <Route path='create-pet' element={<CreatePet />}/>
              <Route path='edit-pet/:petId' element={<EditPet />}/>
              <Route path='my-appointments' element={<MyAppointments />}/>
            </Route>
            <Route path="/calendar" element={<Calendar />} errorElement={<ErrorPage />}/>
            <Route path="/register" element={<Register />} />
            {/* <Route path="*" element={<Page404 />} /> */}
          </Routes>
        </div>
      </BrowserRouter>
    </AuthContext.Provider>
  );
}

export default App;
