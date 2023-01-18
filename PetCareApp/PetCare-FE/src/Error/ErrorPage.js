import React from 'react'
import { useRouteError } from 'react-router-dom';

const ErrorPage = () => {
    const error = useRouteError();
    console.error();

    return (
        <section class="notFound">
            <div class="img">
                <img src="https://assets.codepen.io/5647096/backToTheHomepage.png" alt="Back to the Homepage" />
                <img src="https://assets.codepen.io/5647096/Delorean.png" alt="El Delorean, El Doc y Marti McFly" />
            </div>
            <div class="text">
                <p>
                    {error && error.status && <h4>{error.status}</h4>}
                </p>
                <p>
                    {error && <i>{error.statusText || error.message}</i>}
                </p>
                <h3>BACK TO HOME?</h3>
                <a href="#" class="yes">YES</a>
                <a href="https://www.youtube.com/watch?v=G3AfIvJBcGo">NO</a>
            </div>
        </section>
    )
}

export default ErrorPage