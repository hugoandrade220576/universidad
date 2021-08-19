using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace universidad.Models
{
    public class Carreras
    {
        [Key]
        public int Id { get; set; }
        public string NombreCarrera { get; set; }
        public string Numeromaterias { get; set; }

        public string Facultad { get; set; }
              
        public DateTime FechaCreacion { get; set; }

    }
}
