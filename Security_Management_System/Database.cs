using System;
using MySql.Data.MySqlClient;

public class DatabaseHelper
{
    private static DatabaseHelper _instance;
    private MySqlConnection _connection;
    private static readonly object _lock = new object();

    private DatabaseHelper()
    {
        string connectionString = "Server=localhost;Database=securitymanagement;Uid=root;Pwd=Pranopasha@7;";
        _connection = new MySqlConnection(connectionString);
    }
    public static DatabaseHelper Instance
    {
        get
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new DatabaseHelper();
                }
                return _instance;
            }
        }
    }

    public MySqlConnection Connection
    {
        get { return _connection; }
    }

    public void OpenConnection()
    {
        if (_connection.State == System.Data.ConnectionState.Closed)
        {
            _connection.Open();
        }
    }

    public void CloseConnection()
    {
        if (_connection.State == System.Data.ConnectionState.Open)
        {
            _connection.Close();
        }
    }

    public int ExecuteNonQuery(string query, params MySqlParameter[] parameters)
    {
        using (MySqlCommand cmd = new MySqlCommand(query, _connection))
        {
            cmd.Parameters.AddRange(parameters);
            return cmd.ExecuteNonQuery();
        }
    }

    public MySqlDataReader ExecuteQuery(string query, params MySqlParameter[] parameters)
    {
        using (MySqlCommand cmd = new MySqlCommand(query, _connection))
        {
            cmd.Parameters.AddRange(parameters);
            return cmd.ExecuteReader();
        }
    }
}