using System;
namespace veterinaria.App.Dominio {
    public class Visita{
        public int Id{get; set;}
        public float Temperatura {get; set;}
        public float Peso {get; set;}
        public float FrecuenciaRespiratoria {get; set;}
        public float FrecuenciaCardiaca {get; set;}
        public string EstadoDeAnimo {get; set;}
        public DateTime FechaVisita {get; set;}
        public int IdProfesional {get; set;}
        public int Recomendaciones {get; set;}
        public int Medicamentos {get; set;}
    }
}