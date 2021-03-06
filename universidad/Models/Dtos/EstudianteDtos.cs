using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace universidad.Models
{
    public class EstudianteDto
    {

       
        public int Id { get; set; }
        [Required(ErrorMessage ="el nombre es obligatorio")]
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public string Edad { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Codemateria { get; set; }
        public DateTime FechaCreacion { get; set; }
    }

    

}
