using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd
{
    public class Agregar
    {
        public String nombre { get; set; }
        public int precio { get; set; }

        public int codigo { get; set; } 

        public void AgregarPro(int acodigo, String aNombre, String aPrecio)
        {
            nombre = aNombre;
            precio = Convert.ToInt32(aPrecio);
            codigo = Convert.ToInt32(acodigo);
        }
    }
}
