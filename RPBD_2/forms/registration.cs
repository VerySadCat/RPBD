using RPBD_2.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPBD_2
{
    public partial class registration : Form
    {

        WorkWithDBRoles db = new WorkWithDBRoles();
        public registration()
        {
            InitializeComponent();
        }

        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            string log = tbLogin.Text;
            string pas = tbPas.Text;
            string stat = db.seachStatUser(log, pas);
            // выбираем какую форму создавать в зависимости от того, какой статус к нам пришел
            if (db.seachStatUser(stat) == 0)
            {
                try
                {
                    using (adminForm frm = new adminForm(log))
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
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
