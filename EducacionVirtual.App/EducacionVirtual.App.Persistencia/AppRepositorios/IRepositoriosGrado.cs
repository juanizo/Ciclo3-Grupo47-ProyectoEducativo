using System.Collections.Generic;
using EducacionVirtual.App.Dominio;

namespace EducacionVirtual.App.Persistencia
{
    public interface IRepositoriosGrado
    {
        IEnumerable<Grado> GetAllGrado();

        Grado AddGrado(Grado grado);

        Grado UpdateGrado(Grado grado);

        void DeleteGrado(int idGrado);

        Grado GetGrado(int idGrado);
    }
}