/* eslint-disable jsx-a11y/iframe-has-title */
/* eslint-disable jsx-a11y/anchor-is-valid */

import './App.css';
import Home from './components/Common/Home';
import About from './components/Common/About';
import NavBar from './components/Common/NavBar';
import DoctorsList from './components/Doctors/DoctorsList';
import PetsList from './components/Pets/PetsList';
import HeadContactInfo from './components/Common/HeadContactInfo';
import { BrowserRouter, Route, Routes } from 'react-router-dom';
import Calendar from './components/Calendar/Calendar';
import Doctor from './components/Doctors/Doctor';
import Login from './components/Login/Login';
import LoginModal from './components/Login/LoginModal';

function App() {
  return (
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
  );
}

export default App;
