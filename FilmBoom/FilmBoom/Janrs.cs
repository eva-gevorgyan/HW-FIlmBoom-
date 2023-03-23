using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmBoom
{
    abstract class Janrs
    {
        public int setStar { get; set; }
        public string ChoosenFilm { get; set; }
        public Janrs(string ChoosenFilm) { }
        public Janrs(int setStar) { }
        public void SetStar(int a)
        {
            int set = 0;
            set = a + setStar;
            if (set >= 5)
            {
                set = 5;
            }
        }
        public string[] janrs_list = { "Documentary", "Comedy", "Action", "Drama", "Thriller", "Romantic" };
        public int[] films_year = { 2001, 1999, 2022, 2023, 2000, 2004 };
        public int[] views = { 220000, 350, 450001, 69870, 0, 723564 };
        public int[] stars = { 3, 1, 4, 5, 0, 5 };
        public abstract void PrintCost();
        public void print_film_year(string filmname)
        {
            for (int i = 0; i < janrs_list.Length; i++)
            {
                for (int j = 0; j < films_year.Length; j++)
                {
                    for (int k = 0; k < views.Length; k++)
                    {
                        for (int m = 0; m < stars.Length; m++)
                        {
                            if (filmname == janrs_list[i] && i == j && j == k && k == m)
                            {
                                Console.WriteLine($"You choose {filmname}, {films_year[j]}, rating {stars[m]}, {views[k]} views");
                                Console.Write("In main role - ");
                                ShowActors(i);
                                SetStar(stars[m]);
                                break;
                            }
                        }
                    }
                }
            }
        }
        public List<string> Actors_List=new List<string>() {"Tom Hardi","Johnny Depp","Ryan Reynolds","Leonardo DiCaprio","Will Smith","Brad Pitt"};
        public void ShowActors(int i)
        {
                switch (i)
                {
                    case 0:
                        Console.WriteLine(Actors_List[0]);
                        break;
                    case 1:
                        Console.WriteLine(Actors_List[1]);
                        break;
                    case 2:
                        Console.WriteLine(Actors_List[2]);
                        break;
                    case 3:
                        Console.WriteLine(Actors_List[3]);
                        break;
                    case 4:
                        Console.WriteLine(Actors_List[4]);
                        break;
                    case 5:
                        Console.WriteLine(Actors_List[5]);
                        break;
                }
        }
    }
}
