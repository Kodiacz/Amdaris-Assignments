/* eslint-disable jsx-a11y/iframe-has-title */
/* eslint-disable jsx-a11y/anchor-is-valid */
import './App.css';
import Home from './components/Home';
import About from './components/About';
import NavBar from './components/NavBar';
import DoctorsList from './components/DoctorsList';
import PetsList from './components/PetsList';
import HeadContactInfo from './components/HeadContactInfo';
import { BrowserRouter, Route, Routes } from 'react-router-dom';

function App() {
  return (
    <BrowserRouter>
      <HeadContactInfo />
      <div className='main-body'>
        <NavBar />
        <Routes>
          <Route path="/doctors" element={<DoctorsList />} />
          <Route path="/about" element={<About />} />
          <Route path="/pets" element={<PetsList />} />
          <Route path="/" element={<Home />} />
          {/* <Route path="*" element={<Page404 />} /> */}
        </Routes>
      </div>
    </BrowserRouter>
  );
}

export default App;
