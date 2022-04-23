namespace XPTO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_Gravar_Click(object sender, EventArgs e)
        {

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////CAMPOS NAO PREENCHIDOS////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            CodigosGerais c = new CodigosGerais();
            if (c.CampoVazio(txt_Nome, "NOME"))
                return;

            if (c.CampoVazio(txt_SobreNome, "SOBRENOME"))
                return;

            if (c.CampoVazio(txt_Idade, "IDADE"))
                return;

            if (c.CampoVazio(txt_CPF, "CPF"))
            {
                return;
            }
            if (c.CampoVazio(cbo_Vaga, "CAMPO VAGA"))
            {
                return;
            }

            if (!rbtn_Sim.Checked && !rbtn_Nao.Checked)
            {
                MessageBox.Show("Por Favor Responda SIM ou NÃO", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                groupBox1.Focus();
                return;
            }

            string data = mask_DataNasc.Text;
            if (data.Length < 8)
            {
                MessageBox.Show("Data Invalida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mask_DataNasc.Focus();
                return;
            }
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////VALIDADOR CPF//////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string cpf = txt_CPF.Text;
            if (cpf.Length < 11)
            {
                MessageBox.Show("Verifique o CPF", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (CodigosGerais.ValidaCPF(cpf))
            {

            }
            else
            {
                MessageBox.Show("CPF INVALIDO", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_CPF.Focus();
                return;


            }           
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////           
            //////////////////////////////////VERIFICA OS BOTOES SIM E NAO////////////////////////////////////////////////////////////////////////////////// 
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string txt;

            txt = groupBox1.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;

            groupBox1.Text = txt;
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////ADIOCIONA O CADASTROS NO DATA GRID VIEW/////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////   
            dataGridView1.Rows.Add(txt_Nome.Text, txt_SobreNome.Text, txt_CPF.Text, mask_DataNasc.Text, txt_Idade.Text, txt, cbo_Vaga.Text);
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////LIMPA OS CAMPOS APOS CLICAR EM SALVAR//////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            txt_Nome.Text = "";
            txt_Nome.Focus();
            txt_SobreNome.Text = "";
            mask_DataNasc.Text = "";
            txt_CPF.Text = "";
            txt_Idade.Text = "";
            groupBox1.Text = "";
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }

        private void txt_Nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_CPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            CodigosGerais.Idade(e);
        }

        private void txt_Idade_KeyPress(object sender, KeyPressEventArgs e)
        {
            CodigosGerais.Idade(e);
        }

        private void btn_Salvar_Click(object sender, EventArgs e)

        {

            MessageBox.Show("Sua Lista foi  Salva", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja relamente sair?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btn_Remover_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (MessageBox.Show("DESEJA REALMENTE EXCLUIR ESSE ITEM?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.No)
                {

                    return;
                }
                else
                {
                    dataGridView1.Rows.Remove(row);
                }



            }

        }
    }
}