﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CandidatosWeb.Consultas
{
    public partial class ByCorreo : System.Web.UI.Page
    {
        ServiceAlumno.ServicioAlumnoClient servicioAlumno = new ServiceAlumno.ServicioAlumnoClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void setUpGridView()
        {
            String correo = this.tbCorreo.Text;

            if (correo.Equals(""))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alert", "alert('Por favor, ingresa un correo');", true);
            }
            else
            {
                this.gvAlumno.DataSource = servicioAlumno.ConsultarAlumnoPorCorreo(correo);
                this.gvAlumno.DataBind();
                if (this.gvAlumno.Rows.Count == 0)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alert", "alert('No se hallaron resultados');", true);
                }
                
            }

        }

        protected void btnCorreo_Click(object sender, EventArgs e)
        {
            setUpGridView();
        }
    }
}