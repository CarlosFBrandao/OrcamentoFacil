﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloCliente : ModeloEndereco
    {
        public int IdCliente { get; set; }
        public string NomeCliente { get; set; }
        public string Contato { get; set; }
        public string Telefone { get; set; }
    }
}
