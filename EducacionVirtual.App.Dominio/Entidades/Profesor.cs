using System;

namespace EducacionVirtual.App.Dominio{

    public class Profesor : Persona
    {
        public string Especializacion{get;set;}
        public Grado Grado{get;set;}
    }
}