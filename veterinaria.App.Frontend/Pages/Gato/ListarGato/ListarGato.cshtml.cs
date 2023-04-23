using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using veterinaria.App.Dominio;
using veterinaria.App.Persistencia;

namespace veterinaria.App.Frontend.Pages
{
    public class ListarGatoModel : PageModel {       
        //List<string> elementos = new List<string>();
        //public List<string> ListaGatos {get;set;}
        //public List<Gato> lisGatos;
        private readonly IRepositorioGato repositorioGato;
        private static IRepositorioGato _repoGato = new RepositorioGato(new Persistencia.AppContexto());
        public IEnumerable<Gato> Gatos {get;set;}

        public ListarGatoModel(IRepositorioGato repositorioGato){
            this.repositorioGato = repositorioGato;
        }
        

        public void OnGet(){
          this.Gatos = _repoGato.GetAllGato();  
            //= gatos;
           /*foreach (Gato p in gatos){
               elementos.Add(p.Nombre);           
            }*/ 
            // ListaGatos = new  List<string>();
            // ListaGatos.AddRange(elementos); 
           /*var Gatos = repositorioGato.GetAllGato();    
            foreach (Gato p in Gatos)            {
                Console.WriteLine(p.Nombre);
            }*/ 
        }
        public void EliminarGato(){            
            _repoGato.DeletedGato(2);
            Console.WriteLine("Gato borrado!");           
        }

    }
}
