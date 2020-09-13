using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_3A_29_30.DTO
{
    class tblAutorDTO
    {
        private int idAutor, idade;
        private string nome;

        public int IdAutor { get => idAutor; set => idAutor = value; }
        public int Idade { get => idade; set => idade = value; }


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
