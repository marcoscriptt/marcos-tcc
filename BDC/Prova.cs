using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BDC
{
    public class Prova
    {



        private static string SQL;
        private static SqlDataReader dr;


        private int _qantidade;
        public int qantidade
        {
            get { return _qantidade; }
            set { _qantidade = value; }
        }
        private int _IdProva;
        public int IdProva
        {
            get { return _IdProva; }
            set { _IdProva = value; }
        }


        ////private String _Prova;
        ////public String Prova
        ////{
        ////    get { return _Prova; }
        ////    set { _Prova = value; }
        ////}



        private String _Questoes;
        public String Questoes
        {
            get { return _Questoes; }
            set { _Questoes = value; }
        }

        private String _MateriaProva;
        public String MateriaProva
        {
            get { return _MateriaProva; }
            set { _MateriaProva = value; }
        }


        private String _NomeProf;
        public String NomeProf
        {
            get { return _NomeProf; }
            set { _NomeProf = value; }
        }



        public SqlDataReader ConsultarRespostaQuest()
        {
            try
            {
                BDC.ClasseCOnexaoSql c = new BDC.ClasseCOnexaoSql();
                SQL = "SELECT q.questao, q.idquestao, q.respostaA,q.respostaB,q.respostaC,q.respostaD,q.respostaCerta FROM SistemaP.DBO.tbquestao q INNER JOIN SistemaP.DBO.tbprova_questao b on q.idquestao = b.idquestao where b.idprova = '"+_IdProva+"'";
                return c.RetornarDataReader(SQL);
                

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public SqlDataReader ConsultarMateProf()
        {
            try
            {
                BDC.ClasseCOnexaoSql c = new BDC.ClasseCOnexaoSql();
                SQL = "SELECT materia_prova FROM SistemaP.DBO.tbprova WHERE IDPROVA ='" + _IdProva + "'";
                return c.RetornarDataReader(SQL);


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        

         public SqlDataReader ConsultarSeq()
        {
            try
            {
                BDC.ClasseCOnexaoSql c = new BDC.ClasseCOnexaoSql();
                SQL = " select current_value from sys.sequences where name = 'SEQ_PROVA'";
                return c.RetornarDataReader(SQL);


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SqlDataReader ConsultarProf()
        {
            try
            {
                BDC.ClasseCOnexaoSql c = new BDC.ClasseCOnexaoSql();
                SQL = "SELECT NOME_PROF FROM SistemaP.DBO.tbprova WHERE IDPROVA ='" + _IdProva + "'";
                return c.RetornarDataReader(SQL);


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public SqlDataReader ConsultarQuantidade()
        {
            try
            {
                BDC.ClasseCOnexaoSql c = new BDC.ClasseCOnexaoSql();
                SQL = "SELECT quantidade FROM SistemaP.DBO.tbprova WHERE idprova = " + _IdProva;

                //SQL = "SELECT p.quantidade FROM SistemaP.DBO.tbprova p inner join SistemaP.DBO.tbprova_questao b on p.idprova = b.idprova WHERE p.idprova = " + _IdProva;
                return c.RetornarDataReader(SQL);


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public SqlDataReader provanome()
        {
            try
            {
                BDC.ClasseCOnexaoSql c = new BDC.ClasseCOnexaoSql();
                SQL = "SELECT prova FROM SistemaP.DBO.tbprova WHERE idprova = " + _IdProva;

                //SQL = "SELECT p.quantidade FROM SistemaP.DBO.tbprova p inner join SistemaP.DBO.tbprova_questao b on p.idprova = b.idprova WHERE p.idprova = " + _IdProva;
                return c.RetornarDataReader(SQL);


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SqlDataReader ConsultarQuest()
        {
            try
            {
                BDC.ClasseCOnexaoSql c = new BDC.ClasseCOnexaoSql();
                SQL = "SELECT pq.idquestao FROM SistemaP.DBO.tbprova_questao pq inner join SistemaP.DBO.tbprova p on pq.idprova = p.idprova where p.idprova ='"+IdProva+"'";
                return c.RetornarDataReader(SQL);


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        //public SqlDataReader ConsultarQuest()
        //{
        //    try
        //    {
        //        BDC.ClasseCOnexaoSql c = new BDC.ClasseCOnexaoSql();
        //        SQL = "SELECT p.questao, p.idquestao FROM SistemaP.DBO.tbquestao p inner join SistemaP.DBO.tbprova_questao b on p.idquestao = b.idquestao";
        //        return c.RetornarDataReader(SQL);


        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}


        public SqlDataReader Consultar2()
        {
            try
            {
                BDC.ClasseCOnexaoSql c = new BDC.ClasseCOnexaoSql();
                SQL = "SELECT * FROM SistemaP.DBO.tbprova where idprova ="+ IdProva;
                return c.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet Listar(string texto)
        {
            BDC.ClasseCOnexaoSql c = new BDC.ClasseCOnexaoSql();
            string comando = string.Empty;
            if (texto.Length == 0) // texto == null || texto == ""
            {
                comando = "SELECT * FROM SistemaP.DBO.tbprova order by prova";
                return c.RetornarDataSet(comando);
            }
            else
            {
                comando = "SELECT * FROM SistemaP.DBO.tbprova  WHERE prova LIKE '%" + texto + "%' ORDER BY prova";
                return c.RetornarDataSet(comando);
            }
        }



    }
}
