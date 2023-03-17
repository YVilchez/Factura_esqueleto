using Biblio_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Biblio_Datos
{
   public class UsuarioBDD
    {
        //Cadena de conexion BDD servidor 
       readonly string cadena = "server=localhost; user=root; database=factura; password=1234;";
        //MEtodos para interactuar

        public Usuario Autenticar(Login login)
            {
            //Capturar errores
            Usuario user = null;
            try
            {
                //ARMAR sentencia SQL 
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT * FROM usuario WHERE CodigoUsuario = @CodigoUsuario AND Contrase = @Contrase;");

                //al salir de la ejecucion cierra 

                using (MySqlConnection _conexion = new MySqlConnection(cadena) )
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;
                        comando.Parameters.Add("@CodigoUsuario",MySqlDbType.VarChar, 50).Value = login.CodigoUsuario;
                        comando.Parameters.Add("@Contrase", MySqlDbType.VarChar, 80).Value = login.Contra;

                        //Ejecutar sentencia traer datos
                        MySqlDataReader dr = comando.ExecuteReader();
                        if (dr.Read())
                        {
                            user = new Usuario();
                            user.CodigoUsuario = dr["CodigoUsuario"].ToString();
                            user.Nombre = dr["Nombre"].ToString();
                            user.Contra = dr["Contrase"].ToString();
                            user.Correo = dr["Correo"].ToString();
                            user.Rol = dr["Rol"].ToString();
                            //if (dr["Foto"].GetType() != typeof(DBNull))
                            //{
                                user.Foto = (byte[])dr["Foto"];
                            //}

                            user.FechaCreacion = Convert.ToDateTime(dr["FechaCreacion"]);
                            user.EstadoActivo = Convert.ToBoolean(dr["EstadoActivo"]);

                        }
                    }
                }
               
            }
            
            catch (System.Exception ex)
            {

            }
            return user;
        }
    }
}
