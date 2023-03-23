using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmBoom
{
    internal class Film:Janrs
    {
        public int setStar { get; set; }
        public string ChoosenFilm { get;set; }
        public Film(string ChoosenFilm):base(ChoosenFilm){this.ChoosenFilm = ChoosenFilm;}
        public Film(int setStar) : base(setStar) { this.setStar = setStar; }
        public override void PrintCost() { }
    }
}
