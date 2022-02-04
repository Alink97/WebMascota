using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebMascota
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIniListar_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/Mascotas.aspx");
        }

        protected void btnIniAgregar_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/Agregar.aspx");
        }
    }
}