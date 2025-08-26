namespace PryDiazPp1
{
    partial class frmRegistrar
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
            LblUsuario = new Label();
            LblContraseña = new Label();
            LblModulo = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            BtnAceptar = new Button();
            BtnCancelar = new Button();
            CmbComboBox = new ComboBox();
            SuspendLayout();
            // 
            // LblUsuario
            // 
            LblUsuario.AutoSize = true;
            LblUsuario.Font = new Font("Segoe UI", 9.75F);
            LblUsuario.ForeColor = Color.Black;
            LblUsuario.Location = new Point(71, 85);
            LblUsuario.Name = "LblUsuario";
            LblUsuario.Size = new Size(53, 17);
            LblUsuario.TabIndex = 0;
            LblUsuario.Text = "Usuario";
            // 
            // LblContraseña
            // 
            LblContraseña.AutoSize = true;
            LblContraseña.Font = new Font("Segoe UI", 9.75F);
            LblContraseña.ForeColor = Color.Black;
            LblContraseña.Location = new Point(71, 182);
            LblContraseña.Name = "LblContraseña";
            LblContraseña.Size = new Size(74, 17);
            LblContraseña.TabIndex = 1;
            LblContraseña.Text = "Contraseña";
            // 
            // LblModulo
            // 
            LblModulo.AutoSize = true;
            LblModulo.Font = new Font("Segoe UI", 9.75F);
            LblModulo.ForeColor = Color.Black;
            LblModulo.Location = new Point(71, 289);
            LblModulo.Name = "LblModulo";
            LblModulo.Size = new Size(54, 17);
            LblModulo.TabIndex = 2;
            LblModulo.Text = "Modulo";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(228, 82);
            textBox1.MaxLength = 10;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(109, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(228, 182);
            textBox2.MaxLength = 10;
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '#';
            textBox2.Size = new Size(109, 23);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // BtnAceptar
            // 
            BtnAceptar.ForeColor = Color.Black;
            BtnAceptar.Location = new Point(452, 85);
            BtnAceptar.Name = "BtnAceptar";
            BtnAceptar.Size = new Size(75, 23);
            BtnAceptar.TabIndex = 6;
            BtnAceptar.Text = "Aceptar";
            BtnAceptar.UseVisualStyleBackColor = true;
            BtnAceptar.Click += BtnAceptar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.ForeColor = Color.Black;
            BtnCancelar.Location = new Point(452, 199);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(75, 23);
            BtnCancelar.TabIndex = 7;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // CmbComboBox
            // 
            CmbComboBox.FormattingEnabled = true;
            CmbComboBox.Location = new Point(228, 283);
            CmbComboBox.Name = "CmbComboBox";
            CmbComboBox.Size = new Size(109, 23);
            CmbComboBox.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(CmbComboBox);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnAceptar);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(LblModulo);
            Controls.Add(LblContraseña);
            Controls.Add(LblUsuario);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblUsuario;
        private Label LblContraseña;
        private Label LblModulo;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button BtnAceptar;
        private Button BtnCancelar;
        private ComboBox CmbComboBox;
    }
}
