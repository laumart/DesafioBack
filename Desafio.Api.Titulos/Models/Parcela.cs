using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Desafio.Api.Titulos.Models
{
    [Table("parcela")]
    public class Parcela
    {
        public int Numero { get; set; }
        public DateTime Vencimento { get; set; }
        public decimal Valor { get; set; }
    }
}