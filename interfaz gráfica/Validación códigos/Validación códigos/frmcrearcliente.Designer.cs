namespace Validación_códigos
{
    partial class frmcrearcliente
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
            btnsalir = new Button();
            btnconfirmar = new Button();
            lblnombre = new Label();
            lbltarjeta = new Label();
            txtnombre = new TextBox();
            txttarjeta = new TextBox();
            txtfechanac = new TextBox();
            lblfechanac = new Label();
            SuspendLayout();
            // 
            // btnsalir
            // 
            btnsalir.Font = new Font("Segoe UI", 10.9439993F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsalir.Location = new Point(65, 316);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(204, 64);
            btnsalir.TabIndex = 3;
            btnsalir.Text = "CANCELAR Y SALIR";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // btnconfirmar
            // 
            btnconfirmar.Font = new Font("Segoe UI", 10.9439993F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnconfirmar.Location = new Point(591, 316);
            btnconfirmar.Name = "btnconfirmar";
            btnconfirmar.Size = new Size(191, 64);
            btnconfirmar.TabIndex = 2;
            btnconfirmar.Text = "CONFIRMAR";
            btnconfirmar.UseVisualStyleBackColor = true;
            btnconfirmar.Click += btnconfirmar_Click;
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Font = new Font("Segoe UI", 20.16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblnombre.Location = new Point(65, 122);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(173, 47);
            lblnombre.TabIndex = 4;
            lblnombre.Text = "NOMBRE";
            // 
            // lbltarjeta
            // 
            lbltarjeta.AutoSize = true;
            lbltarjeta.Font = new Font("Segoe UI", 20.16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltarjeta.Location = new Point(65, 46);
            lbltarjeta.Name = "lbltarjeta";
            lbltarjeta.Size = new Size(263, 47);
            lbltarjeta.TabIndex = 5;
            lbltarjeta.Text = "NRO. TARJETA";
            // 
            // txtnombre
            // 
            txtnombre.Font = new Font("Segoe UI", 16.128F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtnombre.Location = new Point(390, 122);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(392, 45);
            txtnombre.TabIndex = 6;
            // 
            // txttarjeta
            // 
            txttarjeta.Font = new Font("Segoe UI", 16.128F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txttarjeta.Location = new Point(390, 46);
            txttarjeta.Name = "txttarjeta";
            txttarjeta.Size = new Size(392, 45);
            txttarjeta.TabIndex = 7;
            // 
            // txtfechanac
            // 
            txtfechanac.Font = new Font("Segoe UI", 16.128F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtfechanac.Location = new Point(390, 193);
            txtfechanac.Name = "txtfechanac";
            txtfechanac.Size = new Size(392, 45);
            txtfechanac.TabIndex = 9;
            // 
            // lblfechanac
            // 
            lblfechanac.AutoSize = true;
            lblfechanac.Font = new Font("Segoe UI", 20.16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblfechanac.Location = new Point(65, 193);
            lblfechanac.Name = "lblfechanac";
            lblfechanac.Size = new Size(279, 47);
            lblfechanac.TabIndex = 8;
            lblfechanac.Text = "FECHA DE NAC.";
            // 
            // frmcrearcliente
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 412);
            Controls.Add(txtfechanac);
            Controls.Add(lblfechanac);
            Controls.Add(txttarjeta);
            Controls.Add(txtnombre);
            Controls.Add(lbltarjeta);
            Controls.Add(lblnombre);
            Controls.Add(btnsalir);
            Controls.Add(btnconfirmar);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "frmcrearcliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ASOCIAR TARJETA A CLIENTE";
            Load += frmasociartarjeta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnsalir;
        private Button btnconfirmar;
        private Label lblnombre;
        private Label lbltarjeta;
        private TextBox txtnombre;
        private TextBox txttarjeta;
        private TextBox txtfechanac;
        private Label lblfechanac;
    }
}