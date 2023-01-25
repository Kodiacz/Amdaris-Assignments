/* eslint-disable jsx-a11y/iframe-has-title */
/* eslint-disable jsx-a11y/anchor-is-valid */

import './App.css';
import { useEffect, useState } from 'react';
import ErrorPage from './Pages/ErrorPages/ErrorPage';
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
import UserSettings from './components/User/EditUser';
import MyAppointments from './Pages/AccountPages/MyAppointments'
import { BrowserRouter, Route, Routes } from 'react-router-dom';
import DeletePetDialog from './components/Dialog/DeletePetDialog';
import AccountDetails from './Pages/AccountPages/AccountDetails';
import PrivateRoutes from './components/PrivateRoutes/PrivateRoutes';
import Login  from './components/Login/Login';
import EditUser from './components/User/EditUser';

const defaultProfilePicturePath = './img/default-images/default-user-pic.jpg'
//./img/users-profile-images/-user.jpg

const initialAuthState = {
  accessToken: '',
  username: '',
  userId: '',
  profileImageFilePath: '',
};

function App() {
  const [user, setUser] = useLocalStorage('user', initialAuthState);
  const [profilePicture, setProfilePicture] = useLocalStorage('profilePicture', user.profileImageFilePath ? user.profileImageFilePath : defaultProfilePicturePath);
  console.log(user.profileImageFilePath ? 'user.profileImageFilePath' : 'defaultProfilePicturePath');

  useEffect(() => {
    if (user.profileImageFilePath) {
      setProfilePicture(user.profileImageFilePath)
    }
  }, [user])


  const onLogin = (authData) => {
    setUser(authData)
    toast("You were loged in");
  }

  const onLogout = () => {
    setUser(initialAuthState);
    toast("You were loged out")
  }
  // console.log('App', profilePicture);
  console.log(user)

  //setProfilePicture, profilePicture
  return (
    <AuthContext.Provider value={{ user, onLogin, onLogout, setProfilePicture }}>
      <BrowserRouter>
        <HeadContactInfo />
        <div className='main-body'>
          <NavBar username={user.username} onLogout={onLogout} profilePicture={profilePicture} />
          {/* <NavBar username={user.username} onLogout={onLogout} profilePicture={user.profilePicture}/> */}
          <Routes>
            <Route path="/" element={<Home />} />
            <Route path="/about" element={<About />} />
            <Route path="/doctors/*" element={<DoctorsList />} />
            <Route path="/doctors/doctor/:doctorId" element={<Doctor />} />
            <Route path="/my-account/*" element={<PrivateRoutes />} errorElement={<ErrorPage />}>
              <Route path='my-pets' element={<PetsList />} />
              <Route path='create-pet' element={<CreatePet />} />
              <Route path='edit-pet/:petId' element={<EditPet />} />
              <Route path='my-appointments' element={<MyAppointments />} />
              <Route path='account-details/*' element={<AccountDetails />} />
                <Route path='edit-account' element={<EditUser />}/>
              <Route/>
            </Route>
            <Route path="/register" element={<Register />} />
            <Route path="/login" element={<Login />} />
            <Route path="*" element={<ErrorPage />} />
          </Routes>
        </div>
      </BrowserRouter>
    </AuthContext.Provider>
  );
}

export default App;
