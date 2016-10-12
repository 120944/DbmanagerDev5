using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Logic {
    public interface DbConnector {
      void ExecuteQuery(string query);
      DataTable SelectQuery(string query);
    }
}
