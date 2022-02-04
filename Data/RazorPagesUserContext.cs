#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RPC.Models;

    public class RazorPagesUserContext : DbContext
    {
        public RazorPagesUserContext (DbContextOptions<RazorPagesUserContext> options)
            : base(options)
        {
        }

        public DbSet<RPC.Models.User> User { get; set; }
    }
