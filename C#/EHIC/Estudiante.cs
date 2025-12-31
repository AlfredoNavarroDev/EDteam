namespace EHIC;

public class Estudiante(string nombre, string apellido, int edad, string carrera)
    : Persona(nombre, apellido, edad), IEvaluable, INotificable
{
    public string Carrera
    {
        get => field;
        set => field = string.IsNullOrEmpty(value) ? "Sin Carrera" : value.Trim();
    } = carrera.Trim();
    
    private readonly List<double> _calificaciones = [];

    public void AgregarCalificacion(double nota)
    {
        if(nota >= 0 && nota <= 20)
        {
            _calificaciones.Add(nota);
        }
    }


    public override string ObtenerInfo()
    {
        return $"{base.ObtenerInfo()} | {Carrera} | Promedio: {ObtenerPromedio():F2}";
    }
    
    // Implementación de IEvaluable
    public double ObtenerPromedio() => _calificaciones.Count > 0 ? Math.Round(_calificaciones.Average(), 2) : 0.0;

    public string ObtenerEstado() => ObtenerPromedio() switch
        {
            >= 14 => "Aprobado",
            >= 10 => "Regular",
            _ => "Desaprobado"
        };

    public void EnviarNotificacion(string mensaje)
    {
        Console.WriteLine($"{Nombre}: {mensaje}");
    }
}