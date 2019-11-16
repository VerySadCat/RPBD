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
    public partial class UPDUsers : Form
    {
        string fio1, log1, pas1, stat1;

        WorkWithDBRoles db = new WorkWithDBRoles();
        private void UPDUsers_Load(object sender, EventArgs e)
        {
            tbFIO.Text = fio1;
            lbLog.Text = log1;
            tbPas.Text = pas1;
            cbRole.DisplayMember = "stat";
            cbRole.ValueMember = "stat";
            cbRole.DataSource = db.allStatusWithoutPatient();
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            string newlog = lbLog.Text;
            string newpas = tbPas.Text;
            string newfio = tbFIO.Text;
            string newstat = cbRole.Text;
            db.UPDUser(newfio, newlog, newpas, newstat, "");
            MessageBox.Show("Информация успешно изменена, но для ее вывода на экран необходимо перезагрузить приложение");
            this.Close();
        }

        public UPDUsers(string fio, string log, string pas, string stat)
        {
            fio1 = fio;
            log1 = log;
            pas1 = pas;
            stat1 = stat;
            InitializeComponent();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
