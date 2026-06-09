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
            string dbPath = ObtenerRutaBaseDatos();

           
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

        private static string ObtenerRutaBaseDatos()
        {
            string baseDir = "";
            try
            {
                baseDir = Path.GetDirectoryName(typeof(csConexion).Assembly.Location);
            }
            catch { }

            if (string.IsNullOrEmpty(baseDir))
                baseDir = AppDomain.CurrentDomain.BaseDirectory;

            string projectPath = Path.GetFullPath(Path.Combine(baseDir, "..", "..", "BD", "Aybar1.accdb"));
            if (File.Exists(projectPath))
                return projectPath;

            string appPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "BD", "Aybar1.accdb");
            if (File.Exists(appPath))
                return appPath;

            return Path.Combine(baseDir, "BD", "Aybar1.accdb");
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
