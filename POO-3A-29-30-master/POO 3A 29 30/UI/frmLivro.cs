using POO_3A_29_30.BLL;
using POO_3A_29_30.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_3A_29_30.UI
{
    public partial class frmLivro : Form
    {
        tblLivroBLL bllLivro = new tblLivroBLL();
        tblLivroDTO dtoLivro = new tblLivroDTO();

        public frmLivro()
        {
            InitializeComponent();
        }

        private void FrmLivro_Load(object sender, EventArgs e)
        {
            GridLivro.DataSource = bllLivro.ListarLivro();
        }
        private void GridAutor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = GridLivro.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTitulo.Text = GridLivro.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtData.Text = GridLivro.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPag.Text = GridLivro.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtValor.Text = GridLivro.Rows[e.RowIndex].Cells[4].Value.ToString();
            

            /*btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;*/
        }
        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                // Passo os dados para o DTO
                dtoLivro.IdLivro = int.Parse(txtId.Text);
                dtoLivro.Titulo = txtTitulo.Text.ToString();
                dtoLivro.DataCadastro = DateTime.Parse(txtData.Text);
                dtoLivro.NumPaginas = int.Parse(txtPag.Text);
                dtoLivro.Valor = double.Parse(txtValor.Text);


                bllLivro.InserirLivro(dtoLivro);
                MessageBox.Show("Inserção Realizada com Sucesso. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GridLivro.DataSource = bllLivro.ListarLivro();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            // Passo os dados para o DTO
            dtoLivro.IdLivro = int.Parse(txtId.Text);
            dtoLivro.Titulo = txtTitulo.Text.ToString();
            dtoLivro.DataCadastro = DateTime.Parse(txtData.Text);
            dtoLivro.NumPaginas = int.Parse(txtPag.Text);
            dtoLivro.Valor = double.Parse(txtValor.Text);


            bllLivro.AlterarLivro(dtoLivro);
            GridLivro.DataSource = bllLivro.ListarLivro();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Está ação irá deletar o registro selecionado e não poderá ser desfeito, deseja continuar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    dtoLivro.IdLivro = Convert.ToInt32(txtId.Text);
                    bllLivro.ExcluirLivro(dtoLivro);
                    GridLivro.DataSource = bllLivro.ListarLivro();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string condicao = "idLivro like '%" + txtPesquisar.Text + "%'" +
                              "or titulo like '%" + txtPesquisar.Text + "%'" +
                              "or valor like '%" + txtPesquisar.Text + "%'" +
                              "or numPaginas like '%" + txtPesquisar.Text + "%'" +
                              "or dataCadastro like '%" + txtPesquisar.Text + "%'";
            GridLivro.DataSource = bllLivro.PesquisarLivro(condicao);
        }
    }
}
