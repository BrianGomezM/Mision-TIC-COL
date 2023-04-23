using System;
namespace veterinaria.App.Dominio {
    public class Propietario : Persona {
       public string Direccion {get; set;}
       public Gato duenio {get; set;}
    }
}