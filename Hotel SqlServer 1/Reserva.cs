using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace Hotel_SqlServer_1
{
    public class Reserva
    {
        public int Id { get; set; }
        public int NumeroReserva { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int QuartoId { get; set; }
        public Quarto Quartos { get; set; }

        public static List<Reserva> ReservaList = new List<Reserva>();

        public static void NovaReserva()
        {
            Reserva reserva = new Reserva();
            Random random = new Random(); // criacao numero reserva
            reserva.NumeroReserva = random.Next(1, 1000);
            reserva.CheckIn = DateTime.Now.AddDays(-4); 
            Reserva.ReservaList.Add(reserva);
            Console.WriteLine(reserva.ToString());
        }
        public override string ToString()
        {
            return $"Numero Reserva {NumeroReserva} CheckIN: {CheckIn}";
        }

        public static void PedirCheckIn()
        {
          
            Reserva reserva = new Reserva();
            Console.WriteLine("Insira numero reserva: ");
            reserva.NumeroReserva = int.Parse(Console.ReadLine());
            reserva.CheckIn = DateTime.Now.AddDays(-2);
            Reserva.ReservaList.Add(reserva);
            Console.WriteLine(reserva.ToString());
            Hospede.PedirDadosComReserva();
            
        }

        public static void PedirCheckOut()
        {
            Console.WriteLine("indique numero quarto:");
            Reserva reserva = new Reserva();
            reserva.NumeroReserva = int.Parse(Console.ReadLine());
            Reserva.ReservaList.Remove(reserva);
            Hospede.CheckOut();
        }
    }
}
