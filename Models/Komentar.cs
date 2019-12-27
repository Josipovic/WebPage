using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stranica.Models
{
    public class Komentar
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Author { get; set; }
        public string Text { get; set; }
        public virtual Novosti Novosti { get; set; }
    }
}