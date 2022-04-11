using System.Collections.Generic;
using System.Data.SqlClient;

namespace Test_Kotlin_Novator
{
    class DataAccess
    {
        
        static readonly string connectString = @"
                Data Source=DESKTOP-MRL0FU6;
                Initial Catalog=master;
                Integrated Security=True;
            ";

        public List<Customer> GetCustomers()
        {
            var query = "SELECT * FROM Customer;";
            return GetObjects<Customer>(4, query);
        }

        public List<Account> GetAccounts(int customerID)
        {
            var query = $"SELECT * FROM Account WHERE CustomerID = {customerID};";
            return GetObjects<Account>(6, query);
        }

        public void DeleteAccount(int accountID)
        {
            var query = $"DELETE FROM Account WHERE ID = {accountID};";
            QueryToDB(query);
        }

        public void DeleteCustomer(int customerID)
        {
            var query = $"DELETE FROM Customer WHERE ID = {customerID};";
            QueryToDB(query);
        }

        public void InsertCustomer(string name, long inn, string address)
        {
            var query = $"INSERT INTO Customer (Name, INN, Address) VALUES ('{name}', {inn}, '{address}');";
            QueryToDB(query);
        }

        public void InsertAccount(decimal account, string name, int bik, decimal balance, int customerID)
        {

            var query = $"INSERT INTO Account (Account, Name, BIK, Balance, CustomerID) " +
                        $"VALUES ({account}, '{name}', {bik}, {balance}, {customerID});";
            QueryToDB(query);
        }

        public void UpdateCustomer(string name, long inn, string address, int customerID)
        {
            var query = $"UPDATE Customer SET Name = '{name}', INN = {inn}, Address = '{address}' WHERE ID = '{customerID}'";
            QueryToDB(query);
        }

        public void UpdateAccount(decimal account, string name, int bik, decimal balance, int accountID)
        {
            var query = $"UPDATE Account SET Account = {account}, Name = '{name}', " +
                        $"BIK = {bik}, Balance = {balance}  WHERE ID = '{accountID}'";
            QueryToDB(query);
        }

        private void QueryToDB(string query)
        {
            using (SqlConnection myConnection = new SqlConnection(connectString))
            {
                myConnection.Open();
                SqlCommand command = new SqlCommand(query, myConnection);
                command.ExecuteNonQuery();
            }
        }

        private List<T> GetObjects<T>(int arraySize, string query) where T : Model.IModel, new()
        {
            List<string[]> rows = new List<string[]>();
            List<T> result = new List<T>();

            using (SqlConnection myConnection = new SqlConnection(connectString))
            {
                myConnection.Open();

                SqlCommand command = new SqlCommand(query, myConnection);

                using (SqlDataReader reader = command.ExecuteReader())
                { 
                    while (reader.Read())
                    {
                        rows.Add(new string[arraySize]);

                        for (int i = 0; i < arraySize; i++)
                            rows[rows.Count - 1][i] = reader[i].ToString();

                        T obj = new T();
                        obj.SetParameters(rows[rows.Count - 1]);

                        result.Add(obj);
                    }
                }
                return result;
            }
        }       
    }
}
