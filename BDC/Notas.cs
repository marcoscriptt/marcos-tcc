using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace BDC
{
    public class Notas
    {



        private static string SQL;
        private static SqlDataReader dr;

        private String _confer;

        public String Confer
        {
            get { return _confer; }
            set { _confer = value; }
        }

        private String _Rm;

        public String Rm
        {
            get { return _Rm; }
            set { _Rm = value; }
        }



        private int _Nota;

        public int Nota
        {
            get { return _Nota; }
            set { _Nota = value; }
        }


        private String _Prova;

        public String Prova
        {
            get { return _Prova; }
            set { _Prova = value; }
        }



        public void Incluir()
        {
            try
            {
                BDC.ClasseCOnexaoSql c = new BDC.ClasseCOnexaoSql();
                SQL = "INSERT INTO SistemaP.DBO.TBnotas_aluno (RM_ALUNO, PROVA, NOTA) VALUES ('" + _Rm + "', '" + _Prova + "','" + _Nota + "')";
                c.ExecutarComando(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SqlDataReader Consultar()
        {
            try
            {
                BDC.ClasseCOnexaoSql c = new BDC.ClasseCOnexaoSql();
                SQL = "SELECT * FROM SistemaP.DBO.tbnotas_aluno WHERE RM_Aluno = " + Rm;
                return c.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public SqlDataReader ConsultarConfer()
        {
            try
            {
                BDC.ClasseCOnexaoSql c = new BDC.ClasseCOnexaoSql();
                SQL = "SELECT * FROM SistemaP.DBO.tbnotas_aluno WHERE idprova = " + Confer;
                return c.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet Listar(string texto, string texto2)
        {
            BDC.ClasseCOnexaoSql c = new BDC.ClasseCOnexaoSql();
            string comando = string.Empty;
            if (texto.Length == 0) // texto == null || texto == ""
            {
                comando = " select q.rm_aluno, q.nome, p.turma_alu, q.num_chamada, r.login from SistemaP.DBO.tb_aluno as q inner join SistemaP.DBO.tb_turma as p on p.id_turma = q.id_turma inner join SistemaP.DBO.TB_USER r on r.login = q.login where turma_alu ='" + texto2 + "' or q.RM_Aluno LIKE '%" + texto + "%' or  n.prova ='" + texto2 + "'";
                return c.RetornarDataSet(comando);
                // inner join nome 
            }
            else
            {
                comando = "select q.rm_aluno, q.nome, p.turma_alu, q.num_chamada, r.login from SistemaP.DBO.tb_aluno as q inner join SistemaP.DBO.tb_turma as p on p.id_turma = q.id_turma inner join SistemaP.DBO.TB_USER r on r.login = q.login where turma_alu ='" + texto2 + "' or q.RM_Aluno LIKE '%" + texto + "%' ";
                   return c.RetornarDataSet(comando);
            }
        }
    }
}
