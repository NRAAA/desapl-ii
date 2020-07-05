using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CandidatosWeb.Consultas
{
    public partial class ByNomApe : System.Web.UI.Page
    {
        ServiceAlumno.ServicioAlumnoClient servicioAlumno = new ServiceAlumno.ServicioAlumnoClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void setUpGridView()
        {
            String nombre = this.tbNombre.Text;
            String apellido = this.tbApellido.Text;

            if (nombre.Equals("") || apellido.Equals(""))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alert", "alert('Por favor, completa ambos campos');", true);
            }
            else
            {

                this.gvAlumno.DataSource = servicioAlumno.ConsultarAlumnoPorNombreApellido(nombre, apellido);
                this.gvAlumno.DataBind();

                if (this.gvAlumno.Rows.Count == 0)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alert", "alert('No se hallaron resultados');", true);
                }
            }

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            setUpGridView();
        }
    }
}