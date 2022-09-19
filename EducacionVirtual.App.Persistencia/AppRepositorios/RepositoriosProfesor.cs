using System.Collections.Generic;
using System.Linq;
using EducacionVirtual.App.Dominio;

namespace EducacionVirtual.App.Persistencia
{
    public class RepositoriosProfesor : IRepositoriosProfesor
    {
        
       

        private readonly AppContext _appContext = new AppContext();
        
       
        Profesor IRepositoriosProfesor.AddProfesor(Profesor profesor)
        {
            var profesorAdicionado = _appContext.Profesores.Add(profesor);
            _appContext.SaveChanges();
            return profesorAdicionado.Entity;
        }

        void IRepositoriosProfesor.DeleteProfesor(int idProfesor)
        {
            var profesorEncontrado = _appContext.Profesores.FirstOrDefault(p => p.Id == idProfesor);
            if(profesorEncontrado == null){
                return;
            }
            _appContext.Profesores.Remove(profesorEncontrado);
            _appContext.SaveChanges();

        }

        Profesor IRepositoriosProfesor.GetProfesor(int idProfesor)
        {
            var profesorEncontrado = _appContext.Profesores.FirstOrDefault(p => p.Id == idProfesor);
            
            return profesorEncontrado;
        }

        IEnumerable<Profesor> IRepositoriosProfesor.GetAllProfesor()
        {
            return _appContext.Profesores;
        }

        Profesor IRepositoriosProfesor.UpdateProfesor(Profesor profesor)
        {
            var profesorEncontrado = _appContext.Profesores.FirstOrDefault(p => p.Id == profesor.Id);
            if(profesorEncontrado != null){
                profesorEncontrado.Name = profesor.Name;
                profesorEncontrado.Apellidos = profesor.Apellidos;
                profesorEncontrado.Email = profesor.Email;
                profesorEncontrado.Edad = profesor.Edad;
                profesorEncontrado.Telefono = profesor.Telefono;
                profesorEncontrado.Direccion = profesor.Direccion;
                profesorEncontrado.Contrasena = profesor.Contrasena;
                profesorEncontrado.Especializacion = profesor.Especializacion;
                profesorEncontrado.Grado = profesor.Grado;

                _appContext.SaveChanges();

                

            }

            return profesorEncontrado;

        }
    }
}