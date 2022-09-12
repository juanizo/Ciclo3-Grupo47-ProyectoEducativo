using System;
using System.ComponentModel.DataAnnotations;
namespace EducacionVirtual.App.Dominio{

    public class Profesor : Persona
    {
        [Required]
        public string Especializacion{get;set;}
        public Grado Grado{get;set;}
    }
}