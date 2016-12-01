using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aspnetcore.Web.Context;
using Aspnetcore.Web.Model;

namespace Aspnetcore.Web.Seed
{
    public static class SeedDatabase
    {
        public static void Initialize(AcmeContext context)
        {
            if (context.MateriasPrimas.Any())
                return;

            List<MateriaPrima> materiasPrimas = new List<MateriaPrima>
            {
                new MateriaPrima {Nome = "Dynamite Sticks", EstoqueMaximo = 1000, EstoqueMinimo = 1},
                new MateriaPrima {Nome = "Fuses", EstoqueMaximo = 1000, EstoqueMinimo = 10},
                new MateriaPrima {Nome = "Magnet", EstoqueMaximo = 10, EstoqueMinimo = 1},
                new MateriaPrima {Nome = "Unicycle", EstoqueMaximo = 3, EstoqueMinimo = 1},
                new MateriaPrima {Nome = "Jet", EstoqueMaximo = 5, EstoqueMinimo = 1},
                new MateriaPrima {Nome = "Pills", EstoqueMaximo = 10000, EstoqueMinimo = 500},
                new MateriaPrima {Nome = "Boulders", EstoqueMaximo = 20, EstoqueMinimo = 1},
                new MateriaPrima {Nome = "Anvil", EstoqueMaximo = 100, EstoqueMinimo = 5},
                new MateriaPrima {Nome = "Bottle", EstoqueMaximo = 50, EstoqueMinimo = 1},
                new MateriaPrima {Nome = "R-P-M", EstoqueMaximo = 1000, EstoqueMinimo = 50},
                new MateriaPrima {Nome = "Tornado Seeds", EstoqueMaximo = 10000, EstoqueMinimo = 10},
                new MateriaPrima {Nome = "Water Pistol", EstoqueMaximo = 5, EstoqueMinimo = 1}

            };

            context.MateriasPrimas.AddRange(materiasPrimas);
            context.SaveChanges();

        }
    }
}
