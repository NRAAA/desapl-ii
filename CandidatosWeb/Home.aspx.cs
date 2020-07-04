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
        }

        private void setUpGridView()
        {
            this.gvTop5.DataSource = servicioAlumno.ConsultarTopCincoAlumnos();
            this.gvTop5.DataBind();
        }

        protected void btnTop5_Click(object sender, EventArgs e)
        {
            
            setUpGridView();
            

            if (secondClick)
            {
                secondClick = false;
                this.gvTop5.Visible = false;
            }
            else
            {
                secondClick = true;
                this.gvTop5.Visible = true;
            }
        }
        
    }
}