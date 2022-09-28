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

        private readonly IRepositoriosEstudiante _repoEstudiante;

        public FormularioEModel(IRepositoriosEstudiante repoEstudiante)
        {
            _repoEstudiante = repoEstudiante;
        }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            
            if(!ModelState.IsValid)
            {
                return Page();
            }
            
  
                _repoEstudiante.AddEstudiante(Estudiante);
                return RedirectToPage("/Index");
             
        }

        
        
    }
}
