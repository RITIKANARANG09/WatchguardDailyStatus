using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public abstract class DbConnection
    {
        private string ConnectionString { get; set; }
        private TimeSpan Timeout { get; set; }
        public DbConnection(string st)
        {
            if(!String.IsNullOrWhiteSpace(st))
            this.ConnectionString = st;
        }
        public abstract void openc();
        public abstract void closec();
    }
    public class SqlConnection : DbConnection
    {
        public override void openc()
        {
            Console.WriteLine("opened connection in sql");
        }
        public override void closec()
        {
            Console.WriteLine("closed connection in sql");
        }
    }
    public class OracleConnection : DbConnection
    {
        public override void openc()
        {
            Console.WriteLine("opened connection in oracle");
        }
        public override void closec()
        {
            Console.WriteLine("closed connection in oracle");
        }
    }
}
