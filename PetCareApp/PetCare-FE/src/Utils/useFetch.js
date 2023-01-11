import axios from 'axios';
import { useEffect, useState } from 'react';

const useFetch = (url) => {
    const [state, setState] = useState([]);
    const [isLoading, setIsLoading] = useState(true);
    const [error, setError] = useState(null);

    useEffect(() => {
        fetchData();
    }, [url])

    async function fetchData() {
        const result = await axios.get(url)
            .catch(error => setError(error))
        setIsLoading(false)
        setState(result.data);
    }

    return {
        state,
        error,
        isLoading,
    }
}

export { useFetch }