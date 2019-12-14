using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatBot
{
    public partial class RatingForm : Form
    {
        private Form1 frm1;
        Films films = new Films();
        private TextChat chat;
        public RatingForm(Form1 form)
        {
            frm1 = form;
            InitializeComponent();
            TextChat tmp = new TextChat(form);
            chat = tmp;
            films.LoadXMLFile("");
        }
        private int rating;
        private void trackBarRating_Scroll(object sender, EventArgs e)
        {
            labelRating.Text = trackBarRating.Value.ToString();
            rating = trackBarRating.Value;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Close();
            foreach (Film f in films.GetByRating(rating))
            {
                frm1.textBoxMessages.AppendText("Бот: " + f.ToString() + Environment.NewLine);
            }
            chat.FilmCounter();
        }

        private void buttonQuestion_Click(object sender, EventArgs e)
        {
            QuestionForm form = new QuestionForm();
            form.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            
            Close();
        }
    }
}