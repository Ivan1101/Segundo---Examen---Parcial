using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace Segundo___Examen___Parcial.Clases
{
    public class Albúm
    {
        string titulo_albúm;
        string artista;
        DateTime fecha_publicacón;
        List<Canción> canciones = new List<Canción>();
        public string Titulo_albúm { get => titulo_albúm; set => titulo_albúm = value; }
        public string Artista { get => artista; set => artista = value; }

        public DateTime Fecha_publicacón { get => fecha_publicacón; set => fecha_publicacón = value; }
        public List<Canción> Canciones { get => canciones; set => canciones = value; }
       

        public Albúm()
        {
            Canciones = new List<Canción>();
        }
    }
}