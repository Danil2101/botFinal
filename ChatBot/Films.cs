using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ChatBot
{
    class Films
    {
        private ArrayList films = new ArrayList();

        public void LoadXMLFile(string filmName)
        {
            Film film;
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("..\\..\\listFilmsUkr.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                //                Console.WriteLine("-- -Start foreach---");
                if (xnode.HasChildNodes)
                {
                    //                    Console.WriteLine("---Start if---");
                    film = new Film();
                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {
                        if (childnode.Name == "id")
                        {
                            film.Id = Convert.ToInt32(childnode.InnerText);
                        }
                        if (childnode.Name == "name")
                        {
                            film.Name = childnode.InnerText;
                        }
                        if (childnode.Name == "year")
                        {
                            film.Year = Convert.ToInt32(childnode.InnerText);
                        }
                        if (childnode.Name == "director")
                        {
                            film.Director = childnode.InnerText;
                        }
                        if (childnode.Name == "genre")
                        {
                            film.Genre = childnode.InnerText;
                        }
                        if (childnode.Name == "rating")
                        {
                            film.Rating = Convert.ToInt32(childnode.InnerText);
                        }
                    }
                    films.Add(film);
                    Console.WriteLine();
                }
            }
        }

        public void Print()
        {
            foreach (Film f in films)
            {
                Console.WriteLine(f);
            }
        }

        public ArrayList GetAllList()
        {
            return this.films;
        }

        public ArrayList GetByRating(int rating)
        {
            ArrayList ratingList = new ArrayList();

            foreach(Film f in this.films)
            {
                if(f.Rating == rating)
                {
                    ratingList.Add(f);
                }
            }
            return ratingList;
        }

        public ArrayList GetByRatingBetween(int ratingStart, int ratingEnd)
        {
            ArrayList ratingList = new ArrayList();

            foreach (Film f in this.films)
            {
                if (ratingStart <= f.Rating && f.Rating <= ratingEnd)
                {
                    ratingList.Add(f);
                }
            }
            return ratingList;
        }

        public ArrayList GetByYear(int year)
        {
            ArrayList returnList = new ArrayList();

            foreach (Film f in this.films)
            {
                if (f.Year == year)
                {
                    returnList.Add(f);
                }
            }
            return returnList;
        }

        public ArrayList GetByYearBetween(int yearStart, int yearEnd)
        {
            ArrayList returnList = new ArrayList();

            foreach (Film f in this.films)
            {
                if (yearStart <= f.Year && f.Year <= yearEnd)
                {
                    returnList.Add(f);
                }
            }
            return returnList;
        }

        public ArrayList GetContainName(string name)
        {
            ArrayList returnList = new ArrayList();

            foreach (Film f in this.films)
            {
                if (f.Name.ToUpper().Contains(name.ToUpper()))
                {
                    returnList.Add(f);
                }
            }
            return returnList;
        }

        public ArrayList GetContainNameDirector(string director)
        {
            ArrayList returnList = new ArrayList();

            foreach (Film f in this.films)
            {
              //  if (f.Director.ToUpper().Contains(director.ToUpper()))
                {
                    returnList.Add(f);
                }
            }
            return returnList;
        }

        public ArrayList GetContainNameGenre(string genre)
        {
            ArrayList returnList = new ArrayList();

            foreach (Film f in this.films)
            {
                if (f.Genre.ToUpper().Contains(genre.ToUpper()))
                {
                    returnList.Add(f);
                }
            }
            return returnList;
        }

        public ArrayList GetFilmById(int id)
        {
            ArrayList returnList = new ArrayList();

            foreach (Film f in this.films)
            {
                if (f.Id == id)
                {
                    returnList.Add(f);
                }
            }
            return returnList;
        }


    }
}
