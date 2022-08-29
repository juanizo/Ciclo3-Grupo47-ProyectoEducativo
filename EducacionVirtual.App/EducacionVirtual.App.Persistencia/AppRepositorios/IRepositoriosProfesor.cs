using System.Collections.Generic;
using EducacionVirtual.App.Dominio;

namespace EducacionVirtual.App.Persistencia
{
    public interface IRepositoriosProfesor
    {
        IEnumerable<Profesor> GetAllProfesor();
 
        Profesor AddProfesor(Profesor profesor);

        Profesor UpdateProfesor(Profesor profesor);

        void DeleteProfesor(int idProfesor);

        Profesor GetProfesor(int idProfesor);
    }
}