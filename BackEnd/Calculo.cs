using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd
{
    public class Calculo
    {
        public int descuento;
        public decimal precio { get; set; }
        
        public decimal efectivoDes(int descuento, decimal precio)
        {
            descuento = Convert.ToInt32(precio) * 15 / 100;
            precio = precio - descuento;
            return precio;
        }

        public decimal tarjeta(decimal precio)
        {
            precio =precio * (11 / 10);

            return precio;
        }
    }
}
