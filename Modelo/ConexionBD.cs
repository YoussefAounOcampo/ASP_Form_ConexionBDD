using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Media;

namespace Modelo
{
    public class ConexionBD
    {
        private string cadena = "server=localhost;database=db_empresa; user=usr_empresa; password=Clave2DAM";
        public MySqlConnection conectar = new MySqlConnection();

        public void AbrirConexion()
        {
            try
            {

                conectar.ConnectionString = cadena;
                conectar.Open();
                // System.Diagnostics.Debug.WriteLine("Conexión realizada con éxito");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void CerrarConexion()
        {
            try
            {
                if (conectar.State == ConnectionState.Open)
                {
                    conectar.Close();
                    //System.Diagnostics.Debug.WriteLine("Conexión Cerrada con éxito");

                }


            }
            catch (Exception ex)
            {
                //System.Diagnostics.Debug.WriteLine("Error. " + ex.Message);
                Console.WriteLine(ex.Message);
            }
        }
    }
}
