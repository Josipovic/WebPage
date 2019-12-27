using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Stranica.Models
{
    public class NovostiContext:DbContext
    {
        public  DbSet<Novosti>Novosti { get; set; }
        public DbSet<Komentar>Komentari { get; set; }

    }
}