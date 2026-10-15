namespace Validación_códigos
{
    partial class pnlprincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnlprincipal));
            lblcodigo = new Label();
            txtcodigo = new TextBox();
            menuStrip1 = new MenuStrip();
            itmcrearcliente = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblcodigo
            // 
            lblcodigo.AutoSize = true;
            lblcodigo.BackColor = SystemColors.ControlDarkDark;
            lblcodigo.Font = new Font("Segoe UI", 21.8879986F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcodigo.ForeColor = SystemColors.MenuText;
            lblcodigo.Location = new Point(106, 340);
            lblcodigo.Name = "lblcodigo";
            lblcodigo.Size = new Size(784, 51);
            lblcodigo.TabIndex = 1;
            lblcodigo.Text = "ESCANEAR CÓDIGO PARA CARGAR SALDO";
            lblcodigo.Click += lblcodigo_Click;
            // 
            // txtcodigo
            // 
            txtcodigo.Font = new Font("Segoe UI", 24.192F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtcodigo.ForeColor = SystemColors.WindowText;
            txtcodigo.Location = new Point(265, 434);
            txtcodigo.Name = "txtcodigo";
            txtcodigo.Size = new Size(536, 63);
            txtcodigo.TabIndex = 2;
            txtcodigo.TextChanged += txtcodigo_TextChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(21, 21);
            menuStrip1.Items.AddRange(new ToolStripItem[] { itmcrearcliente });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1039, 40);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // itmcrearcliente
            // 
            itmcrearcliente.Font = new Font("Segoe UI Semibold", 13.8239994F, FontStyle.Bold);
            itmcrearcliente.Name = "itmcrearcliente";
            itmcrearcliente.Size = new Size(197, 36);
            itmcrearcliente.Text = "CREAR CLIENTE";
            itmcrearcliente.Click += itmasociartarjeta_Click;
            // 
            // pnlprincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1039, 774);
            Controls.Add(txtcodigo);
            Controls.Add(lblcodigo);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ButtonHighlight;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "pnlprincipal";
            StartPosition = FormStartPosition.CenterParent;
            Text = "PUNTO DE CARGA VERSIÓN 1.0";
            Load += pnlprincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label lblcodigo;
        private TextBox txtcodigo;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem itmcrearcliente;
    }
}
