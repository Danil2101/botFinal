using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ChatBot
{
    public partial class StartForm : Form
    {
        private TextChat chat;
        private Form1 frm1;
        public StartForm(Form1 form)
        {
            frm1 = form;
            InitializeComponent();
            TextChat tmp = new TextChat(form);
            chat = tmp;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            chat.OpenLog();
            Close();
        }
    }
}
