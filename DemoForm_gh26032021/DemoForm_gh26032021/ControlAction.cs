using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoForm_gh26032021
{
    class ControlAction
    {
        // get Server Name
        public DataTable getServerName ()
        {
            DataTable dataTable = new DataTable();
            dataTable = SqlDataSourceEnumerator.Instance.GetDataSources();
            return dataTable;
        }

        // get all database

        public DataTable getDataBase( string server, string user, string pass)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(
                "select name form sys.Database", "Data Source="+server+ ";Initial Catalog = master; User ID=" + user+ "; Password=" + pass +"");
            dataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count == 0)
                return null;
            return dataTable;
        }
    }
}
