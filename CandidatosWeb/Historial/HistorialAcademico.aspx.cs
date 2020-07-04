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

        }

        private void setUpGridView()
        {
            String dni = this.tbDNI.Text;

            if (dni.Equals(""))
            {

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
        }
    }
}