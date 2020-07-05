using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CandidatosWeb
{
    public partial class Home : System.Web.UI.Page
    {
        ServiceAlumno.ServicioAlumnoClient servicioAlumno = new ServiceAlumno.ServicioAlumnoClient();

        Boolean secondClick = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            setUpGridView();
        }

        private void setUpGridView()
        {
            this.gvTop5.DataSource = servicioAlumno.ConsultarTopCincoAlumnos();
            this.gvTop5.DataBind();
        }
        
    }
}