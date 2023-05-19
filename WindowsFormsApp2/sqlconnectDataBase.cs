using System.Data.SqlClient;
namespace WindowsFormsApp2
{ 

    class sqlconnectDataBase
    {
        SqlConnection _connect = new SqlConnection
        (@" Server=;
        Initial Catalog = Users;
        Integrated Security = True");
        public void OpenConnectDB() 
        {
            if (_connect.State == System.Data.ConnectionState.Closed)
                _connect.Open();
        }
        public void CloseConnectDB() 
        {
            if (_connect.State==System.Data.ConnectionState.Open)
             _connect.Close();
        }
        public SqlConnection GetConnect()
        {
            return _connect;
        }

    }
}
