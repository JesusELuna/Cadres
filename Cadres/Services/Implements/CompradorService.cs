﻿using DAOs.Implements;
using Entidades;
using Entidades.DTO;
using Entidades.Filter;
using Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Services.Implements
{
    public class CompradorService : GenericService<CompradorDAO, Comprador, int>, ICompradorService
    {
        public CompradorService(CompradorDAO entityDAO) : base(entityDAO)
        {
        }

        public IList<CompradorDTO> GetByFilter(FilterComprador filter)
        {
            return this.EntityDAO.GetByFilter(filter).Select(x => EntityConverter.ConvertCompradorToCompradorDTO(x)).ToList();
        }

        public IList<CompradorDTO> GetDTOAll()
        {
            return this.GetAll().Select(x => EntityConverter.ConvertCompradorToCompradorDTO(x)).ToList();
        }

        public CompradorDTO GetDTOById(int id)
        {
            Comprador comprador = this.GetById(id);

            return EntityConverter.ConvertCompradorToCompradorDTO(comprador);
        }
    }
}
