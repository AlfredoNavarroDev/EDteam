namespace EHIC;

// Clase Persona con constructor primario (C# moderno)
// Recibe nombre, apellido y edad al crear el objeto
public class Persona(string nombre, string apellido, int edad)
{
    // 🔒 PRIVATE
    // Campo privado: solo accesible dentro de esta clase
    // Se genera un ID único automáticamente usando GUID
    private string _id = Guid.NewGuid().ToString();
    
    // 🌍 PUBLIC
    // Propiedades públicas: accesibles desde cualquier parte del programa
    // Se inicializan con los valores recibidos en el constructor
    public string Nombre { get; set; } = nombre;
    public string Apellido { get; set; } = apellido;
    
    // 🧬 PROTECTED
    // Solo accesible dentro de esta clase o en clases que hereden de Persona
    // No puede accederse directamente desde una instancia externa
    protected int Edad { get; set; } = edad;
    
    // 📦 INTERNAL
    // Accesible solo dentro del mismo proyecto (assembly)
    // Se genera un código interno basado en el tiempo actual
    internal string CodigoInterno { get; set; } = $"INT-{DateTime.Now.Ticks % 10000}";

    // 🔐 PUBLIC (solo lectura)
    // Expone el ID privado sin permitir que sea modificado
    // Aplica encapsulamiento
    public string Id => _id;
    
    // 🔁 VIRTUAL
    // Método que puede ser sobrescrito por clases hijas usando override
    // Devuelve información básica de la persona
    public virtual string ObtenerInfo() => $"{Nombre} {Apellido}, (ID: {Id})";
    
    // 🧬 PROTECTED
    // Método accesible solo por esta clase y sus clases hijas
    // Permite usar la edad sin exponerla públicamente
    protected string ObtenerEdad() => $"{Edad} años";
}