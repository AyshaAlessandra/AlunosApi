import React from "react";
import { Link } from "react-router-dom";
import './styles.css';

import { FiXCircle, FiEdit, FiUserX } from 'react-icons/fi'
import logoCadastro from '../../assets/cadastro1.png'

export default function Alunos() {
    return (
        <div className="aluno-container">
            <header>
                <img src={logoCadastro} alt="Cadastro" />
                <span>Bem-Vindo, <strong>Aysha</strong>!</span>
                <Link className="button" to="aluno/novo">Novo Aluno</Link>
                <button type="button">
                    <FiXCircle size={35} color='#17202a' />
                </button>
            </header>
            <form>
                <input type='text' placeholder="Nome" />
                <button type="button" class="button">
                    Filtrar aluno por nome (parcial)
                </button>
            </form>
            <h1>Relação de Alunos</h1>
            <ul>
                <li>
                    <b>Nome:</b> Aysha<br />
                    <b>Email:</b> aysha@gmail.com<br />
                    <b>Idade:</b> 21<br />
                    <button title="button">
                        <FiEdit size='25' color="#17202a" />
                    </button>
                    <button title="button">
                        <FiUserX size='25' color="#17202a" />
                    </button>
                </li>

                <li>
                    <b>Nome:</b> Aysha<br />
                    <b>Email:</b> aysha@gmail.com<br />
                    <b>Idade:</b> 21<br />
                    <button title="button">
                        <FiEdit size='25' color="#17202a" />
                    </button>
                    <button title="button">
                        <FiUserX size='25' color="#17202a" />
                    </button>
                </li>
            </ul>
        </div>
    )
}