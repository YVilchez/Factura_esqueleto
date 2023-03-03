namespace Biblio_Entidades
{
    public class Login
    {
        //Agregar PROPIEDADES
        public string CodigoUsuario { get; set; }
        public string Contra { get; set; }
       //Administrador / Usuario
        public string Rol { get; set; }


        //Desarmador, generar construcctor, quitar seleciones
        //se deja vacio para instanciar objeto siempre
        public Login()
        {
        }
        //Desarmador, generar construcctor, selecionar todas las opciones
        public Login(string codigoUsuario, string contra, string rol)
        {
            CodigoUsuario = codigoUsuario;
            Contra = contra;
            Rol = rol;
        }
    }
}
