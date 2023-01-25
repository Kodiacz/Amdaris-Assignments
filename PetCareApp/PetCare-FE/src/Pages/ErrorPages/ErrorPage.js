import React from 'react'
import { Link, useRouteError } from 'react-router-dom';
import './ErrorPage.css'

const ErrorPage = () => {
    // const error = useRouteError();
    console.error();

    return (
        <section class="not-found">
            <div class="img-not-found">
                <img src="https://assets.codepen.io/5647096/backToTheHomepage.png" alt="Back to the Homepage" />
                <img src="https://assets.codepen.io/5647096/Delorean.png" alt="El Delorean, El Doc y Marti McFly" />
            </div>
            <div class="text-not-found">
                <h1>
                    404
                    {/* {error && error.status && <h4>{error.status}</h4>} */}
                </h1>
                <p>
                    {/* {error && <i>{error.statusText || error.message}</i>} */}
                </p>
                <h3>BACK TO HOME?</h3>
                <Link to='' className='link-to-home-page'>Yes</Link>
                <a className='link-to-no-page' href="https://www.youtube.com/watch?v=G3AfIvJBcGo">NO</a>
            </div>
        </section>
    )
}

export default ErrorPage