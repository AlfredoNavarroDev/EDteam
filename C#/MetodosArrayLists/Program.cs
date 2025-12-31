void Saludar(string nombre)
{
    Console.WriteLine($"Hola {nombre}");
}

Saludar("Alfredo");

int[] numeros = [12, 20, 41, 50];
string[] frutas = ["Manzana", "Plátano", "Naranja", "Uva"];

List<string> nombres = ["Ana", "Carlos", "María"];
nombres.Add("Pedro");

Console.WriteLine(string.Join(", ", nombres));

nombres.Insert(0, "José");

Console.WriteLine(string.Join(", ", nombres));

List<int> nums = [3,1,4,1,5,9,2,6];

nums.Sort();
Console.WriteLine(string.Join(", ", nums));