using Newtonsoft.Json;
using Segundo___Examen___Parcial.Clases;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Segundo___Examen___Parcial
{
    public partial class _Default : Page
    {
        static int seleccionado;
        static List<Albúm> albums = new List<Albúm>();
        static List<Canción> canciones = new List<Canción>();
        protected void Page_Load(object sender, EventArgs e)
        {
            MaintainScrollPositionOnPostBack = true;
            if (!IsPostBack)
            {
                //Cada vez que se corre el programa, se cargan las universidades existentes en el archivo Json

                //se usará el archivo de universidades
                string archivo = Server.MapPath("Archivo Albumes.json");
                //se abre el archivo
                StreamReader jsonStream = File.OpenText(archivo);

                //se lee todo el contenido del archivo y el contenido se guarda en la variable json
                string json = jsonStream.ReadToEnd();

                jsonStream.Close();

                //Se deserializa (convierte) la cadena json en la estructura que tiene la lista universidades
                albums = JsonConvert.DeserializeObject<List<Albúm>>(json);
                bloqueo();
            }
            Button2.Visible = false; 
        }
        public void bloqueo()
        {
            TextBoxNombre.Visible = false;
            TextBoxNombre.Enabled = false;
            TextBoxartista.Enabled = false; TextBoxartista.Visible = false;
            Label4.Visible = false;
            Label5.Visible = false; TextBoxtiempo.Enabled = false;
            TextBoxtiempo.Visible = false;Label6.Visible = false; Button1.Visible = false;
        }
        public void desbloqueo()
        {
            TextBoxNombre.Visible = true;
            TextBoxNombre.Enabled = true;
            TextBoxartista.Enabled = true; TextBoxartista.Visible = true;
            Label4.Visible = true;
            Label5.Visible = true; TextBoxtiempo.Enabled = true ;
            TextBoxtiempo.Visible = true; Label6.Visible = true; Button1.Visible = true;
        }
        public void limpiar_campos()
        {
            TextBoxNombre.Text = " ";
            TextBoxartista.Text = " "; 
            TextBoxtiempo.Text = " "; 
        }
        public void GuardarJson()
        {
            string json = JsonConvert.SerializeObject(albums);
            string archivo = Server.MapPath("Archivo Albumes.json");
            System.IO.File.WriteAllText(archivo, json);
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Albúm album = new Albúm();
            album = albums.Find(u => u.Titulo_albúm == TextBoxtitulo.Text);
            if(seleccionado == 0)
            {
                if (album != null)
                {
                    canciones = album.Canciones.ToList();
                    Canción canción = new Canción();
                    canción.Nombre_canción = TextBoxNombre.Text;
                    canción.Artista_canción = TextBoxartista.Text;
                    canción.Duración_min = Convert.ToInt32(TextBoxtiempo.Text);
                    canciones.Add(canción);
                    album.Canciones= canciones.ToList();
                    limpiar_campos();
                }
                else
                {
                    Canción canción = new Canción();
                    canción.Nombre_canción = TextBoxNombre.Text;
                    canción.Artista_canción = TextBoxartista.Text;
                    canción.Duración_min = Convert.ToInt32(TextBoxtiempo.Text);
                    canciones.Add(canción);
                    limpiar_campos();
                }
            }
            else if (seleccionado == 1)
            {
                if (album != null)
                {
                    canciones = album.Canciones.ToList();
                    Canción canción = new Canción();
                    canción.Nombre_canción = TextBoxNombre.Text;
                    canción.Artista_canción = TextBoxartista.Text;
                    canción.Duración_min = Convert.ToInt32(TextBoxtiempo.Text);
                    canciones.Add(canción);
                    album.Canciones = canciones.ToList();
                    limpiar_campos();
                }
                else
                {
                    Canción canción = new Canción();
                    canción.Nombre_canción = TextBoxNombre.Text;
                    canción.Artista_canción = TextBoxartista.Text;
                    canción.Duración_min = Convert.ToInt32(TextBoxtiempo.Text);
                    canciones.Add(canción);
                    limpiar_campos();
                }
            }
            else if (seleccionado == 2)
            {
                if (album != null)
                {
                    canciones = album.Canciones.ToList();
                    Canción canción = new Canción();
                    canción.Nombre_canción = TextBoxNombre.Text;
                    canción.Artista_canción = TextBoxartista.Text;
                    canción.Duración_min = Convert.ToInt32(TextBoxtiempo.Text);
                    canciones.Add(canción);
                    album.Canciones = canciones.ToList();
                    limpiar_campos();
                }
                else
                {
                    Canción canción = new Canción();
                    canción.Nombre_canción = TextBoxNombre.Text;
                    canción.Artista_canción = TextBoxartista.Text;
                    canción.Duración_min = Convert.ToInt32(TextBoxtiempo.Text);
                    canciones.Add(canción);
                    limpiar_campos();
                }
            }
            Button2.Visible = true;
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            seleccionado = DropDownList_registro.SelectedIndex;
            if (seleccionado == 0)
            {
                desbloqueo();
            }
            else if(seleccionado == 1)
            {
                desbloqueo();
            }
            else if (seleccionado == 2)
            {
                desbloqueo();
            }
        }

        protected void Button_guardar_Click(object sender, EventArgs e)
        {

           Albúm uni = albums.Find(u => u.Titulo_albúm == TextBoxtitulo.Text);
            if (seleccionado == 0)
            {
                if (uni == null)
                {
                    Albúm albúm = new Albúm();
                    albúm.Titulo_albúm= TextBoxtitulo.Text;
                    albúm.Artista = TextBoxnombre_artista.Text;
                    albúm.Fecha_publicacón = Calendarfecha_publicación.SelectedDate;
                    albúm.Canciones = canciones.ToList();
                    albums.Add(albúm);
                    GuardarJson();
                    canciones.Clear();
                }
                else
                {
                    uni.Canciones = canciones;
                    GuardarJson();
                }

            }
            else if (seleccionado == 1)
            {
                if (uni == null)
                {
                    Albúm albúm = new Albúm();
                    albúm.Titulo_albúm = TextBoxtitulo.Text;
                    albúm.Artista = TextBoxnombre_artista.Text;
                    albúm.Fecha_publicacón = Calendarfecha_publicación.SelectedDate;
                    albúm.Canciones = canciones.ToList();
                    albums.Add(albúm);
                    GuardarJson();
                    canciones.Clear();
                }
                else
                {
                    uni.Canciones = canciones;
                    GuardarJson();
                }
            }
            else if (seleccionado == 2)
            {
                if (uni == null)
                {
                    Albúm albúm = new Albúm();
                    albúm.Titulo_albúm = TextBoxtitulo.Text;
                    albúm.Artista = TextBoxnombre_artista.Text;
                    albúm.Fecha_publicacón = Calendarfecha_publicación.SelectedDate;
                    albúm.Canciones = canciones.ToList();
                    albums.Add(albúm);
                    GuardarJson();
                    canciones.Clear();
                }
                else
                {
                    uni.Canciones = canciones;
                    GuardarJson();
                }
            }
            Button2.Visible = false;
        }
    }
}