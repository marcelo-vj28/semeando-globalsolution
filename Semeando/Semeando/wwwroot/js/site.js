// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Gerenciamento de páginas
function showPage(pageId) {
    // Remove active class de todas as páginas e itens do menu
    document.querySelectorAll('.page').forEach(page => {
        page.classList.remove('active');
    });
    document.querySelectorAll('.menu-item').forEach(item => {
        item.classList.remove('active');
    });

    // Adiciona active class para a página e item do menu selecionados
    document.getElementById(pageId).classList.add('active');
    Array.from(document.querySelectorAll('.menu-item')).find(item => 
        item.textContent.toLowerCase() === pageId
    ).classList.add('active');
}

// Popula a tabela de usuários
function populateUsersTable() {
    const tbody = document.getElementById('usersData');
    tbody.innerHTML = mockData.usuarios.map(user => `
        <tr>
            <td>${user.idUsuario}</td>
            <td>${user.nome}</td>
            <td>${user.email}</td>
            <td>${user.ranking}</td>
        </tr>
    `).join('');
}

// Popula a tabela de levels
function populateLevelsTable() {
    const tbody = document.getElementById('levelsData');
    tbody.innerHTML = mockData.levels.map(level => `
        <tr>
            <td>${level.idLevel}</td>
            <td>${level.titulo || 'N/A'}</td>
            <td>${level.descricao}</td>
            <td>${level.dificuldade}</td>
        </tr>
    `).join('');
}

// Popula a tabela de perguntas
function populateQuestionsTable() {
    const tbody = document.getElementById('questionsData');
    tbody.innerHTML = mockData.perguntas.map(question => `
        <tr>
            <td>${question.idPergunta}</td>
            <td>${question.idLevel}</td>
            <td>${question.textoPergunta}</td>
            <td>${question.tipoPergunta}</td>
        </tr>
    `).join('');
}

// Manipulação do formulário de usuários
function submitUserForm(event) {
    event.preventDefault();

    const form = document.getElementById('userForm');

    if (!form.checkValidity()) {
        event.stopPropagation();
        form.classList.add('was-validated');
        return;
    }

    const formData = {
        idUsuario: mockData.usuarios.length + 1,
        nome: document.getElementById('nome').value,
        email: document.getElementById('email').value,
        ranking: document.getElementById('ranking').value,
    };

    mockData.usuarios.push(formData);
    populateUsersTable();

    alert('Usuário cadastrado com sucesso!');
    form.reset();
    form.classList.remove('was-validated');
}

// Inicialização
document.addEventListener('DOMContentLoaded', function () {
    // Popula as tabelas iniciais
    populateUsersTable();
    populateLevelsTable();
    populateQuestionsTable();

    // Adiciona validação e evento ao formulário de usuários
    const userForm = document.getElementById('userForm');
    userForm.addEventListener('submit', submitUserForm, false);
});

// Mock de dados
const mockData = {
    usuarios: [
        { idUsuario: 1, nome: "João Silva", email: "joao@email.com", ranking: "A" },
        { idUsuario: 2, nome: "Maria Santos", email: "maria@email.com", ranking: "B" },
    ],
    levels: [
        { idLevel: 1, titulo: "", descricao: "Introdução", dificuldade: "Iniciante" },
        { idLevel: 2, titulo: "Médio", descricao: "Médio", dificuldade: "Intermediário" },
    ],
    perguntas: [
        { idPergunta: 1, idLevel: 1, textoPergunta: "O que é sustentabilidade?", tipoPergunta: "Múltipla Escolha" },
        { idPergunta: 2, idLevel: 2, textoPergunta: "Como implementar energia sustentável?", tipoPergunta: "Múltipla Escolha" },
    ],
};

