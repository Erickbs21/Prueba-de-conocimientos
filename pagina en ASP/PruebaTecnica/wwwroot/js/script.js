function validar() {
    // Obtener el valor del campo usuario
    let user = document.getElementById("usuario").value;

    // Obtener el valor del campo contraseña
    let pass = document.getElementById("password").value;

    // Validar que no estén vacíos
    if (user === "" || pass === "") {
        alert("Todos los campos son obligatorios");
        return false; // Evita que el formulario se envíe
    }

    // Si todo está correcto
    alert("Datos enviados correctamente");
    return true; // Permite enviar el formulario
}

function verPassword() {
    // Obtener el input de contraseña
    let pass = document.getElementById("password");

    // Cambiar entre tipo password y text
    if (pass.type === "password") {
        pass.type = "text"; // Muestra la contraseña
    } else {
        pass.type = "password"; // Oculta la contraseña
    }
}

