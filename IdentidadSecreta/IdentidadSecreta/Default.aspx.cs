using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IdentidadSecreta
{
    public partial class _Default : Page
    {
        private static Dictionary<string, string> nombreSuperheroe;
        private static Dictionary<string, string> apellidoSuperheroe;
        private static Dictionary<string, string> mesProfesionIdeal;
        private static Dictionary<string, string> apellidoProfesionIdeal;
        private static Dictionary<string, string> nombreSuperpoder;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarDatos();
            }
        }

        private void CargarDatos()
        {
            InicializarDiccionarios();
            CargarNombresSuperHeroes();
            CargarApellidosSuperHeroes();
            CargarMesProfesionIdeal();
            CargarApellidoProfesionIdeal();
            CargarNombreSuperpoder();
        }

        private void InicializarDiccionarios()
        {
            nombreSuperheroe = new Dictionary<string, string>();
            apellidoSuperheroe = new Dictionary<string, string>();
            mesProfesionIdeal = new Dictionary<string, string>();
            apellidoProfesionIdeal = new Dictionary<string, string>();
            nombreSuperpoder = new Dictionary<string, string>();

        }

        private void CargarNombreSuperpoder()
        {
            nombreSuperpoder.Add("A", "Lágrimas de ácido");
            nombreSuperpoder.Add("B", "Invisibilidad en lo oscuro");
            nombreSuperpoder.Add("C", "Controlar el control");
            nombreSuperpoder.Add("D", "Comunicarse con las frutas");
            nombreSuperpoder.Add("E", "Detectar basura");
            nombreSuperpoder.Add("F", "75% de levitación");
            nombreSuperpoder.Add("G", "Encender lámparas");
            nombreSuperpoder.Add("H", "Atracción de balas");
            nombreSuperpoder.Add("I", "Leer tu propia mente");
            nombreSuperpoder.Add("J", "Caída de cabello instantánea");
            nombreSuperpoder.Add("K", "Crecimiento anormal de pelos");
            nombreSuperpoder.Add("L", "Atraer rayos");
            nombreSuperpoder.Add("M", "Superlentitud");
            nombreSuperpoder.Add("N", "Resucitar insectos");
            nombreSuperpoder.Add("O", "Envejecimiento ultra-rápido");
            nombreSuperpoder.Add("P", "Escritura invisible");
            nombreSuperpoder.Add("Q", "Superfuerza por 1 segundo");
            nombreSuperpoder.Add("R", "Transformarse en laptop");
            nombreSuperpoder.Add("S", "Seducir sombreros");
            nombreSuperpoder.Add("T", "Pintor de aire");
            nombreSuperpoder.Add("U", "Implantar recuerdos falsos");
            nombreSuperpoder.Add("V", "Reducir tu reflejos de reacción");
            nombreSuperpoder.Add("W", "Bajar del bus sin pasarte la parada");
            nombreSuperpoder.Add("X", "Reir de cualquier chiste");
            nombreSuperpoder.Add("Y", "Pescar bagres");
            nombreSuperpoder.Add("Z", "Atraer piedras");
        }

        private void CargarApellidoProfesionIdeal()
        {
            apellidoProfesionIdeal.Add("A", "Ardillas"); //
            apellidoProfesionIdeal.Add("B", "Pelos"); //
            apellidoProfesionIdeal.Add("C", "Top models");
            apellidoProfesionIdeal.Add("D", "Chumbos");
            apellidoProfesionIdeal.Add("E", "Pepinos"); //
            apellidoProfesionIdeal.Add("F", "Leones");
            apellidoProfesionIdeal.Add("G", "Unicornios");
            apellidoProfesionIdeal.Add("H", "Cangrejos"); //
            apellidoProfesionIdeal.Add("I", "Dinosaurios"); //
            apellidoProfesionIdeal.Add("J", "Papas"); //
            apellidoProfesionIdeal.Add("K", "Pokemón");
            apellidoProfesionIdeal.Add("L", "Políticos");
            apellidoProfesionIdeal.Add("M", "Dragones");
            apellidoProfesionIdeal.Add("N", "Aliens");
            apellidoProfesionIdeal.Add("O", "Folclóricas");
            apellidoProfesionIdeal.Add("P", "Almejas");
            apellidoProfesionIdeal.Add("Q", "Serpientes");
            apellidoProfesionIdeal.Add("R", "Perezosos");
            apellidoProfesionIdeal.Add("S", "Zombies");
            apellidoProfesionIdeal.Add("T", "Ovejas");
            apellidoProfesionIdeal.Add("U", "Huesos"); //
            apellidoProfesionIdeal.Add("V", "Choferes"); //
            apellidoProfesionIdeal.Add("W", "Chorizos");
            apellidoProfesionIdeal.Add("X", "Orcos");
            apellidoProfesionIdeal.Add("Y", "Tiburones");
            apellidoProfesionIdeal.Add("Z", "Piedras");
        }

        private void CargarMesProfesionIdeal()
        {
            mesProfesionIdeal.Add("ENERO", "Domador de");
            mesProfesionIdeal.Add("FEBRERO", "Peluquero de"); //
            mesProfesionIdeal.Add("MARZO", "Vendedor de"); //
            mesProfesionIdeal.Add("ABRIL", "Jinete de");
            mesProfesionIdeal.Add("MAYO", "Susurrador de");
            mesProfesionIdeal.Add("JUNIO", "Cazador de");
            mesProfesionIdeal.Add("JULIO", "Retratista de");
            mesProfesionIdeal.Add("AGOSTO", "Maquillador de");
            mesProfesionIdeal.Add("SETIEMBRE", "Masajista de");
            mesProfesionIdeal.Add("OCTUBRE", "Encantador de");
            mesProfesionIdeal.Add("NOVIEMBRE", "Profanador de");
            mesProfesionIdeal.Add("DICIEMBRE", "Coleccionista de");
        }

        private void CargarApellidosSuperHeroes()
        {
            apellidoSuperheroe.Add("A", "Elástico");
            apellidoSuperheroe.Add("B", "Carmesi");
            apellidoSuperheroe.Add("C", "Radiactivo");
            apellidoSuperheroe.Add("D", "Volador");
            apellidoSuperheroe.Add("E", "Espacial");
            apellidoSuperheroe.Add("F", "Letal");
            apellidoSuperheroe.Add("G", "Flácido");
            apellidoSuperheroe.Add("H", "Marciano");
            apellidoSuperheroe.Add("I", "Oscuro");
            apellidoSuperheroe.Add("J", "Invisible");
            apellidoSuperheroe.Add("K", "Mutante");
            apellidoSuperheroe.Add("L", "Vengador");
            apellidoSuperheroe.Add("M", "Amoroso");
            apellidoSuperheroe.Add("N", "Apestoso");
            apellidoSuperheroe.Add("O", "Mágico");
            apellidoSuperheroe.Add("P", "Gigante");
            apellidoSuperheroe.Add("Q", "Doloroso"); //
            apellidoSuperheroe.Add("R", "Biónico");
            apellidoSuperheroe.Add("S", "Negro");
            apellidoSuperheroe.Add("T", "Sangriento");
            apellidoSuperheroe.Add("U", "Rocoso");
            apellidoSuperheroe.Add("V", "De hierro");
            apellidoSuperheroe.Add("W", "Psíquico");
            apellidoSuperheroe.Add("X", "Maravilla");
            apellidoSuperheroe.Add("Y", "Hipster");
            apellidoSuperheroe.Add("Z", "Invencible");
        }

        private void CargarNombresSuperHeroes()
        {
            nombreSuperheroe.Add("A", "Sobaco");
            nombreSuperheroe.Add("B", "Asesino");
            nombreSuperheroe.Add("C", "Capitán");
            nombreSuperheroe.Add("D", "Peón"); //
            nombreSuperheroe.Add("E", "Trueno");
            nombreSuperheroe.Add("F", "Lobo");
            nombreSuperheroe.Add("G", "Conejo");
            nombreSuperheroe.Add("H", "Halcón");
            nombreSuperheroe.Add("I", "Sargento");
            nombreSuperheroe.Add("J", "Defensor"); //
            nombreSuperheroe.Add("K", "El milagro");
            nombreSuperheroe.Add("L", "El rey");
            nombreSuperheroe.Add("M", "Mejillón");
            nombreSuperheroe.Add("N", "Robot");
            nombreSuperheroe.Add("O", "Vigilante");
            nombreSuperheroe.Add("P", "Maestro");
            nombreSuperheroe.Add("Q", "Doctor");
            nombreSuperheroe.Add("R", "Orificio");
            nombreSuperheroe.Add("S", "Pepino");
            nombreSuperheroe.Add("T", "Príncipe");
            nombreSuperheroe.Add("U", "Tiburón");
            nombreSuperheroe.Add("V", "Aguijón");
            nombreSuperheroe.Add("W", "Fantasma");
            nombreSuperheroe.Add("X", "Agente");
            nombreSuperheroe.Add("Y", "Tornado");
            nombreSuperheroe.Add("Z", "Brujo");
        }

        protected void btnObtener_Click(object sender, EventArgs e)
        {
            string _urlImagen = ObtenerImagenSuperheroe();
            string _nombreSuperheroe = ObtenerNombreSuperheroe();
            string _apellidoSuperheroe = ObtenerApellidoSuperheroe();
            string _profesionPublica = ObtenerProfesionPublica();
            string _superpoder = ObtenerSuperpoder();
            string urlRedirect = string.Format("RevelarIdentidad.aspx?urlImagen={0}&nombreSuperheroe={1}&profesionPublica={2}&superpoder={3}&apellidoSuperheroe={4}",
                _urlImagen, _nombreSuperheroe, _profesionPublica, _superpoder, _apellidoSuperheroe);
            Response.Redirect(urlRedirect);
            
        }

        private string ObtenerApellidoSuperheroe()
        {
            string valor2 = string.Empty;

            string clave2 = txtApellidoReal.Text.Length > 0 ? txtApellidoReal.Text[0].ToString().ToUpper().Trim() : string.Empty;

            apellidoSuperheroe.TryGetValue(clave2, out valor2);

            return valor2;
        }

        private string ObtenerImagenSuperheroe()
        {
            int nroImagen = 1;
            string nombre = ObtenerNombreSuperheroe();
            string apellido = ObtenerApellidoSuperheroe();
            nroImagen = (nombre.Length + apellido.Length)%11 + 1;
            string urlImagen = string.Format("Images/{0}.png", nroImagen);
            return urlImagen;

        }

        private string ObtenerSuperpoder()
        {
            string valor1 = string.Empty;
            string clave = txtCampoExtra.Text.Length > 0 ? txtCampoExtra.Text[0].ToString().ToUpper().Trim() : string.Empty;

            nombreSuperpoder.TryGetValue(clave, out valor1);

            return valor1;
        }

        private string ObtenerProfesionPublica()
        {
            string valor1 = string.Empty;
            string valor2 = string.Empty;
            string clave1 = txtMes.Text.Length > 0 ? txtMes.Text.ToUpper().Trim() : string.Empty;
            string clave2 = txtApellidoReal.Text.Length > 0 ? txtApellidoReal.Text[0].ToString().ToUpper().Trim() : string.Empty;


            mesProfesionIdeal.TryGetValue(clave1, out valor1);
            apellidoProfesionIdeal.TryGetValue(clave2, out valor2);

            return valor1 + " " + valor2;
        }

        private string ObtenerNombreSuperheroe()
        {
            string valor1 = string.Empty;

            string clave1 = txtNombreReal.Text.Length > 0 ? txtNombreReal.Text[0].ToString().ToUpper().Trim() : string.Empty;
            
            nombreSuperheroe.TryGetValue(clave1, out valor1);
            
            return valor1;
        }
    }
}