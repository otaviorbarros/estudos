using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pratica4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnCad_Click(object sender, EventArgs e)
        {

            string nome, desc;
            double valor;
            int cod;
            Produto prodRecebe;
            nome = txtNome.Text.Trim();
            desc = txtDescricao.Text.Trim();
            valor = Convert.ToDouble(txtValorVenda.Text.Trim());
            cod = Convert.ToInt32(txtCod.Text.Trim());
            
            prodRecebe = CriarObj(nome, valor, desc, cod);
            AddProd(prodRecebe);
            CarregarGrid();
            LimparCampos();
        }
        List<Produto> lstProd = new List<Produto>();
        
        private Produto CriarObj(string nome, double valor, string desc, int cod)
        {
            Produto p1 = new Produto();
            p1.Nome = nome;
            p1.Valor = valor;
            p1.Descricao = desc;
            p1.Codigo = cod;
            return p1;
        }        
        private void AddProd(Produto prod)
        {
            lstProd.Add(prod);
        }
        private void CarregarGrid()
        {
            dgvProd.DataSource = null;
            dgvProd.DataSource = lstProd;
        }
        private void LimparCampos()
        {
            txtDescricao.Clear();
            txtNome.Clear();
            txtValorVenda.Clear();
            txtCod.Clear();
        }
        private void FiltrarMaior()
        {
            double maior = Convert.ToDouble(txtMaior.Text.Trim());
            dgvProd.DataSource = null;
            if(txtMaior.Text.Trim() == "")
            {
                dgvProd.DataSource = lstProd;
            }else
            {
                dgvProd.DataSource = lstProd.Where(prod => prod.Valor > maior).ToList();
            }
        }
        private void FiltrarMenor()
        {
            double maior = Convert.ToDouble(txtMaior.Text.Trim());
            dgvProd.DataSource = null;
            if(txtMaior.Text.Trim() == "")
            {
                dgvProd.DataSource = lstProd;
            }
            else
            {
                dgvProd.DataSource = lstProd.Where(prod => prod.Valor < maior).ToList();
            }
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            if (rbMaior.Checked)
            {
                FiltrarMaior();
            }else if (rbMenor.Checked)
            {
                FiltrarMenor();
            }
        }

        private void dgvProd_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvProd.RowCount > 0)
            {
                Produto objLinhaClicada = (Produto)dgvProd.CurrentRow.DataBoundItem;
                txtCod.Text = objLinhaClicada.Codigo.ToString();
                txtNome.Text = objLinhaClicada.Nome.ToString();
                txtValorVenda.Text = objLinhaClicada.Valor.ToString();
                txtDescricao.Text = objLinhaClicada.Descricao.ToString();

                txtPos.Text = e.RowIndex.ToString();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string nome, desc;
            double valor;
            int cod, posLinha;
            try
            {
                nome = txtNome.Text;
                desc = txtDescricao.Text;
                valor = Convert.ToDouble(txtValorVenda.Text.Trim());
                cod = Convert.ToInt32(txtCod.Text.Trim());
                posLinha = Convert.ToInt32(txtPos.Text.Trim());

                lstProd[posLinha].Codigo = cod;
                lstProd[posLinha].Descricao = desc;
                lstProd[posLinha].Nome = nome;
                lstProd[posLinha].Valor = valor;
            }
            catch 
            {

                MessageBox.Show("Erro na aplicação");
            }
            

            
            
            CarregarGrid();
            LimparCampos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int posLinha;
            posLinha = Convert.ToInt32(txtPos.Text);

            lstProd.RemoveAt(posLinha);

            CarregarGrid();
            LimparCampos();
        }
    }
}
