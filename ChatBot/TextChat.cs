using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
namespace ChatBot
{
    public class TextChat
    {
        Films films = new Films();
        private Form1 frm1;
        public string question;
        
        public TextChat (Form1 form)
        {
            films.LoadXMLFile("");
            frm1 = form;
        }
        public void SendingMessages()
        {
            string message = frm1.textBoxSendingMessages.Text.ToString();
            string name = "Користувач: ";
            string fullMessage = name + message;
            question = message;
            frm1.textBoxMessages.AppendText(fullMessage + Environment.NewLine);
            frm1.textBoxSendingMessages.Clear();
            
        }
        public void SaveLog()
        {
            string writePath = @"log.txt";

            string text = frm1.textBoxMessages.Text;
            try 
            {
                using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(text);
                }

            }
            catch (Exception e)
            {
            }
    
        }
        public void OpenLog()
        {
            if (File.Exists(@"log.txt"))
            {
                frm1.textBoxMessages.AppendText(File.ReadAllText(@"log.txt", Encoding.GetEncoding(1251)));
                FilmCounter();
            }
        }
        

         
     

        void FindingByYear()
        {
            int res;
            bool isInt = Int32.TryParse(question, out res);
            if (isInt == true)
            {
                int Year = 0;
                Year = Convert.ToInt32(question);
                    foreach (Film f in films.GetByYear(Year))
                    {
                        frm1.textBoxMessages.AppendText("Бот: " +  f.ToString() + Environment.NewLine);
                    }
                    
            }
        }


        void FindingByRating()
        {
            int res;
            bool isInt = Int32.TryParse(question, out res);
            if (isInt == true)
            {
                int rating = 0;
                rating = Convert.ToInt32(question);

                foreach (Film f in films.GetByRating(rating))
                {
                    frm1.textBoxMessages.AppendText("Бот: " + f.ToString() + Environment.NewLine);
                }


            }
        }
        public void FindingByGenre()
        {
            if (question.Length > 4)
            {
                foreach (Film f in films.GetContainNameGenre(question))

                {
                    frm1.textBoxMessages.AppendText("Бот: " + f.ToString() + Environment.NewLine);
                }
            }
            
      
        }

         int Counter()
        {
            string Text = frm1.textBoxMessages.Text;
            int RatingCount = new Regex("Рейтинг").Matches(Text).Count;
            int BotCount = new Regex("Бот:").Matches(Text).Count;
            int NameCount = new Regex("Назва").Matches(Text).Count;
            int YearCount = new Regex("Рік").Matches(Text).Count;
            int Count = Math.Min(Math.Min(RatingCount, BotCount), Math.Min(YearCount, NameCount));
            return Count;
        }
        public void FilmCounter() 
        {
            frm1.label1.Text = "Кількість повідомлень: " + Convert.ToString(Counter());
        }
       public void ReplyToMessage()
            {
            if (question != "")
            {
                FindingByYear();
                FindingByRating();
                FindingByGenre();
            }

        }
        public void RandomFilm()
        {
            Random rand = new Random();
            int valueId = rand.Next(1, 250);
            foreach (Film f in films.GetFilmById(valueId))
            {
                frm1.textBoxMessages.AppendText("Бот: " + f.ToString() + Environment.NewLine);
            }
        }

        }
    }