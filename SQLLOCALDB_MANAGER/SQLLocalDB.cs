using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SQLLOCALDB_MANAGER
{
    static class LocalDB
    {
        public static void MAKE_DATABASE(string dbName, string Path, string instanceName)
        {
            try
            {
                string connectionString = String.Format("Data Source=(LocalDB)\\"+instanceName+";Integrated Security=SSPI;Trusted_Connection=yes;");
                using (var connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("", connection);
                    Path +=  @"\";
                    cmd.CommandText = string.Format(@"CREATE DATABASE [{1}] ON ( FILENAME = '{0}{1}.mdf' ), ( FILENAME = '{0}{1}_log.ldf' ) FOR ATTACH", Path, dbName);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    connection.Dispose();
                    MessageBox.Show("La base de données a été attachée avec succès.", "Opération effectuée");
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
