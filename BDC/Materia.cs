using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace BDC
{
  public  class Materia
    {
        private static string SQL;
        private static SqlDataReader dr;


        private int _IdMateria;

        public int IdMateria
        {
            get { return _IdMateria; }
            set { _IdMateria = value; }
        }
        private string _MateriaProf;

        public string MateriaProf
        {
            get { return _MateriaProf; }
            set { _MateriaProf = value; }
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
                ClasseCOnexaoSql c = new ClasseCOnexaoSql();
                SQL = "INSERT INTO SistemaP.DBO.tb_materia (id_materia, materia_prof, STATUS) VALUES (seq_materia.nextval, '" + _MateriaProf + "','" + _Ativo + "');";
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

                SQL = "DELETE FROM SistemaP.DBO.tb_materia WHERE id_materia = " + linha + "";
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
                ClasseCOnexaoSql c = new ClasseCOnexaoSql();
                SQL = "UPDATE SistemaP.DBO.tb_materia SET materia_prof = '" + _MateriaProf + "', ATIVO = '" + _Ativo + "' WHERE id_materia = " + _IdMateria;

                c.ExecutarComando(SQL);
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
                SQL = "SELECT * FROM SistemaP.DBO.tb_materia WHERE id_materia = '" + _IdMateria + "'";
                return c.RetornarDataReader(SQL);
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
                SQL = "UPDATE SistemaP.DBO.tb_materia SET status = '" + Valor + "' WHERE id_materia = " + _IdMateria;
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
                ClasseCOnexaoSql c = new ClasseCOnexaoSql();
                SQL = "DELETE FROM SistemaP.DBO.tb_materia WHERE id_materia= '" + IdMateria + "'";
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
                ClasseCOnexaoSql c = new ClasseCOnexaoSql();
                SQL = "SELECT materia_prof FROM SistemaP.DBO.tb_materia";
                return c.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private int _Rm;

        public int Rm
        {
            get { return _Rm; }
            set { _Rm = value; }
        }

        public SqlDataReader Consultar2()
        {
            try
            {
                ClasseCOnexaoSql c = new ClasseCOnexaoSql();
                SQL = "SELECT materia_prof FROM SistemaP.DBO.PROF_MATERIA WHERE RM_PROFESSOR = '" + _Rm + "'";
                return c.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SqlDataReader Consultar10()
        {
            try
            {
                ClasseCOnexaoSql c = new ClasseCOnexaoSql();
                SQL = "SELECT MATERIA_PROF FROM SistemaP.DBO.tb_materia WHERE MATERIA_PROF = '" + _MateriaProf + "'";
                return c.RetornarDataReader(SQL);
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
                comando = "SELECT * FROM SistemaP.DBO.TB_MATERIA ORDER BY MATERIA_PROF";
                return c.RetornarDataSet(comando);
            }
            else
            {
                comando = "SELECT * FROM SistemaP.DBO.tb_MATERIA  WHERE MATERIA_PROF LIKE '%" + texto + "%' ORDER BY MATERIA_PROF";
                return c.RetornarDataSet(comando);
            }
        }

        public DataSet Listar2(string texto)
        {
            ClasseCOnexaoSql c = new ClasseCOnexaoSql();
            string comando = string.Empty;

            comando = "SELECT MATERIA_PROF FROM SistemaP.DBO.PROF_MATERIA WHERE RM_PROFESSOR = '" + texto + "' ORDER BY MATERIA_PROF";

                return c.RetornarDataSet(comando);
            
        }
    }
}
