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
    }
}
