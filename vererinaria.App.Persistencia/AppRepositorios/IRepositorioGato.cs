using System;
using System.Collections.Generic;
using System.Linq;
using veterinaria.App.Dominio;

namespace veterinaria.App.Persistencia {
    public interface IRepositorioGato{
        IEnumerable<Gato> GetAllGato();
        Gato AddGato(Gato gato);
        Gato UpdateGato(Gato gato, int idGato_original);
        void DeletedGato(int idGato);
        Gato GetGato(int idGato);
    }
}

