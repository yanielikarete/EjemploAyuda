using System.Collections.Generic;
using EjemploAyuda.Models;
using EjemploAyuda.Services.Interfaces;
using EjemploAyuda.Infraestructure;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace EjemploAyuda.Services
{
    public class TutorialService : ITutorial
    {
        private EjemploDataContext _context;

        public TutorialService(EjemploDataContext context)
        {
            _context = context;
        }

        public async Task<List<Tutorial>> GetAll()
        {
            return await _context.Tutoriales.ToListAsync();
        }
        
        public async Task<List<Tutorial>> GetAllTutotialPublished()
        {
            return await _context.Tutoriales.Where(y => y.Published == true).ToListAsync();
        }

        public async Task<List<Tutorial>> Add(Tutorial tutorial)
        {
            _context.Tutoriales.Add(tutorial);
            _context.SaveChanges();
            return await GetAll();
        }
    }
}