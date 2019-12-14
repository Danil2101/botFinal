using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot
{
    class Film
    {
        public int Id;
        public string Name;
        public int Year;
        public string Director;
        public string Genre;
        public int Rating;

        public override string ToString()
        {
            string FullName = " \r\n " +  "Назва: " + Name + " \r\n " + "Рік " + Year + " \r\n " + "Режисер: " + Director +  " \r\n " + "Жанр: " + Genre + " \r\n " + "Рейтинг: " + Rating + " \r\n ";
            return FullName;
        }
    }
}
