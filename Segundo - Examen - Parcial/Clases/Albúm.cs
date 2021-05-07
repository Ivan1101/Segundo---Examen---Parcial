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
        string fecha_publicacón;

        public string Titulo_albúm { get => titulo_albúm; set => titulo_albúm = value; }
        public string Artista { get => artista; set => artista = value; }
        public string Fecha_publicacón { get => fecha_publicacón; set => fecha_publicacón = value; }
    }
}