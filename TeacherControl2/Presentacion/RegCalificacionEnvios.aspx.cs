﻿﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace RegEstudiantes.Presentacion
{
    public partial class RegCalificacionEnvios : System.Web.UI.Page
    {
        EnviosTareas envio = new EnviosTareas();
        string link;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request.QueryString["IdEnvio"] != null)
            {
                int id = int.Parse(Request.QueryString["IdEnvios"]);
                IdEnvioTextBox.Text = id.ToString();
                Buscar(id);
            }
        }

        bool Buscar(int id)
        {
            bool envio = false;

            return envio;
        }

        protected void DescargarLinkButton_Click(object sender, EventArgs e)
        {
            Response.Redirect(link);
        }

        protected void RigthImageButton_Click(object sender, ImageClickEventArgs e)
        {
            
        }

        protected void LeftImageButton_Click(object sender, ImageClickEventArgs e)
        {
            
        }

        protected void CalificarButton_Click(object sender, EventArgs e)
        {

        }
    }
}