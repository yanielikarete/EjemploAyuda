using System.Collections.Generic;
using System.Threading.Tasks;
using EjemploAyuda.Domain.Models;

namespace EjemploAyuda.Services.Interfaces
{
    public interface IAutor
    {
        public Task<List<Autor>> GetAll();
         public Task<List<Autor>> Add(Autor autor);
    }
}