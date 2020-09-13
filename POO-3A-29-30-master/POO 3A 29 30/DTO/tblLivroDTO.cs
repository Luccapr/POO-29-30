using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_3A_29_30.DTO
{
    class tblLivroDTO
    {
        private int idLivro, tblAutor_id, tblEditora_id, numPaginas;
        private string titulo;
        private DateTime dataCadastro;
        private double valor;

        public int IdLivro { get => idLivro; set => idLivro = value; }
        public int TblAutor_id { get => tblAutor_id; set => tblAutor_id = value; }
        public int TblEditora_id { get => tblEditora_id; set => tblEditora_id = value; }
        public int NumPaginas { get => numPaginas; set => numPaginas = value; }
        public DateTime DataCadastro { get => dataCadastro; set => dataCadastro = value; }
        public double Valor { get => valor; set => valor = value; }

        public string Titulo
        {
            set
            {
                if (value != string.Empty)
                {
                    this.titulo = value;
                }
                else
                {
                    throw new Exception("O campo Titulo é obrigatório.");
                }

            }
            get { return this.titulo; }
        }

    }
}
