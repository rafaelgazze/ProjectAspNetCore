using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aspnetcore.Web.Model
{
    public class Producao
    {
        public int ProducaoId { get; set; }

        public int MateriaPrimaId { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public MateriaPrima MateriaPrima { get; set; }
        public Produto Produto { get; set; }
    }
}
