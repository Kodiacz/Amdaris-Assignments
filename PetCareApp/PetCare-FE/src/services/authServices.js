const baseUrl = 'https://localhost:7038/';

export const login = async (data) => {
   const res = await fetch(`${baseUrl}api/Authentication/Login`, {
      method: 'POST',
      headers: {
         'Content-Type': 'application/json',
      },
      body: JSON.stringify(data),
   });

   const jsonResult = await res.json()
   
   if (res.ok) {
      return jsonResult;
   } else {
      throw jsonResult;
   }
}

export const register = async (data) => {
   
   const res = await fetch(`${baseUrl}api/Authentication/Register`, {
      method: 'POST',
      headers: {
         'Content-Type': 'application/json',
      },
      body: JSON.stringify(data),
   });
   
   if (res.ok) {
      return 'registered';
   } else {
      throw res.text();
   }
}