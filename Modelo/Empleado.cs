using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Web.UI.WebControls;
using System.Data;

namespace Modelo
{


    public class Empleado
    {

        ConexionBD conectar;
         
        private DataTable drop_puesto()
        {
            DataTable tabla= new DataTable();
            conectar= new ConexionBD();
            conectar.AbrirConexion();
            string consulta = string.Format("select id_puesto as ID, puesto from puestos;");
            MySqlDataAdapter query = new MySqlDataAdapter(consulta, conectar.conectar);
            query.Fill(tabla);
            conectar.CerrarConexion();
            return tabla;   
        }

        private DataTable grid_Empleados() 
        {
            DataTable tabla = new DataTable();
            conectar = new ConexionBD();
            conectar.AbrirConexion();
            string consulta = string.Format("SELECT e.id_empleados as ID, e.codigo, e.nombre,e.apellidos, e.direccion, e.telefono, e.fecha_nacimiento, p.puesto, e.id_puesto\r\nFROM empleados as e inner join puestos as p on e.id_puesto=p.id_puesto;");
            MySqlDataAdapter query = new MySqlDataAdapter(consulta, conectar.conectar);
            query.Fill(tabla);
            conectar.CerrarConexion();
            return tabla;
        }

        public void drop_puesto(DropDownList drop)
        {
            drop.ClearSelection(); //Limpiamos lo seleccionado
            drop.Items.Clear(); //Quitamos todos los items
            drop.AppendDataBoundItems = true; //Limpia el control como el objeto logico del control.
            drop.Items.Add("<<Elige Puesto>>");
            drop.Items[0].Value = "0";
            drop.DataSource = drop_puesto();
            drop.DataTextField= "puesto"; //El enunciado
            drop.DataValueField= "id"; //el valor
            drop.DataBind();
        }

        public void grid_empleados(GridView grid)
        {
            grid.DataSource = grid_Empleados();
            grid.DataBind(); 
        }
    }
}
