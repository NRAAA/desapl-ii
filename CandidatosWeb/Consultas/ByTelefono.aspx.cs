using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CandidatosWeb.Consultas
{
    public partial class ByTelefobo : System.Web.UI.Page
    {
        ServiceAlumno.ServicioAlumnoClient servicioAlumno = new ServiceAlumno.ServicioAlumnoClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void setUpGridView()
        {
            String tel = this.tbTel.Text;

            if (tel.Equals(""))
            {

            }
            else
            {
                this.gvAlumno.DataSource = servicioAlumno.ConsultarAlumnoPorTelefono(tel);
                this.gvAlumno.DataBind();
            }

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            setUpGridView();
        }
    }
}