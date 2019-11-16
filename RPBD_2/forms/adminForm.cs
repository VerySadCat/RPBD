using RPBD_2.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPBD_2.forms
{
    public partial class adminForm : Form
    {
        users us;
        string thisLog;
        WorkWithDBRoles db = new WorkWithDBRoles();
        public adminForm(string log)
        {
            thisLog = log;
            us = db.GetUserLog(log);
            InitializeComponent();
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                using (creatUser frm = new creatUser())
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {

                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка ввода");
            }
        }

        private void ButtonUPD_Click(object sender, EventArgs e)
        {
            if (tbSeachFIO.Text == "")
            {
                dGVUsers.DataSource = db.getAllUser();
            }
            else
            {
                if (db.seachUser(tbSeachFIO.Text).Count > 0)
                    dGVUsers.DataSource = db.seachUser(tbSeachFIO.Text);
                else
                {
                    dGVUsers.DataSource = null;
                    MessageBox.Show("Увы, такого работника мы не нашли");
                }
            }
        }

        private void DGVUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string dLog = Convert.ToString(this.dGVUsers.CurrentRow.Cells[1].Value);
            if (e.ColumnIndex == 5)
            {

                if (thisLog != dLog)
                {
                    db.delUser(dLog);
                    MessageBox.Show("Пользователь успешно удален");
                }
                else
                   if (thisLog == dLog)
                    MessageBox.Show("Пользователь не может быть удален, вы сейчас работаете под ним");

            }
            if (e.ColumnIndex == 4)
            {
                string pas = Convert.ToString(this.dGVUsers.CurrentRow.Cells[2].Value);
                string fio = Convert.ToString(this.dGVUsers.CurrentRow.Cells[0].Value);
                string stat = Convert.ToString(this.dGVUsers.CurrentRow.Cells[3].Value);
                try
                {
                    using (UPDUsers frm = new UPDUsers(fio, dLog, pas, stat))
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            dGVUsers.DataSource = db.getAllUser();
                        }
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Ошибка ввода");
                }
            }
        }

        private void ButtonUPDUser_Click(object sender, EventArgs e)
        {
            try
            {
                using (UPDUsers frm = new UPDUsers(lbFIO.Text, lbLog.Text, lbPas.Text, lbStat.Text))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                       
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка ввода");
            }
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            lbFIO.Text = us.FIO;
            lbLog.Text = us.login;
            lbPas.Text = us.password;
            lbStat.Text = us.nameStat;
        }

        private void TabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
