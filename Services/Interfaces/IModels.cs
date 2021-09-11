using System.Collections.Generic;
using System.Threading.Tasks;

namespace EjemploAyuda.Services.Interfaces
{
    public interface IModels<T> where T : class
    {
        public Task<List<T>> GetAll();
        public Task<List<T>> Add (T entity);
    }

}