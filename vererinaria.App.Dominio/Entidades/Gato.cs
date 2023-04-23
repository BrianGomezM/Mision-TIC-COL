using System;
namespace veterinaria.App.Dominio {
    public class Gato{
        public int Id{get; set;}
        public string Nombre {get; set;}
        public string Raza {get; set;}
        public int Edad {get; set;}
        public string Color {get; set;}
        public Visita[] visitas {get; set;}
    }
}