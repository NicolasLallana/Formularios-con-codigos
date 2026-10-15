using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Validación_códigos
{
    public partial class frmcargasaldo : Form{
        private int idt;
        private ConsultasDB con = new ConsultasDB();

        public frmcargasaldo(int idt){
            InitializeComponent();
            this.idt = idt;
            this.StartPosition = FormStartPosition.CenterScreen;
            // Enter should activar el botón de confirmar
            this.AcceptButton = btnconfirmar;
            if (con.Validar_Codigo(idt) == 0){
                MessageBox.Show("Código inválido");
                this.Close();
            }
            lblmostrarsaldo.Text = "$ " + con.Consulta_Saldo(idt).ToString("F0");
        }

        private void frmcargasaldo_Load(object sender, EventArgs e)
        {
            // Asegura que el control reciba foco después de que el formulario se muestre
            this.BeginInvoke((Action)(() => { txtmonto.Focus(); }));
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtmonto.Text)){
                MessageBox.Show("Rellene el campo Monto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtmonto.Text, out decimal monto)){
                MessageBox.Show("Formato de Monto inválido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmonto.Clear();
                return;
            }
            try{
                decimal carga = Convert.ToDecimal(txtmonto.Text);
                con.Cargar_Saldo(idt, carga);
                MessageBox.Show("Saldo cargado correctamente.", "Carga exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex){
                MessageBox.Show("Error al cargar saldo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
