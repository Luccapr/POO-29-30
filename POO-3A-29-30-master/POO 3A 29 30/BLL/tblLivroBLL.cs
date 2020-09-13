using POO_3A_29_30.DAL;
using POO_3A_29_30.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_3A_29_30.BLL
{
    class tblLivroBLL
    {
        private DALBD daoBanco = new DALBD();


        public DataTable ListarLivro()
        {
            string sql = string.Format($@"select * from TBL_Livro");
            return daoBanco.ExecutarConsulta(sql);
        }

        // Metodo Alterar
        public void AlterarLivro(tblLivroDTO DtoLivro)
        {
            string sql = string.Format($@"UPDATE TBL_Livro set titulo = '{DtoLivro.Titulo}',
                                                                 dataCadastro = '{DtoLivro.DataCadastro}',
                                                                 numPaginas = '{DtoLivro.NumPaginas}',
                                                                 valor = '{DtoLivro.Valor}'
                                                   where idLivro = '{DtoLivro.IdLivro}';");
            daoBanco.ExecutarComando(sql);
        }

        //Metodo Inserir
        public void InserirLivro(tblLivroDTO ObjLivro)
        {
            string sql = string.Format($@"INSERT INTO TBL_Livro VALUES (NULL, '{ObjLivro.Titulo}',
                                                                                '{ObjLivro.DataCadastro}',
                                                                                '{ObjLivro.NumPaginas}',
                                                                                '{ObjLivro.Valor}');");
            daoBanco.ExecutarComando(sql);
        }
        // Metodo Excluir
        public void ExcluirLivro(tblLivroDTO ObjLivro)
        {
            string sql = string.Format($@"DELETE FROM TBL_Livro where idLivro = {ObjLivro.IdLivro};");
            daoBanco.ExecutarComando(sql);
        }

        // Metodo Consulta
        public DataTable PesquisarLivro(string condicao)
        {
            string sql = string.Format($@"select * from TBL_Livro where " + condicao);
            return daoBanco.ExecutarConsulta(sql);
        }
    }
}
