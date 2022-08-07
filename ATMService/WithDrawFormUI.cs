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
    public partial class WithDrawFormUI : Form
    {
        UserManagementStore userManagementStore = null;
        public WithDrawFormUI()
        {
            InitializeComponent();
            userManagementStore = new UserManagementStore(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);

        }

        private void btnWithDrawAmount_Click(object sender, EventArgs e)
        {
            txtCardNumber.Text = UserFormUI.CardNumber;
            User user = new User();
            user.Balance = Convert.ToDecimal(txtWithDraw.Text);
            userManagementStore.WithDrawMoney(txtCardNumber.Text, Convert.ToDecimal(txtWithDraw.Text));
            MessageBox.Show("Successfully Deducted");
        }
    }
}
