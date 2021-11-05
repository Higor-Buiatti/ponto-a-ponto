import React, { useState, useEffect } from 'react';
import Ponto from './Ponto';



const Example = ({ conta, setConta }) => {
    
    const [request, setRequest] = useState([])
    useEffect(() => {
        const fetchData = async () => {
            const res = await fetch(`https://localhost:44373/api/ponto/${conta}`)
            const data = await res.json()

            console.log(data)
            return data
        }
        const getData = async () => {
            const dataFromServer = await fetchData()
            setRequest(dataFromServer)
        }

        getData()

    }, [conta]);


    return (
        <table>
            <thead>
                <tr>
                    <th>Nome</th>
                    <th>Data</th>
                    <th>Hora</th>
                </tr>
            </thead>
                {request.map((req) => (
                        <Ponto key={req.id} ponto={req} />
                ))}
        </table>
    );
}
export default Example