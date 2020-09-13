using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_3A_29_30.DTO
{
    class tblEditoraDTO
    {
        private int idEditora;
        private string nome, endereco, uf;

        public int IdEditora { get => idEditora; set => idEditora = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Uf { get => uf; set => uf = value; }

        public string Nome
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nome = value;
                }
                else
                {
                    throw new Exception("O campo Nome é obrigatório.");
                }

            }
            get { return this.nome; }
        }
    }
}
