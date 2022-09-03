using System;

namespace EducacionVirtual.App.Dominio{

    public class Estudiante : Persona{
        public Grado Grado{get;set;}
        public Materia Materia{get;set;}
        public Profesor Profesor{get; set;}
    }
}