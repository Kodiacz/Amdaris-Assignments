import React, { useContext } from 'react'
import { Navigate, Outlet } from 'react-router-dom';
import { AuthContext } from '../../contexts/AuthContext'
import MyAccountSideBar from '../User/MyAccountSideBar';

const PrivateRoutes = () => {
  const { user } = useContext(AuthContext);
  
  return (
    <>
      {user.accessToken ? <MyAccountSideBar /> : <Navigate to='/login' />}
    </>
  )
}

export default PrivateRoutes