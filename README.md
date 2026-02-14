# Prueba Técnica: .NET y Tecnologías Relacionadas
# Este repositorio contiene la resolución de la prueba de conocimientos y aptitudes técnicas para el perfil de Desarrollador .NET

# Contenido:
Consumo de API:

Este proyecto integra:

Diseño de base de datos relacional en SQL Server

Aplicación de consola en C# (.NET)

Consultas SQL solicitadas

Sistema de logs

Página web que consume una API pública usando fetch

Separación por capas y archivos

## Base de Datos (SQL Server)
Tablas creadas

Catálogos

PROYECTO (IdProyecto, Nombre)

PRODUCTO (IdProducto, Nombre)

TIPO (IdTipo, Nombre)

TIPO_INFORMACION (IdTipoInfo, Nombre)

Operativas

PROYECTO_PRODUCTO (IdProyecto, IdProducto)

FORMATO_MENSAJE (IdFormato, IdTipo, IdTipoInfo, Nombre, Remitente, Asunto)

MENSAJE (IdMensaje, IdFormato, IdProyecto, IdProducto)

Con:

Llaves primarias

Llaves foráneas

Integridad referencial
Consultas SQL realizadas

Productos asignados al proyecto 1
Mensajes asignados al producto 2
Mensajes no asignados al producto 3
Productos no asignados al proyecto 2

## Aplicación en C# (Consola)
Funcionalidades:

-Conexión a SQL Server mediante cadena de conexión
-Clase genérica para ejecutar:

SELECT → devuelve DataSet

INSERT, UPDATE, DELETE → devuelve filas afectadas
5. Página Web – Consumo de API

Se creó una aplicación web que consume la API pública:

https://rickandmortyapi.com/

Funcionalidades:

Mostrar personajes
Mostrar episodios
Mostrar ubicaciones
Búsqueda por nombre