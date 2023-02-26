using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace usuario.Models
{
    public class Usuario 
    {
        int id { get; set; }


        public string Nombre { get; set; }

        public string Apellidos { get; set; }

        public string Edad { get; set; }

        public string Correo { get; set; }

        public Byte[] foto { get; set; }
    }
}