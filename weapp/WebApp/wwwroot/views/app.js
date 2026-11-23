var formActivo = "";

window.obtenerDatos = async function obtenerDatos(buscar = "", form = "Alumnos") {
    const termino = encodeURIComponent(String(buscar ?? "").trim());
    const candidatos =
        form === "Alumnoes" || form === "Alumnos"
            ? ["/api/Alumnos/buscar", "/api/Alumnoes/buscar"]
            : form === "Materias" || form === "Materia"
                ? ["/api/Materias/buscar", "/api/Materia/buscar"]
                : [`/api/${form}/buscar`];

    for (const base of candidatos) {
        const respuesta = await fetch(`${base}?buscar=${termino}`, {
            method: "GET",
            headers: { "Content-Type": "application/json" }
        });
        if (respuesta.ok) {
            const texto = await respuesta.text();
            return texto ? JSON.parse(texto) : [];
        }
    }

    return [];
};

document.addEventListener("DOMContentLoaded", () => {
    const menu = document.getElementById("mnxAcademica");
    if (menu) {
        menu.addEventListener("click", event => {
            const target = event.target.closest("[data-form]");
            if (!target) return;
            event.preventDefault();
            abrirVentana(target.dataset.form);
        });
    }
});

async function abrirVentana(form) {
    if (!form) return;
    formActivo = form;
    const $ventana = $(`#${form}`);
    if ($ventana.length === 0) return;

    if ($ventana.find("form").length > 0) {
        $ventana.show();
        return;
    }

    const resp = await fetch(`/views/${form}.html`);
    if (!resp.ok) return;

    const vista = await resp.text();
    $ventana.html(vista);
    if (typeof $ventana.draggable === "function") {
        $ventana.draggable();
    }
    $ventana.show();
    cerrarVentana();
}

function cerrarVentana() {
    $(".btn-close").off("click").on("click", e => {
        const form = e.target.dataset.form;
        if (form) {
            $(`#${form}`).hide();
        }
    });
}

window.abrirVentana = abrirVentana;
window.cerrarVentana = cerrarVentana;