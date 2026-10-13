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
    }
}
