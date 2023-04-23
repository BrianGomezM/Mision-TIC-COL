using System;
using veterinaria.App.Dominio;
using veterinaria.App.Persistencia;
namespace veterinaria.App.Consola{
    class Program
    {
        private static IRepositorioGato _repoGato = new RepositorioGato(new Persistencia.AppContexto());
        static void Main(string[] args){
            
            Console.WriteLine("Hello World!");
           // obtenerGatos();
            AddGato();
        }

        private static void AddGato(){
            var gato = new Gato{
                Nombre = "Pelusa",
                Raza = "Albino",
                Edad = 1,
                Color = "Tigrillo"
            };
            _repoGato.AddGato(gato);
        }

         private static void BuscarGato(int idGato){
            var gato = _repoGato.GetGato(idGato);
            //Console.WriteLine(paciente.Nombre+" "+paciente.Apellidos);
            string datos_gato = "\nNombre:"+gato.Nombre;
            Console.WriteLine(datos_gato);          
         //SIN RETORNO       
        }

         private static void DeleteGato(int idGato){            
            _repoGato.DeletedGato(1);
            Console.WriteLine("Gato borrado!");           
        }

         private static void UpdateGato(int idGato){            
            //var paciente_actualizado = _repoPaciente.UpdatePaciente(paciente);
            var gatoActualizado = new Gato{
                Nombre = "Nicolay5"
            };
            _repoGato.UpdateGato(gatoActualizado, idGato);
            //var paciente = _repoPaciente.UpdatePaciente(idPaciente);
            Console.WriteLine("Paciente actualizado!");
            //return paciente_actualizado;              
        }
         private static void obtenerGatos(){
          var gatos = _repoGato.GetAllGato();  
           foreach (Gato p in gatos)
            {
                Console.WriteLine(p.Nombre + " " );
            } 
        }
    }
}
