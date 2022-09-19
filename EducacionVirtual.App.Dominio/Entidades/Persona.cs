using System;
using System.ComponentModel.DataAnnotations;
namespace EducacionVirtual.App.Dominio
{
    public class Persona{
        public int Id{get;set;}
        //[Required]
        public string Name{get;set;}
        //[Required]
        public string Apellidos{get;set;}
        //[Required]
        public string Email{get;set;}
        //[Required]
        public int Edad{get;set;}
        //[Required]
        public string Telefono{get;set;}
        //[Required]
        public string Direccion{get;set;}

        public string Usuario{get;set;}
        //[Required]
        public string Contrasena{get;set;}
        
        public string Codigo{get;set;}
    }
}
