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
    public partial class GenreForm : Form
    {
        private Form1 frm1;
        private TextChat chat;
        Films films = new Films();
        
        public GenreForm(Form1 form)
        {
            frm1 = form;
            TextChat tmp = new TextChat(form);
            chat = tmp;
            InitializeComponent();
            films.LoadXMLFile("");
        }
      
        void Returning()
        {
            Close();
            chat.FilmCounter();
        }

        private void CornerButtonAction_Click(object sender, EventArgs e)
        {

            foreach (Film f in films.GetContainNameGenre("Бойовик"))
            {
                frm1.textBoxMessages.AppendText("Бот: " + f.ToString() + Environment.NewLine);
            }
            Returning();

        }

        private void CornerButtonAdventure_Click(object sender, EventArgs e)
        {
            foreach (Film f in films.GetContainNameGenre("Пригода"))
            {
                frm1.textBoxMessages.AppendText("Бот: " + f.ToString() + Environment.NewLine);
            }
            Returning();
        }

        private void CornerButtonDetective_Click(object sender, EventArgs e)
        {
            foreach (Film f in films.GetContainNameGenre("Детектив"))
            {
                frm1.textBoxMessages.AppendText("Бот: " + f.ToString() + Environment.NewLine);
            }
            Returning();
        }

        private void CornerButtonDrama_Click(object sender, EventArgs e)
        {
            foreach (Film f in films.GetContainNameGenre("Драма"))
            {
                frm1.textBoxMessages.AppendText("Бот: " + f.ToString() + Environment.NewLine);
            }
            Returning();
        }

        private void CornerButtonHistory_Click(object sender, EventArgs e)
        {
            foreach (Film f in films.GetContainNameGenre("Історичний фільм"))
            {
                frm1.textBoxMessages.AppendText("Бот: " + f.ToString() + Environment.NewLine);
            }
            Returning();
        }

        private void CornerButtonComedy_Click(object sender, EventArgs e)
        {
            foreach (Film f in films.GetContainNameGenre("Комедія"))
            {
                frm1.textBoxMessages.AppendText("Бот: " + f.ToString() + Environment.NewLine);
            }
            Returning();
        }

        private void CornerButtonMelodrama_Click(object sender, EventArgs e)
        {
            foreach (Film f in films.GetContainNameGenre("Мелодрама"))
            {
                frm1.textBoxMessages.AppendText("Бот: " + f.ToString() + Environment.NewLine);
            }
            Returning();
        }

        private void CornerButtonThriller_Click(object sender, EventArgs e)
        {
            foreach (Film f in films.GetContainNameGenre("Трилер"))
            {
                frm1.textBoxMessages.AppendText("Бот: " + f.ToString() + Environment.NewLine);
            }
            Returning();
        }

        private void CornerButtonHorror_Click(object sender, EventArgs e)
        {
            foreach (Film f in films.GetContainNameGenre("Фільм жахів"))
            {
                frm1.textBoxMessages.AppendText("Бот: " + f.ToString() + Environment.NewLine);
            }
            Returning();
        }

        private void CornerButtonScienceFiction_Click(object sender, EventArgs e)
        {
            foreach (Film f in films.GetContainNameGenre("Фантастика"))
            {
                frm1.textBoxMessages.AppendText("Бот: " + f.ToString() + Environment.NewLine);
            }
            Returning();
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
