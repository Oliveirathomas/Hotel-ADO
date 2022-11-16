using Hotel_SqlServer_1.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_SqlServer_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MenuInicial();
            /*
            using (MeuContexto ctx = new MeuContexto())
            {
                if (ctx.Quartos.Count == 0)
                {
                    Tipologia T1 = new Tipologia() { Tipo = "T1" };
                    Tipologia T2 = new Tipologia() { Tipo = "T2" };
                    Tipologia T3 = new Tipologia() { Tipo = "T3" };
                    Quarto quartoT1 = new Quarto() { Numero = 1, AC = true, Imagem = null, Piso = 0, Tipologias = T1 };
                    Quarto quartoT2 = new Quarto() { Numero = 2, AC = true, Imagem = null, Piso = 1, Tipologias = T2 };
                    Quarto quartoT3 = new Quarto() { Numero = 12, AC = false, Imagem = null, Piso = 0, Tipologias = T3 };
                    ctx.AddRange(T1, T2, T3, quartoT1, quartoT2, quartoT3);
                    ctx.SaveChanges();
                }
            }
        }
        public class Quarto
        {
            public int Id { get; set; }
            public int Numero { get; set; }
            public bool AC { get; set; }
            public int Piso { get; set; }
            public int TipologiaID { get; set; } // Foreign Key criada na BD
            public Tipologia Tipologias { get; set; } // Propriedade navegação    tipologia.Quarto.Tipo
            public Reserva Reservas { get; set; }  //  Propriedade navegação
            public int ReservaID { get; set; }  // Foreign Key criada na BD
            public byte[] Imagem { get; set; }

            public void PedirQuarto()
            {

            }
        }
        public class Tipologia
        {
            public int Id { get; set; }
            public string Tipo { get; set; }
            public ICollection<Quarto> Quartos { get; set; }
            public ICollection<Reserva> Reservas { get; set; }
        }

        public class Reserva
        {
            public int Id { get; set; }
            public int Numero { get; set; }
            public DateTime CheckIn { get; set; }
            public DateTime CheckOut { get; set; }
            public int QuartoID { get; set; }
            public Quarto Quartos { get; set; }

        }
        /*
        public class MeuContexto : DbContext
        {
            public DbSet<Quarto> Quartos { get; set; }
            public DbSet<Tipologia> Tipologias { get; set; }
            public DbSet<Reserva> Reservas { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(@"SERVER=(localdb)\mssqllocaldb; DATABASE=Alunos; TRUSTED_CONNECTION=TRUE;");

                base.OnConfiguring(optionsBuilder);
            }
        */
        }
        public static void MenuInicial()
        {
            Console.WriteLine("Hotel Rumos");
            Console.WriteLine("Selecione uma opção:\n 1-Nova Reserva \n 2-CheckIn \n 3-CheckOut \n 4-Consulta \n 5-Sair");
            int escolha = int.Parse(Console.ReadLine());
            switch (escolha)
                
            {
                case 1: Hospede.PedirDados(); break;
                case 2: Reserva.PedirCheckIn(); break;
                case 3: Reserva.PedirCheckOut(); break;
                case 4: ; Hospede.MostrarHospedes(); break;
                case 5: ; break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }

        
     
    }
}
