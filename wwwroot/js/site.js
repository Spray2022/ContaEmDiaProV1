// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    getTree(); // Chama a função para carregar os dados e renderizar a árvore
});

function getTree() {
    var treeData = [];

    // Chama a API para obter os dados do Plano de Contas
    $.getJSON('/PlanoDeContas/GetPlanoDeContas', function (data) {
        treeData = data;
        // Inicializa o treeview após os dados serem carregados
        $('#treeview').treeview({
            data: treeData,
            showIcon: true,
            showBorder: false,
            expandIcon: 'fa fa-plus',
            collapseIcon: 'fa fa-minus',
            emptyIcon: 'fa fa-file'
        });
    }).fail(function (xhr, status, error) {
        console.error("Erro ao carregar o plano de contas:", error);
    });
}
