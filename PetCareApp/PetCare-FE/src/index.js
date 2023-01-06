import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import App from './App';
import reportWebVitals from './reportWebVitals';
import { BrowserRouter, Route, Routes } from 'react-router-dom';
import DoctorsList from './components/DoctorsList.js';
import PetsList from './components/PetList.js'
import NavBar from './components/NavBar.js';
import HeadContactInfo from './components/HeadContactInfo.js';
import FooterContactInfo from './components/FooterContactInfo';

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
  <React.StrictMode>
    {/* <App /> */}
    <BrowserRouter>
      <HeadContactInfo />
      <div className='main-body'>
        <NavBar />
        <Routes>
          {/* <Route path="/somepage" element={<SomePage />} /> */}
          <Route path="/doctors" element={<DoctorsList />} />
          {/* <Route path="/about" element={<About />} /> */}
          <Route path="/pets" element={<PetsList />} />
          <Route path="/" element={<App />} />
          {/* <Route path="*" element={<Page404 />} /> */}
        </Routes>
      </div>
    </BrowserRouter>
    <FooterContactInfo />
  </React.StrictMode>
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
