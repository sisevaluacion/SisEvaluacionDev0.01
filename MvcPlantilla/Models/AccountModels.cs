using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;

namespace MvcPlantilla.Models
{
    public class UsersContext : DbContext
    {
        public UsersContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<UserProfile> UserProfiles { get; set; }
    }

    [Table("UserProfile")]
    public class UserProfile
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public string UserName { get; set; }
    }

    public class RegisterExternalLoginModel
    {
        [Required]
        [Display(Name = "Nombre de usuario")]
        public string UserName { get; set; }

        public string ExternalLoginData { get; set; }
    }

    public class LocalPasswordModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña actual")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "El número de caracteres de {0} debe ser al menos {2}.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Nueva contraseña")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar la nueva contraseña")]
        [Compare("NewPassword", ErrorMessage = "La nueva contraseña y la contraseña de confirmación no coinciden.")]
        public string ConfirmPassword { get; set; }
    }

    public class LoginModel
    {
        [Required]
        [Display(Name = "Nombre de usuario")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        [Display(Name = "¿Recordar cuenta?")]
        public bool RememberMe { get; set; }
    }
    public class LoginModelEdit
    {
        [Required]
        [Display(Name = "Nombre de usuario")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Repita Contraseña")]
        public string RePassword { get; set; }

    }

    public class RegisterModel
    {
        [Required]
        [Display(Name = "Nombre de usuario")]
        public string UserName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "El número de caracteres de {0} debe ser al menos {2}.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar contraseña")]
        [Compare("Password", ErrorMessage = "La contraseña y la contraseña de confirmación no coinciden.")]
        public string ConfirmPassword { get; set; }
    }

    public class ExternalLogin
    {
        public string Provider { get; set; }
        public string ProviderDisplayName { get; set; }
        public string ProviderUserId { get; set; }
    }
    public class RegistrarDocente
    {
        public string Codigo { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public string Contrasenia { get; set; }
        public string Carrera { get; set; }
        public string Asignatura { get; set; }
    }
    public class RegistrarAlumno
    {
        public string Codigo { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public string Contrasenia { get; set; }
        public string Carrera { get; set; }
        public string Asignatura { get; set; }
    }
    public class RegistrarAsignatura
    {
        public string Codigo { get; set; }
        public string Asignatura { get; set; }
        public string Carrera { get; set; }
    }
    public class AsignarCargaAcademica
    {
        public string Codigo { get; set; }
        public string Docente { get; set; }
        public string Carrera { get; set; }
        public bool Asignatura1 { get; set; }
        public bool Asignatura2 { get; set; }
        public bool Asignatura3 { get; set; }
        public bool Asignatura4 { get; set; }
        
    }
    public class ElaborarTema
    {
        public string Codigo { get; set; }
        public string Curso { get; set; }
        public string Tema { get; set; }

    }
    public class ElaborarPRegunta
    {
        public string Codigo { get; set; }
        public string Curso { get; set; }
        public string Pregunta { get; set; }
        public string Alternativa1 { get; set; }
        public bool Correcta1 { get; set; }
        public string Alternativa2 { get; set; }
        public bool Correcta2 { get; set; }
        public string Alternativa3 { get; set; }
        public bool Correcta3 { get; set; }
        public string Alternativa4 { get; set; }
        public bool Correcta4 { get; set; }

    }
}
