import { useState } from "react"

const useLocalStorage = (key, initialiValue) => {
    const [state, setsTate] = useState(() => {
        
        try {
            let item = localStorage.getItem(key);
    
            return item 
            ? JSON.parse(item)
            : initialiValue;

        } catch(err) {
            console.log(err);
            return initialiValue;
        }
    });

    const setItem = (value) => {
        try {
            localStorage.setItem(key, JSON.stringify(value));

            setsTate(value);
        } catch(err) {
            console.log(err);
        }
    } 
    
    return [
        state,
        setItem,
    ];
}

export default useLocalStorage;