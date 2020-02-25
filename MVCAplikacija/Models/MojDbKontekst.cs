using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace MVCAplikacija.Models
{
    public class MojDbKontekst : DbContext
    {
        public MojDbKontekst(DbContextOptions<MojDbKontekst> options)
            : base(options)
        {
        }

        public DbSet<MVCAplikacija.Models.Users> Users { get; set; }
        public DbSet<MVCAplikacija.Models.Groups> Groups { get; set; }
    }
}

