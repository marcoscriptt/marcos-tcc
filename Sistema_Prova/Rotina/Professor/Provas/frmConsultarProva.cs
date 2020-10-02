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
    public partial class frmConsultarProva : Form
    {
        public frmConsultarProva()
        {
            InitializeComponent();
        }
        //private static
        //        string strConexaoOra =
        //    @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";

        string strConexaoOra =
      @"Server= DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";
        private void frmConsultarProva_Load(object sender, EventArgs e)
        {
            if (txtTitulo.Text == null)
            {
                btnAlterar.Enabled = false;
            }

          Listar();
          //CarregarGridQues();
          BDC.Materia tu = new BDC.Materia();
            
         cboMateriaP.DataSource = tu.Listar("").Tables[0];
         cboMateriaP.DisplayMember = "materia_prof";
         cboMateriaP.ValueMember = "id_materia";
         cboMateriaP.SelectedIndex = -1;
        }

        private void btnBuscarprova(object sender, EventArgs e)
        {
       
        }


        private void ExcluirProva(object sender, EventArgs e)
        {


            try
            {
                if (sender == btnExcluir)
                {
                    if (MessageBox.Show("Tem certeza que deseja excluir o item selecionado?", "Confirmar",
    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
    MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                    {
                        int linha = Convert.ToInt32(this.dgv.CurrentRow.Cells["IDPROVA"].Value);

                        SqlConnection connLogin = new SqlConnection(strConexaoOra);
                        connLogin.Open();
                        string SQL = "DELETE FROM SistemaP.DBO.TBPROVA WHERE IDPROVA = " + linha + "";


                        SqlCommand commLogin = new SqlCommand(SQL, connLogin);
                        int y = commLogin.ExecuteNonQuery();



                    }


                }

                MessageBox.Show("Adm excluido com sucesso");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro!" + ex.Message);
                //throw;
            }

        }

        private void MudarAtivo(Object o, EventArgs e)
        {

            BDC.Prova a = new BDC.Prova();
         //   a.IdProva = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value);
            string Id = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value).ToString();
            var b = (Button)o;
            int Valor = 1;

            String conn =
              @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";

            SqlConnection connLogin = new SqlConnection(conn);
            connLogin.Open();
            string SQL = "UPDATE SistemaP.DBO.tbprova SET status = '" + Valor + "' WHERE idprova= " + Id;
            SqlCommand commLogin = new SqlCommand(SQL, connLogin);
            int y = commLogin.ExecuteNonQuery();
            Listar();
            MessageBox.Show("Usuario " + b.Text + " com sucesso");



        }
        private void MudarStatus(object o, EventArgs e)
        {
            BDC.Prova a = new BDC.Prova();
            //a.IdProva = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value);
            string Rm = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value).ToString();
            var b = (Button)o;
            int Valor = 0;

            String conn =
              @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";

            SqlConnection connLogin = new SqlConnection(conn);
            connLogin.Open();
            string SQL = "UPDATE SistemaP.DBO.tbprova SET status = '" + Valor + "' WHERE idprova= " + Rm;
            SqlCommand commLogin = new SqlCommand(SQL, connLogin);
            int y = commLogin.ExecuteNonQuery();

            Listar();

            MessageBox.Show("Usuario " + b.Text + " com sucesso");
        }

        private void Alterar(object sender, EventArgs e)
        {

        }

        private void Listar()
        {
            BDC.Aluno adm = new BDC.Aluno();
            try
            {
                String conn =
                @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";

                string sql = "select IDPROVA,PROVA,MATERIA_PROVA,etiqueta,Quantidade FROM SistemaP.DBO.tbprova order by IDPROVA";
              
       

                SqlConnection con = new SqlConnection(conn);
                SqlCommand com = new SqlCommand(sql, con);

                try
                {
                    SqlDataAdapter Da = new SqlDataAdapter(com);
                    DataTable dlista = new DataTable();
                    Da.Fill(dlista);


                    dgv.DataSource = dlista;


                    this.dgv.Columns[0].HeaderText = "ID";
                    this.dgv.Columns[1].HeaderText = "PROVA";
                    this.dgv.Columns[2].HeaderText = "MATERIA";
                    this.dgv.Columns[3].HeaderText = "ETIQUETA";
                    this.dgv.Columns[4].HeaderText = "QUANTIDADE DE PERGUNTAS";
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

        private void btnSair_Click(object sender, EventArgs e)
        {
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        //-----------------------------------------------------------------------------------------------

        private void CarregarGridQues()
        {
            BDC.Questoes adm = new BDC.Questoes();
            try
            {
                String conn =
                @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";

                string sql = "select * FROM SistemaP.DBO.tbquestao where titulo = '" + txtPesquisa.Text + "'";

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
                        string sql2 = "select * from SistemaP.DBO.tbquestao order by titulo ";

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

        private void AlterarQues(object sender, EventArgs e)
        {
        }

        private void ExcluirQue(object sender, EventArgs e)
        {



            try
            {
                if (sender == btnExcluir)
                {
                    if (MessageBox.Show("Tem certeza que deseja excluir o item selecionado?", "Confirmar",
    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
    MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                    {
                        int linha = Convert.ToInt32(this.dgv.CurrentRow.Cells["idquestao"].Value);
                        string strConexaoOra =
               @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";

                        SqlConnection connLogin = new SqlConnection(strConexaoOra);
                        connLogin.Open();
                        string SQL = "DELETE FROM SistemaP.DBO.tbquestao WHERE idquestao = " + linha + "";


                        SqlCommand commLogin = new SqlCommand(SQL, connLogin);
                        int y = commLogin.ExecuteNonQuery();

                        CarregarGridQues();
                    }

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro!" + ex.Message);
                //throw;
            }

        }


        private void MudarStatusQues1(object o, EventArgs e)
        {
            try
            {
                BDC.Questoes a = new BDC.Questoes();
                a.IdQuestao = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value);
                string Rm = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value).ToString();
                var b = (Button)o;
                int Valor = 1;
            
                String conn =
                  @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";

                SqlConnection connLogin = new SqlConnection(conn);
                connLogin.Open();
                string SQL = "UPDATE SistemaP.DBO.tbquestao SET status = '" + Valor + "' WHERE idquestao= " + Rm;
                SqlCommand commLogin = new SqlCommand(SQL, connLogin);
                int y = commLogin.ExecuteNonQuery();

                CarregarGridQues();

                MessageBox.Show("Usuario " + b.Text + " com sucesso");

            }





            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }




        private void MudarStatusQues0(object o, EventArgs e)
        {

        }








 

        private void btnBuscar_ClickQues(object sender, EventArgs e)
        {
            BDC.Questoes adm = new BDC.Questoes();
            try
            {
                String conn =
                @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";

                string sql = "select * FROM SistemaP.DBO.tbquestao where titulo = '" + txtPesquisa.Text + "'";

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
                        string sql2 = "select * FROM SistemaP.DBO.tbquestao order by titulo";

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

        private void frmConsultarQuestao_Load_1(object sender, EventArgs e)
        {
            CarregarGridQues();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
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

        private void txtPesquisa_TextChanged_1(object sender, EventArgs e)
        {
            try
            {


                String conn1 =
                       @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";
                string keyword = txtPesquisa.Text;
                string sql = "SELECT * FROM SistemaP.DBO.TBPROVA where TITULO like'%" + keyword + "%'";
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                
            SqlConnection connLogin = new SqlConnection(strConexaoOra);
            connLogin.Open();

            string SQLLogin = "UPDATE SistemaP.DBO.tbprova SET etiqueta = '" + txtEtiqueta.Text + "',  prova = '" + txtTitulo.Text + "', MATERIA_PROVA = '" + cboMateriaP.Text + "' WHERE IDPROVA='" + label3.Text + "' ";



            SqlCommand commLogin = new SqlCommand(SQLLogin, connLogin);
            int y = commLogin.ExecuteNonQuery();
            connLogin.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("PROVA ALTERADA COM SUCESSO");    
            }

            MessageBox.Show("PROVA ALTERADA COM SUCESSO!");
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowindex = e.RowIndex;
            label3.Text = dgv.Rows[rowindex].Cells[0].Value.ToString();
            txtTitulo.Text = dgv.Rows[rowindex].Cells[1].Value.ToString();
         //   txtAplicador.Text = dgv.Rows[rowindex].Cells[1].Value.ToString();
            cboMateriaP.Text = dgv.Rows[rowindex].Cells[2].Value.ToString();
            txtEtiqueta.Text = dgv.Rows[rowindex].Cells[3].Value.ToString();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            try
            {
                if (sender == btnExcluir)
                {
                    if (MessageBox.Show("Tem certeza que deseja excluir o item selecionado?", "Confirmar",
    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
    MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                    {
                        int linha = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value.ToString());
                     
                        SqlConnection connLogin = new SqlConnection(strConexaoOra);
                        connLogin.Open();
                        string SQL = "DELETE FROM SistemaP.DBO.TBPROVA WHERE IDPROVA = " + linha + "";
                    

                        SqlCommand commLogin = new SqlCommand(SQL, connLogin);

                        int y = commLogin.ExecuteNonQuery();
                     

                        Select();
                    }
                    else
                    {

                    }

                }

                MessageBox.Show("PROVA EXCLUIDA COM SUCESSO");
                txtTitulo.Text = null;
                txtEtiqueta.Text = null;
                cboMateriaP.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro!" + ex.Message);
                //throw;
            }

        }

        private void txtPesquisa_TextChanged_2(object sender, EventArgs e)
        {
            try
            {


                String conn1 =
                       @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";
                string keyword = txtPesquisa.Text;
                string sql = "SELECT * FROM SistemaP.DBO.TBPROVA where PROVA like'%" + keyword + "%' or ETIQUETA like'%" + keyword + "%'";
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
