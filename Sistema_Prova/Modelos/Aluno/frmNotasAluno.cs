using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sistema_Prova.Modelos.Aluno.Materia
{
    public partial class frmNotasAluno : Form
    {
        public frmNotasAluno()
        {
            InitializeComponent();
        }


        private string _TextoTeste;
        public String TextoTeste
        {
            get { return _TextoTeste; }
            set { _TextoTeste = value; }
        }

        private string _TextoTesteRM;
        public String TextoTesteRM
        {
            get { return _TextoTesteRM; }
            set { _TextoTesteRM = value; }
        }



















        private void Listar()
        {
            BDC.Notas adm = new BDC.Notas();
            try
            {
                String conn =
                @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";

                string sql = "SELECT n.Prova, n.nota FROM SistemaP.DBO.tb_aluno ainner join SistemaP.DBO.tbnotas_aluno n on a.RM_ALUNO = n.RM_ALUNO where n.RM_ALUNO = '"+_TextoTesteRM+"' ORDER BY n.prova";

                SqlConnection con = new SqlConnection(conn);
                SqlCommand com = new SqlCommand(sql, con);
                try
                {
                    SqlDataAdapter Da = new SqlDataAdapter(com);
                    DataTable dlista = new DataTable();
                    Da.Fill(dlista);
                    if (dlista.Rows.Count == 0)
                    {
                        MessageBox.Show("sem registros");
                        dgv.Columns.Clear();
                        string sql2 = "SELECT n.Prova, n.nota FROM SistemaP.DBO.tb_aluno a inner join SistemaP.DBO.tbnotas_aluno n on a.RM_ALUNO = n.RM_ALUNO where  n.RM_ALUNO = '" + _TextoTesteRM + "' ORDER BY n.prova";


                        SqlConnection con2 = new SqlConnection(conn);
                        SqlCommand com2 = new SqlCommand(sql2, con2);


                        try
                        {
                            SqlDataAdapter Da2 = new SqlDataAdapter(com2);
                            DataTable dlista2 = new DataTable();
                            Da2.Fill(dlista2);
                            dgv.DataSource = dlista2;

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            // throw;
                        }

                    }
                    else
                    {
                        dgv.DataSource = dlista;
                    }





                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    // throw;
                }







            }
            catch (Exception)
            {

                throw;
            }
        }





        public DataTable Select()
        {
            String conn1 =
      @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";

            SqlConnection conn = new SqlConnection(conn1);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT n.Prova, n.nota FROM SistemaP.DBO.tb_aluno a inner join SistemaP.DBO.tbnotas_aluno n on a.RM_ALUNO = n.RM_ALUNO where n.RM_ALUNO = '" + _TextoTesteRM + "' ORDER BY n.prova";


               
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
                dgv.DataSource = dt;

                this.dgv.Columns[0].HeaderText = "PROVA";
                this.dgv.Columns[1].HeaderText = "NOTA";
     
                
            
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return dt;
        }





        private void frmNotasAluno_Load(object sender, EventArgs e)
        {
            Select();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
                this.Close();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            try
            {


                String conn1 =
                       @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";
                string keyword = txtPesquisa.Text;
                string sql = "SELECT n.Prova, n.nota FROM SistemaP.DBO.tb_aluno a inner join SistemaP.DBO.tbnotas_aluno n on a.RM_ALUNO = n.RM_ALUNO where n.prova ='" + txtPesquisa.Text + "' AND n.RM_ALUNO = '" + _TextoTesteRM + "' ORDER BY n.prova";
                SqlConnection conn = new SqlConnection(conn1);
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
