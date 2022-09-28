using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EducacionVirtual.App.Dominio;
using EducacionVirtual.App.Persistencia;
using EducacionVirtual.App.Presentacion.Areas.Identity.Data;

namespace EducacionVirtual.App.Presentacion.Pages
{
    public class ConfiguracionModel : PageModel
    {
        public Profesor Profesor{get;set;}
        public Usuario Input { get; set; }
        

       
        public void OnGet()
        {
          
        }
        /*
         public class InputModel
        {
           
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            
            [Display(Name = "Nombre")]
            public string Nombre { get; set; }

            [Display(Name = "Apellidos")]
            public string Apellidos { get; set; }

           
   
            [Display(Name = "Telefono")]
            public string Telefono { get; set; }

            [Required]
            [Display(Name = "Edad")]
            public string Edad { get; set; }

           
            [Display(Name = "Direccion")]
            public string Direccion { get; set; }

            
            [Display(Name = "Tipo")]
            public string Type { get; set; }
        }
        */
    }
}
