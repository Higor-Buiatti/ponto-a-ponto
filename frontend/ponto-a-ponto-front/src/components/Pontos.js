import React from 'react'
import Ponto from './Ponto'


const Pontos = ({pontos}) => {
    return (
        <>
            {pontos.map((ponto) => (
                <Ponto key={ponto.id} ponto = {ponto} />
            ))}
        </>
    )
}

export default Pontos
