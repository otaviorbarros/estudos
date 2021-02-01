using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pratica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome, end;
            int idade;
            Pessoa p1Recebe;
            nome = txtNome.Text.Trim();
            end = txtEnd.Text.Trim();
            idade = Convert.ToInt32(txtIdade.Text);
            p1Recebe = CriarObjeto(nome, end, idade);
            AddPessoa(p1Recebe);
            LimparCampos();
            CarregarGrid();

        }
        List<Pessoa> lstPessoa = new List<Pessoa>();

        private Pessoa CriarObjeto(string nome, string endereco, int idade)
        {
            Pessoa p1 = new Pessoa();
            p1.nome = nome;
            p1.end = endereco;
            p1.idade = idade;

            return p1;
        }
        private void AddPessoa(Pessoa p1)
        {
            lstPessoa.Add(p1);
        }
        private void CarregarGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lstPessoa;
        }
        private void LimparCampos()
        {
            txtEnd.Clear();
            txtIdade.Clear();
            txtNome.Clear();
        }
   
    }
}
