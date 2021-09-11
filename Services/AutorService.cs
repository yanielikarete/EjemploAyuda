using System.Collections.Generic;
using System.Threading.Tasks;
using EjemploAyuda.Domain.Models;
using EjemploAyuda.Services.Interfaces;

namespace EjemploAyuda.Services
{
    public class AutorService : IAutor
    {
        public Task<List<Autor>> Add(Autor autor)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Autor>> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}