using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace Sistema_Prova.Rotina.Professor.Provas
{
    public partial class frmDisponibiliza : Form
    {
        public frmDisponibiliza()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmDisponibiliza_Load(object sender, EventArgs e)
        {
            try
            {
                BDC.Turma tu = new BDC.Turma();

                cbTurma.DataSource = tu.Listar("").Tables[0];
                cbTurma.DisplayMember = "turma_alu";
                cbTurma.ValueMember = "id_turma";
                cbTurma.SelectedIndex = -1;
                Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }


        private void CarregarGrid()
        {
            BDC.Prova adm = new BDC.Prova();
            try
            {
                String conn =
                @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";

                string sql = "select idprova,prova,NOME_PROF, materia_prova FROM SistemaP.DBO.tbprova where prova = '" + txtPesquisa.Text + "'";

                SqlConnection con = new SqlConnection(conn);
                SqlCommand com = new SqlCommand(sql, con);
                try
                {
                    SqlDataAdapter Da = new SqlDataAdapter(com);
                    DataTable dlista = new DataTable();
                    Da.Fill(dlista);
                    if (dlista.Rows.Count == 0)
                    {
                        dgv.Columns.Clear();
                        string sql2 = "select idprova, prova,etiqueta, materia_prova  FROM SistemaP.DBO.tbprova order by prova ";

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //string message = "DESEJA MESMO SAIR?";
            //string caption = "Error detected in imput";
            //DialogResult result;
            //MessageBoxButtons button = MessageBoxButtons.YesNo;

            //result = MessageBox.Show(message, caption, button);

            //if (result == System.Windows.Forms.DialogResult.Yes)
            //{
            this.Close();
            //}
        }
        private static
            string strConexaoOra =
      @"Server= DESKTOP-HKS0009 ;Database=SistemaP; User Id=equipe7;Password=123456;";

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnAtivar_Click(object sender, EventArgs e)
        {
            if (cbTurma.Text == string.Empty)
            {
                MessageBox.Show("Você precisa escolher uma turma para liberar a prova");
            }
            else
            {
                SqlConnection connLogin = new SqlConnection(strConexaoOra);
                connLogin.Open();

                string SQLLogin = "UPDATE SistemaP.DBO.tbprova SET turmaatual  = '" + cbTurma.Text + "' WHERE idprova ='" + txtId.Text + "' ";

                SqlCommand commLogin = new SqlCommand(SQLLogin, connLogin);
                int y = commLogin.ExecuteNonQuery();
                connLogin.Close();


                if (y == 1)
                {
                    MessageBox.Show("PROVA LIBERADA");
                    Select();
                }
            }
        }

        private void btnDesativar_Click(object sender, EventArgs e)
        {
            if (cbTurma.Text == string.Empty)
            {
                MessageBox.Show("Você precisa escolher uma turma para onerar a prova");
            }
            else
            {
                SqlConnection connLogin = new SqlConnection(strConexaoOra);
                connLogin.Open();
                string SQLLogin = "UPDATE SistemaP.DBO.tbprova SET turmaatual  = '----' WHERE idprova ='" + txtId.Text + "' ";


                SqlCommand commLogin = new SqlCommand(SQLLogin, connLogin);
                int y = commLogin.ExecuteNonQuery();
            }
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
                string sql = "select idprova,prova,NOME_PROF, materia_prova FROM SistemaP.DBO.tbprova where prova like'%" + keyword + "%'";
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
            this.txtPesquisa.Focus();
        }

        private void dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowindex = e.RowIndex;
            txtId.Text = dgv.Rows[rowindex].Cells[0].Value.ToString();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public DataTable Select()
        {
            String conn1 =
      @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";

            SqlConnection conn = new SqlConnection(conn1);
            DataTable dt = new DataTable();
            try
            {
                string sql = "select idprova,prova, turmaatual,MATERIA_PROVA, ETIQUETA FROM SistemaP.DBO.tbprova";






                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
                dgv.DataSource = dt;


                this.dgv.Columns[0].HeaderText = "ID";
                this.dgv.Columns[1].HeaderText = "PROVA";
                this.dgv.Columns[2].HeaderText = "TURMA LIBERADA";
                this.dgv.Columns[3].HeaderText = "MATERIA";
                this.dgv.Columns[4].HeaderText = "ETIQUETA";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbTurma.Text == string.Empty)
            {
                MessageBox.Show("Você precisa escolher uma turma para onerar a prova!");
            }
            else
            {
                SqlConnection connLogin = new SqlConnection(strConexaoOra);
                connLogin.Open();
                string SQLLogin = "UPDATE SistemaP.DBO.tbprova SET turmaatual  = '----' WHERE idprova ='" + txtId.Text + "' ";


                SqlCommand commLogin = new SqlCommand(SQLLogin, connLogin);
                int y = commLogin.ExecuteNonQuery();
                if (y == 1)
                {
                    MessageBox.Show("Prova onerada com sucesso!");
                    Select();
                }
            }
        }


    }
}
