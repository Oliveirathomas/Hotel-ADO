using System.Collections.Generic;

namespace Hotel_SqlServer_1.Models
{
    public class Quarto
    {
        public int Id { get; set; }
        public int Piso { get; set; }
        public int Numero { get; set; }
        public bool AC { get; set; }
        public string Tipologia { get; set; }
        public int ReservaId { get; set; }
        public Reserva Reservas { get; set; }
        
    }
}
