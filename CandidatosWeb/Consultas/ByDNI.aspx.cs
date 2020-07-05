using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CandidatosWeb.Consultas
{
    public partial class ByDNI : System.Web.UI.Page
    {

        ServiceAlumno.ServicioAlumnoClient servicioAlumno = new ServiceAlumno.ServicioAlumnoClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void setUpGridView()
        {
            String dni = this.tbDNI.Text;

            if (dni.Equals(""))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alert", "alert('Por favor, ingresa un número de documento');", true);
            }
            else
            {
                Session["dni"] = dni;
                this.gvAlumno.DataSource = servicioAlumno.ConsultarAlumnoPorDni(dni);
                this.gvAlumno.DataBind();

                if (this.gvAlumno.Rows.Count == 0)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alert", "alert('No se hallaron resultados');", true);
                }else
                this.btnSee.Visible = true;
            }
            
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            setUpGridView();
        }
    }
}