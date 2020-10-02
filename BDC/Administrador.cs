  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace BDC
{
 public    class Administrador
    {
        private static string Sql;
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

        private int _Ativo;

        public int Ativo
        {
            get { return _Ativo; }
            set { _Ativo = value; }
        }


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


  



        public void Incluir()
        {
            try
            {
                BDC.ClasseCOnexaoSql c = new BDC.ClasseCOnexaoSql();
                Sql = "INSERT INTO SistemaP.DBO.TB_ADMIN (RM_ADMIN, NOME,  ULTIMOACESSO, CADASTRO, STATUS) VALUES ('" + _Rm + "', '" + _Nome + "','" + _DataAcesso + "','" + _DataCadastro + "', '" + _Ativo + "')";
                c.ExecutarComando(Sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /*  public int IncluirRetornoCodigo()
        {
            try
            {
                ClasseCOnexaoSql c = new ClasseCOnexaoSql();
                Sql = "INSERT INTO TBFUNCIONARIO (NOME, DOCUMENTO, DATANASCIMENTO, MATRICULAFUNCIONAL, ATIVO) VALUES ('" + _Nome + "', '" + _Documento + "', #" + _DataNascimento + "#, '" + _MatriculaFuncional + "', '" + _Ativo + "');";
                return c.ExecutarComandoRetorno(Sql);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        
         */


        public void Alterar()
        {
            try
            {
                BDC.ClasseCOnexaoSql c = new BDC.ClasseCOnexaoSql();
                Sql = "UPDATE SistemaP.DBO.TB_ADMIN SET NOME = '" + _Nome + "', RM = '" + _Rm +
                    "', CADASTRO ='" + _DataCadastro + "' , ULTIMOACESSO = '" + _DataAcesso + "', status = '" + _Ativo + "' WHERE RM_ADMIN = " + _Rm;

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
                BDC.ClasseCOnexaoSql c = new BDC.ClasseCOnexaoSql();
                Sql = "UPDATE TB_ADMIN SET status = '" + Valor + "' WHERE RM_ADMIN = " + _Rm;
                c.ExecutarComando(Sql);
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
                Sql = "DELETE FROM TB_ADMIN WHERE RM_admin= '" + _Rm + "'";
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
                BDC.ClasseCOnexaoSql c = new BDC.ClasseCOnexaoSql();
                Sql = "SELECT * FROM SistemaP.DBO.TB_ADMIN" ;
                return c.RetornarDataReader(Sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SqlDataReader ConsultarRm()
        {
            try
            {
                BDC.ClasseCOnexaoSql c = new BDC.ClasseCOnexaoSql();
                Sql = "SELECT * FROM SistemaP.DBO.TB_ADMIN WHERE RM_admin= '" + _Rm + "'";
                return c.RetornarDataReader(Sql);
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
                Sql = "SELECT * FROM SistemaP.DBO.TB_ADMIN WHERE LOGIN = '" + _Login + "'";
                return c.RetornarDataReader(Sql);
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
                comando = "SELECT nome FROM TB_ADMIN ORDER BY NOME";
                return c.RetornarDataSet(comando);
            }
            else
            {
                comando = "SELECT * FROM Tb_ADMIN  WHERE NOME LIKE '%" + texto + "%' ORDER BY NOME";
                return c.RetornarDataSet(comando);
            }
        }

        public void AlterarDataUltimoAcesso()
        {
            try
            {//colocar para aluno, admin e professor
                BDC.ClasseCOnexaoSql c = new BDC.ClasseCOnexaoSql();
                Sql = "UPDATE TB_admin SET ULTIMOACESSO = '" + System.DateTime.Today + "' WHERE rm_admin = " + _Rm + " ";
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

                Sql = "DELETE FROM TB_ADMIN WHERE RM_ADMIN = " + linha + "";
                c.ExecutarComando(Sql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public void IncluirStore() 
        {
            try
            {
                ClasseCOnexaoSql c = new ClasseCOnexaoSql();

                Sql = "SistemaP.DBO.sp_inserir_adm";
                  List<SqlParameter> p  = new List<SqlParameter>();
                p.Add(new SqlParameter("vRM_ADMIN", SqlDbType.Int) { Value =_Rm});
                p.Add(new SqlParameter("vNOME", SqlDbType.NVarChar) { Value = _Nome });
                p.Add(new SqlParameter("vLOGIN", SqlDbType.Int) { Value =  _Login });
                p.Add(new SqlParameter("vultimoacesso", SqlDbType.NVarChar) { Value = _DataAcesso });
                p.Add(new SqlParameter("vcadastro", SqlDbType.NVarChar) { Value = _DataCadastro });
            // value do c# 
                c.ExecutarStoredProcedureParametro(Sql, p.ToArray());
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
     // STORE DELETE E INSERT 

    }
}
