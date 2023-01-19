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