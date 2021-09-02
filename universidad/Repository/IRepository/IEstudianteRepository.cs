using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using universidad.Models;

namespace universidad.Repository.IRepository
{
    public interface IestudianteRepository
    {
        ICollection<Estudiante> GetEstudiantes();
        Estudiante GetEstudiante(int EstudianteId);
        bool ExisteEstudiante(string nombre);
        bool ExisteEstudiante(int id);

        bool CrearEstudiante(Estudiante estudiante);
        bool ActualizarEstudiante(Estudiante estudiante);
        bool BorrarEstudiante(Estudiante estudiante);

        bool Guardar();



    }
}
