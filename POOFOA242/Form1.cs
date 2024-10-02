namespace POOFOA242
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nome = txtNome.Text;
            MessageBox.Show($"Seja vem-vindo(a) {nome}");
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
                btnCliqueMe.Enabled = false;
            else 
                btnCliqueMe.Enabled = true;
        }
    }
}
