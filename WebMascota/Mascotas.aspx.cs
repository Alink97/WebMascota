using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebMascota.Repositorys;
using System.Net.Http;
using WebMascota.Models;

namespace WebMascota
{
    public partial class Mascotas : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Conexion conn = new Conexion();
            listadoMascotas.DataSource = conn.Listar();
            listadoMascotas.DataBind();
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            int indexOfColumn = 0;
            if (e.Row.Cells.Count > indexOfColumn)
            {
                e.Row.Cells[indexOfColumn].Visible = false;
            }
        }
    }
}