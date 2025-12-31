namespace ClassObjectProperties;

public class Estudiante(int id, string nombres, string apellidos)
{
    public int Id { get; set; } = id;
    public string Nombres { get; set; } = nombres;
    public string Apellidos { get; set; } = apellidos;

    public List<string> Cursos { get; } = [];

    public string Email
    {
        get => string.IsNullOrWhiteSpace(field)
            ? $"{Nombres.ToLower()}.{Apellidos.ToLower()}@tecsup.edu.pe"
            : field;
        set => field = string.IsNullOrWhiteSpace(value)
            ? string.Empty
            : value.Trim().ToLower();
    } = string.Empty;

    public void AddCurso(string curso)
    {
        Cursos.Add(curso);
        Console.WriteLine($"El curso {curso} ha sido añadido a {Nombres} {Apellidos}");
    }

    public string ObtenerInfo() => $"{Id} - {Nombres} {Apellidos}";
    
    public string ObtenerCurso() => $"Cursos: {string.Join(", ", Cursos)}";
}
