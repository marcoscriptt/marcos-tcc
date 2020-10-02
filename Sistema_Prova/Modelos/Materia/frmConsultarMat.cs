using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace Sistema_Prova.Modelos.Materia
{
    public partial class frmConsultarMat : Form
    {
        public frmConsultarMat()
        {
            InitializeComponent();
        }


        private void Listar(object sender, EventArgs e)
        {
            Select();
        
        }

        public DataTable Select()
        {
            String conn1 =
      @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";

            SqlConnection conn = new SqlConnection(conn1);
            DataTable dt = new DataTable();
            try
            {
                string sql = "";

                if (chkInativo.Checked == true)
                {
                    sql = "SELECT ID_MATERIA, MATERIA_PROF, STATUS FROM SistemaP.DBO.TB_MATERIA where status =0";

                }
                if (chkAtivo.Checked == true)
                {
                    sql = "SELECT ID_MATERIA, MATERIA_PROF, STATUS FROM SistemaP.DBO.TB_MATERIA where status =1";

                }
                else
                {
                    sql = "SELECT ID_MATERIA, MATERIA_PROF, STATUS FROM SistemaP.DBO.TB_MATERIA ";
                }




                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
                dgv.DataSource = (dt);

                this.dgv.Columns[0].HeaderText = "ID";
                this.dgv.Columns[1].HeaderText = "MATÉRIA";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return dt;
        }


        private void Excluir(object sender, EventArgs e)
        {

        }


        private void MudarStatus1(object o, EventArgs e)
        {
            BDC.Materia a = new BDC.Materia();
            a.IdMateria = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value);
            string Rm = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value).ToString();
            var b = (Button)o;
            int Valor = 1;
           
            String conn =
              @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";

            SqlConnection connLogin = new SqlConnection(conn);
            connLogin.Open();
            string SQL = "UPDATE SistemaP.DBO.tb_materia SET status = '" + Valor + "' WHERE id_materia= " + Rm;
            SqlCommand commLogin = new SqlCommand(SQL, connLogin);
            int y = commLogin.ExecuteNonQuery();

            CarregarGrid();

            MessageBox.Show("Matéria ativada com sucesso");

        }


        private void MudarStatus0(object o, EventArgs e)
        {
            BDC.Materia a = new BDC.Materia();
            a.IdMateria = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value);
            string Rm = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value).ToString();
            var b = (Button)o;
            int Valor = 0;

            String conn =
              @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";

            SqlConnection connLogin = new SqlConnection(conn);
            connLogin.Open();
            string SQL = "UPDATE SistemaP.DBO.tb_materia SET status = '" + Valor + "' WHERE id_materia= " + Rm;
            SqlCommand commLogin = new SqlCommand(SQL, connLogin);
            int y = commLogin.ExecuteNonQuery();

            CarregarGrid();

            MessageBox.Show("Matéria ativada com sucesso");

        }



        private void Alterar(object sender, EventArgs e)
        {
            try
            {

                BDC.Materia adm = new BDC.Materia();


                Materia.frmAlterarMat falt = new Materia.frmAlterarMat();
                SqlDataReader dr;

                adm.IdMateria = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value);

                dr = adm.Consultar5();

                if (dr.Read())
                {
                    falt.txtCod.Text = dr["id_Materia"].ToString();
                    falt.txtNome.Text = dr["materia_prof"].ToString();





                }


                falt.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
        }

        private void frmConsultarMat_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }


        private void CarregarGrid()
        {
            BDC.Administrador adm = new BDC.Administrador();
            try
            {
                String conn =
                @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";

                string sql = "SELECT * FROM SistemaP.DBO.TB_MATERIA ";



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
                        string sql2 = "SELECT * FROM SistemaP.DBO.TB_MATERIA ";

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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string message = "DESEJA MESMO SAIR?";
            string caption = "Error detected in imput";
            DialogResult result;
            MessageBoxButtons button = MessageBoxButtons.YesNo;

            result = MessageBox.Show(message, caption, button);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            CarregarGrid2();
        }
        private void CarregarGrid2()
        {
            BDC.Administrador adm = new BDC.Administrador();
            try
            {

                string sql = "";

                String conn =


                       @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";
                if (chkInativo.Checked == true)
                {
                    sql = "SELECT * from tb_materia where status =0";

                }
                else if (chkAtivo.Checked == true)
                {
                    sql = "SELECT * from tb_materia where status =1";

                }
                else
                {
                    sql = "SELECT * from tb_materia";
                }



                SqlConnection con = new SqlConnection(conn);
                SqlCommand com = new SqlCommand(sql, con);

                try
                {
                    SqlDataAdapter Da = new SqlDataAdapter(com);
                    DataTable dlista = new DataTable();
                    Da.Fill(dlista);


                    dgv.DataSource = dlista;

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

        private void chkAtivo_CheckedChanged(object sender, EventArgs e)
        {
            CarregarGrid2();
        }

        private void chkInativo_CheckedChanged(object sender, EventArgs e)
        {
            CarregarGrid2();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                String conn1 =
                               @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";
                string keyword = txtPesquisa.Text;
                string sql = "SELECT * FROM SistemaP.DBO.tb_materia where materia_prof like'%" + keyword + "%' or id_materia like'%" + keyword + "%'";
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
