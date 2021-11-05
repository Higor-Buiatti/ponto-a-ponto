import React from 'react'
import Consult from './Consult'
import Footer from './Footer'
import Header from './Header'

const Search = ({ pontos, id, setId }) => {
    return (
        <div className = "search">
            < Header />
            < Consult pontos = {pontos}/>
            < Footer />
        </div>
    )
}

export default Search
