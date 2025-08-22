using System;
using System.Collections.Generic;
using System.Linq;

namespace CampañaVacunacion
{
    public static class Generador
    {
        // Generar toda la población de ciudadanos (1 a 500)
        public static List<Ciudadano> GenerarCiudadanos(int cantidad)
        {
            List<Ciudadano> lista = new List<Ciudadano>();
            for (int i = 1; i <= cantidad; i++)
            {
                lista.Add(new Ciudadano(i));
            }
            return lista;
        }

        // Selecciona "cantidad" ciudadanos aleatorios desde la población
        public static HashSet<Ciudadano> GenerarVacunados(List<Ciudadano> poblacion, int cantidad, Random rnd)
        {
            HashSet<Ciudadano> vacunados = new HashSet<Ciudadano>();
            List<Ciudadano> posibles = poblacion.ToList();

            while (vacunados.Count < cantidad && posibles.Count > 0)
            {
                int index = rnd.Next(posibles.Count);
                vacunados.Add(posibles[index]);
                posibles.RemoveAt(index);
            }

            return vacunados;
        }
    }
}