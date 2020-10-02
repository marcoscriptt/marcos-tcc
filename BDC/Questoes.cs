using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace BDC
{
    public class Questoes
    {

        private static string SQL;
        private static SqlDataReader dr;

    

        private int _IdQuestao;

        public int IdQuestao
        {
            get { return _IdQuestao; }
            set { _IdQuestao = value; }
        }


        private String _RespostaD;

        public String RespostaD
        {
            get { return _RespostaD; }
            set { _RespostaD = value; }
        }


        private String _RespostaC;

        public String RespostaC
        {
            get { return _RespostaC; }
            set { _RespostaC = value; }
        }


        private String _RespostaB;

        public String RespostaB
        {
            get { return _RespostaB; }
            set { _RespostaB = value; }
        }


        private String _RespostaA;

        public String RespostaA
        {
            get { return _RespostaA; }
            set { _RespostaA = value; }
        }


        private String _RespostaCerta;

        public String RespostaCerta
        {
            get { return _RespostaCerta; }
            set { _RespostaCerta = value; }
        }



        private String _Titulo;

        public String Titulo
        {
            get { return _Titulo; }
            set { _Titulo = value; }
        }





        private String _Questao;

        public String Questao
        {
            get { return _Questao; }
            set { _Questao = value; }
        }

        private int _Ativo;

        public int Ativo
        {
            get { return _Ativo; }
            set { _Ativo = value; }
        }




  































        public void Incluir()
        {
            try
            {
                BDC.ClasseCOnexaoSql c = new BDC.ClasseCOnexaoSql();
                SQL = "UPDATE SistemaP.DBO.TbQuestao SET status ='"+ _Ativo+" ,Questao ='" + _Questao + "',respostaA ='" + _RespostaA + "',respostaB='" + RespostaB + "' ,respostaC ='" + _RespostaC + "',respostaD ='" + _RespostaC + "', respostaCerta ='" + _RespostaCerta + "' WHERE IDQUESTAO = " + _IdQuestao + "";

                c.ExecutarComando(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public void Alterar()
        {
            try
            {
                BDC.ClasseCOnexaoSql c = new BDC.ClasseCOnexaoSql();
                SQL = "UPDATE SistemaP.DBO.TbQuestao SET status ='" + _Ativo + "', Questao ='" + _Questao + "', respostaA ='" + _RespostaA + "',respostaB ='" + _RespostaB + "', respostaC ='" + _RespostaC + "',respostaD ='" + _RespostaC + "', titulo ='" + _Titulo + "',  respostaCerta ='" + _RespostaCerta + "' WHERE IDQUESTAO = '" + _IdQuestao + "';";
                c.ExecutarComando(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Ativar(Byte Valor)
        { //Valor 1 = Reativar    Valor 0 = Desativar
            try
            {
                BDC.ClasseCOnexaoSql c = new BDC.ClasseCOnexaoSql();
                SQL = "UPDATE SistemaP.DBO.tbquestao SET status = '" + Valor + "' WHERE idquestao = " + _IdQuestao;
                c.ExecutarComando(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Excluir()
        {
            try
            {
                BDC.ClasseCOnexaoSql c = new BDC.ClasseCOnexaoSql();
                SQL = "DELETE FROM SistemaP.DBO.tbquestao WHERE IdQuestao = '" + _IdQuestao + "'";
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
                SQL = "SELECT * FROM SistemaP.DBO.tbquestao ";
                return c.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public SqlDataReader Consultar3()
        {
            try
            {
                BDC.ClasseCOnexaoSql c = new BDC.ClasseCOnexaoSql();
                SQL = "SELECT * FROM SistemaP.DBO.tbquestao WHERE IdQuestao = '" + _IdQuestao + "'";
                return c.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public SqlDataReader Consultar2()
        {
            try
            {
                BDC.ClasseCOnexaoSql c = new BDC.ClasseCOnexaoSql();
                SQL = "SELECT IdQuestao FROM SistemaP.DBO.tbquestao where titulo = '" + _Titulo + "'";
                return c.RetornarDataReader(SQL);




            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public DataSet Listar2(string texto)
        {
            BDC.ClasseCOnexaoSql c = new BDC.ClasseCOnexaoSql();
            string comando = string.Empty;
            if (texto.Length == 0) // texto == null || texto == ""
            {
                comando = "SELECT etiqueta FROM SistemaP.DBO.tbquestao ORDER BY etiqueta";
                return c.RetornarDataSet(comando);
            }
            else
            {
                comando = "SELECT etiqueta FROM SistemaP.DBO.tbquestao  WHERE titulo LIKE '%" + texto + "%' ORDER BY etiqueta";
                return c.RetornarDataSet(comando);
            }
        }



        public DataSet Listar(string texto)
        {
            BDC.ClasseCOnexaoSql c = new BDC.ClasseCOnexaoSql();
            string comando = string.Empty;
            if (texto.Length == 0) // texto == null || texto == ""
            {
                comando = "SELECT titulo FROM SistemaP.DBO.tbquestao ORDER BY titulo";
                return c.RetornarDataSet(comando);
            }
            else
            {
                comando = "SELECT titulo FROM SistemaP.DBO.tbquestao  WHERE titulo LIKE '%" + texto + "%' ORDER BY titulo";
                return c.RetornarDataSet(comando);
            }
        }

    

        public void Deletar(int linha)
        {
            try
            {
                BDC.ClasseCOnexaoSql c = new BDC.ClasseCOnexaoSql();

                SQL = "DELETE FROM SistemaP.DBO.tbquestao WHERE idquestao = " + linha + "";
                c.ExecutarComando(SQL);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }




    }
}
