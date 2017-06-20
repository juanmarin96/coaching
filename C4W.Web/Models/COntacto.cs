using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace C4W.Web.Models
{
    public class Contacto
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Debes digitar un nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Debes digitar un país")]
        public string Pais { get; set; }
        [Required(ErrorMessage = "Debes digitar un correo")]
        public string Correo { get; set; }
        [Required(ErrorMessage = "Debes digitar una ciudad")]
        public string Ciudad { get; set; }
        [Display(Name = "Teléfono")]
        public string Telefono { get; set; }
        public string Comentario { get; set; }
    }
}