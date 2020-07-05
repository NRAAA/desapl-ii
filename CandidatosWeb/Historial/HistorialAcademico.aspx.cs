using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CandidatosWeb.Historial
{
    public partial class Historial_académico : System.Web.UI.Page
    {
        ServiceAlumno.ServicioAlumnoClient servicioAlumno = new ServiceAlumno.ServicioAlumnoClient();
        ServiceEstudio.ServicioEstudioClient servicioEstudio = new ServiceEstudio.ServicioEstudioClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && Session["dni"] != null)
            {
                this.tbDNI.Text = Session["dni"].ToString();
            }
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
                this.gvAlumno.DataSource = servicioAlumno.ConsultarAlumnoOcurrencias(dni);
                this.gvPromedioCurso.DataSource = servicioEstudio.ConsultarPromedioPorCursoAlumno(dni);
                this.gvPorcInas.DataSource = servicioEstudio.ConsultarPorcentajeInasistenciaAlumno(dni);
                this.gvNotas.DataSource = servicioEstudio.ConsultarNotasAlumno(dni);
                this.gvAlumno.DataBind();
                this.gvPromedioCurso.DataBind();
                this.gvPorcInas.DataBind();
                this.gvNotas.DataBind();
            }

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            setUpGridView();

            this.lblOcurrencias.Visible = true;
            this.lblPorcInas.Visible = true;
            this.lblPromCur.Visible = true;
            this.lblCalificacion.Visible = true;
        }
    }
}