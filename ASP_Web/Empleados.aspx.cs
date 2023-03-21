using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Web
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Empleado empleado;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                empleado = new Empleado();
                empleado.drop_puesto(drop_puesto);
                empleado.grid_empleados(grid_empleados);
            }
        }

        protected void Btn_crear_Click(object sender, EventArgs e)
        {
            empleado = new Empleado();

            if (empleado.crear(txt_codigo.Text, txt_nombre.Text, txt_apellidos.Text, txt_direccion.Text, txt_telefono.Text, txt_fecha.Text, Convert.ToInt16(drop_puesto.SelectedValue)) > 0)
            {
                lbl_mensaje.Text = "Ingreso realizado con éxito";
                empleado.grid_empleados(grid_empleados);
            }
        }

        protected void grid_empleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_codigo.Text = grid_empleados.SelectedRow.Cells[2].Text; //cogemos la celda 2 porque en la 0 y 1 están los botones. la 2 es la de codigo
            txt_nombre.Text = grid_empleados.SelectedRow.Cells[3].Text;
            txt_apellidos.Text = grid_empleados.SelectedRow.Cells[4].Text;
            txt_direccion.Text = grid_empleados.SelectedRow.Cells[5].Text;
            txt_telefono.Text = grid_empleados.SelectedRow.Cells[6].Text;
            DateTime fecha=Convert.ToDateTime(grid_empleados.SelectedRow.Cells[7].Text); //Convertir de yyyy-mm-dd --> dd-mm-aaaa
            txt_fecha.Text=fecha.ToString("yyyy-MM-dd");
            int indice = grid_empleados.SelectedRow.RowIndex;
            drop_puesto.SelectedValue = grid_empleados.DataKeys[indice].Values["id_puesto"].ToString();
            Btn_actualizar.Visible = true;
        }

        protected void grid_empleados_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            empleado = new Empleado();

            if (empleado.borrar(Convert.ToInt32(e.Keys["id"]))>0)
            {
                lbl_mensaje.Text = "Borrado realizado con éxito";
                empleado.grid_empleados(grid_empleados);
            }
        }

        protected void Btn_actualizar_Click(object sender, EventArgs e)
        {
            empleado = new Empleado();

            if (empleado.actualizar(Convert.ToInt32(grid_empleados.SelectedValue),txt_codigo.Text, txt_nombre.Text, txt_apellidos.Text, txt_direccion.Text, txt_telefono.Text, txt_fecha.Text, Convert.ToInt16(drop_puesto.SelectedValue)) > 0)
            {
                lbl_mensaje.Text = "Modificación realizado con éxito";
                empleado.grid_empleados(grid_empleados);
            }
        }
    }
}