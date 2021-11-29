namespace formulaireCli
{
    public partial class formulaireClient : Form
    {
        public formulaireClient()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void formulaireClient_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnRe_Click(object sender, EventArgs e)
        {
            choose.Text = "--choisissez votre ID--";
            textnom.Clear();   
            textnum.Clear();
            textem.Clear();
            textprnm.Clear();
            textadrss.Clear();
        }

        private void quit_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void btnAl_Click(object sender, EventArgs e)
        {
            Client cle = new Client();
            cle.Choose = choose.Text;
            cle.Textnom = textnom.Text;
            cle.Textadrss = textadrss.Text;
            cle.Textem = textem.Text;
            cle.Textprnm = textprnm.Text;
            cle.Textnum = int.Parse(textnum.Text);
            if (cle.ajoutcle(cle) == true)
            {
                MessageBox.Show("Ajout effectué avec success");
                dgclient.DataSource = null;
                dgclient.DataSource = Listclient.listcl;
                
              

            }

        }
    }
}