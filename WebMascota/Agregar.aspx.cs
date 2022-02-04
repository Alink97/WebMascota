using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebMascota.Models;
using WebMascota.Repositorys;

namespace WebMascota
{
    public partial class Agregar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnNewMascota_Click(object sender, EventArgs e)
        {
            Conexion conn = new Conexion();
            Mascota mascota = new Mascota();
            mascota.name = tbNewNombre.Text;
            mascota.edad = int.Parse(tbNewEdad.Text);
            mascota.raza = tbNewRaza.Text;
            if(conn.Agregar(mascota) < 1)
            {

            }

            tbNewNombre.Text = "";
            tbNewEdad.Text = "";
            tbNewRaza.Text = "";
        }
    }
}