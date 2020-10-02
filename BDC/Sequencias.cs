using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace BDC
{
    public class Sequencias
    {

        public static string IdProva(SqlConnection cn)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                string Resultado;
                SqlDataReader Leitor;

                cmd.CommandText = "SELECT SistemaP.DBO.SEQ_PROVA.NEXTVAL FROM DUAL";
                Leitor = cmd.ExecuteReader();
                Leitor.Read();
                Resultado = Leitor[0].ToString();
                Leitor.Close();


                return Resultado;
            }
            catch (Exception)
            {
                
                throw;
            }
           
        }

 

        public static string IdTurma(SqlConnection cn)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                string Resultado;
                SqlDataReader Leitor;

                cmd.CommandText = "SELECT SistemaP.DBO.next value for SistemaP.DBO.SEQ_TURMA FROM DUAL";
                Leitor = cmd.ExecuteReader();
                Leitor.Read();
                Resultado = Leitor[0].ToString();
                Leitor.Close();


                return Resultado;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public static string IdMateria(SqlConnection cn)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                string Resultado;
                SqlDataReader Leitor;

                cmd.CommandText = "SELECT SistemaP.DBO.SEQ_materia.NEXTVAL FROM DUAL";
                Leitor = cmd.ExecuteReader();
                Leitor.Read();
                Resultado = Leitor[0].ToString();
                Leitor.Close();


                return Resultado;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
