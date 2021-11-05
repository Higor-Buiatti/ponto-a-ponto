import React, { useState } from 'react'

const Register = (pontos, setPontos) => {
    const [nome, setNome] = useState('')
    const [cpf, setCpf] = useState('')

    const onSubmit = () => {

        if (!nome) {
            alert('insira um nome')
        }
        if (!cpf) {
            alert('insira um cpf')
        }

        addTask({ nome, cpf })

        setNome('')
        setCpf('')
    }

    const addTask = async (pontos) => {
        const res = await fetch('https://localhost:44373/api/ponto',{
            method: 'POST',
            headers: {
                'Content-type': 'application/json'
            },
            body: JSON.stringify(pontos)
        })
        const data = await res.json()
        setPontos([...pontos, data])

        alert("Ponto Registrado!")
    }

    return (
        <div className="consult">
            <h1>Registro de Ponto</h1>
            <form className='form' onSubmit={onSubmit}>
                <div className="form-nome">
                    <label>NOME :</label>
                    <input type="text" name="cpf" value={nome} onChange={(e) => setNome(e.target.value)} />
                </div>
                <div className="form-nome">
                    <label>CPF :</label>
                    <input type="text" name="cpf" value={cpf} onChange={(e) => setCpf(e.target.value)} />
                </div>
                <div className="consult-buttons">
                    <button >
                        <h5 >REGISTRAR</h5>
                    </button>
                </div>
            </form>
        </div>

    )
}

export default Register
