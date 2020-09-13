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
    public partial class frmEditora : Form
    {
        tblEditoraBLL bllEditora = new tblEditoraBLL();
        tblEditoraDTO dtoEditora = new tblEditoraDTO();

        public frmEditora()
        {
            InitializeComponent();
        }

        private void FrmAutor_Load(object sender, EventArgs e)
        {
            GridEditora.DataSource = bllEditora.ListarEditora();
        }
        private void GridAutor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = GridEditora.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtUF.Text = GridEditora.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtNome.Text = GridEditora.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtEndereco.Text = GridEditora.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPesquisar.Text = GridEditora.Rows[e.RowIndex].Cells[1].Value.ToString();

            /*btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;*/
        }
        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                // Passo os dados para o DTO
                dtoEditora.Uf = txtUF.Text.ToString();
                dtoEditora.Nome = txtNome.Text.ToString();
                dtoEditora.Endereco = txtEndereco.Text.ToString();



                bllEditora.InserirEditora(dtoEditora);
                MessageBox.Show("Inserção Realizada com Sucesso. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GridEditora.DataSource = bllEditora.ListarEditora();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            // Passo os dados para o DTO
            dtoEditora.Uf = txtUF.Text.ToString();
            dtoEditora.Nome = txtNome.Text.ToString();
            dtoEditora.Endereco = txtEndereco.Text.ToString();


            bllEditora.AlterarEditora(dtoEditora);
            GridEditora.DataSource = bllEditora.ListarEditora();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Está ação irá deletar o registro selecionado e não poderá ser desfeito, deseja continuar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    dtoEditora.IdEditora = Convert.ToInt32(txtId.Text);
                    bllEditora.ExcluirEditora(dtoEditora);
                    GridEditora.DataSource = bllEditora.ListarEditora();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string condicao = "idEditora like '%" + txtPesquisar.Text + "%'" +
                              "or endereco like '%" + txtPesquisar.Text + "%'" +
                              "or uf like '%" + txtPesquisar.Text + "%'" +
                              "or nome like '%" + txtPesquisar.Text + "%'";
            GridEditora.DataSource = bllEditora.PesquisarEditora(condicao);
        }

    }
}
