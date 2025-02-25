using System;
using System.ComponentModel.DataAnnotations;

namespace Preguntas.Models
{
    // Clase que representa una pregunta dentro del sistema.
    public class Pregunta
    {
        // Propiedad que almacena el identificador único de la pregunta.
        public int Id { get; set; }

        // Propiedad para el texto de la pregunta.
        // Se utiliza el atributo [Required] para asegurar que el usuario ingrese un valor.
        // [Display] especifica el nombre que se mostrará en la interfaz de usuario (HTML),
        // facilitando la presentación de etiquetas más amigables.
        [Required(ErrorMessage = "El texto de la pregunta es obligatorio")]
        [Display(Name = "Texto de la Pregunta")]
        public string TextoPregunta { get; set; }

        // Propiedad que almacena la fecha en la que se creó la pregunta.
        // La fecha se inicializa automáticamente con la fecha y hora actual.
        // [Display] permite definir la etiqueta que será mostrada en la interfaz.
        [Display(Name = "Fecha de Creación")]
        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        // Propiedad booleana para indicar si la pregunta está activa.
        // Se establece un valor predeterminado en true.
        // [Display] define la forma en que se presentará esta propiedad en HTML.
        [Display(Name = "Activa")]
        public bool Activa { get; set; } = true;
    }
}
