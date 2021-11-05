import React from 'react'
import Footer from './Footer'
import Header from './Header'
import Register from './Register'

const Check = ({ pontos, setPontos }) => {
    return (
        <div className="search">
            < Header />
            < Register pontos = {pontos} setPontos={setPontos}/>
            < Footer />
        </div>
    )
}

export default Check
