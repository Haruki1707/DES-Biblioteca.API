using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entities.DTO
{
    public class AutorDto
    {
        public int Codigo { get; set; }

        [Required(ErrorMessage = "El nombre del autor es requerido")]
        [StringLength(50, ErrorMessage = "El nombre del autor no puede exceder los 50 caracteres")]
        public string NombreAutor { get; set; } = String.Empty;

        [Required(ErrorMessage = "El apellido del autor es requerido")]
        [StringLength(50, ErrorMessage = "El apellido del autor no puede exceder los 50 caracteres")]
        public string ApellidoAutor { get; set; } = String.Empty;
    }
}
