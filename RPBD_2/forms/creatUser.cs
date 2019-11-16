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
    public partial class creatUser : Form
    {
        WorkWithDBRoles db = new WorkWithDBRoles();
        public creatUser()
        {
            
            InitializeComponent();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            string fio = tbFIO.Text;
            string log = tbLog.Text;
            string pas = tbPas.Text;
            string stat = cbRole.Text;
            if (db.newUser(fio, log, pas, stat, ""))
            {
                MessageBox.Show("Пользователь успешно добавлен");
                this.Close();
            }
            else
            {
                MessageBox.Show("К сожалению, пользователь с таким логином уже существует");
            }
        }

        private void CreatUser_Load(object sender, EventArgs e)
        {
            cbRole.DisplayMember = "nameStat";
            cbRole.ValueMember = "nameStat";
            cbRole.DataSource = db.allStatusWithoutPatient();
        }
    }
}
