# desapl-ii
Final Project

[Integrantes]

-Flavia Estefanía Figueroa Castillo
-Nicolás Rojas Artadi

[Métodos]

IMPORTANTE: Todos los métodos poseen validación y mensaje amigable al front para avisar en todo caso se ingrese un campo null o vacío ("").

(ServicioAlumno)
-->Información General del Alumno

-ConsultarAlumnoPorDni
-->Devuelve La Información del Alumno al buscarla por Dni
<Datos de Prueba>
"62099547", "16696463", "42972788", "19329100"

--ConsultarAlumnoPorTelefono
-->Devuelve La Información del Alumno al buscarla por Número de Teléfono
<Datos de Prueba>
"973546958", "909152013", "911014646", "968270879"

--ConsultarAlumnoPorCorreo
-->Devuelve La Información del Alumno al buscarla por Dirección de Correo Electrónico
<Datos de Prueba>
"rosssatell@gmail.com", "josemanuel2153@gmail.com", "nataliprados@gmail.com", "samualbert@outlook.com"

--ConsultarAlumnoPorNombreApellido
-->Devuelve Lista de Alumnos que cumplan con incluir cadena ingresada en campos Nombre o Apellido
<Datos de Prueba> (Ingresar sin comillas "")
"Natalia", "Salvador", "Barreto", "Jove"
//Ingresar " " (Espacio en Blanco) para obtener listado completo.


<--------------------------------------------->


(ServicioEstudio)
-->Información sobre Notas / Asistencia / Proyectos del Alumno

-ConsultarNotasAlumno
-->Devuelve las notas por Actividad(Tarea o Proyecto), comentarios del profesor e información sobre la Actividad (Titulo, Tema, Descripción) al buscar por Dni.
<Datos de Prueba>
"62099547", "16696463", "50711637", "40733642"

-ConsultarPorcentajeInasistenciaAlumno
-->Devuelve el porcentaje de Inasistencia (de todas las clases) al buscar por Dni
<Datos de Prueba> 
"62099547", "83212052"(No tiene inasistencias, devuelve 0%), "25024747", "42972788"

-ConsultarPromedioPorCursoAlumno
-->Devuelve las notas promedio por curso al buscar por Dni
<Datos de Prueba>
"83212052", "25024747", "62099547", "68703332"


<--------------------------------------------->


(ServicioUbigeo)
--> Información sobre el ubigeo por departamentos / distritos / provincias

-GetDepartamentos
--> Devuelve la lista de departamentos con el idDepartamento y nombre del departamento en cada uno
<Datos de Prueba>(Solo invocar el método)

-GetProvincias
--> Devuelve la lista de provincias en un departamento con el idProvincia y nombre de la provincia en cada uno.
<Datos de Prueba>
"idDepa": 20 [Hace referencia al departamento de Puno]

-GetDistritos
--> Devuelve la lista de distritos en una provincia con el idDistrito y nombre del distrito en cada uno.
<Datos de Prueba>
"idDepa": 20 [Hace referencia al departamento de Puno]
"idProvincia": 02 [Hace referencia a la provincia de Azangaro]
