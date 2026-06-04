using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryAybar.ERP2
{
    public class csConexion
    {
        private static string connectionString;
        private static OleDbConnection connection;

        static csConexion()
        {
            // Try resolving relative to the assembly file location first (works in tests and powershell)
            string baseDir = "";
            try
            {
                baseDir = Path.GetDirectoryName(typeof(csConexion).Assembly.Location);
            }
            catch { }

            if (string.IsNullOrEmpty(baseDir))
            {
                baseDir = AppDomain.CurrentDomain.BaseDirectory;
            }

            string dbPath = Path.Combine(baseDir, "BD", "Aybar1.accdb");

            // Fallback: If not found, try AppDomain base directory directly
            if (!File.Exists(dbPath))
            {
                string appDir = AppDomain.CurrentDomain.BaseDirectory;
                string appPath = Path.Combine(appDir, "BD", "Aybar1.accdb");
                if (File.Exists(appPath))
                {
                    dbPath = appPath;
                }
                else
                {
                    // Fallback for visual design time or debugging in VS
                    string vsPath = Path.Combine(appDir, "..", "..", "BD", "Aybar1.accdb");
                    if (File.Exists(vsPath))
                    {
                        dbPath = Path.GetFullPath(vsPath);
                    }
                }
            }

            // Determine if Microsoft.ACE.OLEDB.12.0 or Microsoft.ACE.OLEDB.16.0 works on the environment
            string provider = "Microsoft.ACE.OLEDB.12.0";
            if (!ProbarProveedor(provider, dbPath))
            {
                if (ProbarProveedor("Microsoft.ACE.OLEDB.16.0", dbPath))
                {
                    provider = "Microsoft.ACE.OLEDB.16.0";
                }
            }

            connectionString = $"Provider={provider};Data Source={dbPath};Persist Security Info=False;";
        }

        private static bool ProbarProveedor(string provider, string dbPath)
        {
            try
            {
                string tempStr = $"Provider={provider};Data Source={dbPath};Persist Security Info=False;";
                using (OleDbConnection tempConn = new OleDbConnection(tempStr))
                {
                    tempConn.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static OleDbConnection GetConnection()
        {
            if (connection == null)
            {
                connection = new OleDbConnection(connectionString);
            }
            return connection;
        }

        public static bool TestConnection(out string message)
        {
            try
            {
                using (OleDbConnection tempConn = new OleDbConnection(connectionString))
                {
                    tempConn.Open();
                    message = "Conexión exitosa a la base de datos.";
                    return true;
                }
            }
            catch (Exception ex)
            {
                message = "Error al intentar conectar: " + ex.Message;
                return false;
            }
        }
    }
}
