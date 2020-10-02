using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace BDC
{
   public class Professor
    {

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


        private static string SQL;
        private static SqlDataReader dr;


        private String _Nome;

        public String Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
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
            set { _Login = value; }
        }
        private String _Senha;

        public String Senha
        {
            get { return _Senha; }
            set { _Senha = value; }
        }

        private String _Materias;

        public String Materias
        {
            get { return _Materias; }
            set { _Materias = value; }
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

        private String _Materia;

        public String Materia
        {
            get { return _Materia; }
            set { _Materia = value; }
        }


        public void Incluir()
        {
            try
            {
                BDC.ClasseCOnexaoSql c = new BDC.ClasseCOnexaoSql();
                SQL = "INSERT INTO SistemaP.DBO.tb_Prof (RM_Professor, NOME,  ULTIMOACESSO, CADASTRO, LOGIN, STATUS) VALUES ('" + _Rm + "', '" + _Nome + "','" + _DataAcesso + "', '" + _DataCadastro + "', '" + _Login + "','" + _Ativo + "');";
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
                SQL = "UPDATE SistemaP.DBO.tb_Prof SET NOME = '" + _Nome + "', CADASTRO = '" + _DataCadastro + "', ULTIMOACESSO = '" + _DataAcesso + "' ,login = '" + _Login +
                    "', ATIVO = '" + _Ativo + "' WHERE RM_Professor = " + _Rm;

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
                SQL = "UPDATE SistemaP.DBO.tb_Prof SET status = '" + Valor + "' WHERE RM_Professor= " + _Rm;
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
                SQL = "DELETE FROM SistemaP.DBO.tb_Prof WHERE RM_professor= '" + _Rm + "'";
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
                SQL = "SELECT * FROM SistemaP.DBO.tb_Prof WHERE RM_Professor = " + Rm;
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
                SQL = "SELECT * FROM SistemaP.DBO.tb_Prof WHERE Login = '" + _Login +"'";
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
                comando = "SELECT RM_Professor, NOME FROM SistemaP.DBO.tb_Prof ORDER BY NOME";
                return c.RetornarDataSet(comando);
            }
            else
            {
                comando = "SELECT RM_Professor, NOME FROM SistemaP.DBO.tb_Prof  WHERE NOME LIKE '%" + texto + "%' ORDER BY NOME";
                return c.RetornarDataSet(comando);
            }
        }

          public DataSet Listar2(string texto)
        {
            BDC.ClasseCOnexaoSql c = new BDC.ClasseCOnexaoSql();
            string comando = string.Empty;
            if (texto.Length == 0) // texto == null || texto == ""
            {
                comando = "select * from SistemaP.DBO.PROF_MATERIA where RM_PROFESSOR = '"+texto+"'";
                return c.RetornarDataSet(comando);
            }
            else
            {
                comando = "SELECT RM_Professor, NOME FROM SistemaP.DBO.tb_Prof  WHERE NOME LIKE '%" + texto + "%' ORDER BY NOME";
                return c.RetornarDataSet(comando);
            }
        }

        public void AlterarDataUltimoAcesso()
        {
            try
            {
                BDC.ClasseCOnexaoSql c = new BDC.ClasseCOnexaoSql();
                SQL = "UPDATE SistemaP.DBO.tb_Prof SET ULTIMOACESSO = '" + System.DateTime.Today + "' WHERE rm_Professor = " + _Rm + " ";
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

                SQL = "DELETE FROM tb_prof WHERE rm_prof = " + linha + "";
                c.ExecutarComando(SQL);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



  





        public void AddMateria()
        {
            try
            { // ver corretamente o nome da tabela
                BDC.ClasseCOnexaoSql c = new BDC.ClasseCOnexaoSql();
                SQL = "INSERT INTO SistemaP.DBO.materia_Prof (RM_Professor, Materia_prof) VALUES ('" + _Rm + "', '" + _Materias + "',);";
                c.ExecutarComando(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
