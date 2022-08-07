using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ATMLib
{
    public class UserManagementStore : IUserManagementStore
    {
        SqlConnection connection = null;
        SqlCommand command = null;
        SqlDataReader reader = null;

        public UserManagementStore(string connectionString)
        {
            connection = new SqlConnection(connectionString);
        }  
        public decimal AddBalance(string CardNumber, decimal Balance)
        {
            try
            {
                string sql = "UPDATE User SET  BALANCE =@BALANCE+BALANCE WHERE CARDNUMBER=@CardNumber";
                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Balance", Balance);
                command.Parameters.AddWithValue("@CardNumber", CardNumber);





                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                int count = command.ExecuteNonQuery();

                return count;




            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

   

        public decimal GetData(string CardNumber)
        {
            decimal balance = 0;
            try
            {
                string sql = "SELECT distinct BALANCE FROM User where CARDNUMBER=@CardNumber";
                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@CardNumber", CardNumber);

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                object res = command.ExecuteScalar();
                balance = Convert.ToDecimal(res);
                return balance;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return balance;
        }

        public List<Transaction> getDetails(string CardNumber)
        {
            List<Transaction> transactionslist = new List<Transaction>();
            try
            {
                string sql = " SELECT U.CARDNUMBER,TransactionAmount,TransactionDate FROM User U JOIN TRANSACTIONS T ON  U.CardNumber=T.CardNumber WHERE U.CardNumber=@CardNumber ORDER BY T.TransactionDate  DESC";
                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@CardNumber", CardNumber);



                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Transaction transaction = new Transaction();
                    transaction.CardNumber = reader["CardNumber"].ToString();

                    if (string.IsNullOrEmpty(reader["TransactionDate"].ToString()) != true)
                    {
                        transaction.TransactionDate = Convert.ToDateTime(Convert.ToString(reader["TransactionDate"]));
                    }
                    if (string.IsNullOrEmpty(reader["TransactionAmount"].ToString()) != true)
                    {
                        transaction.TransactionAmount = Convert.ToDecimal(Convert.ToString(reader["TransactionAmount"]));
                    }

                    transactionslist.Add(transaction);

                }
                return transactionslist;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return transactionslist;
        }

       


        public bool VerifyUser(User user)
        {
            bool result = false;
            try
            {
                string sql = "SELECT * FROM User where CardNumber=@CardNumber and PinNumber=@PinNumber";
                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@CardNumber", user.CardNumber);
                command.Parameters.AddWithValue("@PinNumber", user.PinNumber);


                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return result;
        }

       

        public decimal WithDrawMoney(string CardNumber, decimal Balance)
        {
            try
            {
                string sql = "UPDATE User SET  Balance =Balance-@Balance WHERE CardNumber=@CardNumber";
                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Balance", Balance);
                command.Parameters.AddWithValue("@CardNumber", CardNumber);


                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                int count = command.ExecuteNonQuery();

                return count;


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
