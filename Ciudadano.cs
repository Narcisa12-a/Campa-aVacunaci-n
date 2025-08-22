using System;

namespace CampañaVacunacion
{
    public class Ciudadano
    {
        public int Id { get; set; }

        public Ciudadano(int id)
        {
            Id = id;
        }

        public override string ToString()
        {
            return $"Ciudadano {Id}";
        }

        // Sobrescribimos Equals y GetHashCode para que HashSet funcione correctamente
        public override bool Equals(object obj)
        {
            return obj is Ciudadano otro && Id == otro.Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}