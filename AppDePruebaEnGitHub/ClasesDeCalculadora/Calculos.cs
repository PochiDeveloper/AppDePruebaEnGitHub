using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDePruebaEnGitHub.ClasesDeCalculadora
{
    public class Calculos
    {
        public async Task<double> suma(double n1, double n2) 
        {
            await Task.Delay(100);
            return n1 + n2;
        }
        public async Task<double> resta(double n1, double n2)
        {
            await Task.Delay(100);
            return n1 - n2;
        }
        public async Task<double> mult(double n1, double n2)
        {
            await Task.Delay(100);
            return n1 * n2;
        }
        public async Task<double> div(double n1, double n2)
        {
            double result = 0;
            await Task.Delay(100);
            if (n1 == 0)
            {
                Console.WriteLine("No se puede dividir entre 0");
            }
            else
            {
                result = n1 / n2;
            }
            return result;

        }
    }
}
