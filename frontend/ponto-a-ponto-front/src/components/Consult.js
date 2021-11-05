import React from 'react'
import { useState } from 'react'
import Example from './Example'
import Pontos from './Pontos'


const Consult = ({ pontos }) => {
    const [cpf, setCpf] = useState('')
    const [showTable, setShowTable] = useState(false)
    const [conta, setConta] = useState(0);
    
    return (
        <div className="consult">
            <h1>Consulta de Ponto</h1>
            <form className="form-cpf">
                <label>CPF :</label>
                <input type="text" name="cpf" value={cpf} onChange={(e) => setCpf(e.target.value)} />
            </form>
            {/* <div className="consult-buttons">
                <button onClick={() => setShowTable(!showTable)} >
                    <h5>HOJE</h5>
                </button>
                <button onClick={() => setShowTable(!showTable)}>
                    <h5 >3 DIAS</h5>
                </button>
                <button onClick={() => setShowTable(!showTable)}>
                    <h5>5 DIAS</h5>
                </button>
                <button onClick={() => setShowTable(!showTable)}>
                    <h5>10 DIAS</h5>
                </button>
                <button onClick={() => setShowTable(!showTable)}>
                    <h5>15 DIAS</h5>
                </button>
                <button onClick={() => setShowTable(!showTable)}>
                    <h5>30 DIAS</h5>
                </button>
            </div> */}
            <div className="consult-buttons">
                <button onClick={() => setConta(cpf)}>
                    <h5>Consultar</h5>
                </button>
                <Example conta={conta} setConta={setConta} />
            </div>
        </div>
    )
}

export default Consult
