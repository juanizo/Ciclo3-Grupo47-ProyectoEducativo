using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EducacionVirtual.App.Dominio;
using EducacionVirtual.App.Persistencia;

namespace EducacionVirtual.App.Presentacion.Pages
{
    public class FormularioEModel : PageModel
    {
        [BindProperty]
        public Estudiante Estudiante {get;set;}
        [BindProperty]        
        public Profesor Profesor{get;set;}

        private readonly IRepositoriosEstudiante _repoEstudiante;
        private readonly IRepositoriosProfesor _repoProfesor;

        public FormularioEModel(IRepositoriosEstudiante repoEstudiante, IRepositoriosProfesor repoProfesor)
        {
            _repoEstudiante = repoEstudiante;
            _repoProfesor = repoProfesor;
        }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            
            Console.Write(profesor);

            if(!ModelState.IsValid)
            {
                return Page();
            }
            
           
                _repoProfesor.AddProfesor(Profesor);
                _repoEstudiante.AddEstudiante(Estudiante);
                return RedirectToPage("/Index");
             
        }
    }
}
