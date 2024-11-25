using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ATVcadCliente.Models;

namespace ATVcadCliente.Data
{
    public class ATVcadClienteContext : DbContext
    {
        public ATVcadClienteContext (DbContextOptions<ATVcadClienteContext> options)
            : base(options)
        {
        }

        public DbSet<ATVcadCliente.Models.Cliente> Cliente { get; set; } = default!;
    }
}
