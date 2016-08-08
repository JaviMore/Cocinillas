using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocinillas
{
    public class Calorias
    {
       public static int calculaCalorias(int calorias, int cantidad){
          
           int resultado = calorias * cantidad;

           return resultado;
       }
    }
}
