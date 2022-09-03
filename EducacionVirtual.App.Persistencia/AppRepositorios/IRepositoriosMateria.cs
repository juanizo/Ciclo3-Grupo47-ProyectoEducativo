using System.Collections.Generic;
using EducacionVirtual.App.Dominio;

namespace EducacionVirtual.App.Persistencia
{
    public interface IRepositoriosMateria
    {
        IEnumerable<Materia> GetAllMateria();

        Materia AddMateria(Materia materia);

        Materia UpdateMateria(Materia materia);

        void DeleteMateria(int idMateria);

        Materia GetMateria(int idMateria);
    }
}