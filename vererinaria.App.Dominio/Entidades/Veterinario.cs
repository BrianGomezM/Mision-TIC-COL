using System;
namespace veterinaria.App.Dominio {
    public class Veterinario : Persona {
       public string TargetaProfesional {get; set;}
       public Visita[] visitas {get; set;}
       public Gato atiende {get; set;}
    }
}