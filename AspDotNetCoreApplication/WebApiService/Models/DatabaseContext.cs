using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiService.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options):base(options)
        {
        }

        public DbSet<Users> User { get; set; }

        public DbSet<PaymentDetails> PaymentDetail { get; set; }
    }
}
