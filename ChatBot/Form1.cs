using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace ChatBot
{
    public partial class Form1 : Form
    {
        private TextChat chat;
        Films films = new Films();
        public Form1()
        {
            TextChat tmp = new TextChat(this);
            StartForm form = new StartForm(this);
            chat = tmp;
            form.TopMost = true;
            form.Show();
            InitializeComponent();
            textBoxMessages.ReadOnly = true;
            textBoxMessages.ScrollBars = ScrollBars.Vertical;
            Text = textBoxMessages.Text;
            bool RepeatText = Text.Contains("Будь ласка, введіть жанр фільма, рейтинг або рік для пошуку");
            if (RepeatText == true)
            {
                textBoxMessages.AppendText("Бот: " + "Будь ласка, введіть жанр фільма, рейтинг або рік для пошуку" + Environment.NewLine);
            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            films.LoadXMLFile("");
        }

        
        private void buttonSend_Click(object sender, EventArgs e)
        {
            chat.SendingMessages();
            chat.ReplyToMessage();
            chat.FindingByGenre();
            chat.FilmCounter();

        }



        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Ви бажаєте зберегти цей діалог?",
                                     "Вихід", MessageBoxButtons.YesNo);
            if(dialog == DialogResult.Yes)
            {
                chat.SaveLog();
            }

            Application.Exit();
        }

        private void textBoxsendingMessages_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBoxSendingMessages.Text.ToString() == System.Environment.NewLine)
                textBoxSendingMessages.Clear();
            if (textBoxSendingMessages.Text != String.Empty) {
                if (e.KeyCode == Keys.Enter)
                {
                    chat.SendingMessages();
                    chat.ReplyToMessage();
                    chat.FilmCounter();
                }
            }
        }


        private void roundedCornerButtonRating_Click(object sender, EventArgs e)
        {
            RatingForm form = new RatingForm(this);
            form.Show();
        }

        private void roundedCornerButtonGenre_Click(object sender, EventArgs e)
        {
            GenreForm form = new GenreForm(this);
            form.Show();
        //    form.Location = new Point(728, 610);

        }

        private void roundedCornerButtonYear_Click(object sender, EventArgs e)
        {

            YearForm form = new YearForm(this);
            form.Show();

        }

        private void roundedCornerButtonRandom_Click(object sender, EventArgs e)
        {
            chat.RandomFilm();
            chat.FilmCounter();
        }


        private void buttonQuestion_Click(object sender, EventArgs e)
        {
            QuestionForm form = new QuestionForm();
            form.Show();
        }

        private void buttonCleanDialog_Click(object sender, EventArgs e)
        {
            textBoxMessages.Clear();
            textBoxMessages.AppendText("Бот: " + "Будь ласка, введіть жанр фільма, рейтинг або рік для пошуку" + Environment.NewLine);
            chat.FilmCounter();

        }
    }
}
