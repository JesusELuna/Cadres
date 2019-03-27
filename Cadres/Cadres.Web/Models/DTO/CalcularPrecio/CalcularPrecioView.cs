﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Cadres.Web.Models.DTO.CalcularPrecio
{
    public class CalcularPrecioView
    {
        [Required]
        [Range(1, 200)]
        public decimal Ancho { get; set; }

        [Required]
        [Range(1, 200)]
        public decimal Largo { get; set; }

        [Required]
        [DisplayName("Varilla")]
        public long VarillaId { get; set; }
    }
}