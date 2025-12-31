using EHIC;

var persona = new Persona("Alfredo", "Navarro", 19);
Console.WriteLine($"Público: {persona.Nombre} {persona.Apellido}");
Console.WriteLine($"Privado con getter público: {persona.Id}");
Console.WriteLine($"Interno: {persona.CodigoInterno}");
Console.WriteLine($"No se puede acceder a: persona._id (privado) y persona.Edad (protegido)");

Estudiante estudiante1 = new Estudiante("Alfredo", "Navarro", 19, "Ing. Software Backend");
Estudiante estudiante2 = new Estudiante("Aldy", "Montoya", 19,"Ing. Software Fullstack");
Estudiante estudiante3 = new Estudiante("Leonardo","Olortegui", 18,"Ing. Software Frontend");

estudiante1.AgregarCalificacion(18);
estudiante1.AgregarCalificacion(16);
estudiante1.AgregarCalificacion(19);

estudiante2.AgregarCalificacion(12);
estudiante2.AgregarCalificacion(13);

estudiante3.AgregarCalificacion(15);
estudiante3.AgregarCalificacion(17);

Console.WriteLine(estudiante1.ObtenerInfo());
Console.WriteLine(estudiante2.ObtenerInfo());
Console.WriteLine(estudiante3.ObtenerPromedio());
Console.WriteLine(estudiante1.ObtenerEstado());

estudiante1.EnviarNotificacion("Hola profesor");

Profesor profesor = new Profesor("Juan", "Leon", 40, "Móviles");

profesor.EnviarNotificacion("Hola a ustedes alumnos");
profesor.AsignarCurso("Programación en Móviles en Android");
profesor.AsignarCurso("Programación en Móviles en ios");
Console.WriteLine(profesor.ObtenerInfo());