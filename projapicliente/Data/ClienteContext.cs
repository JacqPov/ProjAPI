using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using projapicliente.Models;

    public class ClienteContext : DbContext
    {
        public ClienteContext (DbContextOptions<ClienteContext> options)
            : base(options)
        {
        }

        public DbSet<projapicliente.Models.Cliente> Cliente { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
    }
