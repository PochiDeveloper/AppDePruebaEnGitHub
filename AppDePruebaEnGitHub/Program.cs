//Realizando suma mediante uso de clases;
using AppDePruebaEnGitHub.ClasesDeCalculadora;

Console.WriteLine("Insert el primer numero: ");
double n1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Insert el segundo numero: ");
double n2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("==========================");
Console.WriteLine("Calculadora");
Console.WriteLine("==========================");
Console.WriteLine("1. Suma.");
Console.WriteLine("2. Resta.");
Console.WriteLine("3. Multiplicar.");
Console.WriteLine("4. Dividir.");
Console.WriteLine("==========================");
Console.WriteLine("Insert el numero de la opcion: ");
int opt = Convert.ToInt32(Console.ReadLine());

double result = 0;

//Instancia de la clase Calculos;
Calculos calculos = new Calculos();

switch (opt) 
{
    //Suma
    case 1:
        result = await calculos.suma(n1, n2);
        break;
    //Resta
    case 2:
        result = await calculos.resta(n1, n2);
        break;
    //Mult.
    case 3:
        result = await calculos.mult(n1, n2);
        break;
    //Div.
    case 4:
        result = await calculos.div(n1, n2);
        break;
}

Console.WriteLine($"Resultado: {result}");
