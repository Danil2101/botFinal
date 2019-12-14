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
    public partial class YearForm : Form
    {
        private int yearfrom = 0;
        private int yearto = 0;
        private Form1 frm1;
        private TextChat chat;
        Films films = new Films();
        public YearForm(Form1 form)
        {
            frm1 = form;
            InitializeComponent();
            films.LoadXMLFile("");
            TextChat tmp = new TextChat(form);
            chat = tmp;
            for (int i = 2019; i >= 1886; i--)
            {
                comboBoxYearFrom.Items.Add(i);
                comboBoxYearTo.Items.Add(i);
            }
        }
      
        private void buttonOk_Click(object sender, EventArgs e)
        {
            yearfrom = Convert.ToInt32(comboBoxYearFrom.SelectedItem);
            yearto = Convert.ToInt32(comboBoxYearTo.SelectedItem);
            Close();
            if (yearfrom == 0)
            {
                foreach (Film f in films.GetByYear(yearto))
                {
                    frm1.textBoxMessages.AppendText("Бот: " + f.ToString() + Environment.NewLine);
                }
            }
            else if (yearto == 0)
            {
                foreach (Film f in films.GetByYear(yearfrom))
                {
                    frm1.textBoxMessages.AppendText("Бот: " + f.ToString() + Environment.NewLine);
                }
            }
            else
            {
                foreach (Film f in films.GetByYearBetween(yearfrom, yearto))
                {
                    frm1.textBoxMessages.AppendText("Бот: " +  f.ToString() + Environment.NewLine);
                }
            }
            chat.FilmCounter();
        }
        public void YearForm_Load(object sender, EventArgs e)
        {
          
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
