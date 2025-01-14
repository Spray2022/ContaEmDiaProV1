# ContaEmDiaProV1
ContaEmDia
ContaEmDia é uma aplicação de contabilidade financeira desenvolvida com ASP.NET Core 9.0 e SQL Express, voltada para gestão de faturas, contas a pagar, contas a receber, plano de contas e relatórios financeiros. O sistema também oferece suporte a padrões contábeis e integração com ficheiros SAFT, atendendo à legislação Angolana.
________________________________________
Funcionalidades
•	Gestão Financeira: 
o	Plano de Contas com classes, contas e subcontas.
o	Locação de transações com partidas dobradas (débito e crédito).
o	Controle de saldos acumulados em contas.
•	Faturas e Pagamentos: 
o	Emissão de faturas.
o	Controle de contas a pagar e a receber.
•	Relatórios Personalizados: 
o	Relatórios financeiros e de gestão.
o	Geração de ficheiros SAFT.
•	Gestão de Usuários: 
o	Autenticação e autorização usando Identity.
o	Múltiplos níveis de acesso para Admins e Usuários.
________________________________________
Tecnologias Utilizadas
•	Back-end: ASP.NET Core 9.0
•	Banco de Dados: SQL Express
•	Frontend: Razor Pages com Bootstrap
•	Controle de Versão: Git
•	Ficheiros de Integração: SAFT
________________________________________
Instalação e Configuração
1. Requisitos
•	IDE: Visual Studio 2022
•	Banco de Dados: SQL Server Express
•	SDK: .NET 9.0

2. Clonar o Repositório
Execute o comando abaixo para clonar o repositório:   
User:    
Senha:

git clone
https://github.com/Spray2022/ContaEmDiaProV1.git
4. Configurar a Base de Dados
1.	Abra o projeto no Visual Studio 2022.
2.	Edite o arquivo appsettings.json para incluir a string de conexão do banco de dados.
3.	Execute o comando para aplicar as migrações: 
4.	dotnet ef database update




4. Executar o Projeto
No Visual Studio, pressione F5 para iniciar a aplicação.
________________________________________
Como Contribuir
1. Reporte Problemas
Use a aba Issues para relatar bugs ou sugerir melhorias.
2. Solicite Mudanças
•	Crie um fork do repositório.
•	Crie um branch para sua alteração: 
•	git checkout -b minha-alteracao
•	Envie suas mudanças: 
•	git add .
•	git commit -m "Descrição da alteração"
•	git push origin minha-alteracao
•	Abra um Pull Request explicando suas mudanças.
________________________________________
Licença
Este projeto é licenciado sob a MIT License.
________________________________________
Contato
•	Autor: Nekrumah Campos
•	Email: nekrumah.c2@hotmail.com 
•	LinkedIn: www.linkedin.com/in/jesus-spray
