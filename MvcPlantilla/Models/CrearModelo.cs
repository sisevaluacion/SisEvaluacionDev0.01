using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel.DataAnnotations;

namespace MvcPlantilla.Controllers
{
    public class CrearModelo
    {
        [Required]
        public string Usuario { get; set; }
        [Required]
        public string Contrasena { get; set; }
        [Required]
        public string ContrasenaNueva { get; set; }
    }
}
