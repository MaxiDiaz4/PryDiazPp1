namespace PryDiazPp1
{
    partial class frmBienvenida
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
            LblBienvenido = new Label();
            LblSintepartSrl = new Label();
            SuspendLayout();
            // 
            // LblBienvenido
            // 
            LblBienvenido.AutoSize = true;
            LblBienvenido.BackColor = Color.White;
            LblBienvenido.Font = new Font("Stencil", 24F);
            LblBienvenido.Location = new Point(296, 150);
            LblBienvenido.Name = "LblBienvenido";
            LblBienvenido.Size = new Size(237, 38);
            LblBienvenido.TabIndex = 0;
            LblBienvenido.Text = "BIENVENIDO!!!";
            // 
            // LblSintepartSrl
            // 
            LblSintepartSrl.AutoSize = true;
            LblSintepartSrl.BackColor = Color.Red;
            LblSintepartSrl.Font = new Font("Stencil", 24F);
            LblSintepartSrl.Location = new Point(272, 250);
            LblSintepartSrl.Name = "LblSintepartSrl";
            LblSintepartSrl.Size = new Size(275, 38);
            LblSintepartSrl.TabIndex = 1;
            LblSintepartSrl.Text = "SINTERPART SRL";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Blue;
            ClientSize = new Size(800, 450);
            Controls.Add(LblSintepartSrl);
            Controls.Add(LblBienvenido);
            ForeColor = SystemColors.ControlText;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblBienvenido;
        private Label LblSintepartSrl;
    }
}