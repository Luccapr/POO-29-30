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
    class tblEditoraBLL
    {
        private DALBD daoBanco = new DALBD();

        // Metodo Listar
        public DataTable ListarEditora()
        {
            string sql = string.Format($@"select * from TBL_Editora");
            return daoBanco.ExecutarConsulta(sql);
        }


        // Metodo Alterar
        public void AlterarEditora(tblEditoraDTO DtoEditora)
        {
            string sql = string.Format($@"UPDATE TBL_Editora set nome = '{DtoEditora.Nome}',
                                                                endereco = '{DtoEditora.Endereco}',
                                                                uf = '{DtoEditora.Uf}'
                                                        where idEditora = '{DtoEditora.IdEditora}';");
            daoBanco.ExecutarComando(sql);
        }

        //Metodo Inserir
        public void InserirEditora(tblEditoraDTO ObjEditora)
        {
            string sql = string.Format($@"INSERT INTO TBL_Editora VALUES (NULL, '{ObjEditora.Nome}',
                                                                                '{ObjEditora.Endereco}',
                                                                                '{ObjEditora.Uf}');");
            daoBanco.ExecutarComando(sql);
        }
        // Metodo Excluir
        public void ExcluirEditora(tblEditoraDTO ObjEditora)
        {
            string sql = string.Format($@"DELETE FROM TBL_Editora where idEditora = {ObjEditora.IdEditora};");
            daoBanco.ExecutarComando(sql);
        }

        // Metodo Consulta
        public DataTable PesquisarEditora(string condicao)
        {
            string sql = string.Format($@"select * from TBL_Editora where " + condicao);
            return daoBanco.ExecutarConsulta(sql);
        }


    }
}
