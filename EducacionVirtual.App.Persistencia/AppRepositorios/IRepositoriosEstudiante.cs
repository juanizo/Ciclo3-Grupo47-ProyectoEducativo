using System.Collections.Generic;
using EducacionVirtual.App.Dominio;

namespace EducacionVirtual.App.Persistencia
{
    public interface IRepositoriosEstudiante
    {
        IEnumerable<Estudiante> GetAllEstudiante();
        
        Estudiante AddEstudiante(Estudiante estudiante);

        Estudiante UpdateEstudiante(Estudiante Estudiante);

        void DeleteEstudiante(int idEstudiante);

        Estudiante GetEstudiante(int idEstudiante);
    }
}