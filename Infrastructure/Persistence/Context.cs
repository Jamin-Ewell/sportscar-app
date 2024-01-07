using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence
{
    public class Context : DbContext
    {


        public DbSet<Car>? Cars { get; set; }

        public DbSet<User>? User { get; set; }

        public DbSet<Dealer>? Dealer { get; set; }
    }
}
