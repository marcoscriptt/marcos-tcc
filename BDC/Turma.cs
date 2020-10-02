using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace BDC
{
   public class Turma
    {

        private static string Sql;
        private static string SQL;
        private static SqlDataReader dr;


        private int _IdTurma;

        public int IdTurma
        {
            get { return _IdTurma; }
            set { _IdTurma = value; }
        }
        private string _TurmaAlu;

        public string TurmaAlu
        {
            get { return _TurmaAlu; }
            set { _TurmaAlu = value; }
        }

        private int _Ativo;

        public int Ativo
        {
            get { return _Ativo; }
            set { _Ativo = value; }
        }




        public SqlDataReader Consultar10()
        {

            ClasseCOnexaoSql c = new ClasseCOnexaoSql();

            try
            {
                SQL = "SELECT TURMA_ALU FROM SistemaP.DBO.TB_TURMA where turma_alu =  '" + _TurmaAlu + "'";
                return c.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



        public DataSet Prenchercb()
        {

            ClasseCOnexaoSql c = new ClasseCOnexaoSql();

            try
            {
                SQL = "SELECT TURMA_ALU, ID_TURMA FROM SistemaP.DBO.TB_TURMA ORDER BY ID_TURMA ";
                return c.RetornarDataSet(SQL);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
          public SqlDataReader Consultar5()
        {
            try
            {
                ClasseCOnexaoSql c = new ClasseCOnexaoSql();
                Sql = "SELECT ID_TURMA FROM SistemaP.DBO.tb_turma where turma_alu =  '" + _TurmaAlu +"'";
                return c.RetornarDataReader(Sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public SqlDataReader Consultar4()
        {
            try
            {
                ClasseCOnexaoSql c = new ClasseCOnexaoSql();
                Sql = "SELECT * FROM SistemaP.DBO.tb_turma where id_turma =  '" + _IdTurma + "'";
                return c.RetornarDataReader(Sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void Incluir()
        {
            try
            {
                ClasseCOnexaoSql c = new ClasseCOnexaoSql();
                Sql = "INSERT INTO SistemaP.DBO.tb_turma (id_turma, turma_alu, STATUS) VALUES (next value for SistemaP.DBO.SEQ_TURMA, '" + _TurmaAlu + "','" + _Ativo + "');";
                c.ExecutarComando(Sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Deletar(int linha)
        {
            try
            {
                BDC.ClasseCOnexaoSql c = new BDC.ClasseCOnexaoSql();

                Sql = "DELETE FROM SistemaP.DBO.tb_turma WHERE RM_ADMIN = " + linha + "";
                c.ExecutarComando(Sql);
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
                ClasseCOnexaoSql c = new ClasseCOnexaoSql();
                Sql = "UPDATE SistemaP.DBO.tb_turma SET turma_alu = '" + _TurmaAlu + "', id_turma= '" + _TurmaAlu +
                    "', ATIVO = '" + _Ativo + "' WHERE id_turma = " + _IdTurma;

                c.ExecutarComando(Sql);
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
                ClasseCOnexaoSql c = new ClasseCOnexaoSql();
                Sql = "UPDATE SistemaP.DBO.tb_turma SET status = '" + Valor + "' WHERE id_turma = " + _IdTurma;
                c.ExecutarComando(Sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public bool Consultar2()
        {
            BDC.ClasseCOnexaoSql objConexao = new BDC.ClasseCOnexaoSql();


            SQL = " SELECT * FROM SistemaP.DBO.TB_MATERIA WHERE rm_aluno = '" + _IdTurma + "'";

            dr = objConexao.RetornarDataReader(SQL);
   
            dr.Read();



            if (dr.HasRows)
            {
                // Adicionar os valores retirados das tabelas nas variaveis de consulta

                //Achar o indice da coluna
                System.Console.WriteLine(dr[2]);

                IdTurma = Convert.ToInt16(dr["ID_TURMA"]);



                TurmaAlu = Convert.ToString(dr["Turma_Alu"]);


                return true;
            }
            else
            {
                return false;
            }
        }
















        public void Excluir()
        {
            try
            {
                ClasseCOnexaoSql c = new ClasseCOnexaoSql();
                Sql = "DELETE FROM SistemaP.DBO.tb_turma WHERE id_turma= '" + _IdTurma + "'";
                c.ExecutarComando(Sql);
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
                ClasseCOnexaoSql c = new ClasseCOnexaoSql();
                Sql = "SELECT * FROM SistemaP.DBO.tb_turma " ;
                return c.RetornarDataReader(Sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




        public DataSet Listar(string texto)
        {
            ClasseCOnexaoSql c = new ClasseCOnexaoSql();
            string comando = string.Empty;
            if (texto.Length == 0) // texto == null || texto == ""
            {
                //comando = "SELECT ID_TURMA, TURMA_ALU FROM SistemaP.DBO.TB_TURMA ORDER BY TURMA_ALU";
                comando = "SELECT ID_TURMA, TURMA_ALU FROM SistemaP.DBO.TB_TURMA ORDER BY TURMA_ALU";
                return c.RetornarDataSet(comando);
            }
            else
            {
                comando = "SELECT ID_TURMA, TURMA_ALU FROM SistemaP.DBO.TB_TURMA  WHERE TURMA_ALU LIKE '%" + texto + "%' ORDER BY TURMA_ALU";
                return c.RetornarDataSet(comando);
            }
        }


    }
}
