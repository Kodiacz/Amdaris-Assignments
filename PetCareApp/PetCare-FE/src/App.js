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
import { BrowserRouter, Route, Routes } from 'react-router-dom';
import HeadContactInfo from './components/Common/HeadContactInfo';

function App() {
  const [user, setUser] = useState({
    accessTokent: 'aksesche',
  })

  const login = (authData) => {
    setUser(authData)
  }

  return (
    <AuthContext.Provider value={{user, login}}>
      <BrowserRouter>
        <HeadContactInfo />
        <div className='main-body'>
          <NavBar />
          <Routes>
            <Route path="/doctors/*" element={<DoctorsList />} />
            <Route path="/about" element={<About />} />
            <Route path="/doctors/doctor/:id" element={<Doctor />} />
            <Route path="/pets" element={<PetsList />} />
            <Route path="/" element={<Home />} />
            <Route path="/calendar" element={<Calendar />} />
            <Route path="/login" element={<Login />} />
            {/* <Route path="*" element={<Page404 />} /> */}
          </Routes>
        </div>
      </BrowserRouter>
    </AuthContext.Provider>
  );
}

export default App;
