using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmBoom
{
    internal class Paid : Janrs
    {
        public int setStar { get; set; }
        public string ChoosenFilm { get; set; }
        public Paid(string ChoosenFilm) : base(ChoosenFilm) { this.ChoosenFilm = ChoosenFilm; }
        public Paid(int setStar) : base(setStar) {this.setStar = setStar;}
        const int Cost = 50;
        public override void PrintCost()
        {
            Console.WriteLine($"It costs {Cost}$");
        }
    }
}
