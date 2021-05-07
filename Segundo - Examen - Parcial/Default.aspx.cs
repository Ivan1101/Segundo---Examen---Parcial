using Segundo___Examen___Parcial.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Segundo___Examen___Parcial
{
    public partial class _Default : Page
    {
        static int seleccionado;
        List<Albúm> albums = new List<Albúm>();
        List<Canción> canciones = new List<Canción>();
        protected void Page_Load(object sender, EventArgs e)
        {
            bloqueo();
        }
        public void bloqueo()
        {
            TextBoxNombre.Visible = false;
            TextBoxNombre.Enabled = false;
            TextBoxartista.Enabled = false; TextBoxartista.Visible = false;
            Label4.Visible = false;
            Label5.Visible = false; TextBoxtiempo.Enabled = false;
            TextBoxtiempo.Visible = false;Label6.Visible = false; 
        }
        public void desbloqueo()
        {
            TextBoxNombre.Visible = true;
            TextBoxNombre.Enabled = true;
            TextBoxartista.Enabled = true; TextBoxartista.Visible = true;
            Label4.Visible = true;
            Label5.Visible = true; TextBoxtiempo.Enabled = true ;
            TextBoxtiempo.Visible = true; Label6.Visible = true;
        }
        public void limpiar_campos()
        {
            TextBoxNombre.Text = " ";
            TextBoxartista.Text = " "; 
            TextBoxtiempo.Text = " "; 
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
    }
}