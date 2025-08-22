using System;
using System.Collections.Generic;
using System.Linq;

namespace CampañaVacunacion
{
    public static class Utilidades
    {
        public static void ImprimirListado(HashSet<Ciudadano> listado, string titulo)
        {
            Console.WriteLine($"\n{titulo}:");

            if (listado.Count == 0)
            {
                Console.WriteLine(" - No hay ciudadanos en este listado.");
                return;
            }

            foreach (var ciudadano in listado.OrderBy(x => x.Id))
            {
                Console.WriteLine(" - " + ciudadano);
            }

            Console.WriteLine($"Total: {listado.Count}");
        }
    }
}