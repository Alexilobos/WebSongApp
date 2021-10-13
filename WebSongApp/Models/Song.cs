using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebSongApp.Models
{
    public class Song
    {
        [Key]
       
        [Required(ErrorMessage = "El campo del nombre es requerido")] //para validar el name
        [StringLength(60, MinimumLength = 2, ErrorMessage = "El nombre tiene que tener entre 5 a 60 caracteres")]
        [Display(Name = "Cancion")]
        public string Cancion { get; set; }
        [Required]
        [Display(Name = "Autor")]
        public string Autor { get; set; }
        [Display(Name = "Letra")]
        public string Letra { get; set; }
        [Display(Name = "Enlace")]
        public string Enlace { get; set; }
    }
}
