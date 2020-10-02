using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sistema_Prova.Modelos.Turma
{
    public partial class frmConsultarTurma : Form
    {
        public frmConsultarTurma()
        {
            InitializeComponent();
        }
  




        private void Excluir(object sender, EventArgs e)
        {


            try
            {
                if (sender == btnExcluir)
                {
                    if (MessageBox.Show("Tem certeza que deseja excluir o item selecionado?", "Confirmar",
    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
    MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                    {
                        int linha = Convert.ToInt32(this.dgv.CurrentRow.Cells["ID_TURMA"].Value);
                   
             string strConexaoOra =
         @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";
                        SqlConnection connLogin = new SqlConnection(strConexaoOra);
                        connLogin.Open();
                        string SQL = "DELETE FROM SistemaP.DBO.tb_materia WHERE ID_TURMA = " + linha + "";


                        SqlCommand commLogin = new SqlCommand(SQL, connLogin);
                        int y = commLogin.ExecuteNonQuery();

                        CarregarGrid();
                    }

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro!" + ex.Message);
                //throw;
            }

        }


         private void MudarStatus1(object o, EventArgs e)
        {
            BDC.Turma a = new BDC.Turma();
            a.IdTurma = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value);
            string Rm = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value).ToString();
            var b = (Button)o;
            int Valor = 1;
           
            String conn =
              @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";

            SqlConnection connLogin = new SqlConnection(conn);
            connLogin.Open();
            string SQL = "UPDATE SistemaP.DBO.tb_turma SET status = '" + Valor + "' WHERE id_turma= " + Rm;
            SqlCommand commLogin = new SqlCommand(SQL, connLogin);
            int y = commLogin.ExecuteNonQuery();

            CarregarGrid();

            MessageBox.Show("Usuario ativado com sucesso");

        }


         private void MudarStatus0(object o, EventArgs e)
         {
             BDC.Turma a = new BDC.Turma();
             a.IdTurma = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value);
             string Rm = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value).ToString();
             var b = (Button)o;
             int Valor = 0;

             String conn =
               @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";

             SqlConnection connLogin = new SqlConnection(conn);
             connLogin.Open();
             string SQL = "UPDATE SistemaP.DBO.tb_turma SET status = '" + Valor + "' WHERE id_turma= " + Rm;
             SqlCommand commLogin = new SqlCommand(SQL, connLogin);
             int y = commLogin.ExecuteNonQuery();

             CarregarGrid();

             MessageBox.Show("Usuario desativado com sucesso");

         }



         private void Alterar(object sender, EventArgs e)
         {
             try
             {

                 BDC.Turma adm = new BDC.Turma();


                 Turma.frmAlterarTurma falt = new Turma.frmAlterarTurma();
                 SqlDataReader dr;

                 adm.IdTurma = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value);

                 dr = adm.Consultar4();

                 if (dr.Read())
                 {
                     falt.txtCod.Text = dr["id_turma"].ToString();
                     falt.txtNome.Text = dr["turma_alu"].ToString();
                    

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
          string message = "DESEJA MESMO SAIR?";
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
                    sql = "SELECT * FROM SistemaP.DBO.TB_Turma where status =0";

                }
                if (chkAtivo.Checked == true)
                {
                    sql = "SELECT * FROM SistemaP.DBO.TB_Turma where status =1";

                }
                else
                {
                    sql = "SELECT * FROM SistemaP.DBO.TB_Turma ";
                }




                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
                dgv.DataSource = (dt);

                this.dgv.Columns[0].HeaderText = "ID";
                this.dgv.Columns[1].HeaderText = "TURMA";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        private void Listar(object sender, EventArgs e)
        {
          

            Select();

            //if (sender == this.btnBuscar)
            //{
            //    this.txtPesquisa.Text = String.Empty;
            //}
            //this.txtPesquisa.Focus();

        }

        private void CarregarGrid()
        {
            BDC.Administrador adm = new BDC.Administrador();
            try
            {
                String conn =
                @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";

                string sql = "SELECT * FROM SistemaP.DBO.TB_TURMA ";



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
                        string sql2 = "SELECT * FROM SistemaP.DBO.TB_TURMA ";

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

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
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

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {

        }

        private void chkInativo_CheckedChanged(object sender, EventArgs e)
        {
            CarregarGrid2();
        }

        private void chkAtivo_CheckedChanged(object sender, EventArgs e)
        {
            CarregarGrid2();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
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
                    sql = "SELECT * from tb_turma where status =0";

                }
                else if (chkAtivo.Checked == true)
                {
                    sql = "SELECT * from tb_turma where status =1";

                }
                else
                {
                    sql = "SELECT * from tb_turma";
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

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                String conn1 =
                               @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";
                string keyword = txtPesquisa.Text;
                string sql = "SELECT * FROM SistemaP.DBO.tb_turma where turma_alu like'%" + keyword + "%' or id_turma like'%" + keyword + "%'";
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

        private void dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowindex = e.RowIndex;
            textBox1.Text = dgv.Rows[rowindex].Cells[1].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Modelos.Aluno.frmConsultarNotas a = new Aluno.frmConsultarNotas();

            a.TextoTeste = textBox1.Text;

            a.ShowDialog();
        }


    }
}
