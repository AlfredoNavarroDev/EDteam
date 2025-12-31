namespace EHIC;

public class Profesor(string nombre, string apellido, int edad, string especialidad)
    : Persona(nombre, apellido, edad), INotificable
{
    public string Especialidad {get; set;} = especialidad;
    public List<String> Cursos { get; } = [];
    
    public void AsignarCurso(string curso) => Cursos.Add(curso);

    public override string ObtenerInfo()
    {
        return $"{base.ObtenerInfo()} | {Especialidad} | Cursos: {Cursos.Count}";
    }
    
    public void EnviarNotificacion(string mensaje) => Console.WriteLine($"Prof. {Nombre}: {mensaje}");
}
