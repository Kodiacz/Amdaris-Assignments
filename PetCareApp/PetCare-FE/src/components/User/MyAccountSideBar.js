import React from 'react'
import { Link, Outlet } from 'react-router-dom'
import './MyAccountSideBar.css'

const MyAccountSideBar = () => {
  return (
    <div className='my-account-page'>
      <div className="sidenav">
        <Link to="my-pets">Pets</Link>
        <Link to="create-pet">Add Pet</Link>
        <Link to="somewhere">Clients</Link>
        <Link to="somewhere">Contact</Link>
      </div>
      <div className='outlet-container'>
        <Outlet />
      </div>
    </div>
  )
}

export default MyAccountSideBar