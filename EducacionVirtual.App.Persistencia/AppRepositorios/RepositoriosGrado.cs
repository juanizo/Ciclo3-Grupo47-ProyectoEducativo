using System.Collections.Generic;
using System.Linq;
using EducacionVirtual.App.Dominio;

namespace EducacionVirtual.App.Persistencia
{
    public class RepositoriosGrado : IRepositoriosGrado
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

        public RepositoriosGrado (AppContext appContext)
        {
            _appContext = appContext;
        }

        Grado IRepositoriosGrado.AddGrado(Grado grado)
        {
            var gradoAdicionado = _appContext.Grado.Add(grado);
            _appContext.SaveChanges();
            return gradoAdicionado.Entity;
        }

        void IRepositoriosGrado.DeleteGrado(int idGrado)
        {
            var gradoEncontrado = _appContext.Grado.FirstOrDefault(p => p.Id == idGrado);
            if(gradoEncontrado == null){
                return;
            }
            _appContext.Grado.Remove(gradoEncontrado);
            _appContext.SaveChanges();

        }

        Grado IRepositoriosGrado.GetGrado(int idGrado)
        {
            var gradoEncontrado = _appContext.Grado.FirstOrDefault(p => p.Id == idGrado);
            
            return gradoEncontrado;
        }

        IEnumerable<Grado> IRepositoriosGrado.GetAllGrado()
        {
            return _appContext.Grado;
        }

        Grado IRepositoriosGrado.UpdateGrado(Grado grado)
        {
            var gradoEncontrado = _appContext.Grado.FirstOrDefault(p => p.Id == grado.Id);
            if(gradoEncontrado != null){
                
                gradoEncontrado.Codigo = grado.Codigo;
                gradoEncontrado.Max_Estudiantes = grado.Max_Estudiantes;

                _appContext.SaveChanges();

                

            }

            return gradoEncontrado;

        }
    }
}