using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MamiQueTuQuiere.Clases
{
    class Class_CicloH
    {
        public int Ciclos_Hamiltonianos(int aux)
        {
            int factorial = 1;
            int total1 = 0;
            for (int i = 1; i <= (aux - 1); i++)
            {
                factorial *= i;
            }

            total1 = factorial / 2;

            return total1;
        }
    }
}
