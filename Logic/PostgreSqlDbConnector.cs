using System;
using System.Configuration;
using System.Data;
using System.Runtime.Remoting.Channels;
using Npgsql;

namespace Logic {
  public class PostgreSqlDbConnector : DbConnector {
    public string ConnectionString { get; set; }

    public PostgreSqlDbConnector(string connstring) {
      ConnectionString = connstring;
    }

    public void ExecuteQuery(string query) {
      try {
        var connection = new NpgsqlConnection(ConnectionString);
        connection.Open();
        
        var cmd = new NpgsqlCommand(query, connection);
        cmd.ExecuteNonQuery();

        connection.Close();
      }
      catch (Exception) {
        throw;
      }
    }

    public DataTable SelectQuery(string query) {
      var dt = new DataTable();
      try {
        var connection = new NpgsqlConnection(ConnectionString);
        connection.Open();

        var cmd = new NpgsqlCommand(query, connection);
        var da = new NpgsqlDataAdapter(cmd);
        da.Fill(dt);

        connection.Close();
      }
      catch (Exception) {
        throw;
      }
      return dt;
    }

    public static string FromAppSettings(SettingsBase settings) {
      string connectionstring = ""; 
      connectionstring =
        $"Host={settings["DBHost"]};Port={settings["DBPort"]};" +
        $"Database={settings["DBName"]};User Id={settings["DBUserID"]};" +
        $"Password={settings["DBPassword"]};";
      return connectionstring;
    }
  }
}