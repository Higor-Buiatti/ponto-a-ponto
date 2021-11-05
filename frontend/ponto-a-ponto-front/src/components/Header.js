import { Link } from 'react-router-dom';
import logo from '../images/logo.svg';
import NavBar from './NavBar';


const Header = () => {
    return (
        <header className="mainHeader">
            <div className="logoContainer">   
                <img src={logo} className="App-logo" alt="logo" />
                <Link to = "/" className="logoText">Ponto a Ponto</Link>
            </div>
            <div className = "nav-bar">
                < NavBar />
            </div>

             
        </header>
    )
}

export default Header
