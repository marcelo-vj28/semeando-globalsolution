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

// Dados mockados para a tabela
const mockData = {
    usuarios: [
        { idUsuario: 1, nome: "João Silva", email: "joao@email.com", ranking: "A", streak: 5, bio: "Dev" },
        { idUsuario: 2, nome: "Maria Santos", email: "maria@email.com", ranking: "B", streak: 3, bio: "Dev" }
    ],
    levels: [
        { idLevel: 1, titulo: "", descricao: "Introdução", dificuldade: "Iniciante" },
        { idLevel: 2, titulo: "Médio", descricao: "Médio", dificuldade: "Intermediário" }
    ],
    perguntas: [
        { idPergunta: 1, idLevel: 1, textoPergunta: "O que é sustentabilidade?", tipoPergunta: "Múltipla Escolha" },
        { idPergunta: 2, idLevel: 2, textoPergunta: "Como implementar energia sustentável?", tipoPergunta: "Múltipla Escolha" }
    ],
    opcoes: [
        { idPergunta: 1, idOpcao: 1, textoOpcao: "A", opcaoCorreta: true },
        { idPergunta: 1, idOpcao: 2, textoOpcao: "B", opcaoCorreta: false }
    ]
};

// Popula a tabela com os dados mockados
function populateTable() {
    const tbody = document.getElementById('userData');
    tbody.innerHTML = mockData.map(user => `
        <tr>
            <td>${user.id}</td>
            <td>${user.nome}</td>
            <td>${user.email}</td>
            <td>${user.ranking}</td>
            <td>${user.streak}</td>
            <td>${user.bio}</td>
        </tr>
    `).join('');
}

// Manipulação do formulário
function submitForm() {
    const form = document.getElementById('userForm');
    
    if (!form.checkValidity()) {
        event.preventDefault();
        event.stopPropagation();
        form.classList.add('was-validated');
        return;
    }

    const formData = {
        nome: document.getElementById('nome').value,
        email: document.getElementById('email').value,
        ranking: document.getElementById('ranking').value,
        streak: document.getElementById('streak').value,
        bio: document.getElementById('bio').value
    };

    // Aqui você adicionaria a lógica para enviar os dados para o backend
    console.log('Form submitted:', formData);
    alert('Usuário cadastrado com sucesso!');
    form.reset();
    form.classList.remove('was-validated');
}

// Inicialização
document.addEventListener('DOMContentLoaded', function() {
    // Popula a tabela inicial
    populateTable();

    // Adiciona validação do Bootstrap aos formulários
    const forms = document.querySelectorAll('.needs-validation');
    Array.prototype.slice.call(forms).forEach(function(form) {
        form.addEventListener('submit', function(event) {
            if (!form.checkValidity()) {
                event.preventDefault();
                event.stopPropagation();
            }
            form.classList.add('was-validated');
        }, false);
    });
});
