using ClassObjectProperties;

Estudiante est1 = new Estudiante(111, "Alfredo", "Navarro");
Estudiante est2 = new Estudiante(222, "Aldy", "Montoya");

est1.AddCurso("Python");
est1.AddCurso("C#");
est2.AddCurso("Java");

Console.WriteLine($"{est1.ObtenerInfo()} {est1.ObtenerCurso()}");
Console.WriteLine($"{est2.ObtenerInfo()} {est2.ObtenerCurso()}");

Console.WriteLine($"{est1.Email}");
Console.WriteLine($"{est2.Email}");