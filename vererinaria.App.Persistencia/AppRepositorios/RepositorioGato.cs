using System.Collections;//FALTABA PONER (SEMANA 6)
using System.Collections.Generic;
using System.Linq;
using veterinaria.App.Dominio;

namespace veterinaria.App.Persistencia {
    public class RepositorioGato : IRepositorioGato{
   
        /// <summary>
        /// Referencia al contexto de Paciente
        /// </summary>
        private readonly AppContexto _appContext;
        /// <summary>
        /// Metodo Constructor Utiiza 
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"></param>//
        public RepositorioGato(AppContexto appContext){
            _appContext = appContext;
        }
         public RepositorioGato(){
            
         }
    /*
        List<Gato> gatos;
        public RepositorioGato(){
            gatos = new List<Gato>(){
                new Gato{Id=1, Nombre="calvo", Raza="asd", Edad=21, Color="Rojo"},
                new Gato{Id=1, Nombre="calvo", Raza="asd", Edad=21, Color="Rojo"}
            };
        }

        public IEnumerable<Gato> GetAllGato(){
            return gatos;
        }
    */
        Gato IRepositorioGato.AddGato(Gato gato){
            var gatoAdicionado = _appContext.Gatos.Add(gato);
            _appContext.SaveChanges();
            return gatoAdicionado.Entity;
        }
  
        void IRepositorioGato.DeletedGato(int idGato){
            var gatoEncontrado = _appContext.Gatos.FirstOrDefault(g => g.Id == idGato);
            if (gatoEncontrado == null)
            return;
            _appContext.Gatos.Remove(gatoEncontrado);
            _appContext.SaveChanges();
        }
 
        IEnumerable<Gato> IRepositorioGato.GetAllGato(){     
            return _appContext.Gatos;
        }

        Gato IRepositorioGato.GetGato(int idGato){
            return _appContext.Gatos.FirstOrDefault(g => g.Id == idGato);
        }

        //Paciente IRepositorioPaciente.UpdatePaciente(Paciente paciente)//original del Ing. Oscar
        //Paciente IRepositorioPaciente.UpdatePaciente(int idPaciente)
        //modificada por mi para que funcionara
        Gato IRepositorioGato.UpdateGato(Gato gato, int idGato_original){
            //var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id == paciente.Id);//original del Ing. Oscar
            //var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id == idPaciente);
            var gatoEncontrado = _appContext.Gatos .FirstOrDefault(g => g.Id == idGato_original);//modificada por mi para que funcionara
            if (gatoEncontrado != null){
                gatoEncontrado.Nombre = gato.Nombre;
                gatoEncontrado.Raza = gato.Raza;
                gatoEncontrado.Edad = gato.Edad;
                gatoEncontrado.Color = gato.Color;
                _appContext.SaveChanges();
            }
            return gatoEncontrado;
        }
    }
}


        