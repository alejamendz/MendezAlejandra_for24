// See https://aka.ms/new-console-template for more information
Console.WriteLine("Pedir N notas y mostrar si el promedio es aprobado (>=61) o reprobado.");

Console.Write("¿Cuántas notas?: ");
int n = int.Parse(Console.ReadLine());
double suma = 0;

for (int i = 1; i <= n; i++)
{
    Console.Write("Ingrese nota: ");
    suma += double.Parse(Console.ReadLine());
}

double promedio = suma / n;

if (promedio >= 61)
    Console.WriteLine("Aprobado");
else
    Console.WriteLine("Reprobado");
