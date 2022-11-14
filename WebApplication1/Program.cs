using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Entity.Framework;
using System.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {

        }
    }

    public class Quarto
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public bool AC { get; set; }
        public int Piso { get; set; }
        public Tipologia Tipologias { get; set; }
        
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
        public Quarto Quartos { get; set; }

    }

    public class MeuContexto : DbContext
    {
        public DbSet<Quarto> Quartos { get; set; }
        public DbSet<Tipologia> Tipologia { get; set; }
        public DbSet<Reserva> Reservas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"SERVER=(localdb)\mssqllocaldb; DATABASE=Alunos; TRUSTED_CONNECTION=TRUE;");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
