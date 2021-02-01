using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pratica3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string produto;
            int qtde;
            double valor;
            ProdutoVO prodCad;
            produto = txtProd.Text.Trim();
            qtde = Convert.ToInt32(txtQtde.Text.Trim());
            valor = Convert.ToDouble(txtValor.Text.Trim());


            prodCad = CriarObj(produto, qtde, valor);  
            AddProd(prodCad);
            CarregarGrid();
            LimparCampos();

        }
        List<ProdutoVO> lstProd = new List<ProdutoVO>();

        private ProdutoVO CriarObj(string prod, int qtde, double valor)
        {
            ProdutoVO prod1 = new ProdutoVO();
            prod1.Produto = prod;
            prod1.Quantidade = qtde;
            prod1.Valor = valor;
            
            return prod1;
        }
        private void CarregarGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lstProd;
        }
        private void LimparCampos()
        {
            txtProd.Clear();
            txtQtde.Clear();
            txtValor.Clear();
        }
        private void AddProd(ProdutoVO prod)
        {
            lstProd.Add(prod);
        }
        private void Soma(double valor, int qtde)
        {
            
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            PesquisarNome();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarValorMaior();
        }

        private void PesquisarNome()
        {
            dataGridView1.DataSource = null;
            if (txtPesquisar.Text.Trim() == "")
            {
                dataGridView1.DataSource = lstProd;
            }
            else
            {
                dataGridView1.DataSource = lstProd.Where(prod => prod.Produto.Contains(txtPesquisar.Text.Trim())).ToList();
            }
        }
        private void PesquisarValorMaior()
        {
            double maiorValor = Convert.ToDouble(txtMaior.Text);
            dataGridView1.DataSource = null;
            if (txtMaior.Text.Trim() == "")
            {
                dataGridView1.DataSource = lstProd;
            }
            else
            {
                dataGridView1.DataSource = lstProd.Where(prod => prod.Valor > maiorValor).ToList();
            }
        }
    }
}
