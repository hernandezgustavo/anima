using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IdentidadSecreta
{
    public partial class RevelarIdentidad : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            //urlImagen={0}&nombreSuperheroe={1}&profesionPublica={2}&superpoder={3}
            if (!IsPostBack)
            {
                CargarDatos();
            }
        }

        private void CargarDatos()
        {
            string urlImagen = Request.QueryString["urlImagen"];
            string nombreSuperheroe = Request.QueryString["nombreSuperheroe"];
            string profesionPublica = Request.QueryString["profesionPublica"];
            string superpoder = Request.QueryString["superpoder"];
            string apellidoSuperheroe = Request.QueryString["apellidoSuperheroe"];

            lblNombre.Text = nombreSuperheroe;
            lblProfesion.Text = profesionPublica;
            lblSuperpoder.Text = superpoder;
            lblApellido.Text = apellidoSuperheroe;
            imgSuperheroe.ImageUrl = urlImagen;
        }

    }
}