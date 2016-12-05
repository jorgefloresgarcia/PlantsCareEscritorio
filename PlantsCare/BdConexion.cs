/*
 * Creado por SharpDevelop.
 * Usuario: Uknown
 * Fecha: 01/12/2016
 * Hora: 01:22 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using MySql.Data.MySqlClient;

namespace PlantsCare
{
	/// <summary>
	/// Description of BdConexion.
	/// </summary>
	public class BdConexion
	{
		public BdConexion()
		{
			MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "plantscare";
            
            
            MySqlConnection conn = new MySqlConnection(builder.ToString());
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO Usuarios (IDUsuario,Usuario,Password ) value (11,'JorgeFg','bien')";
            conn.Open();
            cmd.ExecuteNonQuery();
			
		}
	}
}
