Console.WriteLine("Condicionales");

int edad = 20;
if (edad >= 18)
{
    Console.WriteLine($"Edad {edad}: Mayor de edad");
}
else
{
    Console.WriteLine($"Edad {edad}: Menor de edad");
}

Console.WriteLine("Switch");

int dia = 3;
switch (dia)
{
    case 1: Console.WriteLine("El dia es Lunes"); break;
    case 2: Console.WriteLine("El dia es Martes"); break;
    case 3: Console.WriteLine("El dia es Miércoles"); break;
    case 4: Console.WriteLine("El dia es Jueves"); break;
    case 5: Console.WriteLine("El dia es Viernes"); break;
    case 6: Console.WriteLine("El dia es Sabado"); break;
    case 7: Console.WriteLine("El dia es Domingo"); break;
    default: Console.WriteLine("Día invalido"); break;
}

Console.WriteLine($"Bucle for");

for (int i_for = 1; i_for <= 5; i_for++)
{
    Console.WriteLine($"{i_for}");
}

int i_while = 1;

while (i_while <= 5)
{
    Console.WriteLine("i vale: " + i_while);
    i_while++;
}

int i_do_while = 1;

do
{
    Console.WriteLine("i vale: " + i_do_while);
    i_do_while++;
}
while (i_do_while <= 5);

string[] nombres = { "Ana", "Luis", "Carlos" };

foreach (string nombre in nombres)
{
    Console.WriteLine(nombre);
}
