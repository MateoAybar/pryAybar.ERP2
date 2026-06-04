using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryAybar.ERP2.CLS
{
    public class csMetodos
    {
        public static void RegistrarSesion(string usuario, string detalle)
        {
            try
            {
                OleDbConnection conn = csConexion.GetConnection();
                if (conn.State == ConnectionState.Closed) conn.Open();
                using (OleDbCommand cmd = new OleDbCommand("INSERT INTO [AuditoriaSesion] ([Fecha], [Hora], [Usuario], [Detalle]) VALUES (?, ?, ?, ?)", conn))
                {
                    cmd.Parameters.AddWithValue("?", DateTime.Today);
                    cmd.Parameters.AddWithValue("?", DateTime.Now.ToString("HH:mm:ss"));
                    cmd.Parameters.AddWithValue("?", usuario);
                    cmd.Parameters.AddWithValue("?", detalle);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception) { /* Fail silently */ }
        }

        public static bool VerificarLogin(string usuario, string contrasenia, out int idUsuario, out string nombreCompleto, out string perfil)
        {
            idUsuario = -1;
            nombreCompleto = "";
            perfil = "";
            try
            {
                OleDbConnection conn = csConexion.GetConnection();
                if (conn.State == ConnectionState.Closed) conn.Open();

                // 1. Search in Usuario
                using (OleDbCommand cmd = new OleDbCommand("SELECT [Id_Usuario], [Nombre], [Apellido], [Contraseña], [Activo] FROM [Usuario] WHERE [Nombre] = ? OR [Mail] = ? OR [DNI] = ?", conn))
                {
                    cmd.Parameters.AddWithValue("?", usuario);
                    cmd.Parameters.AddWithValue("?", usuario);
                    cmd.Parameters.AddWithValue("?", usuario);

                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string dbPass = reader["Contraseña"].ToString();
                            string dbActivo = reader["Activo"].ToString();
                            
                            if (dbPass != contrasenia)
                            {
                                RegistrarSesion(usuario, "Contraseña incorrecta.");
                                return false;
                            }
                            
                            if (dbActivo.ToLower() != "si")
                            {
                                RegistrarSesion(usuario, "Usuario inactivo.");
                                return false;
                            }

                            idUsuario = Convert.ToInt32(reader["Id_Usuario"]);
                            nombreCompleto = reader["Nombre"].ToString() + " " + reader["Apellido"].ToString();
                        }
                        else
                        {
                            RegistrarSesion(usuario, "Usuario o correo no encontrado.");
                            return false;
                        }
                    }
                }

                // 2. Get Profile ID from Relacion Us-Pe (storing IDs as String)
                string idPerfilStr = "";
                using (OleDbCommand cmdRel = new OleDbCommand("SELECT [Id_Perfil] FROM [Relacion Us-Pe] WHERE [Id_Usuario] = ?", conn))
                {
                    cmdRel.Parameters.AddWithValue("?", idUsuario.ToString());
                    object res = cmdRel.ExecuteScalar();
                    if (res != null) idPerfilStr = res.ToString();
                }

                // 3. Get Profile Name from Perfil
                if (!string.IsNullOrEmpty(idPerfilStr))
                {
                    using (OleDbCommand cmdPerf = new OleDbCommand("SELECT [Nombre] FROM [Perfil] WHERE [Id_Perfil] = ?", conn))
                    {
                        cmdPerf.Parameters.AddWithValue("?", Convert.ToInt32(idPerfilStr));
                        object resName = cmdPerf.ExecuteScalar();
                        if (resName != null) perfil = resName.ToString();
                    }
                }

                RegistrarSesion(usuario, "Ingreso correcto.");
                return true;
            }
            catch (Exception ex)
            {
                RegistrarSesion(usuario, "Error del sistema: " + ex.Message);
                return false;
            }
        }

        public static DataTable ObtenerAuditoria()
        {
            DataTable dt = new DataTable();
            try
            {
                OleDbConnection conn = csConexion.GetConnection();
                if (conn.State == ConnectionState.Closed) conn.Open();
                using (OleDbCommand cmd = new OleDbCommand("SELECT [Id_Auditoria], [Fecha], [Hora], [Usuario], [Detalle] FROM [AuditoriaSesion] ORDER BY [Fecha] DESC, [Id_Auditoria] DESC", conn))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception) { }
            return dt;
        }

        public static DataTable ObtenerPerfiles()
        {
            DataTable dt = new DataTable();
            try
            {
                OleDbConnection conn = csConexion.GetConnection();
                if (conn.State == ConnectionState.Closed) conn.Open();
                using (OleDbCommand cmd = new OleDbCommand("SELECT [Id_Perfil], [Nombre] FROM [Perfil] ORDER BY [Id_Perfil] ASC", conn))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception) { }
            return dt;
        }

        public static DataTable ObtenerProvincias()
        {
            DataTable dt = new DataTable();
            try
            {
                OleDbConnection conn = csConexion.GetConnection();
                if (conn.State == ConnectionState.Closed) conn.Open();
                using (OleDbCommand cmd = new OleDbCommand("SELECT [Id-Provincias], [Provincias] FROM [Provincias] ORDER BY [Provincias] ASC", conn))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception) { }
            return dt;
        }

        public static DataTable ObtenerLocalidades()
        {
            DataTable dt = new DataTable();
            try
            {
                OleDbConnection conn = csConexion.GetConnection();
                if (conn.State == ConnectionState.Closed) conn.Open();
                using (OleDbCommand cmd = new OleDbCommand("SELECT [Id-Localidad], [Localidad] FROM [Localidades] ORDER BY [Localidad] ASC", conn))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception) { }
            return dt;
        }

        public static DataTable ObtenerUsuariosActivos()
        {
            DataTable dt = new DataTable();
            try
            {
                OleDbConnection conn = csConexion.GetConnection();
                if (conn.State == ConnectionState.Closed) conn.Open();
                using (OleDbCommand cmd = new OleDbCommand("SELECT [Id_Usuario], [Nombre] + ' ' + [Apellido] + ' (DNI: ' + [DNI] + ')' AS [Display] FROM [Usuario] WHERE [Activo] = 'si' ORDER BY [Nombre] ASC, [Apellido] ASC", conn))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception) { }
            return dt;
        }

        public static DataRow ObtenerDetalleUsuario(int idUsuario)
        {
            DataTable dt = new DataTable();
            try
            {
                OleDbConnection conn = csConexion.GetConnection();
                if (conn.State == ConnectionState.Closed) conn.Open();
                using (OleDbCommand cmd = new OleDbCommand("SELECT [Id_Usuario], [Nombre], [Apellido], [DNI], [Contraseña], [Mail], [Activo] FROM [Usuario] WHERE [Id_Usuario] = ?", conn))
                {
                    cmd.Parameters.AddWithValue("?", idUsuario);
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception) { }
            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }

        public static int ObtenerPerfilUsuario(int idUsuario)
        {
            try
            {
                OleDbConnection conn = csConexion.GetConnection();
                if (conn.State == ConnectionState.Closed) conn.Open();
                using (OleDbCommand cmd = new OleDbCommand("SELECT [Id_Perfil] FROM [Relacion Us-Pe] WHERE [Id_Usuario] = ?", conn))
                {
                    cmd.Parameters.AddWithValue("?", idUsuario.ToString());
                    object res = cmd.ExecuteScalar();
                    if (res != null) return Convert.ToInt32(res);
                }
            }
            catch (Exception) { }
            return -1;
        }

        public static DataTable ObtenerContactosUsuario(int idUsuario)
        {
            DataTable dt = new DataTable();
            try
            {
                OleDbConnection conn = csConexion.GetConnection();
                if (conn.State == ConnectionState.Closed) conn.Open();
                using (OleDbCommand cmd = new OleDbCommand("SELECT [Numero Celular], [Redes Sociales], [Correo] FROM [Contacto] WHERE [Id-Usuario] = ?", conn))
                {
                    cmd.Parameters.AddWithValue("?", idUsuario);
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception) { }
            return dt;
        }

        public static DataTable ObtenerDomiciliosUsuario(int idUsuario)
        {
            DataTable dt = new DataTable();
            try
            {
                OleDbConnection conn = csConexion.GetConnection();
                if (conn.State == ConnectionState.Closed) conn.Open();
                using (OleDbCommand cmd = new OleDbCommand("SELECT [Nombre], [Numeracion], [Tipo], [Link Maps] FROM [Domicilio] WHERE [Id-Usuario] = ?", conn))
                {
                    cmd.Parameters.AddWithValue("?", idUsuario);
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception) { }
            return dt;
        }

        public static int AgregarUsuario(
            string nombre, 
            string apellido, 
            string dni, 
            string contrasenia, 
            string mail,
            int idPerfil, 
            List<Tuple<string, string, string>> contactos, 
            List<Tuple<string, string, string, string>> domicilios)
        {
            OleDbConnection conn = csConexion.GetConnection();
            if (conn.State == ConnectionState.Closed) conn.Open();
            OleDbTransaction transaction = conn.BeginTransaction();
            
            try
            {
                // 1. Insert into Usuario
                int newUserId = -1;
                using (OleDbCommand cmd = new OleDbCommand("INSERT INTO [Usuario] ([Nombre], [Apellido], [DNI], [Contraseña], [Mail], [Activo]) VALUES (?, ?, ?, ?, ?, ?)", conn, transaction))
                {
                    cmd.Parameters.AddWithValue("?", nombre);
                    cmd.Parameters.AddWithValue("?", apellido);
                    cmd.Parameters.AddWithValue("?", dni);
                    cmd.Parameters.AddWithValue("?", contrasenia);
                    cmd.Parameters.AddWithValue("?", mail);
                    cmd.Parameters.AddWithValue("?", "si");
                    cmd.ExecuteNonQuery();
                }

                // Get ID autonumeric
                using (OleDbCommand cmdId = new OleDbCommand("SELECT @@IDENTITY", conn, transaction))
                {
                    newUserId = Convert.ToInt32(cmdId.ExecuteScalar());
                }

                // 2. Insert into Relacion Us-Pe
                using (OleDbCommand cmdRel = new OleDbCommand("INSERT INTO [Relacion Us-Pe] ([Id_Usuario], [Id_Perfil]) VALUES (?, ?)", conn, transaction))
                {
                    cmdRel.Parameters.AddWithValue("?", newUserId.ToString());
                    cmdRel.Parameters.AddWithValue("?", idPerfil.ToString());
                    cmdRel.ExecuteNonQuery();
                }

                // 3. Insert Contactos
                foreach (var contact in contactos)
                {
                    using (OleDbCommand cmdCont = new OleDbCommand("INSERT INTO [Contacto] ([Id-Usuario], [Numero Celular], [Redes Sociales], [Correo]) VALUES (?, ?, ?, ?)", conn, transaction))
                    {
                        cmdCont.Parameters.AddWithValue("?", newUserId);
                        cmdCont.Parameters.AddWithValue("?", contact.Item1 ?? (object)DBNull.Value);
                        cmdCont.Parameters.AddWithValue("?", contact.Item2 ?? (object)DBNull.Value);
                        cmdCont.Parameters.AddWithValue("?", contact.Item3 ?? (object)DBNull.Value);
                        cmdCont.ExecuteNonQuery();
                    }
                }

                // 4. Insert Domicilios
                foreach (var dom in domicilios)
                {
                    using (OleDbCommand cmdDom = new OleDbCommand("INSERT INTO [Domicilio] ([Id-Usuario], [Nombre], [Numeracion], [Tipo], [Link Maps]) VALUES (?, ?, ?, ?, ?)", conn, transaction))
                    {
                        cmdDom.Parameters.AddWithValue("?", newUserId);
                        cmdDom.Parameters.AddWithValue("?", dom.Item1 ?? (object)DBNull.Value);
                        cmdDom.Parameters.AddWithValue("?", dom.Item2 ?? (object)DBNull.Value);
                        cmdDom.Parameters.AddWithValue("?", dom.Item3 ?? (object)DBNull.Value);
                        cmdDom.Parameters.AddWithValue("?", dom.Item4 ?? (object)DBNull.Value);
                        cmdDom.ExecuteNonQuery();
                    }
                }

                transaction.Commit();
                return newUserId;
            }
            catch (Exception)
            {
                transaction.Rollback();
                throw;
            }
        }

        public static bool ActualizarUsuario(
            int idUsuario,
            string nombre,
            string apellido,
            string dni,
            string contrasenia,
            string mail,
            int idPerfil,
            List<Tuple<string, string, string>> contactos,
            List<Tuple<string, string, string, string>> domicilios)
        {
            OleDbConnection conn = csConexion.GetConnection();
            if (conn.State == ConnectionState.Closed) conn.Open();
            OleDbTransaction transaction = conn.BeginTransaction();
            try
            {
                // 1. Update Usuario
                using (OleDbCommand cmd = new OleDbCommand("UPDATE [Usuario] SET [Nombre] = ?, [Apellido] = ?, [DNI] = ?, [Contraseña] = ?, [Mail] = ? WHERE [Id_Usuario] = ?", conn, transaction))
                {
                    cmd.Parameters.AddWithValue("?", nombre);
                    cmd.Parameters.AddWithValue("?", apellido);
                    cmd.Parameters.AddWithValue("?", dni);
                    cmd.Parameters.AddWithValue("?", contrasenia);
                    cmd.Parameters.AddWithValue("?", mail);
                    cmd.Parameters.AddWithValue("?", idUsuario);
                    cmd.ExecuteNonQuery();
                }

                // 2. Update Relacion Us-Pe (delete first, then insert)
                using (OleDbCommand cmdDelRel = new OleDbCommand("DELETE FROM [Relacion Us-Pe] WHERE [Id_Usuario] = ?", conn, transaction))
                {
                    cmdDelRel.Parameters.AddWithValue("?", idUsuario.ToString());
                    cmdDelRel.ExecuteNonQuery();
                }
                using (OleDbCommand cmdInsRel = new OleDbCommand("INSERT INTO [Relacion Us-Pe] ([Id_Usuario], [Id_Perfil]) VALUES (?, ?)", conn, transaction))
                {
                    cmdInsRel.Parameters.AddWithValue("?", idUsuario.ToString());
                    cmdInsRel.Parameters.AddWithValue("?", idPerfil.ToString());
                    cmdInsRel.ExecuteNonQuery();
                }

                // 3. Update Contactos (delete first, then insert)
                using (OleDbCommand cmdDelCont = new OleDbCommand("DELETE FROM [Contacto] WHERE [Id-Usuario] = ?", conn, transaction))
                {
                    cmdDelCont.Parameters.AddWithValue("?", idUsuario);
                    cmdDelCont.ExecuteNonQuery();
                }
                foreach (var contact in contactos)
                {
                    using (OleDbCommand cmdCont = new OleDbCommand("INSERT INTO [Contacto] ([Id-Usuario], [Numero Celular], [Redes Sociales], [Correo]) VALUES (?, ?, ?, ?)", conn, transaction))
                    {
                        cmdCont.Parameters.AddWithValue("?", idUsuario);
                        cmdCont.Parameters.AddWithValue("?", contact.Item1 ?? (object)DBNull.Value);
                        cmdCont.Parameters.AddWithValue("?", contact.Item2 ?? (object)DBNull.Value);
                        cmdCont.Parameters.AddWithValue("?", contact.Item3 ?? (object)DBNull.Value);
                        cmdCont.ExecuteNonQuery();
                    }
                }

                // 4. Update Domicilios (delete first, then insert)
                using (OleDbCommand cmdDelDom = new OleDbCommand("DELETE FROM [Domicilio] WHERE [Id-Usuario] = ?", conn, transaction))
                {
                    cmdDelDom.Parameters.AddWithValue("?", idUsuario);
                    cmdDelDom.ExecuteNonQuery();
                }
                foreach (var dom in domicilios)
                {
                    using (OleDbCommand cmdDom = new OleDbCommand("INSERT INTO [Domicilio] ([Id-Usuario], [Nombre], [Numeracion], [Tipo], [Link Maps]) VALUES (?, ?, ?, ?, ?)", conn, transaction))
                    {
                        cmdDom.Parameters.AddWithValue("?", idUsuario);
                        cmdDom.Parameters.AddWithValue("?", dom.Item1 ?? (object)DBNull.Value);
                        cmdDom.Parameters.AddWithValue("?", dom.Item2 ?? (object)DBNull.Value);
                        cmdDom.Parameters.AddWithValue("?", dom.Item3 ?? (object)DBNull.Value);
                        cmdDom.Parameters.AddWithValue("?", dom.Item4 ?? (object)DBNull.Value);
                        cmdDom.ExecuteNonQuery();
                    }
                }

                transaction.Commit();
                return true;
            }
            catch (Exception)
            {
                transaction.Rollback();
                throw;
            }
        }

        public static bool DarDeBajaUsuario(int idUsuario)
        {
            try
            {
                OleDbConnection conn = csConexion.GetConnection();
                if (conn.State == ConnectionState.Closed) conn.Open();
                using (OleDbCommand cmd = new OleDbCommand("UPDATE [Usuario] SET [Activo] = 'no' WHERE [Id_Usuario] = ?", conn))
                {
                    cmd.Parameters.AddWithValue("?", idUsuario);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
