﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRest.Models
{
    public class FundoCapital
    {
        public Guid Id { get;}
        public string Nome { get; set; }
        public decimal ValorAtual { get; set; }
        public decimal ValorNecessario { get; set; }
        public DateTime? DataResgate { get; set; } 

        public FundoCapital()
        {
            Id = Guid.NewGuid(); 
        }
    }
}
