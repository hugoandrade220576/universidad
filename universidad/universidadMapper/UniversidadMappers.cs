using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using universidad.Models;

namespace universidad.universidadMapper
{
    public class UniversidadMappers : Profile

    {
        public UniversidadMappers()
        {
            CreateMap<Estudiante, Estudiante>().ReverseMap();
        }
    }
}
