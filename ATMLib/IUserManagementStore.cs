using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMLib
{
    interface IUserManagementStore
    {
        bool VerifyUser(User user);

        decimal GetData( string CardNumber);

       List<Transaction> getDetails(string CardNumber);

        decimal AddBalance(string CardNumber,decimal Balance);

        decimal WithDrawMoney(string CardNumber, decimal Balance);
         
    }
}
