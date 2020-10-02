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



namespace Sistema_Prova.Modelos.Administrador
{
    public partial class frmConsultarAdm : Form
    {
        public frmConsultarAdm()
        {
            InitializeComponent();
        }

        private static
             string strConexaoOra =
           @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";


        public DataTable Select2()
        {
            String conn1 =
          @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";

            SqlConnection conn = new SqlConnection(conn1);
            DataTable dt = new DataTable();
            try
            {
                string keyword = txtPesquisa.Text;

                string sql = "SELECT * FROM SistemaP.DBO.TB_ADMIN where nome like'%" + keyword + "%' or rm_admin like'%" + keyword + "%'";





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





        public DataTable Select()
        {
            String conn1 =
          @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";

            SqlConnection conn = new SqlConnection(conn1);
            DataTable dt = new DataTable();
            try
            {
                string sql = " ";

                if (chkInativo.Checked == true)
                {
                    sql = "SELECT * FROM SistemaP.DBO.TB_ADMIN where status =0";

                }
                if (chkAtivo.Checked == true)
                {
                    sql = "SELECT * FROM SistemaP.DBO.TB_ADMIN where status =1";

                }
                else
                {
                    sql = "SELECT* FROM SistemaP.DBO.TB_ADMIN";
                }




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

        private void Listar(object sender, EventArgs e)
        {
            if (txtNome.Text == null)
            {
                btnAlterar.Enabled = false;
            }
            CarregarGrid();
        }

        private void PassarTxt(object o, EventArgs e)
        {

            String value = txtNome.Text;
            string[] colunas = value.Split(' ');

            if (colunas[0].Equals(" "))
            {
                txtUsuario.Text = colunas[1] + "_" + txtRM.Text;
            }
            else
            {
                txtUsuario.Text = colunas[0] + "_" + txtRM.Text;

            }

        }



        private void CarregarGrid()
        {
            BDC.Administrador adm = new BDC.Administrador();
            try
            {

                string sql = "";

                String conn =


                       @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";
                if (chkInativo.Checked == true)
                {
                    sql = "SELECT q.rm_admin, q.NOME, p.LOGIN,p.Senha,q.CADASTRO,q.ULTIMOACESSO,q.STATUS FROM SistemaP.DBO.TB_ADMIN AS q INNER JOIN SistemaP.DBO.TB_USER AS p on q.LOGIN = p.LOGIN where q.status =0";


                }
                else if (chkAtivo.Checked == true)
                {
                    sql = "SELECT q.rm_admin, q.NOME, p.LOGIN,p.Senha,q.CADASTRO,q.ULTIMOACESSO,q.STATUS FROM SistemaP.DBO.TB_ADMIN AS q INNER JOIN SistemaP.DBO.TB_USER AS p on q.LOGIN = p.LOGIN where q.status =1";

                }
                else
                {
                    sql = "SELECT q.rm_admin, q.NOME, p.LOGIN,p.Senha,q.CADASTRO,q.ULTIMOACESSO,q.STATUS FROM SistemaP.DBO.TB_ADMIN AS q INNER JOIN SistemaP.DBO.TB_USER AS p on q.LOGIN = p.LOGIN";
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
                    this.dgv.Columns[4].HeaderText = "DATA DE CADASTRO";
                    this.dgv.Columns[5].HeaderText = "DATA DE ULTIMO ACESSO";
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

        //Click do botão Buscar 


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
                        int linha = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value.ToString());
                        string linha2 = Convert.ToString(this.dgv.CurrentRow.Cells[2].Value.ToString());
                        SqlConnection connLogin = new SqlConnection(strConexaoOra);
                        connLogin.Open();
                        string SQL = "DELETE FROM SistemaP.DBO.TB_ADMIN WHERE RM_ADMIN = " + linha + "";
                        string SQL2 = "DELETE FROM SistemaP.DBO.tb_user WHERE login = '" + linha2 + "'";

                        SqlCommand commLogin = new SqlCommand(SQL, connLogin);
                        SqlCommand commLogin2 = new SqlCommand(SQL2, connLogin);
                        int y = commLogin.ExecuteNonQuery();
                        int x = commLogin2.ExecuteNonQuery();

                        CarregarGrid();
                    }
                    else
                    {

                    }

                }

                MessageBox.Show("Adm excluido com sucesso");
                txtNome.Text = null;
                txtRM.Text = null;
                txtSenha.Text = null;
                txtUsuario.Text = null;
                maskedCadastro.Text = null;
                maskedAcesso.Text = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro!" + ex.Message);
                //throw;
            }

        }

        private void MudarAtivo(Object o, EventArgs e)
        {

            string Login = txtUsuario.Text;

            string Rm = txtRM.Text;
            int Valor = 1;

            String conn =
                 @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";
            SqlConnection connAdm = new SqlConnection(conn);
            connAdm.Open();
            string SQL = "UPDATE SistemaP.DBO.tb_admin SET status = '" + Valor + "' WHERE rm_admin = " + Rm;
            SqlCommand commAdm = new SqlCommand(SQL, connAdm);
            int y = commAdm.ExecuteNonQuery();

            string SQL2 = "UPDATE SistemaP.DBO.tb_user SET status = '" + Valor + "' WHERE login = '" + Login + "'";
            SqlCommand commLogin = new SqlCommand(SQL, connAdm);
            int x = commLogin.ExecuteNonQuery();

            CarregarGrid();
            connAdm.Close();
            MessageBox.Show("ADMIN ATIVADO COM SUCESSO");



        }
        private void MudarStatus(object o, EventArgs e)
        {

            string Login = txtUsuario.Text;

            string Rm = txtRM.Text;
            int Valor = 0;

            String conn =
         @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";
            SqlConnection connAdm = new SqlConnection(conn);
            connAdm.Open();
            string SQL = "UPDATE SistemaP.DBO.tb_admin SET status = '" + Valor + "' WHERE rm_admin= " + Rm;
            SqlCommand commAdm = new SqlCommand(SQL, connAdm);
            int y = commAdm.ExecuteNonQuery();

            string SQL2 = "UPDATE SistemaP.DBO.tb_user SET status = '" + Valor + "' WHERE login='" + Login + "'";
            SqlCommand commLogin = new SqlCommand(SQL, connAdm);
            int x = commLogin.ExecuteNonQuery();


            CarregarGrid();
            connAdm.Close();
            MessageBox.Show("ADMIN DESATIVADO COM SUCESSO");

        }

        private void Alterar(object sender, EventArgs e)
        {
            try
            {
                Cadastrar();
                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw ex;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmConsultarAdm_Load(object sender, EventArgs e)
        {


        }

        //Click do botão Buscar 
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BDC.Administrador adm = new BDC.Administrador();
            try
            {
                String conn =
                     @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";
                string sql = "SELECT * FROM SistemaP.DBO.TB_ADMIN WHERE NOME='" + txtPesquisa.Text + "'";



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
                        string sql2 = "SELECT * FROM SistemaP.DBO.TB_ADMIN ORDER BY NOME";

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

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            try
            {


                String conn1 =
                       @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";
                string keyword = txtPesquisa.Text;
                string sql = "SELECT * FROM SistemaP.DBO.TB_ADMIN where NOME like'%" + keyword + "%' or rm_admin like'%" + keyword + "%'";
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


        private void Cadastrar()
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
                    this.erro.SetError(this.txtSenha, "Erro no preenchimento do campo");
                    this.txtSenha.Focus();
                    return;
                }

                //Atribuir os valores dos das caixas nas variaveis
                BDC.Administrador adm = new BDC.Administrador();
                BDC.Login objLogin = new BDC.Login();


                int IdNivelAcesso = 0;

                string Usuario = "";

                string Senha = "";


                string DataCadastro = maskedCadastro.Text;
                string DataAcesso = maskedAcesso.Text;

                int Rm = Convert.ToInt32(this.txtRM.Text);
                string Nome = this.txtNome.Text;

                int Ativo;

                if (chkAtivo.Enabled == true)
                {

                    Ativo = 1;


                }
                else
                {
                    Ativo = 0;
                }


                IdNivelAcesso = 1;

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
                string SQL = "UPDATE SistemaP.DBO.TB_ADMIN SET NOME = '" + Nome.ToUpper() + "', CADASTRO ='" + DataCadastro + "' , ULTIMOACESSO = '" + DataAcesso + "', status = '" + Ativo + "' WHERE RM_ADMIN = " + Rm;

                SqlCommand comm = new SqlCommand(SQL, conn);
                int x = comm.ExecuteNonQuery();
                if (x == 1)
                {
                    MessageBox.Show("ADMIN ALTERADO COM SUCESSO!");
                }


                conn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != string.Empty)
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
            else
            {


                this.Close();

            }
        }

        private void dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowindex = e.RowIndex;
            txtNome.Text = dgv.Rows[rowindex].Cells[1].Value.ToString();
            txtRM.Text = dgv.Rows[rowindex].Cells[0].Value.ToString();
            txtUsuario.Text = dgv.Rows[rowindex].Cells[2].Value.ToString();
            maskedAcesso.Text = dgv.Rows[rowindex].Cells[4].Value.ToString();
            maskedCadastro.Text = dgv.Rows[rowindex].Cells[5].Value.ToString();
            txtSenha.Text = dgv.Rows[rowindex].Cells[3].Value.ToString();
        }

        private void chkAtivo_CheckedChanged(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void chkInativo_CheckedChanged(object sender, EventArgs e)
        {
            CarregarGrid();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            CarregarGrid();
        }
    }










}
