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
            catch(Exception ex)
            {
                MessageBox.Show("Impossible d'attacher la base de données au serveur SQL." + Environment.NewLine + "L'erreur suivante est survenue lors de la tentative de rattachement :" + Environment.NewLine + "" + Environment.NewLine + ""+ex.Message+"", "Une erreur est survenue lors du rattachement de la base de données", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void InstanceNameError()
        {
            MessageBox.Show(Environment.NewLine + "Veuillez entrer le nom de l'instance SQL Local DB.","L'instance n'a pas été sélectionnée", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void FileNotExist()
        {
            MessageBox.Show("Impossible d'attacher la base de données au serveur SQL." + Environment.NewLine + "Veuillez sélectionner un fichier de base de données existant.", "Le fichier mdf est introuvable", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
