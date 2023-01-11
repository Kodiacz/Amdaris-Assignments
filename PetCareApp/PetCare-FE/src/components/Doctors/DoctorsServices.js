import { useFetch } from "../../Utils/useFetch.js";

function GetAllDoctors() {
    return useFetch('https://localhost:7038/api/Doctor/GetAll')
}

export { GetAllDoctors }