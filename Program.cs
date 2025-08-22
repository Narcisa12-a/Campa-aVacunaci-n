using System;
using System.Collections.Generic;
using System.Linq;

namespace CampañaVacunacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            // 1. Generar 500 ciudadanos
            var poblacion = Generador.GenerarCiudadanos(500);

            // 2. Seleccionar 75 vacunados con Pfizer y 75 con AstraZeneca
            var vacunadosPfizer = Generador.GenerarVacunados(poblacion, 75, rnd);
            var vacunadosAstra  = Generador.GenerarVacunados(poblacion, 75, rnd);

            // 3. Operaciones de teoría de conjuntos
            var noVacunados   = poblacion.Except(vacunadosPfizer.Union(vacunadosAstra)).ToHashSet();
            var ambasDosis    = vacunadosPfizer.Intersect(vacunadosAstra).ToHashSet();
            var soloPfizer    = vacunadosPfizer.Except(vacunadosAstra).ToHashSet();
            var soloAstra     = vacunadosAstra.Except(vacunadosPfizer).ToHashSet();

            // 4. Mostrar resultados
            Utilidades.ImprimirListado(noVacunados, "Ciudadanos que NO se han vacunado");
            Utilidades.ImprimirListado(ambasDosis, "Ciudadanos que han recibido AMBAS dosis");
            Utilidades.ImprimirListado(soloPfizer, "Ciudadanos que solo recibieron Pfizer");
            Utilidades.ImprimirListado(soloAstra, "Ciudadanos que solo recibieron AstraZeneca");

            Console.WriteLine("\n--- Proceso terminado ---");
        }
    }
}