using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Segundo___Examen___Parcial.Clases
{
    public class Canción
    {
        string nombre_canción;
        string artista_canción;
        int duración_min;

        public string Nombre_canción { get => nombre_canción; set => nombre_canción = value; }
        public string Artista_canción { get => artista_canción; set => artista_canción = value; }
        public int Duración_min { get => duración_min; set => duración_min = value; }
    }
}