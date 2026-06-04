using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pryAybar.ERP2.CLS;

namespace pryAybar.ERP2
{
    public partial class frmInicioSesion : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public frmInicioSesion()
        {
            InitializeComponent();
        }

        private void frmInicioSesion_Load(object sender, EventArgs e)
        {
            string msg;
            if (!csConexion.TestConnection(out msg))
            {
                lblError.Text = "Error BD: " + msg;
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string userStr = txtUsuario.Text.Trim();
            string passStr = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(userStr) || string.IsNullOrEmpty(passStr))
            {
                lblError.Text = "Por favor, ingrese usuario y contraseña.";
                return;
            }

            int idUsuario;
            string nombreCompleto;
            string perfil;

            lblError.Text = "Verificando...";
            Application.DoEvents();

            if (csMetodos.VerificarLogin(userStr, passStr, out idUsuario, out nombreCompleto, out perfil))
            {
                lblError.Text = "";
                frmPrincipal principal = new frmPrincipal(idUsuario, nombreCompleto, perfil);
                this.Hide();
                if (principal.ShowDialog() == DialogResult.OK)
                {
                    this.Show();
                    txtUsuario.Clear();
                    txtPassword.Clear();
                    txtUsuario.Focus();
                }
                else
                {
                    Application.Exit();
                    Environment.Exit(0);
                }
            }
            else
            {
                lblError.Text = "Usuario o contraseña incorrectos, o usuario inactivo.";
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Environment.Exit(0);
        }

        private void chkMostrarPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkMostrarPass.Checked;
        }

        private void Drag_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Drag_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Drag_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void txtInputs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnEntrar_Click(sender, e);
                e.Handled = true;
            }
        }
    }
}
