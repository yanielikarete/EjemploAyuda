using System;
using EjemploAyuda.Domain.Models;

namespace EjemploAyuda.Models
{
    public class Tutorial
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Published { get; set; }
        public DateTime ApprovedDate { get; set; }
        public Autor Autor { get; set; }
    }
}