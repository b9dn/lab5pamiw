using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmWebMVC.Client.Models
{
    public class Film
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Director { get; set; }

        public string Barcode { get; set; }

        public decimal Price { get; set; }

        public DateTime ReleaseDate { get; set; }
    }
}
