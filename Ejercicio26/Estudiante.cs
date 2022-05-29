using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio26
{
    internal interface Estudiante 
    {
 

        public int NotaFinal(int nota)
        {
            if(nota < 5)
            {
                return 0;
            }else
            return 10;
            
        }

        public String Recomendacion()
        {
           return "empresa milloneti";
        }

      



    }
}
