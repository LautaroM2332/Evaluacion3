using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd
{
    
    public class Productos
    {
        public DataTable ListaPro { get; set; } = new DataTable();

        public Productos() 
        {
            ListaPro.TableName = "Lista de Productos";
            ListaPro.Columns.Add("Nombre");
            ListaPro.Columns.Add("Precio", typeof(int));
            ListaPro.Columns.Add("Código");
            LeerArchivo();
        }

        public void LeerArchivo()
        {
            if (System.IO.File.Exists("Precios.xml"))
            {
                ListaPro.ReadXml("Precios.xml");
            }
        }

        public void adicionar(Agregar agregar)
        {
            ListaPro.Rows.Add();//Renglon vacio
            int NuevoRenglon = ListaPro.Rows.Count - 1;

            ListaPro.Rows[NuevoRenglon]["Nombre"] = agregar.nombre;
            ListaPro.Rows[NuevoRenglon]["Precio"] = agregar.precio;
            ListaPro.Rows[NuevoRenglon]["Código"] = agregar.codigo;

            ListaPro.WriteXml("Precios.xml");
        }

    }
}
