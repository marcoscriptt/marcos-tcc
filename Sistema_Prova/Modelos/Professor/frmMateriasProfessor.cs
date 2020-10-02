using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Prova.Modelos.Professor
{
    public partial class frmMateriasProfessor : Form
    {
        public frmMateriasProfessor()
        {
            InitializeComponent();
        }
        private ArrayList _quest = new ArrayList();

        public ArrayList quest
        {
            get { return _quest; }
            set { _quest = value; }
        }

        private string _TextoTeste;

        public string TextoTeste
        {
            get { return _TextoTeste; }
            set { _TextoTeste = value; }
        }

        private ArrayList _quest2 = new ArrayList();

        public ArrayList quest2
        {
            get { return _quest2; }
            set { _quest2 = value; }
        }
        private static
               string strConexaoOra =
           @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";


        public void attMateria()
        {
            DataTable tbl = new DataTable();


            SqlConnection conn5 = new SqlConnection(strConexaoOra);
            conn5.Open();
            string cmd = "select materia_prof  from prof_materia  where rm_professor = '" + TextoTeste + "'";

            SqlDataAdapter da = new SqlDataAdapter(cmd, strConexaoOra);

            da.Fill(tbl);

            try
            {

                foreach (DataRow item in tbl.Rows)
                {
                    _quest.Add(item[0]);

                }
                for (int i = 0; i < tbl.Rows.Count; i++)
                {
                    //  listBox1.Items.Add(_quest[i].ToString());
                    checkedListBox2.Items.Add(_quest[i].ToString());
                }



                conn5.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void frmMateriasProfessor_Load(object sender, EventArgs e)
        {

            try
            {
                attMateria();


                SqlConnection conn5 = new SqlConnection(strConexaoOra);

                int rm = Convert.ToInt32(TextoTeste);
                string cmd = "select materia_prof from prof_materia";

     


                //-----------------------------------------------------------------------
               
                conn5.Open();

                DataTable tbl2 = new DataTable();

                string sql = "select materia_prof from tb_materia";
                SqlDataAdapter da2 = new SqlDataAdapter(sql, strConexaoOra);

                da2.Fill(tbl2);

                try
                {

                    foreach (DataRow item in tbl2.Rows)
                    {
                        _quest.Add(item[0]);

                    }
                    for (int i = 0; i < tbl2.Rows.Count; i++)
                    {
                        //  listBox1.Items.Add(_quest[i].ToString());
                        checkedListBox1.Items.Add(_quest[i].ToString());
                    }



                    conn5.Close();


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }








                conn5.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(strConexaoOra);
                conn.Open();
                foreach (object item in checkedListBox1.CheckedItems)
                {

                    //  listBox2.Items.Add(item);
                    string SQL2 = "INSERT INTO SistemaP.DBO.PROF_MATERIA (RM_Professor, materia_prof) VALUES ('" + _TextoTeste + "', '" + item + "')";
                    SqlCommand comm2 = new SqlCommand(SQL2, conn);
                    int z = comm2.ExecuteNonQuery();
                }
                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            attMateria();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(strConexaoOra);
                conn.Open();
                foreach (object item in checkedListBox1.CheckedItems)
                {

                    //  listBox2.Items.Add(item);
                string SQL2 = "DELETE FROM SistemaP.DBO.prof_materia WHERE materia_prof = " + item + ""; 
                    SqlCommand comm2 = new SqlCommand(SQL2, conn);
                    int z = comm2.ExecuteNonQuery();
                }
                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            attMateria();
        }
    }
}
