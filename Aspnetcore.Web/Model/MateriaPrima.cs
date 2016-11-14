using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aspnetcore.Web.Model
{
    public class MateriaPrima
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int EstoqueMinimo { get; set; }
        public int EstoqueMaximo { get; set; }
    }
}
