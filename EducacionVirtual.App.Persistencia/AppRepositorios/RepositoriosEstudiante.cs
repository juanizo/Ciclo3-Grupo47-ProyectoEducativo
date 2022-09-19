using System.Collections.Generic;
using System.Linq;
using EducacionVirtual.App.Dominio;

namespace EducacionVirtual.App.Persistencia
{
public class RepositoriosEstudiante : IRepositoriosEstudiante
{

        private readonly AppContext _appContext = new AppContext();
   
        Estudiante IRepositoriosEstudiante.AddEstudiante(Estudiante estudiante)
        {
            var estudianteAdicionado = _appContext.Estudiantes.Add(estudiante);
            _appContext.SaveChanges();
            return estudianteAdicionado.Entity;
        }

        void IRepositoriosEstudiante.DeleteEstudiante(int idEstudiante)
        {
            var estudianteEncontrado = _appContext.Estudiantes.FirstOrDefault(p => p.Id == idEstudiante);
            if(estudianteEncontrado == null){
                return;
            }
            _appContext.Estudiantes.Remove(estudianteEncontrado);
            _appContext.SaveChanges();

        }

        Estudiante IRepositoriosEstudiante.GetEstudiante(int idEstudiante)
        {
            var estudianteEncontrado = _appContext.Estudiantes.FirstOrDefault(p => p.Id == idEstudiante);
            
            return estudianteEncontrado;
        }

        IEnumerable<Estudiante> IRepositoriosEstudiante.GetAllEstudiante()
        {
            return _appContext.Estudiantes;
        }

        Estudiante IRepositoriosEstudiante.UpdateEstudiante(Estudiante estudiante)
        {
            var estudianteEncontrado = _appContext.Estudiantes.FirstOrDefault(p => p.Id == estudiante.Id);
            if(estudianteEncontrado != null){
                estudianteEncontrado.Name = estudiante.Name;
                estudianteEncontrado.Apellidos = estudiante.Apellidos;
                estudianteEncontrado.Email = estudiante.Email;
                estudianteEncontrado.Edad = estudiante.Edad;
                estudianteEncontrado.Telefono = estudiante.Telefono;
                estudianteEncontrado.Direccion = estudiante.Direccion;
                estudianteEncontrado.Contrasena = estudiante.Contrasena;
                estudianteEncontrado.Grado = estudiante.Grado;
                estudianteEncontrado.Materia = estudiante.Materia;
                estudianteEncontrado.Profesor = estudiante.Profesor;
            

                _appContext.SaveChanges();

                

            }

            return estudianteEncontrado;

        }

}
}
