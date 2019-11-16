namespace RPBD_2.forms
{
    partial class doctorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbTime = new System.Windows.Forms.ComboBox();
            this.buttonSchedShow = new System.Windows.Forms.Button();
            this.buttonCreatePriem = new System.Windows.Forms.Button();
            this.tbFIOPriem = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.datePriem = new System.Windows.Forms.DateTimePicker();
            this.dGVPriem = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbStat = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbPas = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbLog = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbFIO = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonUPDUser = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPriem)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(745, 409);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbTime);
            this.tabPage1.Controls.Add(this.buttonSchedShow);
            this.tabPage1.Controls.Add(this.buttonCreatePriem);
            this.tabPage1.Controls.Add(this.tbFIOPriem);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.datePriem);
            this.tabPage1.Controls.Add(this.dGVPriem);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(737, 383);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Расписание и приемы";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.TabPage1_Click);
            // 
            // cbTime
            // 
            this.cbTime.FormattingEnabled = true;
            this.cbTime.Location = new System.Drawing.Point(209, 37);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(168, 21);
            this.cbTime.TabIndex = 7;
            // 
            // buttonSchedShow
            // 
            this.buttonSchedShow.Location = new System.Drawing.Point(256, 68);
            this.buttonSchedShow.Name = "buttonSchedShow";
            this.buttonSchedShow.Size = new System.Drawing.Size(81, 36);
            this.buttonSchedShow.TabIndex = 6;
            this.buttonSchedShow.Text = "Показать расписание";
            this.buttonSchedShow.UseVisualStyleBackColor = true;
            this.buttonSchedShow.Click += new System.EventHandler(this.ButtonSchedShow_Click);
            // 
            // buttonCreatePriem
            // 
            this.buttonCreatePriem.Location = new System.Drawing.Point(472, 49);
            this.buttonCreatePriem.Name = "buttonCreatePriem";
            this.buttonCreatePriem.Size = new System.Drawing.Size(88, 36);
            this.buttonCreatePriem.TabIndex = 5;
            this.buttonCreatePriem.Text = "Создать время приема";
            this.buttonCreatePriem.UseVisualStyleBackColor = true;
            // 
            // tbFIOPriem
            // 
            this.tbFIOPriem.Location = new System.Drawing.Point(25, 77);
            this.tbFIOPriem.Name = "tbFIOPriem";
            this.tbFIOPriem.Size = new System.Drawing.Size(168, 20);
            this.tbFIOPriem.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "ФИО пациента";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(112, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Дата, в которою принимают";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // datePriem
            // 
            this.datePriem.CustomFormat = "dd MMM yyyy";
            this.datePriem.Location = new System.Drawing.Point(25, 38);
            this.datePriem.Name = "datePriem";
            this.datePriem.Size = new System.Drawing.Size(168, 20);
            this.datePriem.TabIndex = 1;
            this.datePriem.Value = new System.DateTime(2019, 11, 16, 0, 0, 0, 0);
            // 
            // dGVPriem
            // 
            this.dGVPriem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVPriem.Location = new System.Drawing.Point(6, 117);
            this.dGVPriem.Name = "dGVPriem";
            this.dGVPriem.Size = new System.Drawing.Size(725, 260);
            this.dGVPriem.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.lbStat);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.lbPas);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.lbLog);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.lbFIO);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.buttonUPDUser);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(737, 383);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Личный кабинет";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(640, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Выйти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(42, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Информация о текущем докторе";
            // 
            // lbStat
            // 
            this.lbStat.AutoSize = true;
            this.lbStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbStat.Location = new System.Drawing.Point(45, 151);
            this.lbStat.Name = "lbStat";
            this.lbStat.Size = new System.Drawing.Size(120, 17);
            this.lbStat.TabIndex = 23;
            this.lbStat.Text = "Тут будет статус";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(24, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "ФИО";
            // 
            // lbPas
            // 
            this.lbPas.AutoSize = true;
            this.lbPas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbPas.Location = new System.Drawing.Point(281, 151);
            this.lbPas.Name = "lbPas";
            this.lbPas.Size = new System.Drawing.Size(124, 17);
            this.lbPas.TabIndex = 22;
            this.lbPas.Text = "Тут будет пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(261, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Логин";
            // 
            // lbLog
            // 
            this.lbLog.AutoSize = true;
            this.lbLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbLog.Location = new System.Drawing.Point(282, 93);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(114, 17);
            this.lbLog.TabIndex = 21;
            this.lbLog.Text = "Тут будет логин";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(260, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Пароль";
            // 
            // lbFIO
            // 
            this.lbFIO.AutoSize = true;
            this.lbFIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbFIO.Location = new System.Drawing.Point(45, 93);
            this.lbFIO.Name = "lbFIO";
            this.lbFIO.Size = new System.Drawing.Size(111, 17);
            this.lbFIO.TabIndex = 20;
            this.lbFIO.Text = "Тут будет ФИО";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(24, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Статус";
            // 
            // buttonUPDUser
            // 
            this.buttonUPDUser.Location = new System.Drawing.Point(169, 200);
            this.buttonUPDUser.Name = "buttonUPDUser";
            this.buttonUPDUser.Size = new System.Drawing.Size(75, 23);
            this.buttonUPDUser.TabIndex = 19;
            this.buttonUPDUser.Text = "Изменить";
            this.buttonUPDUser.UseVisualStyleBackColor = true;
            this.buttonUPDUser.Click += new System.EventHandler(this.ButtonUPDUser_Click);
            // 
            // doctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 425);
            this.Controls.Add(this.tabControl1);
            this.Name = "doctorForm";
            this.Text = "Составление расписания и работа доктора";
            this.Load += new System.EventHandler(this.DoctorForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPriem)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbStat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbPas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbLog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbFIO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonUPDUser;
        private System.Windows.Forms.TextBox tbFIOPriem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker datePriem;
        private System.Windows.Forms.DataGridView dGVPriem;
        private System.Windows.Forms.Button buttonSchedShow;
        private System.Windows.Forms.Button buttonCreatePriem;
        private System.Windows.Forms.ComboBox cbTime;
    }
}