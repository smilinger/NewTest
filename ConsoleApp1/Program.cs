using System.Data.SqlClient;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var conn = new SqlConnection(Properties.Settings.Default.TestConnectionString);
            var adp = new SqlDataAdapter();

            var dt = new TestDataSet();
            adp.Fill(dt);


            var rw = dt.CategoryDef.FindByCategoryDefId(1);
        }
    }
}
