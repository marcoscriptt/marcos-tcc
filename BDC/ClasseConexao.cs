using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; using System.Data; 
using System.Data.SqlClient;



namespace BDC
{
    public class ClasseConexao
    {
        
        private static SqlConnection cn;
        private static SqlCommand cmd;
        private static SqlDataAdapter da;
        private static SqlDataReader dr;
        private static SqlParameter p;
        private static SqlParameter q;
        private static DataSet ds;
        private static string Sql;
        private static string dado;
        private static DataTable dt;
        
       // private static
       //      string strConexaoOra =
       //   "Data Source=DESKTOP-HKS0009;Initial Catalog=SistemaP;User ID=equipe7;Password=123456;Language=Portuguese";


        private static
             string strConexaoOra =
          "Data Source=DESKTOP-HKS0009;Initial Catalog=SistemaP;User ID=equipe7;Password=123456;Language=Portuguese";

        public static string Conexao()
        {
            string oradb = strConexaoOra;
            string info = "";
            try
            {
                cn = new SqlConnection(oradb);

                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                    //cn.BeginTransaction();
                    info = "Conectado com a Versão Sql " + cn.ServerVersion + " Utilizando a fonte " + cn.DataSource;
                }
            }
            catch (SqlException ex)
            {
                return ex.Message;
            }
            return info + " Estado da Conexao " + cn.State.ToString() + " OK";
        }

