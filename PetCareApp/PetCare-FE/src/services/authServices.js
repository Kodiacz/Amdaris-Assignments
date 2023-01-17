// import { useAxiosPost } from "../Utils/useFetch"

// async function Login(data) {
//    const res = await useAxiosPost(`https://localhost:7038/api/Authentication/Login`, data);
//    console.log(res, 'mid');
//    return res;
// }

// export { Login }

const baseUrl = 'https://localhost:7038/';

export const login = async (data) => {
   const res = await fetch(`${baseUrl}api/Authentication/Login`, {
      method: 'POST',
      headers: {
         'Content-Type': 'application/json',
      },
      body: JSON.stringify(data),
   })
   
   return res.json();
}