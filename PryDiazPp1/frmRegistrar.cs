namespace PryDiazPp1
{
    public partial class frmRegistrar : Form
    {
        public frmRegistrar()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            frmBienvenida frmBienvenida = new frmBienvenida();
            frmBienvenida.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            TxtUsuario.Text = "";

            TxtContraseña.Text = "";

            CmbComboBox.SelectedIndex = -1;
        }
    }
}
