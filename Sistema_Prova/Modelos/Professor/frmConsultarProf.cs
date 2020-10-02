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
using System.Collections;
namespace Sistema_Prova.Modelos.Professor
{
    public partial class frmConsultarProf : Form
    {
        public frmConsultarProf()
        {
            InitializeComponent();
        }

        private static
         string strConexaoOra =
   @"Server= DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";

        private ArrayList _quest = new ArrayList();

        public ArrayList Quest
        {
            get { return _quest; }
            set { _quest = value; }
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
                        int linha = Convert.ToInt32(this.dgv.CurrentRow.Cells["rm_professor"].Value);
             string strConexaoOra =
         @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";
                        SqlConnection connLogin = new SqlConnection(strConexaoOra);
                        connLogin.Open();
                        string SQL = "DELETE FROM SistemaP.DBO.tb_prof WHERE rm_professor = " + linha + "";


                        SqlCommand commLogin = new SqlCommand(SQL, connLogin);
                        int y = commLogin.ExecuteNonQuery();

                        Listar();
                    }

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro!" + ex.Message);
                //throw;
            }

        }


        private void MudarStatus(object o, EventArgs e)
        {
            string Rm = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value).ToString();
            int Valor = 1;

            String conn =
              @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";

            SqlConnection connLogin = new SqlConnection(conn);
            connLogin.Open();
            string SQL = "UPDATE SistemaP.DBO.tb_Prof SET status = '" + Valor + "' WHERE RM_Professor= " + Rm;
            SqlCommand commLogin = new SqlCommand(SQL, connLogin);
            int y = commLogin.ExecuteNonQuery();

            Listar();

            MessageBox.Show("Usuario ativado com sucesso");
            connLogin.Close();

        }
        private void MudarStatus0(object o, EventArgs e)
        {
            string Rm = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value).ToString();
            int Valor = 0;

            String conn =
              @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";

            SqlConnection connLogin = new SqlConnection(conn);
            connLogin.Open();
            string SQL = "UPDATE SistemaP.DBO.tb_Prof SET status = '" + Valor + "' WHERE RM_Professor= " + Rm;
            SqlCommand commLogin = new SqlCommand(SQL, connLogin);
            int y = commLogin.ExecuteNonQuery();

            Listar();

            MessageBox.Show("Usuario " + "desativado" + " com sucesso");
            connLogin.Close();
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BDC.Professor adm = new BDC.Professor();
            try
            {
                String conn =
                @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";

                string sql = "select * FROM SistemaP.DBO.tb_prof where nome = '" + txtPesquisa.Text + "'";

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
                        string sql2 = "select * FROM SistemaP.DBO.tb_prof order by nome ";

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


            }
        }



        public void Listar()
        {
            BDC.Professor adm = new BDC.Professor();
            try
            {
                String conn =
                @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";

                string sql = "select * from SistemaP.DBO.tb_prof where nome = " + txtPesquisa.Text;

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
                        string sql2 = "select * from SistemaP.DBO.tb_prof order by nome ";

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


            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
          string message = "DESEJA MESMO SAIR?";
        }
        private void Listar(object sender, EventArgs e)
        {

        }

        private void CarregarGrid()
        {
            BDC.Administrador adm = new BDC.Administrador();
            try
            {
                String conn =
                @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";

                string sql = "SELECT * FROM SistemaP.DBO.TB_PROF ";



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
                        string sql2 = "SELECT * FROM SistemaP.DBO.TB_PROF ";

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
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
               string sql = "SELECT rm_professor, nome, login, status, ultimoacesso, cadastro FROM SistemaP.DBO.TB_Prof ";



                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return dt;
        }



        private void frmConsultarProf_Load(object sender, EventArgs e)
        {

            if (txtNome.Text == null)
            {
                btnAlterar.Enabled = false;
            }
            
            //try
             //{
             //    BDC.Materia tu = new BDC.Materia();

            //    cboTurma.DataSource = tu.Listar("").Tables[0];
            //    cboTurma.DisplayMember = "mateira_prof";
            //    cboTurma.ValueMember = "id_materia";
            //    cboTurma.SelectedIndex = -1;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    //throw;
            //}
            CarregarGrid2();
        }

        private void label8_Click(object sender, EventArgs e)
        {

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
            }        }

        private void btnMat_Click(object sender, EventArgs e)
        {
            Modelos.Professor.frmMateriasProfessor a = new frmMateriasProfessor();

            string texto = this.txtRM.Text;
            a.TextoTeste = Convert.ToString(texto);

            a.ShowDialog();
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            CarregarGrid2();

        }

        private void chkAtivo_CheckedChanged(object sender, EventArgs e)
        {
            CarregarGrid2();
        }

        private void chkInativo_CheckedChanged(object sender, EventArgs e)
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
                    sql = "SELECT A.[RM_PROFESSOR] ,A.[NOME],A.[LOGIN],B.[SENHA],A.[ULTIMOACESSO],A.[CADASTRO],A.[STATUS]FROM [TB_PROF] A INNER JOIN TB_USER B ON A.LOGIN = B.LOGIN WHERE A.status =0";


                }
                else if (chkAtivo.Checked == true)
                {
                    sql= "SELECT A.[RM_PROFESSOR] ,A.[NOME],A.[LOGIN],B.[SENHA],A.[ULTIMOACESSO],A.[CADASTRO],A.[STATUS]FROM [TB_PROF] A INNER JOIN TB_USER B ON A.LOGIN = B.LOGIN where A.status =1";
                }
                else
                {
                    sql = "SELECT A.[RM_PROFESSOR] ,A.[NOME],A.[LOGIN],B.[SENHA],A.[ULTIMOACESSO],A.[CADASTRO],A.[STATUS]FROM [TB_PROF] A INNER JOIN TB_USER B ON A.LOGIN = B.LOGIN";

                }

       



                SqlConnection con = new SqlConnection(conn);
                SqlCommand com = new SqlCommand(sql, con);

                try
                {
                    SqlDataAdapter Da = new SqlDataAdapter(com);
                    DataTable dlista = new DataTable();
                    Da.Fill(dlista);


                    dgv.DataSource = dlista;

                    this.dgv.Columns[0].HeaderText = "RM";
                    this.dgv.Columns[1].HeaderText = "NOME";
                    this.dgv.Columns[2].HeaderText = "LOGIN";
                    this.dgv.Columns[3].HeaderText = "SENHA";
                    this.dgv.Columns[4].HeaderText = "DATA DE ULTIMO ACESSO";
                    this.dgv.Columns[5].HeaderText = "DATA DE CADASTRO";
                    this.dgv.Columns[6].HeaderText = "STATUS";

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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtNome.Text == String.Empty)
                {
                    this.erro.SetError(this.txtNome, "Campo obrigatório");
                    this.txtNome.Focus();
                    return;
                }
                if (this.txtRM.Text == String.Empty)
                {
                    this.erro.SetError(this.txtRM, "Campo obrigatório");
                    this.txtRM.Focus();
                    return;
                }
                if (this.txtSenha.Text == String.Empty)
                {
                    this.erro.SetError(this.txtSenha, "Campo obrigatório");
                    this.txtSenha.Focus();
                    return;
                }

                //Atribuir os valores dos das caixas nas variaveis
        
                int IdNivelAcesso = 0;

                string Usuario = "".ToUpper();

                string Senha = "".ToUpper();


                string DataCadastro = maskedCadastro.Text;
                string DataAcesso = maskedAcesso.Text;

                int Rm = Convert.ToInt32(this.txtRM.Text);
                string Nome = this.txtNome.Text.ToUpper();

                int Ativo;

           



                IdNivelAcesso = 2;

                Usuario = this.txtUsuario.Text;

                Senha = this.txtSenha.Text;



                SqlConnection connLogin = new SqlConnection(strConexaoOra);
                connLogin.Open();
                string SQLLogin = "UPDATE SistemaP.DBO.tb_user SET id_acesso = '" + IdNivelAcesso + "',  Senha = '" + Senha.ToUpper() + "' WHERE login='" + Usuario + "' ";



                SqlCommand commLogin = new SqlCommand(SQLLogin, connLogin);
                int y = commLogin.ExecuteNonQuery();
                connLogin.Close();

                SqlConnection conn = new SqlConnection(strConexaoOra);
                conn.Open();
                string SQL = "UPDATE SistemaP.DBO.TB_PROF SET NOME = '" + Nome.ToUpper() + "', CADASTRO ='" + DataCadastro + "' , ULTIMOACESSO = '" + DataAcesso + "'  WHERE RM_PROFESSOR = " + Rm;

                SqlCommand comm = new SqlCommand(SQL, conn);
                int x = comm.ExecuteNonQuery();
                if (x == 1)
                {
                    MessageBox.Show("PROFESSOR ALTERADO COM SUCESSO!");
                    CarregarGrid2();
                }


                conn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowindex = e.RowIndex;
            txtNome.Text = dgv.Rows[rowindex].Cells[1].Value.ToString();
            txtRM.Text = dgv.Rows[rowindex].Cells[0].Value.ToString();
            txtUsuario.Text = dgv.Rows[rowindex].Cells[2].Value.ToString();
            txtSenha.Text = dgv.Rows[rowindex].Cells[3].Value.ToString();
            maskedAcesso.Text = dgv.Rows[rowindex].Cells[4].Value.ToString();
            maskedCadastro.Text = dgv.Rows[rowindex].Cells[5].Value.ToString();
            string texto = dgv.Rows[rowindex].Cells[0].Value.ToString();
            BDC.Materia tu = new BDC.Materia();


            listMateria.DataSource = tu.Listar2(texto).Tables[0];
            listMateria.DisplayMember = "RM_PROFESSOR";
            listMateria.ValueMember = "MATERIA_PROF";
            listMateria.SelectedIndex = -1;


         
            //BDC.Professor prof = new BDC.Professor();

            //listMateria.DataSource = prof.Listar2(texto).Tables[0];
            //listMateria.DisplayMember = "materia_prof";
            //listMateria.ValueMember = "rm_professor";
            //listMateria.SelectedIndex = -1;

        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                String conn1 =
                               @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";
                string keyword = txtPesquisa.Text;
                string sql = "SELECT * FROM SistemaP.DBO.tb_prof where NOME like'%" + keyword + "%' or rm_professor like'%" + keyword + "%'";
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
            string SQL = "UPDATE SistemaP.DBO.tb_materia SET status = '" + Valor + "' WHERE id_materia = " + Rm;
            SqlCommand commLogin = new SqlCommand(SQL, connLogin);
            int y = commLogin.ExecuteNonQuery();

            CarregarGrid();

            MessageBox.Show("Matéria ativada com sucesso");

        }

      private void panel1_Paint(object sender, PaintEventArgs e)
      {

      }


   
    }


}