using System.Collections.Generic;

namespace Hotel_SqlServer_1.Models
{
    public class Reserva
    {
        public int Id { get; set; }
        public int NumeroReserva { get; set; }
        public int QuartoId { get; set; }
        public Quarto Quartos { get; set; }
        
    }
}
