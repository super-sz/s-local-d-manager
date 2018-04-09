using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLLOCALDB_MANAGER
{
    public class Strings
    {
        // SQLLocalDB.cs
        public static string successAttachment = "La base de données a été attachée avec succès.";
        public static string successAttachmentTitle = "Opération effectuée";
        public static string cannotAttachFileCatch = "Impossible d'attacher la base de données au serveur SQL." + Environment.NewLine + "L'erreur suivante est survenue lors de la tentative de rattachement :" + Environment.NewLine + "" + Environment.NewLine + "";
        public static string cannotAttachFileCatchTitle = "Une erreur est survenue lors du rattachement de la base de données";
        public static string selectInstanceMessage = "Veuillez sélectionner une Instance SQL Local DB.";
        public static string selectInstanceMessageTitle = "L'instance n'a pas été sélectionnée";
        public static string fileNotExists = "Impossible d'attacher la base de données au serveur SQL." + Environment.NewLine + "Veuillez sélectionner un fichier de base de données existant.";
        public static string fileNotExistsTitle = "Le fichier mdf est introuvable";

        // Main.cs
        public static string selectFileDialog = "Sélection du fichier MDF à attacher";
        public static string selectFileFilters = "Fichiers MDF (*.mdf)|*.mdf|Tous les fichiers (*.*)|*.*";
    }
}
