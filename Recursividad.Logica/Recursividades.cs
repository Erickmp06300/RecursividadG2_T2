using System;
using System.Collections.Generic;
using System.Text;

namespace Recursividad.Logica
{
    public class Recursividades
    {
        public int CalculcularFcatorial( int num )
        {
            // caso base ode salida 

            if (num == 1) { return 1; }

            // caso general 

            return  num * CalculcularFcatorial(num - 1);



        }

    }
}
