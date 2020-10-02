using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BDC
{
   public class Login
    {

        private static string SQL;
        private static SqlDataReader dr;


 


        private String _Usuario;
        public string Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value.ToUpper(); }
        }

        private string _Senha;

        public string Senha
        {
            get { return _Senha; }
            set { _Senha = value; }
        }

        private int _IdNivelAcesso;

        public int IdNivelAcesso
        {
            get { return _IdNivelAcesso; }
            set { _IdNivelAcesso = value; }
        }


        private int _Status;

        public int Status
        {
            get { return _Status; }
            set { _Status = value; }
        }



        public void Incluir()
        {
            try
            {
              
                BDC.ClasseCOnexaoSql c = new BDC.ClasseCOnexaoSql();
                SQL = "INSERT INTO SistemaP.DBO.TB_User( LOGIN, id_acesso, Senha  ) VALUES (" + _Usuario + ", " + _IdNivelAcesso + ",  '" + _Senha + "') ";
                c.ExecutarComando(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void PegarNivel()
        {

        }
       

      


        public void AlterarDataUltimoAcesso()
        {
            try
            {//colocar para aluno, admin e professor
                BDC.ClasseCOnexaoSql c = new BDC.ClasseCOnexaoSql();
                SQL = "UPDATE SistemaP.DBO.tb_user SET ULTIMOACESSO = '" + System.DateTime.Today + "' WHERE LOGIN = " + _Usuario + " ";
                c.ExecutarComando(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    

        public void AlterarSenha()
        {
            try
            {
                BDC.ClasseCOnexaoSql c = new BDC.ClasseCOnexaoSql();
                SQL = "UPDATE SistemaP.DBO.tb_user SET SENHA = '" + _Senha + "' WHERE login = '" + _Usuario + "' ";
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
                SQL = "UPDATE SistemaP.DBO.tb_user SET Nivel_acesso = '" + _IdNivelAcesso + "',  Senha = '" + _Senha + "' WHERE login='" + _Usuario + "' ";
                c.ExecutarComando(SQL);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public bool Logar()
        {
            BDC.ClasseCOnexaoSql objConexao = new BDC.ClasseCOnexaoSql();

            
            SQL = "SELECT LOGIN, SENHA, ID_ACESSO, status FROM tb_user WHERE LOGIN = '" + _Usuario + "'  AND SENHA = '" + _Senha + "' ";

            dr = objConexao.RetornarDataReader(SQL);
            dr.Read();



            if (dr.HasRows)
            {
                // Adicionar os valores retirados das tabelas nas variaveis de consulta

                //Achar o indice da coluna
                System.Console.WriteLine(dr[2]);

                Usuario = Convert.ToString(dr["LOGIN"]);

                Senha = Convert.ToString(dr["SENHA"]);

                IdNivelAcesso = Convert.ToInt16(dr["ID_ACESSO"]);

                Status = Convert.ToInt16(dr["status"]);

                return true;
            }
            else
            {
                return false;
            }
        }


        public SqlDataReader Consultar()
        {
            try
            {
                BDC.ClasseCOnexaoSql c = new BDC.ClasseCOnexaoSql();
                SQL = "SELECT * FROM SistemaP.DBO.tb_user WHERE Login =' " + _Usuario+"'";
                return c.RetornarDataReader(SQL);
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

                SQL = "SistemaP.DBO.sp_inserir_user";
                List<SqlParameter> p = new List<SqlParameter>();
                p.Add(new SqlParameter("VID_ACESSO", SqlDbType.Int) { Value =  _IdNivelAcesso  });
                p.Add(new SqlParameter("VLOGIN", SqlDbType.NVarChar) { Value = _Usuario });
                p.Add(new SqlParameter("vultimoacesso", SqlDbType.NVarChar) { Value = _Senha });
             
               

                // value do c# 
                c.ExecutarStoredProcedureParametro(SQL, p.ToArray());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }














    }
}
