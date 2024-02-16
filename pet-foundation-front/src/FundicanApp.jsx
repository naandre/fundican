import { useState } from "react"
import { Login } from "./components/Login";
import { Foundations } from "./components/Foundations";


export const FundicanApp = () => {
    const [isLogin, setIsLogin] = useState(false);
    const [token, setToken] = useState('');


    const handleLogin = (newToken) => {
        if(!newToken) {
            setIsLogin(false);
            return;
        }
        setToken(newToken);
        setIsLogin(true);
    }
  return (
    <>
    {!isLogin ? <Login onLogin={handleLogin}/> : <Foundations auth={token}/>}
    </>
  )
}
