﻿using System;


namespace Biblio_Entidades
{
    public class Usuario
    {
        public string CodigoUsuario { get; set; }
        public string Nombre { get; set; }
        public string Contra { get; set; }
        public string Correo { get; set; }

        public string Rol { get; set; }
        public byte[] Foto { get; set; }




        public DateTime FechaCreacion { get; set; }
        public bool EstadoActivo { get; set; }

        //Constructor vacio siempre
        public Usuario()
        {
        }

        public Usuario(string codigoUsuario, string nombre, string contra, string correo, string rol, byte[] foto, DateTime fechaCreacion, bool estadoActivo)
        {
            CodigoUsuario = codigoUsuario;
            Nombre = nombre;
            Contra = contra;
            Correo = correo;
            Rol = rol;
            Foto = foto;
            FechaCreacion = fechaCreacion;
            EstadoActivo = estadoActivo;
        }
    }
}
