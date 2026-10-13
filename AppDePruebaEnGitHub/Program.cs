//Realizando suma mediante uso de clases;
using AppDePruebaEnGitHub.ClasesDeCalculadora;

Console.WriteLine("Insert el primer numero: ");
double n1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Insert el segundo numero: ");
double n2 = Convert.ToDouble(Console.ReadLine());

//Instancia de la clase Calculos;
Calculos calculos = new Calculos();

Console.WriteLine($"Resultado: {await calculos.suma(n1, n2)}");

