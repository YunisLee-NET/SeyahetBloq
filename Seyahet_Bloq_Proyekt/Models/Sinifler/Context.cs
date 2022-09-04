using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Seyahet_Bloq_Proyekt.Models.Sinifler
{
    public class Context : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Bloq> Bloqs { get; set; }
        public DbSet<Elaqe> Elaqes { get; set; }
        public DbSet<Haqqimizda> Haqqimizdas { get; set; }
        public DbSet<Unvan> Unvans { get; set; }
        public DbSet<Yorumlar> Yorumlars { get; set; }
    }
}