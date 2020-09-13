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
    public partial class frmAutor : Form
    {
        tblAutorBLL bllAutor = new tblAutorBLL();
        tblAutorDTO dtoAutor = new tblAutorDTO();

        public frmAutor()
        {
            InitializeComponent();
        }

        private void FrmAutor_Load(object sender, EventArgs e)
        {
            GridAutor.DataSource = bllAutor.ListarAutor();
        }
        private void GridAutor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = GridAutor.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtIdade.Text = GridAutor.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtNome.Text = GridAutor.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPesquisar.Text = GridAutor.Rows[e.RowIndex].Cells[1].Value.ToString();

            /*btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;*/
        }
        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                // Passo os dados para o DTO
                dtoAutor.Idade = int.Parse(txtIdade.Text);
                dtoAutor.Nome = txtNome.Text.ToString();


                bllAutor.InserirAutor(dtoAutor);
                MessageBox.Show("Inserção Realizada com Sucesso. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GridAutor.DataSource = bllAutor.ListarAutor();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            // Passo os dados para o DTO
            dtoAutor.Idade = int.Parse(txtIdade.Text);
            dtoAutor.Nome = txtNome.Text.ToString();


            bllAutor.AlterarAutor(dtoAutor);
            GridAutor.DataSource = bllAutor.ListarAutor();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Está ação irá deletar o registro selecionado e não poderá ser desfeito, deseja continuar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    dtoAutor.IdAutor = Convert.ToInt32(txtId.Text);
                    bllAutor.ExcluirAutor(dtoAutor);
                    GridAutor.DataSource = bllAutor.ListarAutor();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string condicao = "idAutor like '%" + txtPesquisar.Text + "%'" +
                              "or idade like '%" + txtPesquisar.Text + "%'" +
                              "or nome like '%" + txtPesquisar.Text + "%'";
            GridAutor.DataSource = bllAutor.PesquisarAutor(condicao);
        }

        private void frmAutor_Load_1(object sender, EventArgs e)
        {

        }
    }
}
