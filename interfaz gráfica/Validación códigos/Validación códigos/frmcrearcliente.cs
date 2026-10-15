using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Validación_códigos
{
    public partial class frmcrearcliente : Form
    {
        private ConexionDB con;
        public frmcrearcliente()
        {
            con = new ConexionDB();
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            // Enter should activar el botón de confirmar
            this.AcceptButton = btnconfirmar;
        }

        public void Limpieza_Cajas()
        {
            txtfechanac.Clear();
            txtnombre.Clear();
            txttarjeta.Clear();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmasociartarjeta_Load(object sender, EventArgs e)
        {
            // Asegura que el control reciba foco después de que el formulario se muestre
            this.BeginInvoke((Action)(() => { txttarjeta.Focus(); }));
        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txttarjeta.Text) || string.IsNullOrWhiteSpace(txtnombre.Text)){
                    MessageBox.Show("Rellene los campos Nro. Tarjeta y Nombre.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Limpieza_Cajas();
                    return;
            }

            if (!DateTime.TryParse(txtfechanac.Text.Trim(), out DateTime fecha)){
                    MessageBox.Show("Formato de fecha inválido. Use dd/mm/aaaa o formato local.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Limpieza_Cajas();
                    return;
            }
            ConsultasDB con = new ConsultasDB();
            int idt = int.Parse(txttarjeta.Text);
            if (con.Validar_Codigo(idt) == 1){
                MessageBox.Show("La tarjeta ya existe.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Limpieza_Cajas();
                return;
            }
            try
            {
                con.Crear_Tarjeta(idt);
                string nom = txtnombre.Text;
                DateTime nac = DateTime.Parse(txtfechanac.Text);
                con.Crear_Cliente(idt, nom, nac);
                MessageBox.Show("Cliente creado correctamente.", "Creación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
