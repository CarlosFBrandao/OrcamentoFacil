﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloEndereco
    {
        public int IdEndereco { get; set; }
        public string Cep { get; set; }
        public string Numero { get; set; }
        public string Logradouro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
    }
}
