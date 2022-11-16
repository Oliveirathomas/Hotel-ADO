using System.Collections.Generic;

namespace Hotel_SqlServer_1.Models
{
    public class Hospede
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Cartao { get; set; }
        public Quarto Quartos { get; set; }
        public int QuartoId { get; set; }
        public Reserva Reservas { get; set; }
        public int ReservaID {get; set; }

        List<Hospede> Hospedes = new List<Hospede>();

    }
}
