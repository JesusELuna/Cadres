﻿using DAOs.Interfaces;
using Entidades;
using Entidades.DTOs;
using System.Collections.Generic;

namespace Services.Interfaces
{
    public interface IVarillaService : IGenericService<IVarillaDAO, Varilla, int>
    {
        void Insert(VarillaDTO varillaDTO);

        VarillaDTO GetDTOById(int id);

        IList<VarillaDTO> GetDTOAll();

        void SetCantidad(VarillaDTO varillaDTO);

        void SetPrecio(VarillaDTO varillaDTO);

        void DarDeBaja(VarillaDTO varillaDTO);

        IList<VarillaDTO> GetByDisponibilidad(bool estaDisponible);

        IList<VarillaDTO> GetByAncho(decimal ancho);
    }
}
