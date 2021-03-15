﻿using EEC.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EEC.Catalogo.API.Models
{
    public class Produto : Entity, IAggregateRoot
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Imagem { get; set; }
        public int QuantidadeEstoque { get; set; } 
    }
}
