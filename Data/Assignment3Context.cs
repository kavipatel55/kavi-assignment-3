using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assignment3.model;

namespace Assignment3.Data
{
    public class Assignment3Context : DbContext
    {
        public Assignment3Context (DbContextOptions<Assignment3Context> options)
            : base(options)
        {
        }

        public DbSet<Assignment3.model.User> User { get; set; } = default!;
        public DbSet<Assignment3.model.product> product { get; set; } = default!;
        public DbSet<Assignment3.model.Comment> Comment { get; set; } = default!;
        public DbSet<Assignment3.model.order> order { get; set; } = default!;
        public DbSet<Assignment3.model.cart> cart { get; set; } = default!;
    }
}
