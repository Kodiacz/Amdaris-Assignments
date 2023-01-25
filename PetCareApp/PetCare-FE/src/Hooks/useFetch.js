import axios from 'axios';
import { useEffect, useState } from 'react';

const useAxiosGet = (url) => {
    const [state, setState] = useState([]);
    const [isLoading, setIsLoading] = useState(true);
    const [error, setError] = useState(null);

    useEffect(() => {
        fetchData();
    }, [])

    async function fetchData() {
        // setTimeout(async () => {
            const result = await axios.get(url)
                .catch(error => setError(error))
                
            setIsLoading(false)
            setState(result.data);
        // }, 1000);
    }

    return {
        state,
        error,
        isLoading,
    }
}

const useAxiosPost = async (url, body) => {
    //const [state, setState] = useState([]);
    //const [isLoading, setIsLoading] = useState(true);
    //const [error, setError] = useState(null);

    //useEffect(() => {
    //    fetchToken();
    //}, [])

        const result = await axios.post(url, body.data)
        

        return result;
        //body.state.isLoading.setIsLoading(false);
        //body.state.state.setState(result.data);
}

export { useAxiosGet, useAxiosPost }