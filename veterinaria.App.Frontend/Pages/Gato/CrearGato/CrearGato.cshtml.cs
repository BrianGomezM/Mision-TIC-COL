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
    public class CrearGatoModel : PageModel
    {
       
       private static  IRepositorioGato _repoGato = new RepositorioGato(new Persistencia.AppContexto());
       [BindProperty]
       public Gato Nuevogato {get;set;}
     


        public void OnGet(){
            Nuevogato = new Gato();
            /*var gato = new Gato{
                Nombre = "prueba",
                Raza = "prueba",
                Edad = 20,
                Color = "Blanco"
            };
            _repoGato.AddGato(gato);*/
        }

        public IActionResult OnPost(){
            _repoGato.AddGato(Nuevogato);
             return Page();
        } 
    }
}
