using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Org.BouncyCastle.Crypto.Engines;

namespace Projeto_Carros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void ExportarDados(DataGridView dgv_Carros)
        {
            Microsoft.Office.Interop.Excel.Application exportarexcel = new Microsoft.Office.Interop.Excel.Application();

            exportarexcel.Application.Workbooks.Add(true);

            int indicecolumn = 0;

            foreach (DataGridViewColumn column in dgv_Carros.Columns)
            {
                indicecolumn++;

                exportarexcel.Cells[1, indicecolumn] = column.Name;
            }

            int indicefila = 0;

            foreach (DataGridViewRow fila in dgv_Carros.Rows)
            {
                indicefila++;

                indicecolumn = 0;

                foreach (DataGridViewColumn column in dgv_Carros.Columns)
                {
                    indicecolumn++;
                    exportarexcel.Cells[indicefila + 1, indicecolumn] = fila.Cells[column.Name].Value;
                }
            }

            exportarexcel.Visible = true;
        }

        int id = 1;
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            dgv_carros.Rows.Add(id,
            txt_marca.Text,
            txtModelo.Text,
            cmb_Fabricante.Text,
            cmbTipo.Text,
            txtAno.Text,
            cmb_combustivel.Text,
            cmb_Cor.Text,
            txtChassi.Text,
            txtKilometragem.Text,
            txtObservacoes.Text,
            chk_revisao.Checked,
            chk_sinistro.Checked,
            chk_Roubo.Checked,
            chk_Aluguel.Checked,
            chk_Venda.Checked,
            chk_Particular.Checked);



            
            string marca = txt_marca.Text;
            string modelo = txtModelo.Text;
            string fabricante = cmb_Fabricante.Text;
            string tipo = cmbTipo.Text;
            int ano = int.Parse(txtAno.Text);
            string combustivel = cmb_combustivel.Text;
            string cor = cmb_Cor.Text;
            string numero_chassi = txtChassi.Text;
            int kilometragem = int.Parse(txtKilometragem.Text);
            string observacoes = txtObservacoes.Text;



            id++;

            txtAno.Clear();
            txtChassi.Clear();
            cmb_combustivel.Text = "";
            cmb_Cor.Text = "";
            cmb_Fabricante.Text = "";
            txtKilometragem.Clear();
            txtModelo.Clear();
            txtObservacoes.Clear();
            cmbTipo.Text = "";
            txt_marca.Clear();






            chk_Aluguel.Checked = false;
            chk_Particular.Checked = false;
            chk_revisao.Checked = false;
            chk_sinistro.Checked = false;
            chk_Venda.Checked = false;
            chk_Roubo.Checked = false;

            txtCodigo.Text = $"{id.ToString()}";
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            int row = dgv_carros.CurrentCell.RowIndex;
            if (dgv_carros.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("a", "a", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else

                dgv_carros.Rows.RemoveAt(row);
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportarDados(dgv_carros);
        }

     
     
        private void txtAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                { e.Handled = true; }
            }
        }

        private void txtKilometragem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                { e.Handled = true; }
            }
        }



        private void cmb_marca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                { e.Handled = true; }
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                { e.Handled = true; }
            }

        }

        private void txtModelo_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtObservacoes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_marca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = id.ToString();
        }

        private void txtKilometragem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_marca_TextChanged(object sender, EventArgs e)
        {

        }
    }
}