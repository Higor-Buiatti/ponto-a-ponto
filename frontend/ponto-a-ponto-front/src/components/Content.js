import React from 'react'
import { Link } from 'react-router-dom';

const Content = () => {
    
    return (
        <div className="content">
            <h1>Bem vindo!</h1>
            <h3>Oque gostaria de fazer?</h3>
            <div className="buttons">
                <button className="btn-consult">
                    <Link to ="/register">REGISTRAR PONTO</Link>
                </button>
                <button className ="btn-register">
                    <Link to ="/consult">CONSULTAR PONTO</Link>
                </button>
            </div>
        </div>
    )

}

export default Content
