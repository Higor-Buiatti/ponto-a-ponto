import React from 'react'
import { Link } from 'react-router-dom'

const NavBar = () => {
    return (
        <nav className="nav-bar-items">
            <ul className="nav-items">
                <li>
                    <Link to ="/register">REGISTRAR PONTO</Link>
                </li>
                <li>
                    <Link to ="/consult">CONSULTAR PONTO</Link>
                </li>
                <li>
                    <a href="https://www.linkedin.com/in/higor-luiz-silva-de-sousa-buiatti-936125202/">CONTATO</a>
                </li>
            </ul>
        </nav>
    )
}

export default NavBar
