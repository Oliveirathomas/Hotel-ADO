using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;

namespace Hotel_SqlServer_1
{
    internal class Hospede
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int NumeroQuarto { get; set; }
        public Quarto Quartos { get; set; }
        public int QuartoId { get; set; }
        public Reserva Reservas { get; set; }
        public int ReservaId { get; set; }
        public static List<Hospede> HospedeList = new List<Hospede>();

        public static void PedirDados()
        {
            
            Hospede novo = new Hospede();
            Console.WriteLine("Nome do hóspede: ");
            novo.Nome = Console.ReadLine();
            Random random = new Random(); // criação numero quarto
            novo.NumeroQuarto= random.Next(0, 30);
            HospedeList.Add(novo);
            Reserva.NovaReserva();
            Console.WriteLine(novo.ToString());
            Program.MenuInicial();
        }
        public static void PedirDadosComReserva()
        {
            Hospede novo = new Hospede();
            Console.WriteLine("Nome do hóspede: ");
            novo.Nome = Console.ReadLine();
            Random random = new Random(); // criação numero quarto
            novo.NumeroQuarto = random.Next(0, 30);
            HospedeList.Add(novo);
            
            Program.MenuInicial();
        }
        public static void CheckOut()
        {
            Hospede novo = new Hospede();
            Reserva reserva = new Reserva();
        }
        public override string ToString()
        {
            return $"Nome: {Nome} Cartão {NumeroQuarto} ";
        }
        virtual public void Mostrar()
        {
            Console.WriteLine(ToString());
        }
        public static void MostrarHospedes()
        {
            foreach (Hospede novo in HospedeList)
            {
                Console.WriteLine(novo.ToString());
            }
            Program.MenuInicial();
        }
    }
}
