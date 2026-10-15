namespace Validación_códigos
{
    partial class frmventa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmventa));
            btnconfirmar = new Button();
            btnsalir = new Button();
            pnlmenu = new Panel();
            button2 = new Button();
            button1 = new Button();
            btntrago = new Button();
            pnlventa = new Panel();
            lbltotal = new Label();
            lblventatotal = new Label();
            pnlmenu.SuspendLayout();
            SuspendLayout();
            // 
            // btnconfirmar
            // 
            btnconfirmar.Font = new Font("Segoe UI", 10.9439993F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnconfirmar.Location = new Point(925, 500);
            btnconfirmar.Name = "btnconfirmar";
            btnconfirmar.Size = new Size(191, 64);
            btnconfirmar.TabIndex = 0;
            btnconfirmar.Text = "CONFIRMAR";
            btnconfirmar.UseVisualStyleBackColor = true;
            // 
            // btnsalir
            // 
            btnsalir.Font = new Font("Segoe UI", 10.9439993F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsalir.Location = new Point(34, 500);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(204, 64);
            btnsalir.TabIndex = 1;
            btnsalir.Text = "CANCELAR Y SALIR";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // pnlmenu
            // 
            pnlmenu.Controls.Add(button2);
            pnlmenu.Controls.Add(button1);
            pnlmenu.Controls.Add(btntrago);
            pnlmenu.Font = new Font("Segoe UI", 9.792F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlmenu.Location = new Point(12, 12);
            pnlmenu.Name = "pnlmenu";
            pnlmenu.Size = new Size(745, 463);
            pnlmenu.TabIndex = 2;
            pnlmenu.Paint += pnlmenu_Paint;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLight;
            button2.Font = new Font("Segoe UI", 8.064F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(295, 0);
            button2.Name = "button2";
            button2.Size = new Size(140, 157);
            button2.TabIndex = 2;
            button2.Text = "ZILLERTAL 1L";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Font = new Font("Segoe UI", 8.064F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(149, 0);
            button1.Name = "button1";
            button1.Size = new Size(140, 157);
            button1.TabIndex = 1;
            button1.Text = "CORONA 355 c.c.";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = false;
            // 
            // btntrago
            // 
            btntrago.BackColor = SystemColors.ControlLight;
            btntrago.Font = new Font("Segoe UI", 9.216F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btntrago.Image = (Image)resources.GetObject("btntrago.Image");
            btntrago.ImageAlign = ContentAlignment.TopCenter;
            btntrago.Location = new Point(3, 0);
            btntrago.Name = "btntrago";
            btntrago.Size = new Size(140, 157);
            btntrago.TabIndex = 0;
            btntrago.Text = "TRAGO";
            btntrago.TextAlign = ContentAlignment.BottomCenter;
            btntrago.UseVisualStyleBackColor = false;
            btntrago.Click += button1_Click;
            // 
            // pnlventa
            // 
            pnlventa.Location = new Point(776, 12);
            pnlventa.Name = "pnlventa";
            pnlventa.Size = new Size(370, 407);
            pnlventa.TabIndex = 3;
            // 
            // lbltotal
            // 
            lbltotal.AutoSize = true;
            lbltotal.Font = new Font("Segoe UI", 13.8239994F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltotal.Location = new Point(776, 442);
            lbltotal.Name = "lbltotal";
            lbltotal.Size = new Size(148, 32);
            lbltotal.TabIndex = 4;
            lbltotal.Text = "TOTAL   :   $";
            // 
            // lblventatotal
            // 
            lblventatotal.AutoSize = true;
            lblventatotal.Font = new Font("Segoe UI", 16.128F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblventatotal.Location = new Point(974, 436);
            lblventatotal.Name = "lblventatotal";
            lblventatotal.Size = new Size(113, 38);
            lblventatotal.TabIndex = 5;
            lblventatotal.Text = "$$$$$$";
            // 
            // frmventa
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1158, 597);
            Controls.Add(lblventatotal);
            Controls.Add(lbltotal);
            Controls.Add(pnlventa);
            Controls.Add(pnlmenu);
            Controls.Add(btnsalir);
            Controls.Add(btnconfirmar);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "frmventa";
            StartPosition = FormStartPosition.CenterParent;
            Text = "VENTA";
            Load += frmventa_Load;
            pnlmenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnconfirmar;
        private Button btnsalir;
        private Panel pnlmenu;
        private Panel pnlventa;
        private Label lbltotal;
        private Label lblventatotal;
        private Button btntrago;
        private Button button1;
        private Button button2;
    }
}