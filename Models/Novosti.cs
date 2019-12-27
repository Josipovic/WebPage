using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stranica.Models
{
    public class Novosti
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Text { get; set; }
        public string ImageUrl { get; set; }

        public virtual List<Komentar> Komentari { get; set; }
        public Novosti()
        {
            Komentari = new List<Komentar>();
        }
    }
}