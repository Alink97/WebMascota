using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMascota.Models
{
    public class Mascota
    {
        public int id { get; set; }
        public string name { get; set; }
        public string raza { get; set; }
        public int edad { get; set; }
    }
}