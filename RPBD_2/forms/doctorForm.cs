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
    public partial class doctorForm : Form
    {
        users us;
        string thisLog;
        WorkWithDBRoles db = new WorkWithDBRoles();

        public doctorForm(string log)
        {
            thisLog = log;
            us = db.GetUserLog(log);
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            lbFIO.Text = us.FIO;
            lbLog.Text = us.login;
            lbPas.Text = us.password;
            lbStat.Text = us.nameStat;
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSchedShow_Click(object sender, EventArgs e)
        {

        }
    }
}
