using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
namespace PROYECTO_FINAL_PROGRA
{

    public partial class _Default : Page
    {

        List<Gastos> listgastos = new List<Gastos>();
        List<Propiedades> listpropiedades = new List<Propiedades>();
        List<Propietarios> listpropietarios = new List<Propietarios>();
        List<Comunidad> listcomunidad = new List<Comunidad>();
        List<Gastos2> listgastos2 = new List<Gastos2>();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string comunidades = "C:\\Users\\IRON-ROB\\Desktop\\ENGINEERING STUFF\\PROYECTOS FINALES\\PROYECTO FINAL PROGRA\\comunidad.txt";

            FileStream stream = new FileStream(comunidades, FileMode.Open, FileAccess.Read);
            StreamReader leer = new StreamReader(stream);

            while (leer.Peek() > -1)
            {
                Comunidad comunitemp = new Comunidad();

                comunitemp.Identificacion = leer.ReadLine();
                comunitemp.Nombre = leer.ReadLine();
                comunitemp.Poblacion =leer.ReadLine();


                listcomunidad.Add(comunitemp);
            }
            leer.Close();
            GridView1.DataSource = null;
            GridView1.DataBind();
            GridView1.DataSource = listcomunidad;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string propiedades = "C:\\Users\\IRON-ROB\\Desktop\\ENGINEERING STUFF\\PROYECTOS FINALES\\PROYECTO FINAL PROGRA\\propiedades.txt";

            FileStream stream = new FileStream(propiedades, FileMode.Open, FileAccess.Read);
            StreamReader leer = new StreamReader(stream);

            while (leer.Peek() > -1)
            {
                Propiedades propiedadtemp = new Propiedades();

                propiedadtemp.Tipo = leer.ReadLine();
                propiedadtemp.Codigopropiedad= leer.ReadLine();
                propiedadtemp.Metros =Convert.ToInt16(leer.ReadLine());
                propiedadtemp.Nitpropietario = leer.ReadLine();
                

                



                listpropiedades.Add(propiedadtemp);
            }
            leer.Close();
            GridView1.DataSource = null;
            GridView1.DataBind();
            GridView1.DataSource = listpropiedades;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string gastos = "C:\\Users\\IRON-ROB\\Desktop\\ENGINEERING STUFF\\PROYECTOS FINALES\\PROYECTO FINAL PROGRA\\gastos.txt";

            FileStream stream = new FileStream(gastos, FileMode.Open, FileAccess.Read);
            StreamReader leer = new StreamReader(stream);

            while (leer.Peek() > -1)
            {
                Gastos gastostemp = new Gastos();

                gastostemp.Nombre = leer.ReadLine();
                gastostemp.Identificacion = leer.ReadLine();
                gastostemp.Tipodereparto = leer.ReadLine();



                listgastos.Add(gastostemp);
            }
            leer.Close();
            GridView1.DataSource = null;
            GridView1.DataBind();
            GridView1.DataSource = listgastos;
            GridView1.DataBind();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string propietarios = "C:\\Users\\IRON-ROB\\Desktop\\ENGINEERING STUFF\\PROYECTOS FINALES\\PROYECTO FINAL PROGRA\\propietarios.txt";

            FileStream stream = new FileStream(propietarios, FileMode.Open, FileAccess.Read);
            StreamReader leer = new StreamReader(stream);

            while (leer.Peek() > -1)
            {
                Propietarios propietariotemp = new Propietarios();

                propietariotemp.Nombre = leer.ReadLine();
                propietariotemp.Nit = leer.ReadLine();
                propietariotemp.Email = leer.ReadLine();
                



                listpropietarios.Add(propietariotemp);
            }
            leer.Close();
            GridView1.DataSource = null;
            GridView1.DataBind();
            GridView1.DataSource = listpropietarios;
            GridView1.DataBind();
        }
    }
}