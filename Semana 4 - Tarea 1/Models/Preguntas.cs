using System;
using System.ComponentModel.DataAnnotations;

namespace Preguntas.Models
{
    public class Pregunta
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El texto de la pregunta es obligatorio")]
        [Display(Name = "Texto de la Pregunta")]
        public string TextoPregunta { get; set; }

        [Display(Name = "Fecha de Creación")]
        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        [Display(Name = "Activa")]
        public bool Activa { get; set; } = true;
    }
}