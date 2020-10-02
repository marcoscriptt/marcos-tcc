using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace BDC
{
    public class Aluno
    {
        private static string SQL;
        private static SqlDataReader dr;



        private String _DataAcesso;

        public String DataAcesso
        {
            get { return _DataAcesso; }
            set { _DataAcesso = value; }
        }


        private String _DataCadastro;

        public String DataCadastro
        {
            get { return _DataCadastro; }
            set { _DataCadastro = value; }
        }



        private String _Nome;

        public String Nome
        {
            get { return _Nome; }
            set { _Nome = value.ToUpper(); }
        }
        private int _Rm;

        public int Rm
        {
            get { return _Rm; }
            set { _Rm = value; }
        }
        private String _Login;

        public String Login
        {
            get { return _Login; }
            set { _Login = value.ToUpper(); }
        }
        private String _Senha;

        public String Senha
        {
            get { return _Senha; }
            set { _Senha = value; }
        }

        private String _Niveldeacesso;

        public String Niveldeacesso
        {
            get { return _Niveldeacesso; }
            set { _Niveldeacesso = value; }
        }

        private DateTime _DatadeCadastro;

        public DateTime DatadeCadastro
        {
            get { return _DatadeCadastro; }
            set { _DatadeCadastro = value; }
        }
        private DateTime _ultimoacesso;

        public DateTime Ultimoacesso
        {
            get { return _ultimoacesso; }
            set { _ultimoacesso = value; }
        }
        private int _Ativo;

        public int Ativo
        {
            get { return _Ativo; }
            set { _Ativo = value; }
        }

        private String _Turma;

        public String Turma
        {
            get { return _Turma; }
            set { _Turma = value; }
        }

        private int _NumChamada;

        public int NumChamada
        {
            get { return _NumChamada; }
            set { _NumChamada = value; }
        }




        public void Incluir()
        {
            try
            {
                BDC.ClasseCOnexaoSql c = new BDC.ClasseCOnexaoSql();
                SQL = "INSERT INTO SistemaP.DBO.tb_aluno (RM_Aluno, NOME,  ULTIMOACESSO, CADASTRO,TURMA_ALU, NUM_CHAMADA, login, STATUS) VALUES ('" + _Rm + "', '" + _Nome + "','" + _DataAcesso + "','" + _DataCadastro + "',  '" + _Turma + "','" + _NumChamada + "','" + _Login + "','" + _Ativo + "');";
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
                SQL = "UPDATE SistemaP.DBO.tb_aluno SET NOME = '" + _Nome + "', CADASTRO ='" + _DataCadastro + "', ULTIMOACESSO ='" + _DataAcesso + "', turma_alu = '" + _Turma + "',num_chamada = '" + _NumChamada + "',ATIVO = '" + _Ativo + "' WHERE RM_Aluno = " + _Rm;

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
                SQL = "UPDATE SistemaP.DBO.tb_aluno SET status = '" + Valor + "' WHERE RM_Aluno = " + _Rm;
                c.ExecutarComando(SQL);
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

                SQL = "DELETE FROM SistemaP.DBO.tb_aluno WHERE RM_ALUNO = " + linha + "";
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
                SQL = "DELETE FROM SistemaP.DBO.tb_aluno WHERE RM_aluno '" + _Rm + "'";
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
                SQL = "SELECT * FROM SistemaP.DBO.tb_aluno WHERE RM_Aluno = " + _Rm;
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
                SQL = " select q.rm_aluno, q.nome, p.turma_alu, q.num_chamada,q.ultimoacesso, q.login, q.status from SistemaP.DBO.tb_aluno as q inner join SistemaP.DBO.tb_turma as p on p.ID_TURMA = q.ID_TURMA WHERE login =  '" + _Login + "'";
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
                comando = "SELECT * FROM SistemaP.DBO.tb_aluno ORDER BY NOME";
                return c.RetornarDataSet(comando);
            }
            else
            {
                comando = "SELECT * FROM SistemaP.DBO.tb_aluno  WHERE NOME LIKE '%" + texto + "%' or TURMA_ALU LIKE '%" + texto2 + "%'  ORDER BY NOME";
                return c.RetornarDataSet(comando);
            }
        }

        public void AlterarDataUltimoAcesso()
        {
            try
            {
                BDC.ClasseCOnexaoSql c = new BDC.ClasseCOnexaoSql();
                SQL = "UPDATE SistemaP.DBO.tb_aluno SET ULTIMOACESSO = '" + System.DateTime.Today + "' WHERE rm_Aluno = " + _Rm + " ";
                c.ExecutarComando(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


      












    }
}
