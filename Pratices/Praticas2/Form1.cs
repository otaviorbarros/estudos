using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praticas2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string fabricante, modelo;
            int ano, quilometragem;
            double valor;
            AutomovelVO autoRecebe;
            fabricante = txtFab.Text.Trim();
            modelo = txtModelo.Text.Trim();
            ano = Convert.ToInt32(txtAnoFab.Text.Trim());
            quilometragem = Convert.ToInt32(txtKm.Text.Trim());
            valor = Convert.ToInt32(txtValor.Text.Trim());
            autoRecebe = CriarObj(fabricante, modelo, ano, quilometragem, valor);
            AddAuto(autoRecebe);
            CarregarGrid();
            LimparCampos();
        }
        List<AutomovelVO> listAuto = new List<AutomovelVO>();
        
        private AutomovelVO CriarObj(string fabricante, string modelo, int ano, int quilometragem, double valor)
        {
            AutomovelVO auto = new AutomovelVO();
            auto.Fabricante = fabricante;
            auto.Modelo = modelo;
            auto.Ano = ano;
            auto.Quilometragem = quilometragem;
            auto.Valor = valor;
            return auto;
        }
        private void CarregarGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listAuto;
        }
        private void AddAuto(AutomovelVO auto)
        {
            listAuto.Add(auto);
        }
        private void LimparCampos()
        {
            txtAnoFab.Clear();
            txtFab.Clear();
            txtKm.Clear();
            txtModelo.Clear();
            txtValor.Clear();
        }
    }
}
