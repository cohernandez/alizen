using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Security.AccessControl;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace alizen.Models {
    public class ApplicationDBContext : DbContext {
        public ApplicationDBContext (DbContextOptions<ApplicationDBContext> options) : base (options) { }
        
        public class StoreContext : DbContext {
            public DbSet<Product> Products { get; set; }
            public DbSet<User> Users { get; set; }
            public DbSet<Basket> Baskets { get; set; }
            public DbSet<Client> Clients { get; set; }
        }

    }

}