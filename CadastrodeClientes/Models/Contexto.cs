using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastrodeClientes.Models
{
    public class Contexto : DbContext
    { // Criação de context que criara o banco de dados a partir do Entity
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
            Database.EnsureCreated();// Criação de banco de dados caso não haja
        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
