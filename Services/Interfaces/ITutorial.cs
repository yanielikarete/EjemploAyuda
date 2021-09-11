using System.Collections.Generic;
using System.Threading.Tasks;
using EjemploAyuda.Models;

namespace EjemploAyuda.Services.Interfaces
{
    public interface ITutorial
    {


        
        public Task<List<Tutorial>> GetAll();
        public Task<List<Tutorial>> GetAllTutotialPublished();
        public Task<List<Tutorial>> Add(Tutorial tutorial);
    }
}