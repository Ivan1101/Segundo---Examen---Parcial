using Newtonsoft.Json;
using Segundo___Examen___Parcial.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace Segundo___Examen___Parcial
{
    public partial class About : Page
    {
        static bool seleccionar; // variable booleanda para mostrar el DropDownList_mostrar
        static int seleccionada; // variable para ver  la Universidad seleccionada
        static int seleccionado; // Varriable para seleccionar la persona en el DropDownList
        static List<Albúm> albums = new List<Albúm>();
        static List<Canción> canciones = new List<Canción>();
        protected void Page_Load(object sender, EventArgs e)
        {
            desbloqueo1(false);
        }
        public void desbloqueo1(bool ingreso )
        {
            TextBox_codigo.Visible = ingreso; TextBox_codigo.Enabled = ingreso;
             Label2.Visible = ingreso;
        }
        public void desbloqueo_mostrar_datos()
        {
            Label6.Visible = true; Label8.Visible = true; Label9.Visible = true;
            TextBoxNombre.Visible = true; TextBoxartista.Visible = true; TextBoxartista.Visible = true;
            TextBoxtiempo.Visible = true; 
        }
        public void desbloqueo_mostrar_editar()
        {
            TextBoxNombre.Enabled = true; TextBoxartista.Enabled = true; TextBoxartista.Enabled = true;
            TextBoxtiempo.Enabled = true; 
        }
        public void limpiar_campos()
        {
            TextBoxNombre.Text = " ";
            TextBoxartista.Text = " ";
            TextBoxtiempo.Text = " ";
        }
        public void bloqueo()
        {
            TextBoxNombre.Visible = false;
            TextBoxNombre.Enabled = false;
            TextBoxartista.Enabled = false; TextBoxartista.Visible = false;
            Label9.Visible = false;
            Label8.Visible = false; TextBoxtiempo.Enabled = false;
            TextBoxtiempo.Visible = false; Label6.Visible = false; Button1.Visible = false;
        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            seleccionado = DropDownList_mostrar.SelectedIndex;
            if (seleccionado == 1)
            {
                desbloqueo1(true); Button1.Visible = true;
            }
            else if (seleccionado == 2)
            {
                desbloqueo1(true); Button1.Visible = true;
            }
            else if (seleccionado == 3)
            {
                desbloqueo1(true); Button1.Visible = true;
            }
        }
        public void GuardarJson()
        {
            string json = JsonConvert.SerializeObject(albums);
            string archivo = Server.MapPath("Archivo Albumes.json");
            System.IO.File.WriteAllText(archivo, json);
        }

        protected void GridView_Universidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList_mostrar.Visible = true;
            seleccionada = GridView_Universidades.SelectedIndex;
            seleccionar = true;
            canciones = albums[seleccionada].Canciones.ToList();
            limpiar_campos(); bloqueo(); DropDownList_mostrar.SelectedIndex = 0;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (seleccionado == 1)
            {
                Canción search_alumno = new Canción();
                search_alumno = albums[seleccionada].Canciones.Find(bus => bus.Artista_canción == TextBox_codigo.Text);
                if (search_alumno == null)
                {
                    Label_noexiste.Text = "NO EXISTE EL artista";
                    desbloqueo1(true); Button1.Visible = true;
                }
                else
                {
                    Label_noexiste.Text = " ";
                    TextBoxNombre.Text = search_alumno.Nombre_canción;
                    TextBoxartista.Text = search_alumno.Artista_canción;
                    TextBoxtiempo.Text = Convert.ToString(search_alumno.Duración_min);
                    
                    Button2_editar.Visible = true; Button3_eliminar.Visible = true;
                }
            }
            else if (seleccionado == 2)
            {
                Canción search_alumno = new Canción();
                search_alumno = albums[seleccionada].Canciones.Find(bus => bus.Artista_canción == TextBox_codigo.Text);
                if (search_alumno == null)
                {
                
                    Label_noexiste.Text = "NO EXISTE EL artista";
                    desbloqueo1(true); Button1.Visible = true;
                }
                else
                {
                    Label_noexiste.Text = " ";
                    TextBoxNombre.Text = search_alumno.Nombre_canción;
                    TextBoxartista.Text = search_alumno.Artista_canción;
                    TextBoxtiempo.Text = Convert.ToString(search_alumno.Duración_min);

                    Button2_editar.Visible = true; Button3_eliminar.Visible = true;
                }
            }
            else if (seleccionado == 3)
            {
                Canción search_alumno = new Canción();
                search_alumno = albums[seleccionada].Canciones.Find(bus => bus.Artista_canción == TextBox_codigo.Text);
                if (search_alumno == null)
                {
                    Label_noexiste.Text = "NO EXISTE EL artista";
                    desbloqueo1(true); Button1.Visible = true;
                }
                else
                {
                    Label_noexiste.Text = " ";
                    TextBoxNombre.Text = search_alumno.Nombre_canción;
                    TextBoxartista.Text = search_alumno.Artista_canción;
                    TextBoxtiempo.Text = Convert.ToString(search_alumno.Duración_min);

                    Button2_editar.Visible = true; Button3_eliminar.Visible = true;
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (seleccionado == 1)
            {
                int selec_alumno;
                selec_alumno = albums[seleccionada].Canciones.FindIndex(bus => bus.Artista_canción == TextBox_codigo.Text);
                albums[seleccionada].Canciones.RemoveAt(selec_alumno);
                GuardarJson(); limpiar_campos();
                TextBox_codigo.Text = ""; bloqueo(); desbloqueo1(true); Button1.Visible = true;
            }
            else if (seleccionado == 2)
            {
                int selec_alumno;
                selec_alumno = albums[seleccionada].Canciones.FindIndex(bus => bus.Artista_canción == TextBox_codigo.Text);
                albums[seleccionada].Canciones.RemoveAt(selec_alumno);
                GuardarJson(); limpiar_campos();
                TextBox_codigo.Text = ""; bloqueo(); desbloqueo1(true); Button1.Visible = true;
            }
            else if (seleccionado == 3)
            {
                int selec_alumno;
                selec_alumno = albums[seleccionada].Canciones.FindIndex(bus => bus.Artista_canción == TextBox_codigo.Text);
                albums[seleccionada].Canciones.RemoveAt(selec_alumno);
                GuardarJson(); limpiar_campos();
                TextBox_codigo.Text = ""; bloqueo(); desbloqueo1(true); Button1.Visible = true;
            }
        }
    }
}