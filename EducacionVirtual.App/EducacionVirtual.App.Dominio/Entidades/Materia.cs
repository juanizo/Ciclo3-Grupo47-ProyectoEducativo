using System;

namespace EducacionVirtual.App.Dominio
{
    public class Materia
    {
        public int Id{get;set;}
        public string Codigo {get;set;}
        public Profesor profesor{get;set;}
        public float Calificacion{get;set;}
        public string Actividad{get;set;}
    }
}