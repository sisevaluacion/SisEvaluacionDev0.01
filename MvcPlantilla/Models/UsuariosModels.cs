using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;

namespace MvcPlantilla.Models
{
    public class UsuariosModels
    {
        public int ID { get; set; }

        [Required]
        public string Usuario { get; set; }

        [Required]
        public string Contrasena { get; set; }

    }
    public class MovieDBContext : DbContext
    {
        public DbSet<UsuariosModels> Movies { get; set; }
    }
}