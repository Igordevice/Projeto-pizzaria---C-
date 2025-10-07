using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPizzaria
{
    public partial class Form1 : Form // Instanciando a classe conexao
    {
        Conexao con = new Conexao();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTamanho.Items.Add("Pequena - R$20,00");
            cmbTamanho.Items.Add("Média- R$ 30,00");
            cmbTamanho.Items.Add("Grande- R$ 50,00");
        }

        private void cmbTitulo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkTitulo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnTitulo_Click(object sender, EventArgs e)
        {

        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void lblValor_Click(object sender, EventArgs e)
        {

        }

        private void lblPagar_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dgvPizza_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Declarando variaveis

            double valorPizza = 0, valorOpcao = 0, valorTotal = 0;
            if (cmbTamanho.SelectedIndex == 0)
            {
                valorPizza = 20;
            }
            else if (cmbTamanho.SelectedIndex == 1)
            {
                valorPizza = 30;
            }
            else if (cmbTamanho.SelectedIndex == 2)
            {
                valorPizza = 50;
            }
            if (checkBorda.Checked == true)
            {
                valorOpcao = valorOpcao + 5;
            }
            if (checkTempero.Checked == true)
            {
                valorOpcao = valorOpcao + 6;
            }
            if (checkCebola.Checked == true)
            {
                valorOpcao = valorOpcao + 3;
            }
            if (checkCatupiry.Checked == true)
            {
                valorOpcao = valorOpcao + 4;
            }
            else
            {

            }
            valorTotal = valorPizza + valorOpcao;
            txtValor.Text = Convert.ToString(valorPizza);
            txtValorOpt.Text = Convert.ToString(valorOpcao);
            txtPagar.Text = Convert.ToString(valorTotal);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //verificar os campos
            if (txtValor.Text == "")
            {
                MessageBox.Show("Campo Obrigatório");
                txtValor.Focus();
            }
            else if (txtValorOpt.Text == "")
            {
                MessageBox.Show("Campo Obrigatório");
                txtValorOpt.Focus();
            }
            else if (txtPagar.Text == "")
            {
                MessageBox.Show("Campo Obrigatório");
                txtPagar.Focus();
            }
            else
            {
                //tratamento de erros
                try
                {
                    //inserindo dados no banco de dados
                    string sql = "insert into tbPedido(tipoPizza,valorPizza,valorOpcao,valorTotal) values(@pizza,@vpizza,@vopcao,@total)";
                    MySqlCommand cmd = new MySqlCommand(sql, con.ConnectarBD());
                    cmd.Parameters.Add("@pizza", MySqlDbType.Text).Value = cmbTamanho.Text;
                    cmd.Parameters.Add("@vpizza", MySqlDbType.Text).Value = txtValor.Text;
                    cmd.Parameters.Add("@vopcao", MySqlDbType.Text).Value = txtValorOpt.Text;
                    cmd.Parameters.Add("@total", MySqlDbType.Text).Value = txtPagar.Text;
                    cmd.ExecuteNonQuery();// Grava os dados no banco 

                    MessageBox.Show("Dados cadastrados com Sucesso !!!");
                    cmbTamanho.Text = "";
                    txtValor.Text = "";
                    txtValorOpt.Text = "";
                    txtPagar.Text = "";
                    cmbTamanho.Focus();
                    con.DesConnectarBD();

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
        }

        private void dgvPizza_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CarregarPedido();
        }
        // Método que irá carregar informações  no DataGrid
        public void CarregarPedido()
        {
            try
            {
                txtCodigo.Text = dgvPizza.SelectedRows[0].Cells[0].Value.ToString();
                cmbTamanho.Text = dgvPizza.SelectedRows[0].Cells[1].Value.ToString();
                txtValor.Text = dgvPizza.SelectedRows[0].Cells[2].Value.ToString();
                txtValorOpt.Text = dgvPizza.SelectedRows[0].Cells[3].Value.ToString();
                txtPagar.Text = dgvPizza.SelectedRows[0].Cells[4].Value.ToString();

            }
            catch (Exception error)
            {
                MessageBox.Show("Erros ao clicar" + error);
            }

        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisar.Text != "")
            {
                try
                {
                    con.ConnectarBD();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "select * from tbPedido";

                    cmd.Connection = con.ConnectarBD();
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    DataTable dt = new DataTable();
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    dgvPizza.DataSource = dt;
                    con.DesConnectarBD();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else
            {
                //deixa o datagrid limpo
                dgvPizza.DataSource = null;
            }
        }

        private void txtPesquisar_TextChanged_1(object sender, EventArgs e)
        {
            if (txtPesquisar.Text != "")
            {
                try
                {
                    con.ConnectarBD();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "select * from tbPedido";

                    cmd.Connection = con.ConnectarBD();
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    DataTable dt = new DataTable();
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    dgvPizza.DataSource = dt;
                    con.DesConnectarBD();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else
            {
                //deixa o datagrid limpo
                dgvPizza.DataSource = null;
            }
        }
    }
}

