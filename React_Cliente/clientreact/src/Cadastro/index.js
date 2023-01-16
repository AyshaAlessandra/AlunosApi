import React, { useState } from 'react';
import './styles.css';
import logoImage from '../assets/login.png'
import { useNavigate,Link } from 'react-router-dom';
import { FiCornerDownLeft } from 'react-icons/fi';
import api from '../services/api';

export default function Cadastro() {

    const [email, setEmail] = useState('');
    const [password, setPassword] = useState('');
    const [confirmPassword, setConfirmPassword] = useState('');

    const history = useNavigate();

    async function cadastro(event) {
        event.preventDefault();

        const data = {
            email, password, confirmPassword
        };

        try {

            const response = await api.post('api/account/createuser', data)

            alert('Cadastrado com sucesso!. ')

            history('/');
        } catch (error) {
            alert('Não foi possível fazer o cadastro, verifique as informações. ' + error)
        }
    }

    return (
        <div className="cadastro-container">
            <section className="form">
                <img src={logoImage} alt="cadastro" id="img2" />
                <form onSubmit={cadastro}>
                    <h1>Cadastro</h1>

                    <input placeholder="Email"
                        value={email}
                        onChange={e => setEmail(e.target.value)}
                    />
                    <input type="password" placeholder="Password"
                        value={password}
                        onChange={e => setPassword(e.target.value)}
                    />
                    <input type="password" placeholder="Confirm Password"
                        value={confirmPassword}
                        onChange={e => setConfirmPassword(e.target.value)}
                    />
                    <button class="button" type="submit">Cadastro</button>
                    <Link className="back-link" to="/">
                        <FiCornerDownLeft size="25" color="#17202a" />
                    </Link>
                </form>
            </section>
        </div>
    )
}
