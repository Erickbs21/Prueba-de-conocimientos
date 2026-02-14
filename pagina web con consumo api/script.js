// Variables para los elementos del HTML
var inputNombre = document.getElementById('search-input');
var selectEstado = document.getElementById('status-filter');
var selectGenero = document.getElementById('gender-filter');
var contenedor = document.getElementById('characters-grid');

// Esta funcion busca los datos en la api de Rick y Morty
function buscarPersonajes() {
    
    // Agarro los valores de los filtros
    let nombre = inputNombre.value;
    let estado = selectEstado.value;
    let genero = selectGenero.value;

    console.log("Buscando a: " + nombre + " que este " + estado); // Para ver si funciona

    // Limpio el contenedor antes de poner los nuevos
    contenedor.innerHTML = "Cargando...";

   
    fetch('https://rickandmortyapi.com/api/character/?name=' + nombre + '&status=' + estado + '&gender=' + genero)
        .then(function(response) {
            return response.json();
        })
        .then(function(data) {
            // Si la API me devuelve resultados...
            if (data.results) {
                contenedor.innerHTML = ""; 
                
                // Recorro el array de personajes
                for (let i = 0; i < data.results.length; i++) {
                    let pj = data.results[i];
                    
                    
                    contenedor.innerHTML += `
                        <div class="card">
                            <img src="${pj.image}">
                            <div class="card-content">
                                <h3>${pj.name}</h3>
                                <p>Estado: ${pj.status}</p>
                                <p>Género: ${pj.gender}</p>
                                <p>Especie: ${pj.species}</p>
                            </div>
                        </div>
                    `;
                }
            } else {
                // Si no hay nada, pongo un error
                contenedor.innerHTML = "No se encontro nada con esos filtros :( intenta otra vez";
            }
        })
        .catch(function(error) {
            console.log("Rayos, algo salio mal: " + error);
            contenedor.innerHTML = "Error al conectar con el servidor";
        });
}

// Eventos para que busque cuando cambias algo
// Al escribir en el buscador
inputNombre.oninput = function() {
    buscarPersonajes();
};

// Al cambiar los selects
selectEstado.onchange = function() {
    buscarPersonajes();
};

selectGenero.onchange = function() {
    buscarPersonajes();
};

// Llamo a la funcion una vez al principio para que no este vacio
buscarPersonajes();