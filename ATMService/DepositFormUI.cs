using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATMLib;
using System.Configuration;

namespace ATMService
{
    public partial class DepositFormUI : Form
    {
        UserManagementStore userManagementStore = null;
        public DepositFormUI()
        {
            InitializeComponent();
            userManagementStore = new UserManagementStore(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);

        }

        private void lblAmount_Click(object sender, EventArgs e)
        {

        }

        private void btnDepositAmount_Click(object sender, EventArgs e)
        {
            txtCardNumber.Text = UserFormUI.CardNumber;
            User user = new User();
            user.Balance = Convert.ToDecimal(txtAmount.Text);
            userManagementStore.AddBalance(txtCardNumber.Text,Convert.ToDecimal(txtAmount.Text));
            MessageBox.Show("Successfully deposited");

        }
    }
}
