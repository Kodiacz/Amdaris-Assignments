import { Divider } from '@mui/material'
import React from 'react'
import { Link, Outlet } from 'react-router-dom'
import './MyAccountSideBar.css'

const MyAccountSideBar = () => {
  return (
    <>
    <div className='my-account-page'>
      <div className="sidenav">
        <Divider/>
        <Link to="my-pets">Pets</Link>
        <Divider/>
        <Link to="create-pet">Add Pet</Link>
        <Divider/>
        <Link to="account-details">My Account</Link>
        <Divider/>
        <Link to="my-appointments">My Appointments</Link>
        <Divider/>
      </div>
      <div className='outlet-container'>
        <Outlet />
      </div>
    </div>
    </>
  )
}

export default MyAccountSideBar