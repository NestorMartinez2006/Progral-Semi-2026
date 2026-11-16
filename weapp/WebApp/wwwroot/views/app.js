var formActivo = "";

document.addEventListener("DOMContentLoaded", e => {
    mnxAcademica.addEventListener("click", event => {
        event.preventDefault();
        if (event.target.dataset.form) {
            abrirVentana(event.target.dataset.form);
        }
    });
});

function abrirVentana(form) {
    let $ventana = $(`#${form}`);

    $(".position-absolute").css("z-index", 1);
    $ventana.css("z-index", 100);

    if ($ventana.find("form").length > 0) {
        $ventana.show();
        if (form === 'busqueda_alumno' && typeof listarAlumnos === 'function') {
            listarAlumnos();
        }
    } else {
        let url = `/views/${form}.html`;
        fetch(url).then(resp => resp.text()).then(vista => {
            $ventana.html(vista).draggable().show();
            cerrarVentana();
        });
    }
}

function cerrarVentana() {
    $('.btn-close').off('click').on('click', e => {
        const form = e.target.dataset.form;
        if (form) {
            $(`#${form}`).hide();
        }
    });
}

async function obtenerAlumnos(buscar = '') {
    const respuesta = await fetch(`/api/Alumnos/buscar?buscar=${buscar}`, {
        method: "GET",
        headers: { "Content-Type": "application/json" }
    }),
        alumnos = await respuesta.json();
    return alumnos;
}