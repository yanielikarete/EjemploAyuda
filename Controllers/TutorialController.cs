using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EjemploAyuda.Services.Interfaces;
using Microsoft.AspNetCore.Http;


namespace EjemploAyuda.Controllers
{
    public class TutorialController : ControllerBase
    {
        private ITutorial _tutorialService;

        public TutorialController(ITutorial tutorialService)
        {
            _tutorialService = tutorialService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTutotialPublished()
        {
            return Ok(await _tutorialService.GetAllTutotialPublished());
        }
    }
}