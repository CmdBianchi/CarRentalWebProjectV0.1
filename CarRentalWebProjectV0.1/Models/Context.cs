using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace Models {
    public class Context : DbContext {
        public DbSet<CarRental> CarRentals { get; set; }

        public Context(DbContextOptions<Context> options) : base(options) {

        }
    }
}
