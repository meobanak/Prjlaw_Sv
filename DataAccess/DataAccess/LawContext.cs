using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace DataAccess
{
    public class LawContext : DbContext
    {

        public LawContext(DbContextOptions<LawContext> options) : base(options)
        {
        }

        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Article> Article { get; set; }
        public virtual DbSet<BusinessLine> BusinessLine { get; set; }
        public virtual DbSet<CapContribution> CapContribution { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<Nationality> Nationality { get; set; }

    }
}
