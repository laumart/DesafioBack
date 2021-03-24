using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.Api.Titulos.Models
{
    [Table("titulo")]
    public class Titulo
    {

        public long Numero { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public decimal juros { get; set; }
        public decimal multa { get; set; }

        public Parcela parcelas { get; set; }

    }
}
