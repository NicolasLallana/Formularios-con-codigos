namespace Validación_códigos
{
    partial class frmcargasaldo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtmonto = new TextBox();
            lblmonto = new Label();
            lblsaldo = new Label();
            btnsalir = new Button();
            btnconfirmar = new Button();
            lblmostrarsaldo = new Label();
            SuspendLayout();
            // 
            // txtmonto
            // 
            txtmonto.Font = new Font("Segoe UI", 16.128F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtmonto.Location = new Point(417, 146);
            txtmonto.Name = "txtmonto";
            txtmonto.Size = new Size(325, 45);
            txtmonto.TabIndex = 17;
            // 
            // lblmonto
            // 
            lblmonto.AutoSize = true;
            lblmonto.Font = new Font("Segoe UI", 20.16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblmonto.Location = new Point(42, 142);
            lblmonto.Name = "lblmonto";
            lblmonto.Size = new Size(344, 47);
            lblmonto.TabIndex = 16;
            lblmonto.Text = "MONTO A CARGAR";
            // 
            // lblsaldo
            // 
            lblsaldo.AutoSize = true;
            lblsaldo.Font = new Font("Segoe UI", 20.16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblsaldo.Location = new Point(42, 58);
            lblsaldo.Name = "lblsaldo";
            lblsaldo.Size = new Size(299, 47);
            lblsaldo.TabIndex = 13;
            lblsaldo.Text = "SALDO ACTUAL :";
            // 
            // btnsalir
            // 
            btnsalir.Font = new Font("Segoe UI", 10.9439993F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsalir.Location = new Point(42, 285);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(204, 64);
            btnsalir.TabIndex = 11;
            btnsalir.Text = "CANCELAR Y SALIR";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // btnconfirmar
            // 
            btnconfirmar.Font = new Font("Segoe UI", 10.9439993F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnconfirmar.Location = new Point(568, 285);
            btnconfirmar.Name = "btnconfirmar";
            btnconfirmar.Size = new Size(191, 64);
            btnconfirmar.TabIndex = 10;
            btnconfirmar.Text = "CONFIRMAR";
            btnconfirmar.UseVisualStyleBackColor = true;
            btnconfirmar.Click += btnconfirmar_Click;
            // 
            // lblmostrarsaldo
            // 
            lblmostrarsaldo.AutoSize = true;
            lblmostrarsaldo.Font = new Font("Segoe UI", 20.16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblmostrarsaldo.Location = new Point(445, 58);
            lblmostrarsaldo.Name = "lblmostrarsaldo";
            lblmostrarsaldo.Size = new Size(200, 47);
            lblmostrarsaldo.TabIndex = 18;
            lblmostrarsaldo.Text = "$$$$$$$$$";
            // 
            // frmcargasaldo
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 403);
            Controls.Add(lblmostrarsaldo);
            Controls.Add(txtmonto);
            Controls.Add(lblmonto);
            Controls.Add(lblsaldo);
            Controls.Add(btnsalir);
            Controls.Add(btnconfirmar);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "frmcargasaldo";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "CARGAR SALDO";
            Load += frmcargasaldo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtmonto;
        private Label lblmonto;
        private Label lblsaldo;
        private Button btnsalir;
        private Button btnconfirmar;
        private Label lblmostrarsaldo;
    }
}