        public static DataTable ListarAlunos()
        {
            //Sql = @"SELECT * FROM MARCOS.TBALUNO";
            Sql = @"SELECT * FROM MARCOS.TBALUNO ORDER BY NOME";
            cmd = new SqlCommand(Sql, cn);
            cmd.CommandType = CommandType.Text;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        
        public static void FinalizarConexao()
        {
            cn.Close();
            cn.Dispose();
        }




        public DataTable RetornarDataTable(string Comando)
        {
            dt = new DataTable();
            SqlCommand cmd = new SqlCommand(Comando, ConexaoBanco());
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }



        public DataSet RetornarDataSet(string Comando)
        {
            try
            {
                 ds = new DataSet();
                SqlCommand cmd = new SqlCommand(Comando, ConexaoBanco());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




















        public static string PesquisarNomeAluno(string RMDigitado)
        {
            Sql = "SELECT NOME FROM MARCOS.TBALUNO WHERE TBALUNO.RM = :RMPesquisa"; // @ RMPesquisa  > SqlServer

            cmd = new SqlCommand(Sql, cn);
            cmd.CommandType = CommandType.Text;

            p = new SqlParameter();
            p.ParameterName = "@RMPesquisa";
            p.DbType = DbType.String;
            p.Value = RMDigitado;
            cmd.Parameters.Add(p);

            cmd.CommandText = Sql;
            return cmd.ExecuteScalar().ToString();
        }

        public static string Verificar(string NomeDig, string SenhaDig)
        {

            Sql = "SELECT nome FROM MARCOS.tbaluno WHERE TBALUNO.NOME=:NomeDig AND TBALUNO.RM=:senhaDIg"; //@RMPesquisa  > SqlServer

            cmd = new SqlCommand(Sql, cn);
            cmd.CommandType = CommandType.Text;

            p = new SqlParameter();
            p.ParameterName = "@NomeDig";
            p.DbType = DbType.String;
            p.Value = NomeDig;
            cmd.Parameters.Add(p);

            q = new SqlParameter();
            q.ParameterName = "@senhaDIg";
            q.DbType = DbType.String;
            q.Value = SenhaDig;
            cmd.Parameters.Add(q);

            cmd.CommandText = Sql;

            //return cmd.ExecuteScalar().ToString();

            if (cmd.ExecuteScalar() == null)
            {
                dado = null;
            }
            else
            {
                dado = cmd.ExecuteScalar().ToString();
            }

            return dado;

        }

        public static void executarComando(string Sql)
        {
            Conexao();
            try
            {
                SqlCommand cmd = new SqlCommand(Sql, cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static void CriarTablespace()
        {

            string pasta = @"C:\oramarcos\";   //criar em D    a pasta antes de executar o codigo
            string usuario = "marcos";
            string senha = "123456";
            string schema = "NEW_SCHEMA_TBS";
            cmd = cn.CreateCommand();
            cmd.CommandText = "CREATE TABLESPACE \"" + schema + "\" DATAFILE '" + pasta + schema + ".DBF' SIZE 10M AUTOEXTEND ON NEXT 1M";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "CREATE USER \"" + usuario + "\" IDENTIFIED BY \"" + senha + "\" DEFAULT TABLESPACE \"" + schema + "\" TEMPORARY TABLESPACE TEMP";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "GRANT CONNECT TO \"" + usuario + "\"";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "ALTER USER \"" + usuario + "\" QUOTA UNLIMITED ON \"" + schema + "\"";
            cmd.ExecuteNonQuery();
            //Finalizar();
        }

        /// <summary>
        /// Os métodos abaixo tomam como exemplo a Biblioteca/Classes apresentadas
        /// a partir do livro Aplicacoes Comerciais
        /// </summary>
        /// <returns></returns>
        public static SqlConnection ConexaoBanco()
        {
            try
            {
                cn = new SqlConnection(strConexaoOra);
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
                return cn;
            }
            catch (SqlException exOra)
            {
                throw exOra;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void FecharBanco(SqlConnection cn)
        {
            try
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                    cn.Dispose();
                }
            }
            catch (SqlException exOra)
            {
                throw exOra;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SqlDataReader RetornarDataReader(string SqlComando)
        {
            try
            {
                //SqlDataReader dr;
                //SqlCommand cmd = new SqlCommand(SqlComando, abrirBanco());
                cmd = new SqlCommand(SqlComando, ConexaoBanco());
                dr = cmd.ExecuteReader();
                return dr;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public DataTable RetornarDataTable(string SqlComando)
        //{
        //    try
        //    {
        //        DataTable dt = new DataTable();
        //        cmd = new SqlCommand(SqlComando, cn);
        //        da = new SqlDataAdapter(cmd);
        //        da.Fill(dt);
        //        return dt;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //public DataSet RetornarDataSet(string SqlComando)
        //{
        //    try
        //    {
        //        ds = new DataSet();
        //        cmd = new SqlCommand(SqlComando, ConexaoBanco());
        //        da = new SqlDataAdapter(cmd);
        //        da.Fill(ds);
        //        return ds;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //}

        public void ExecutarComando(string SqlComando)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(SqlComando, cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void ExecutarComandoParametro(string SqlComando, SqlParameter[] listaParametros)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = SqlComando;
                cmd.CommandType = CommandType.Text;
                if (listaParametros != null)
                {
                    foreach (SqlParameter p in listaParametros)
                    {
                        cmd.Parameters.Add(p);
                    }
                }
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException exOra)
            {
                throw exOra;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void ExecutarStoredProcedureParametro(string nomeProcedure, SqlParameter[] listaParametros)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = nomeProcedure;
                cmd.CommandType = CommandType.StoredProcedure;
                if (listaParametros != null)
                {
                    foreach (SqlParameter p in listaParametros)
                    {
                        cmd.Parameters.Add(p);
                    }
                }
                Conexao();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException exOra)
            {
                throw exOra;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public int ExecutarComandoRetorno(string SqlComando)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = SqlComando;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                cmd.CommandText = "Select @@Identity";
                dr = cmd.ExecuteReader();
                dr.Read();
                return Convert.ToInt32(dr[0]);
            }
            catch (SqlException exOra)
            {
                throw exOra;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public DataSet RetornarDatasetParametro(string nomeProcedure, SqlParameter[] listaParametros)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = nomeProcedure;
                cmd.CommandType = CommandType.StoredProcedure;
                if (listaParametros != null)
                {
                    foreach (SqlParameter p in listaParametros)
                    {
                        cmd.Parameters.Add(p);
                    }
                }
                cmd.Connection = cn;
                da = new SqlDataAdapter();
                ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                return ds;
            }
            catch (SqlException exOra)
            {
                throw exOra;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                FecharBanco(cn);
            }
        }

        public SqlDataReader RetornarDataReaderParametro(string nomeProcedure, SqlParameter[] listaParametros)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = nomeProcedure;
                cmd.CommandType = CommandType.StoredProcedure;
                if (listaParametros != null)
                {
                    foreach (SqlParameter p in listaParametros)
                    {
                        cmd.Parameters.Add(p);
                    }
                }
                cmd.Connection = cn;
                return cmd.ExecuteReader();
            }
            catch (SqlException exOra)
            {
                throw exOra;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string RetornarStatusBancoDados()
        {
            try
            {
                if (cn.State == ConnectionState.Closed)
                {
                    return "Fechado";
                }
                else
                {
                    return "Aberto";
                }
            }
            catch (SqlException exOra)
            {
                throw exOra;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string RetornarNomeServidor()
        {
            try
            {
                return cn.DataSource;
            }
            catch (SqlException exOra)
            {
                throw exOra;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




    }
}
