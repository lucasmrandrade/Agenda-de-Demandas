window.temaApp = {
    obterTema: function () {
        return localStorage.getItem("tema");
    },

    salvarTema: function (tema) {
        localStorage.setItem("tema", tema);

        // mantém o tema do <html> igual ao escolhido (evita o "flash" ao recarregar)
        document.documentElement.setAttribute("data-theme", tema === "claro" ? "light" : "dark");
    }
};