### ⚠️ Em desenvolvimento.
<br>

<h1 style="font-weight:bold">📘 Sobre</h1>
<p>
   Um projeto simples criado com o objetivo de consumir a api com react. O projeto consiste em um cadastro de 
   alunos, onde da para fazer os principais Crud da aplicação, deletar, atualizar e criar.
</p> 

<br>

<div class="imagens">

   <div class="Front">
      <h1 style="font-weight:bold">📌 FrontEnd</h1>
      <ul>
         <li>Essa visão que irá ter ao fazer alguma requisição com react.</li>
      </ul>
      <div align="center">
         <img width="900px" alt="Cadastro de Alunos" title="Gif Readme" src="Assets/Cadastro_de_alunos.png" />
         <img width="900px" alt="Criar novo aluno" title="Gif Readme" src="Assets/Criar_novo_aluno.png" />
         <img width="900px" alt="Editar Aluno" title="Gif Readme" src="Assets/Modal_editar.png" />
         <img width="900px" alt="Deletar Aluno" title="Gif Readme" src="Assets/Modal_Excluir.png" />
      </div>
   </div>

   <br>

   <div class="Swagger">
      <h1 style="font-weight:bold">📌 API de Alunos</h1>
       <ul>
         <li>Todos os endipoints do microsserviço Estão protegidos</li>
         <li>Foi criado um controller para se registrar e fazer login, assim, tendo acesso aos endpoints.</li>
      </ul>
      <div align="center">
         <img width="900px" alt="Readme" title="Gif Readme" src="Assets/Swagger.png"/>
      </div> 
   </div>

   <br>
</div>
<hr>

<br>

 > Pré-requisitos:

+ Sql server
+ node js
+ Dotnet 6


## Como rodar?

> Instruções para rodar no back.

No arquivo **_appsettings_** da api, precisa mudar a string de conexão do banco de dados na parte chamada **_"DefaultConnection"-**. Depois da conexão com o bando de dados estiver finalizada, abra o terminal do projeto e digite o seguinte comando abaixo:<br/>
Este comando vai ser responsável por atualizar seu banco de dados e colocar uma pequena carga inicial nele.

```
dotnet ef database update
```

> Instruções para rodar front.

Abra um terminal no VsCode, digite o comando abaixo para instalar os pacotes do projeto 

```
npm install
```
Depois de tudo instalado e configurado, coloca o back para rodar e depois o front.
