using System.Collections.Generic;
using System.Linq;
using EducacionVirtual.App.Dominio;

namespace EducacionVirtual.App.Persistencia
{
    public class RepositoriosMateria : IRepositoriosMateria
    {
         ///<summary>    
        //Referencia al Contexto 
        /// </summary>

        private readonly AppContext _appContext;
        /// <summary>
        /// Metodo constructor utiliza 
        /// Inyeccion de dpendencia al utilizar
        ///</summary>
        /// <param  name= "appContext"></param>//

        public RepositoriosMateria (AppContext appContext)
        {
            _appContext = appContext;
        }

        Materia IRepositoriosMateria.AddMateria(Materia materia)
        {
            var materiaAdicionada = _appContext.Materias.Add(materia);
            _appContext.SaveChanges();
            return materiaAdicionada.Entity;
        }

        void IRepositoriosMateria.DeleteMateria(int idMateria)
        {
            var materiaEncontrado = _appContext.Materias.FirstOrDefault(p => p.Id == idMateria);
            if(materiaEncontrado == null){
                return;
            }
            _appContext.Materias.Remove(materiaEncontrado);
            _appContext.SaveChanges();

        }

        Materia IRepositoriosMateria.GetMateria(int idMateria)
        {
            var materiaEncontrado = _appContext.Materias.FirstOrDefault(p => p.Id == idMateria);
            
            return materiaEncontrado;
        }

        IEnumerable<Materia> IRepositoriosMateria.GetAllMateria()
        {
            return _appContext.Materias;
        }

        Materia IRepositoriosMateria.UpdateMateria(Materia materia)
        {
            var materiaEncontrado = _appContext.Materias.FirstOrDefault(p => p.Id == materia.Id);
            if(materiaEncontrado != null){
                    materiaEncontrado.Profesor = materia.Profesor;
                    materiaEncontrado.Calificacion = materia.Calificacion;
                    materiaEncontrado.Actividad = materia.Actividad;

                _appContext.SaveChanges();

                

            }

            return materiaEncontrado;

        }
    }
}