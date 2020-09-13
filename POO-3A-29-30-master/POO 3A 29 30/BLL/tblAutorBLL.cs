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
    class tblAutorBLL
    {
        private DALBD daoBanco = new DALBD();

        // Metodo Listar
        public DataTable ListarAutor()
        {
            string sql = string.Format($@"select * from TBL_Autor");
            return daoBanco.ExecutarConsulta(sql);
        }

        // Metodo Alterar
        public void AlterarAutor(tblAutorDTO DtoAutor)
        {
            string sql = string.Format($@"UPDATE TBL_Autor set nome = '{DtoAutor.Nome}',
                                                                idade = '{DtoAutor.Idade}'
                                                        where idAutor = '{DtoAutor.IdAutor}';");
            daoBanco.ExecutarComando(sql);
        }

        //Metodo Inserir
        public void InserirAutor(tblAutorDTO ObjAutor)
        {
            string sql = string.Format($@"INSERT INTO TBL_Autor VALUES (NULL, '{ObjAutor.Nome}',
                                                                                '{ObjAutor.Idade}');");
            daoBanco.ExecutarComando(sql);
        }
        // Metodo Excluir
        public void ExcluirAutor(tblAutorDTO ObjAutor)
        {
            string sql = string.Format($@"DELETE FROM TBL_Autor where idAutor = {ObjAutor.IdAutor};");
            daoBanco.ExecutarComando(sql);
        }

        // Metodo Consulta
        public DataTable PesquisarAutor(string condicao)
        {
            string sql = string.Format($@"select * from TBL_Autor where " + condicao);
            return daoBanco.ExecutarConsulta(sql);
        }


    }
}
