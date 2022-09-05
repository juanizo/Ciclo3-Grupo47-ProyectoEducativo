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
   
    public class IniciarSesionModel : PageModel
    {
         public Estudiante Estudiante {get;set;}
        public void OnGet()
        {
        }
    }
}
