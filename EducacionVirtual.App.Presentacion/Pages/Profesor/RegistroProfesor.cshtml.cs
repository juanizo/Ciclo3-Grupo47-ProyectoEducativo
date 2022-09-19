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
    public class RegistroProfesorModel : PageModel
    {
        [BindProperty]
        public Profesor Profesor{get;set;}

        private readonly IRepositoriosProfesor _repoProfesor;

        public RegistroProfesorModel(IRepositoriosProfesor repoProfesor)
        {
            _repoProfesor = repoProfesor;
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

            _repoProfesor.AddProfesor(Profesor);
            return RedirectToPage("/Index");
        }
    }
}
