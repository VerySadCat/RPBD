namespace RPBD_2.forms
{
    partial class adminForm
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSeachFIO = new System.Windows.Forms.TextBox();
            this.buttonUPD = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.dGVUsers = new System.Windows.Forms.DataGridView();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameStatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbStat = new System.Windows.Forms.Label();
            this.lbPas = new System.Windows.Forms.Label();
            this.lbLog = new System.Windows.Forms.Label();
            this.lbFIO = new System.Windows.Forms.Label();
            this.buttonUPDUser = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 435);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbSeachFIO);
            this.tabPage1.Controls.Add(this.buttonUPD);
            this.tabPage1.Controls.Add(this.buttonCreate);
            this.tabPage1.Controls.Add(this.dGVUsers);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 409);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Работники";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(613, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Поиск по ФИО";
            // 
            // tbSeachFIO
            // 
            this.tbSeachFIO.Location = new System.Drawing.Point(616, 160);
            this.tbSeachFIO.Name = "tbSeachFIO";
            this.tbSeachFIO.Size = new System.Drawing.Size(132, 20);
            this.tbSeachFIO.TabIndex = 3;
            // 
            // buttonUPD
            // 
            this.buttonUPD.Location = new System.Drawing.Point(616, 52);
            this.buttonUPD.Name = "buttonUPD";
            this.buttonUPD.Size = new System.Drawing.Size(132, 40);
            this.buttonUPD.TabIndex = 2;
            this.buttonUPD.Text = "Обновить";
            this.buttonUPD.UseVisualStyleBackColor = true;
            this.buttonUPD.Click += new System.EventHandler(this.ButtonUPD_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(616, 6);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(132, 40);
            this.buttonCreate.TabIndex = 1;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // dGVUsers
            // 
            this.dGVUsers.AutoGenerateColumns = false;
            this.dGVUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fIODataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.nameStatDataGridViewTextBoxColumn,
            this.Column4,
            this.Column5});
            this.dGVUsers.DataSource = this.usersBindingSource;
            this.dGVUsers.Location = new System.Drawing.Point(6, 6);
            this.dGVUsers.Name = "dGVUsers";
            this.dGVUsers.Size = new System.Drawing.Size(601, 397);
            this.dGVUsers.TabIndex = 0;
            this.dGVUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVUsers_CellContentClick);
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Логин";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Пароль";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // nameStatDataGridViewTextBoxColumn
            // 
            this.nameStatDataGridViewTextBoxColumn.DataPropertyName = "nameStat";
            this.nameStatDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.nameStatDataGridViewTextBoxColumn.Name = "nameStatDataGridViewTextBoxColumn";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "";
            this.Column4.Name = "Column4";
            this.Column4.Text = "Изменить";
            this.Column4.UseColumnTextForButtonValue = true;
            this.Column4.Width = 70;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "";
            this.Column5.Name = "Column5";
            this.Column5.Text = "Удалить";
            this.Column5.UseColumnTextForButtonValue = true;
            this.Column5.Width = 70;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataSource = typeof(RPBD_2.models.users);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.lbStat);
            this.tabPage2.Controls.Add(this.lbPas);
            this.tabPage2.Controls.Add(this.lbLog);
            this.tabPage2.Controls.Add(this.lbFIO);
            this.tabPage2.Controls.Add(this.buttonUPDUser);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 409);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Личный кабинет";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.TabPage2_Click);
            // 
            // lbStat
            // 
            this.lbStat.AutoSize = true;
            this.lbStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbStat.Location = new System.Drawing.Point(80, 146);
            this.lbStat.Name = "lbStat";
            this.lbStat.Size = new System.Drawing.Size(120, 17);
            this.lbStat.TabIndex = 12;
            this.lbStat.Text = "Тут будет статус";
            // 
            // lbPas
            // 
            this.lbPas.AutoSize = true;
            this.lbPas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbPas.Location = new System.Drawing.Point(316, 146);
            this.lbPas.Name = "lbPas";
            this.lbPas.Size = new System.Drawing.Size(124, 17);
            this.lbPas.TabIndex = 11;
            this.lbPas.Text = "Тут будет пароль";
            // 
            // lbLog
            // 
            this.lbLog.AutoSize = true;
            this.lbLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbLog.Location = new System.Drawing.Point(317, 88);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(114, 17);
            this.lbLog.TabIndex = 10;
            this.lbLog.Text = "Тут будет логин";
            // 
            // lbFIO
            // 
            this.lbFIO.AutoSize = true;
            this.lbFIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbFIO.Location = new System.Drawing.Point(80, 88);
            this.lbFIO.Name = "lbFIO";
            this.lbFIO.Size = new System.Drawing.Size(111, 17);
            this.lbFIO.TabIndex = 9;
            this.lbFIO.Text = "Тут будет ФИО";
            // 
            // buttonUPDUser
            // 
            this.buttonUPDUser.Location = new System.Drawing.Point(204, 195);
            this.buttonUPDUser.Name = "buttonUPDUser";
            this.buttonUPDUser.Size = new System.Drawing.Size(75, 23);
            this.buttonUPDUser.TabIndex = 8;
            this.buttonUPDUser.Text = "Изменить";
            this.buttonUPDUser.UseVisualStyleBackColor = true;
            this.buttonUPDUser.Click += new System.EventHandler(this.ButtonUPDUser_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(59, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Статус";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(295, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(296, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(59, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(77, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Информация о текущем пользователе";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(675, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Выйти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "adminForm";
            this.Text = "Управление от администратора";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSeachFIO;
        private System.Windows.Forms.Button buttonUPD;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.DataGridView dGVUsers;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonUPDUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameStatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.Label lbStat;
        private System.Windows.Forms.Label lbPas;
        private System.Windows.Forms.Label lbLog;
        private System.Windows.Forms.Label lbFIO;
        private System.Windows.Forms.Button button1;
    }
}