import { BrowserRouter, Route, Switch } from 'react-router-dom'
import Check from './components/Check'
import Home from './components/Home'
import Search from './components/Search'
import { useState, useEffect } from 'react'



const Routes = () => {
    
    const [pontos, setPontos] = useState([])
    useEffect(() => {
        const getData = async () => {
            const dataFromServer = await fetchData()
            setPontos(dataFromServer)
        }

        getData()
    }, []);

    const fetchData = async () => {
        const res = await fetch(`https://localhost:44373/api/ponto/12851023632`)
        const data = await res.json()

        console.log(data)
        return data
    }
    
    return (
        <BrowserRouter>
            <Switch>
                <Route path="/" exact>
                    <Home />
                </Route>
                <Route path="/consult">
                    <Search pontos = {pontos}/>
                </Route>
                <Route path='/register'>
                    <Check pontos = {pontos} setPontos={setPontos}/>
                </Route>
            </Switch>
        </BrowserRouter>
    )
}

export default Routes
