import React from 'react'
import { parseJSON } from 'date-fns'


const Ponto = ({ ponto }) => {
    return (
        <tr>
            <td>{ponto.nome}</td>
            <td>{parseJSON(ponto.pontoHora).toLocaleDateString()}</td>
            <td>{parseJSON(ponto.pontoHora).toLocaleTimeString()}</td>
        </tr>
    )
}

export default Ponto

