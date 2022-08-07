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
    public partial class UserFormUI : Form
    {
        UserManagementStore userDataStore = null;
        public UserFormUI()
        {
            InitializeComponent();
            userDataStore = new UserManagementStore(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
        }

        public static string CardNumber;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = new User();

            user.CardNumber = txtCardNumber.Text;
            user.PinNumber = txtPinNumber.Text;

            var result = userDataStore.VerifyUser(user);




            if (result == true)
            {
                CardNumber = user.CardNumber;
                DashBoardFormUI homeForm = new DashBoardFormUI();
                homeForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Data Invalid credentials ");
            }


        }
    }
}
