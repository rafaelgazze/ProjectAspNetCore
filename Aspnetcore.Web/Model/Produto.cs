﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aspnetcore.Web.Model
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public MateriaPrima MateriaPrima { get; set; }
        public int Quantidade { get; set; }
    }
}
