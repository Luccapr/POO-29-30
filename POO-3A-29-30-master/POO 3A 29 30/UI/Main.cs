using POO_3A_29_30.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_3A_29_30
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void btnAutor_Click(object sender, EventArgs e)
        {
            frmAutor frmAutor = new frmAutor();
            frmAutor.ShowDialog();
            
        }

        private void btnEditora_Click(object sender, EventArgs e)
        {
            frmEditora frmEditora = new frmEditora();
            frmEditora.ShowDialog();
        }

        private void btnLivro_Click(object sender, EventArgs e)
        {
            frmLivro frmLivro = new frmLivro();
            frmLivro.ShowDialog();
        }
    }
}
