using ATMLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMService
{
    public partial class DashBoardFormUI : Form
    {
        UserManagementStore userDataStore = null;
        public DashBoardFormUI()
        {
            InitializeComponent();
            userDataStore = new UserManagementStore(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);

        }
        private void btnCheckBalance_Click(object sender, EventArgs e)
        {

            txtCardNumber.Text = UserFormUI.CardNumber;

            var result = userDataStore.GetData(txtCardNumber.Text);

            txtBalance.Text = result.ToString();

           



        }

        private void lblCardNumber_Click(object sender, EventArgs e)
        {

        }

        private void txtCardNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblBalance_Click(object sender, EventArgs e)
        {

        }

        private void txtBalance_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMiniStatement_Click(object sender, EventArgs e)
        {
           List<Transaction> transaction =new List<Transaction>();
            txtCardNumber.Text = UserFormUI.CardNumber;

            transaction = userDataStore.getDetails(txtCardNumber.Text);

            gridTransaction.DataSource = transaction;
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            DepositFormUI depositForm = new DepositFormUI();
            depositForm.ShowDialog();
        }

        private void btnWithDraw_Click(object sender, EventArgs e)
        {
            WithDrawFormUI withDrawFrom = new WithDrawFormUI();
            withDrawFrom.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
