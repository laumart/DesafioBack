﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioBack.Domain.Domains
{
    public class TituloInclusao : TituloBase
    {
        public virtual List<ParcelaInclusao> Parcelas { get; set; }
    }
}
