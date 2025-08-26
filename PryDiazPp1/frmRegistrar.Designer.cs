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
            TxtUsuario = new TextBox();
            TxtContraseña = new TextBox();
            BtnAceptar = new Button();
            BtnCancelar = new Button();
            CmbComboBox = new ComboBox();
            btnCancel = new Button();
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
            // TxtUsuario
            // 
            TxtUsuario.Location = new Point(228, 82);
            TxtUsuario.MaxLength = 10;
            TxtUsuario.Name = "TxtUsuario";
            TxtUsuario.Size = new Size(109, 23);
            TxtUsuario.TabIndex = 3;
            // 
            // TxtContraseña
            // 
            TxtContraseña.Location = new Point(228, 182);
            TxtContraseña.MaxLength = 10;
            TxtContraseña.Name = "TxtContraseña";
            TxtContraseña.PasswordChar = '#';
            TxtContraseña.Size = new Size(109, 23);
            TxtContraseña.TabIndex = 4;
            TxtContraseña.TextChanged += textBox2_TextChanged;
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
            BtnCancelar.Location = new Point(0, 0);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(75, 23);
            BtnCancelar.TabIndex = 0;
            // 
            // CmbComboBox
            // 
            CmbComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbComboBox.FormattingEnabled = true;
            CmbComboBox.Items.AddRange(new object[] { "ADM", "SIST", "COM", "VTA" });
            CmbComboBox.Location = new Point(228, 283);
            CmbComboBox.Name = "CmbComboBox";
            CmbComboBox.Size = new Size(109, 23);
            CmbComboBox.TabIndex = 8;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(452, 172);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmRegistrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(CmbComboBox);
            Controls.Add(BtnAceptar);
            Controls.Add(TxtContraseña);
            Controls.Add(TxtUsuario);
            Controls.Add(LblModulo);
            Controls.Add(LblContraseña);
            Controls.Add(LblUsuario);
            Name = "frmRegistrar";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblUsuario;
        private Label LblContraseña;
        private Label LblModulo;
        private TextBox TxtUsuario;
        private TextBox TxtContraseña;
        private Button BtnAceptar;
        private Button BtnCancelar;
        private ComboBox CmbComboBox;
        private Button btnCancel;
    }
}
