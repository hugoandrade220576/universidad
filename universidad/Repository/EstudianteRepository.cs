using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using universidad.Data;
using universidad.Models;
using universidad.Repository.IRepository;

namespace universidad.Repository
{
    public class EstudianteRepository : IestudianteRepository

    {
        public readonly ApplicationDbContext _bd;

        public EstudianteRepository(ApplicationDbContext bd)
        {
            _bd = bd;
        }

        public bool ActualizarEstudiante(Estudiante estudiante)
        {
            _bd.Estudiante.Update(estudiante);
            return Guardar();

        }

        public bool BorrarEstudiante(Estudiante estudiante)
        {
            _bd.Estudiante.Remove(estudiante);
            return Guardar();



        }

        public bool CrearEstudiante(Estudiante estudiante)
        {

            _bd.Estudiante.Add(estudiante);
            return Guardar();

        }

        public bool ExisteEstudiante(string nombre)
        {

            bool valor = _bd.Estudiante.Any(c => c.Nombre.ToLower().Trim() == nombre.ToLower().Trim());
            return valor;
        }

        public bool ExisteEstudiante(int id)
        {
            return _bd.Estudiante.Any(c => c.Id == id);
        }

        public Estudiante GetEstudiante(int EstudianteId)
        {
            return _bd.Estudiante.FirstOrDefault(c => c.Id == EstudianteId);
        }

        public ICollection<Estudiante> GetEstudiantes()
        {
            return _bd.Estudiante.OrderBy(c => c.Nombre).ToList();
        }

        public bool Guardar()
        {

            return _bd.SaveChanges() >= 0 ? true : false;
        }
    }
}
