import React from "react";
import { BrowserRouter, Route, Routes} from 'react-router-dom';
import Login from "./pages/Login";
import Alunos from "./pages/Alunos";
import NovoAluno from "./pages/NovoAluno";
import Cadastro from "./Cadastro";

export default function Rout() {
    return (
        <BrowserRouter>
            <Routes>
                <Route exact path="/" element={< Login/>} />
                <Route path="/alunos" element={< Alunos/>} />
                <Route path="/aluno/novo/:alunoId" element={< NovoAluno/>} />
                <Route path="/cadastro" element={< Cadastro/>} />
            </Routes>
        </BrowserRouter>
    );
}