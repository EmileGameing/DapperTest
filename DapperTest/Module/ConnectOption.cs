using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperTest.Module
{
    public static class ConnectOption
    {
        static string server = "localhost";
        static string database = "test";
        static string user = "root";
        static string pass = "";
        static string charset = "utf8";

        public static string connectionString = string.Format($"Server={server};Database={database};Uid={user};Pwd={pass};Charset={charset};");
    }
}
