using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Web.UI.WebControls;
using System.Data;
using Mysqlx.Cursor;
using static Mysqlx.Crud.Order.Types;

namespace Modelo
{


    public class Empleado
    {

        ConexionBD conectar;

        private DataTable drop_puesto()
        {
            DataTable tabla = new DataTable();
            conectar = new ConexionBD();
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
            string consulta = string.Format("SELECT e.id_empleados as ID, e.codigo, e.nombre,e.apellidos, e.direccion, e.telefono, e.fecha_nacimiento, p.puesto, e.id_puesto\r\nFROM empleados as e inner join puestos as p on e.id_puesto=p.id_puesto order by e.id_empleados;");
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
            drop.DataTextField = "puesto"; //El enunciado
            drop.DataValueField = "id"; //el valor
            drop.DataBind();
        }

        public void grid_empleados(GridView grid)
        {
            grid.DataSource = grid_Empleados();
            grid.DataBind();
        }

        public int crear(string codigo, string nombres, string apellidos, string direccion, string telefono, string fecha, int id_puesto)
        {
            int no = 0;

            conectar = new ConexionBD();
            conectar.AbrirConexion();
            string consulta = string.Format("INSERT INTO empleados\r\n(codigo,nombre,apellidos,direccion,telefono,fecha_nacimiento,id_puesto) VALUES " +
                "('{0}','{1}','{2}','{3}','{4}','{5}',{6});", codigo, nombres, apellidos, direccion, telefono, fecha, id_puesto);
            MySqlCommand query = new MySqlCommand(consulta, conectar.conectar);
            query.Connection = conectar.conectar;
            no = query.ExecuteNonQuery();
            conectar.CerrarConexion();
            return no;

        }

        public int actualizar(int id,string codigo, string nombres, string apellidos, string direccion, string telefono, string fecha, int id_puesto)
        {
            int no = 0;

            conectar = new ConexionBD();
            conectar.AbrirConexion();
            string consulta = string.Format("UPDATE empleados SET codigo= '{0}',nombre ='{1}',apellidos='{2}',direccion='{3}',telefono='{4}',fecha_nacimiento='{5}',id_puesto={6} WHERE id_empleados={7};", codigo, nombres, apellidos, direccion, telefono, fecha, id_puesto,id);
            MySqlCommand query = new MySqlCommand(consulta, conectar.conectar);
            query.Connection = conectar.conectar;
            no = query.ExecuteNonQuery();
            conectar.CerrarConexion();
            return no;
        }


        public int borrar(int id)
        {
            int no = 0;

            conectar = new ConexionBD();
            conectar.AbrirConexion();
            string consulta = string.Format("DELETE FROM empleados WHERE id_empleados={0};", id);
            MySqlCommand query = new MySqlCommand(consulta, conectar.conectar);
            query.Connection = conectar.conectar;
            no = query.ExecuteNonQuery();
            conectar.CerrarConexion();
            return no;
        }

    }
}
