namespace ChatBot
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxSendingMessages = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonQuestion = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.roundedCornerButtonRandom = new ChatBot.NewItems.RoundedCornerButton();
            this.roundedCornerButtonYear = new ChatBot.NewItems.RoundedCornerButton();
            this.roundedCornerButtonGenre = new ChatBot.NewItems.RoundedCornerButton();
            this.roundedCornerButtonRating = new ChatBot.NewItems.RoundedCornerButton();
            this.textBoxMessages = new System.Windows.Forms.TextBox();
            this.buttonCleanDialog = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSendingMessages
            // 
            this.textBoxSendingMessages.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSendingMessages.Location = new System.Drawing.Point(21, 310);
            this.textBoxSendingMessages.Multiline = true;
            this.textBoxSendingMessages.Name = "textBoxSendingMessages";
            this.textBoxSendingMessages.Size = new System.Drawing.Size(476, 32);
            this.textBoxSendingMessages.TabIndex = 0;
            this.textBoxSendingMessages.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxsendingMessages_KeyDown);
            // 
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.buttonSend.FlatAppearance.BorderSize = 0;
            this.buttonSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSend.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSend.Location = new System.Drawing.Point(421, 310);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Padding = new System.Windows.Forms.Padding(1);
            this.buttonSend.Size = new System.Drawing.Size(75, 32);
            this.buttonSend.TabIndex = 1;
            this.buttonSend.Text = "Відправити";
            this.buttonSend.UseVisualStyleBackColor = false;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.buttonQuestion);
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 47);
            this.panel1.TabIndex = 3;
            // 
            // buttonQuestion
            // 
            this.buttonQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.buttonQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonQuestion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.buttonQuestion.FlatAppearance.BorderSize = 3;
            this.buttonQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuestion.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuestion.ForeColor = System.Drawing.Color.White;
            this.buttonQuestion.Location = new System.Drawing.Point(12, 3);
            this.buttonQuestion.Name = "buttonQuestion";
            this.buttonQuestion.Size = new System.Drawing.Size(41, 41);
            this.buttonQuestion.TabIndex = 1;
            this.buttonQuestion.Text = "?";
            this.buttonQuestion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonQuestion.UseVisualStyleBackColor = false;
            this.buttonQuestion.Click += new System.EventHandler(this.buttonQuestion_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonExit.FlatAppearance.BorderSize = 3;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.buttonExit.Location = new System.Drawing.Point(465, 8);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(32, 32);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "X";
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.roundedCornerButtonRandom);
            this.groupBox1.Controls.Add(this.roundedCornerButtonYear);
            this.groupBox1.Controls.Add(this.roundedCornerButtonGenre);
            this.groupBox1.Controls.Add(this.roundedCornerButtonRating);
            this.groupBox1.Location = new System.Drawing.Point(21, 348);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 172);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // roundedCornerButtonRandom
            // 
            this.roundedCornerButtonRandom.BackColor = System.Drawing.Color.White;
            this.roundedCornerButtonRandom.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedCornerButtonRandom.Location = new System.Drawing.Point(253, 97);
            this.roundedCornerButtonRandom.Margin = new System.Windows.Forms.Padding(2);
            this.roundedCornerButtonRandom.Name = "roundedCornerButtonRandom";
            this.roundedCornerButtonRandom.Size = new System.Drawing.Size(169, 58);
            this.roundedCornerButtonRandom.TabIndex = 4;
            this.roundedCornerButtonRandom.Text = "Будь який фільм";
            this.roundedCornerButtonRandom.UseVisualStyleBackColor = false;
            this.roundedCornerButtonRandom.Click += new System.EventHandler(this.roundedCornerButtonRandom_Click);
            // 
            // roundedCornerButtonYear
            // 
            this.roundedCornerButtonYear.BackColor = System.Drawing.Color.White;
            this.roundedCornerButtonYear.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedCornerButtonYear.Location = new System.Drawing.Point(253, 18);
            this.roundedCornerButtonYear.Margin = new System.Windows.Forms.Padding(2);
            this.roundedCornerButtonYear.Name = "roundedCornerButtonYear";
            this.roundedCornerButtonYear.Size = new System.Drawing.Size(169, 58);
            this.roundedCornerButtonYear.TabIndex = 3;
            this.roundedCornerButtonYear.Text = "Рік";
            this.roundedCornerButtonYear.UseVisualStyleBackColor = false;
            this.roundedCornerButtonYear.Click += new System.EventHandler(this.roundedCornerButtonYear_Click);
            // 
            // roundedCornerButtonGenre
            // 
            this.roundedCornerButtonGenre.BackColor = System.Drawing.Color.White;
            this.roundedCornerButtonGenre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.roundedCornerButtonGenre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.roundedCornerButtonGenre.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedCornerButtonGenre.Location = new System.Drawing.Point(27, 18);
            this.roundedCornerButtonGenre.Margin = new System.Windows.Forms.Padding(2);
            this.roundedCornerButtonGenre.Name = "roundedCornerButtonGenre";
            this.roundedCornerButtonGenre.Size = new System.Drawing.Size(169, 58);
            this.roundedCornerButtonGenre.TabIndex = 1;
            this.roundedCornerButtonGenre.Text = "Жанр";
            this.roundedCornerButtonGenre.UseVisualStyleBackColor = false;
            this.roundedCornerButtonGenre.Click += new System.EventHandler(this.roundedCornerButtonGenre_Click);
            // 
            // roundedCornerButtonRating
            // 
            this.roundedCornerButtonRating.BackColor = System.Drawing.Color.White;
            this.roundedCornerButtonRating.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedCornerButtonRating.Location = new System.Drawing.Point(27, 97);
            this.roundedCornerButtonRating.Margin = new System.Windows.Forms.Padding(2);
            this.roundedCornerButtonRating.Name = "roundedCornerButtonRating";
            this.roundedCornerButtonRating.Size = new System.Drawing.Size(169, 58);
            this.roundedCornerButtonRating.TabIndex = 2;
            this.roundedCornerButtonRating.Text = "Рейтинг";
            this.roundedCornerButtonRating.UseVisualStyleBackColor = false;
            this.roundedCornerButtonRating.Click += new System.EventHandler(this.roundedCornerButtonRating_Click);
            // 
            // textBoxMessages
            // 
            this.textBoxMessages.BackColor = System.Drawing.Color.White;
            this.textBoxMessages.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMessages.ForeColor = System.Drawing.Color.Black;
            this.textBoxMessages.Location = new System.Drawing.Point(21, 82);
            this.textBoxMessages.Multiline = true;
            this.textBoxMessages.Name = "textBoxMessages";
            this.textBoxMessages.Size = new System.Drawing.Size(476, 222);
            this.textBoxMessages.TabIndex = 8;
            // 
            // buttonCleanDialog
            // 
            this.buttonCleanDialog.BackColor = System.Drawing.Color.White;
            this.buttonCleanDialog.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.buttonCleanDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCleanDialog.Location = new System.Drawing.Point(21, 53);
            this.buttonCleanDialog.Name = "buttonCleanDialog";
            this.buttonCleanDialog.Size = new System.Drawing.Size(111, 23);
            this.buttonCleanDialog.TabIndex = 9;
            this.buttonCleanDialog.Text = "Очистити діалог";
            this.buttonCleanDialog.UseVisualStyleBackColor = false;
            this.buttonCleanDialog.Click += new System.EventHandler(this.buttonCleanDialog_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(321, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(508, 528);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCleanDialog);
            this.Controls.Add(this.textBoxMessages);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBoxSendingMessages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChatBot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private NewItems.RoundedCornerButton roundedCornerButtonRandom;
        private NewItems.RoundedCornerButton roundedCornerButtonYear;
        private NewItems.RoundedCornerButton roundedCornerButtonRating;
        private NewItems.RoundedCornerButton roundedCornerButtonGenre;
        public System.Windows.Forms.TextBox textBoxMessages;
        public System.Windows.Forms.TextBox textBoxSendingMessages;
        private System.Windows.Forms.Button buttonQuestion;
        private System.Windows.Forms.Button buttonCleanDialog;
        public System.Windows.Forms.Label label1;
    }
}

