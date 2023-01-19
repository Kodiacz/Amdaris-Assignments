import React from 'react'
import { Link, Outlet } from 'react-router-dom'
import './PetSideBar.css'

const PetSideBar = () => {
  return (
    <div className='pets-page'>
      <div className="sidenav">
        <Link to="my-pets">Pets</Link>
        <Link to="create-pet">Add Pet</Link>
        <Link to="somewhere">Clients</Link>
        <Link to="somewhere">Contact</Link>
      </div>
      <div>
        <Outlet />
      </div>
    </div>
  )
}

export default PetSideBar