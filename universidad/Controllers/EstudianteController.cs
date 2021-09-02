using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using universidad.Repository.IRepository;

namespace universidad.Controllers
{
    [Route("api/Estudiante")]
    [ApiController]
    public class EstudianteController : Controller
    {
        private readonly IestudianteRepository _ctorepo;

        public EstudianteController(IestudianteRepository ctorepo)
        {
            _ctorepo = ctorepo;
        }
        [HttpGet ]
        public IActionResult GetEstudiante()
        {
            var listaEstudiante = _ctorepo.GetEstudiantes();
            return Ok(listaEstudiante);
        }
    }
}
