using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_Entidades
{
   public class Producto
    {
        public string codigoPro { get; set; }
        public string descripcion { get; set; }
        public string existencia { get; set; }
        public string precio { get; set; }
        public string imagenpro { get; set; }

        public Producto()
        {

        }

        public Producto(string codigoPro, string descripcion, string existencia, string precio, string imagenpro)
        {
            this.codigoPro = codigoPro;
            this.descripcion = descripcion;
            this.existencia = existencia;
            this.precio = precio;
            this.imagenpro = imagenpro;
        }
    }
}
