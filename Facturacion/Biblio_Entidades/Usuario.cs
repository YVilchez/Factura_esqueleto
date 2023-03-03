using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_Entidades
{
    public class Usuario
    {
        public string codigoUsuario { get; set; }
        public string Nombre { get; set; }
        public string Contra { get; set; }
        public string Correo { get; set; }
        public string Rol { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool EstadoActivo { get; set; }

        //Constructor vacio siempre
        public Usuario()
        {
        }
        //Constructor todas entidades siempre
        public Usuario(string codigoUsuario, string nombre, string contra, string correo, string rol, DateTime fechaCreacion, bool estadoActivo)
        {
            this.codigoUsuario = codigoUsuario;
            Nombre = nombre;
            Contra = contra;
            Correo = correo;
            Rol = rol;
            FechaCreacion = fechaCreacion;
            EstadoActivo = estadoActivo;
        }
    }
}
