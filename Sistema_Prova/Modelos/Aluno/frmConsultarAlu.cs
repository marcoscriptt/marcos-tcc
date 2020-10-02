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

namespace Sistema_Prova.Modelos.Aluno
{
    public partial class frmConsultarAlu : Form
    {
        public frmConsultarAlu()
        {
            InitializeComponent();
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
                    //  sql = "SELECT * FROM SistemaP.DBO.TB_ALUNO where status =0";
                    sql = "select q.rm_aluno, q.nome, p.turma_alu, q.num_chamada, q.login, s.SENHA,q.cadastro,q.ultimoacesso, q.status from SistemaP.DBO.tb_aluno as q inner join SistemaP.DBO.tb_turma as p on p.ID_TURMA = q.ID_TURMA inner join SistemaP.DBO.tb_user as s on q.login = s.login where status =0";
                }
                else if (chkAtivo.Checked == true)
                {
                    //  sql = "SELECT * FROM SistemaP.DBO.TB_ALUNO where status =1";
                    sql = "select q.rm_aluno, q.nome, p.turma_alu, q.num_chamada, q.login, s.SENHA,q.cadastro,q.ultimoacesso, q.status from SistemaP.DBO.tb_aluno as q inner join SistemaP.DBO.tb_turma as p on p.ID_TURMA = q.ID_TURMA inner join SistemaP.DBO.tb_user as s on q.login = s.login where status =1";
                }
                else
                {//arrumar inner jooin
                    //   sql = "SELECT * FROM SistemaP.DBO.TB_ALUNO";
                    sql = "select q.rm_aluno, q.nome, p.turma_alu, q.num_chamada, q.login, s.SENHA,q.cadastro,q.ultimoacesso, q.status from SistemaP.DBO.tb_aluno as q inner join SistemaP.DBO.tb_turma as p on p.ID_TURMA = q.ID_TURMA inner join SistemaP.DBO.tb_user as s on q.login = s.login";
                }

                


                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
                dgv.DataSource = dt;

                this.dgv.Columns[0].HeaderText = "RM";
                this.dgv.Columns[1].HeaderText = "NOME";
                this.dgv.Columns[2].HeaderText = "TURMA";
                this.dgv.Columns[3].HeaderText = "Nº CHAMADA";
                this.dgv.Columns[4].HeaderText = "LOGIN";
                this.dgv.Columns[5].HeaderText = "SENHA";
                this.dgv.Columns[6].HeaderText = "DATA DE CADASTRO";
                this.dgv.Columns[7].HeaderText = "DATA DE ULTIMO ACESSO";
                this.dgv.Columns[8].HeaderText = "STATUS"; 
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
            BDC.Turma tu = new BDC.Turma();

            comboTurma.DataSource = tu.Listar("").Tables[0];
            comboTurma.DisplayMember = "turma_alu";
            comboTurma.ValueMember = "id_turma";
            comboTurma.SelectedIndex = -1;
            Select();
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
            string SQL = "UPDATE SistemaP.DBO.TB_ALUNO SET status = '" + Valor + "' WHERE rm_aluno= " + Rm;
            SqlCommand commAdm = new SqlCommand(SQL, connAdm);
            int y = commAdm.ExecuteNonQuery();

            string SQL2 = "UPDATE SistemaP.DBO.tb_user SET status = '" + Valor + "' WHERE login= " + Login;
            SqlCommand commLogin = new SqlCommand(SQL, connAdm);
            int x = commLogin.ExecuteNonQuery();

            Select();
            connAdm.Close();
            MessageBox.Show("ALUNO ATIVADO COM SUCESSO");



        }
        private void MudarStatus(object o, EventArgs e)
        {

            string Login = txtUsuario.Text;

            string Rm = txtRM.Text;
            int Valor = 0;
            BDC.Turma turma = new BDC.Turma();
            String conn =
              @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";

            SqlConnection connAdm = new SqlConnection(conn);
            connAdm.Open();
            string SQL = "UPDATE SistemaP.DBO.TB_ALUNO SET status = '" + Valor + "' WHERE RM_ALUNO= " + Rm;
            SqlCommand commAdm = new SqlCommand(SQL, connAdm);
            int y = commAdm.ExecuteNonQuery();

            string SQL2 = "UPDATE SistemaP.DBO.tb_user SET status = '" + Valor + "' WHERE login= " + Login;
            SqlCommand commLogin = new SqlCommand(SQL, connAdm);
            int x = commLogin.ExecuteNonQuery();

            Select();
            connAdm.Close();
            MessageBox.Show("ALUNO DESATIVADO COM SUCESSO");

        }


        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                String conn1 =
                               @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";
                string keyword = txtPesquisa.Text;
                string sql = "SELECT * FROM SistemaP.DBO.tb_aluno where NOME like'%" + keyword + "%' or rm_aluno like'%" + keyword + "%'";
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

                string Turma = comboTurma.Text;

                string NumChamada = Chamada.Text;


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
                string SQLLogin = "UPDATE SistemaP.DBO.tb_user SET id_acesso = '" + IdNivelAcesso + "',  Senha = '" + Senha + "' WHERE login='" + Usuario + "' ";



                SqlCommand commLogin = new SqlCommand(SQLLogin, connLogin);
                int y = commLogin.ExecuteNonQuery();
                connLogin.Close();

                SqlConnection conn = new SqlConnection(strConexaoOra);
                conn.Open();
                string SQL = "UPDATE SistemaP.DBO.TB_ALUNO SET NOME = '" + Nome + "', CADASTRO ='" + DataCadastro + "' , ULTIMOACESSO = '" + DataAcesso + "', status = '" + Ativo + "' WHERE RM_ALU = " + Rm;

                SqlCommand comm = new SqlCommand(SQL, conn);
                int x = comm.ExecuteNonQuery();
                if (x == 1)
                {
                    MessageBox.Show("ALUNO ALTERADO COM SUCESSO!");
                }


                conn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }

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
                        int linha = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value.ToString());
                        string linha2 = Convert.ToString(this.dgv.CurrentRow.Cells[4].Value.ToString());
                        SqlConnection connLogin = new SqlConnection(strConexaoOra);
                        connLogin.Open();
                        string SQL = "DELETE FROM SistemaP.DBO.tb_aluno WHERE rm_aluno = " + linha + "";
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

                MessageBox.Show("Aluno excluido com sucesso");
                txtNome.Text = null;
                txtRM.Text = null;
                txtSenha.Text = null;
                txtUsuario.Text = null;
                maskedCadastro.Text = null;
                maskedAcesso.Text = null;
                comboTurma.Text = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro!" + ex.Message);
                //throw;
            }

        }























        //private void CarregarGrid()
        //{
        //    try
        //    {

        //        BDC.Aluno alu = new BDC.Aluno();
        //       this.dgv.DataSource = alu.Listar(this.txtPesquisa.Text, this.cboTurma.Text).Tables[0];
        //      //  this.dgv.Columns[0].HeaderText = "ALUNO";
        //      //  this.dgv.Columns[1].HeaderText = "TURMA";
        //      //  this.dgv.Columns[3].HeaderText = "PROVA";


        //        this.dgv.AutoResizeColumn(1);

        //        this.txtPesquisa.Focus();


        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Erro ao carregar" + ex.Message);
        //        //throw;
        //    }

        //}

        private void frmConsultarAdm_Load(object sender, EventArgs e)
        {

        }
        private static
               string strConexaoOra =
           @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";


        private void MudarStatus1(object o, EventArgs e)
        {
            BDC.Aluno a = new BDC.Aluno();
            a.Rm = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value);
            string Rm = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value).ToString();
            var b = (Button)o;
            int Valor = 1;


            String conn =
              @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";

            SqlConnection connLogin = new SqlConnection(conn);
            connLogin.Open();
            string SQL = "UPDATE SistemaP.DBO.tb_aluno SET status = '" + Valor + "' WHERE rm_aluno= " + Rm;
            SqlCommand commLogin = new SqlCommand(SQL, connLogin);
            int y = commLogin.ExecuteNonQuery();

            Select();

            MessageBox.Show("Usuario ativado com sucesso");
        }

        private void MudarStatus0(object o, EventArgs e)
        {
            BDC.Aluno a = new BDC.Aluno();
            a.Rm = Convert.ToInt32(this.dgv.CurrentRow.Cells["Rm_aluno"].Value);
            string Rm = Convert.ToInt32(this.dgv.CurrentRow.Cells["Rm_aluno"].Value).ToString();
            var b = (Button)o;
            int Valor = 0;
            String conn =
              @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";

            SqlConnection connLogin = new SqlConnection(conn);
            connLogin.Open();
            string SQL = "UPDATE SistemaP.DBO.tb_aluno SET status = '" + Valor + "' WHERE rm_aluno= " + Rm;
            SqlCommand commLogin = new SqlCommand(SQL, connLogin);
            int y = commLogin.ExecuteNonQuery();

            Select();

            MessageBox.Show("Usuario desativado com sucesso");
        }




        private void Alterar(object sender, EventArgs e)
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
                //if (checkBox1.Checked = true)
                //{
                //    txtSenha.Enabled = false;
                //    txtSenha.Text = "123456";
                //}
                else if (this.txtSenha.Text == String.Empty)
                {
                    this.erro.SetError(this.txtSenha, "Erro no preenchimento do campo");
                    this.txtSenha.Focus();
                    return;
                }
                //if (this.comboTurma.Text == String.Empty)
                //{
                //    this.erro.SetError(this.comboTurma, "Erro no preenchimento do campo");
                //    this.comboTurma.Focus();
                //    return;
                //}
                if (this.Chamada.Text == String.Empty)
                {
                    this.erro.SetError(this.Chamada, "Erro no preenchimento do campo");
                    this.Chamada.Focus();
                    return;
                }
                //Atribuir os valores dos das caixas nas variaveis
                BDC.Aluno alu = new BDC.Aluno();
                BDC.Login objLogin = new BDC.Login();
                BDC.Turma turma = new BDC.Turma();
                //SqlDataReader dr;
                //dr = adm.Consultar();

                int IdNivelAcesso = 0;
                string Turma = comboTurma.Text.ToUpper();
                string Usuario = "".ToUpper();

                string Senha = "".ToUpper();


                string NumChamada = Chamada.Text.ToUpper();

                string DataCadastro = maskedCadastro.Text.ToUpper();
                string DataAcesso = maskedAcesso.Text.ToUpper();

                int Rm = Convert.ToInt32(this.txtRM.Text);
                string Nome = this.txtNome.Text.ToUpper();
                int Ativo;


                Ativo = 1;



                SqlDataReader dr;
                turma.TurmaAlu = comboTurma.Text;
                dr = turma.Consultar5();

                dr.Read();
                int Turma2 = Convert.ToInt16(dr["ID_TURMA"]);



                IdNivelAcesso = 3;

                Usuario = this.txtUsuario.Text.ToUpper();

                Senha = this.txtSenha.Text.ToUpper();

                SqlConnection connLogin = new SqlConnection(strConexaoOra);
                connLogin.Open();
                string SQLLogin = "UPDATE SistemaP.DBO.tb_user SET id_acesso = '" + IdNivelAcesso + "',  Senha = '" + Senha + "' WHERE login='" + Usuario + "' ";


                SqlCommand commLogin = new SqlCommand(SQLLogin, connLogin);
                int y = commLogin.ExecuteNonQuery();
                connLogin.Close();

                SqlConnection conn = new SqlConnection(strConexaoOra);
                conn.Open();
                string SQL = "UPDATE SistemaP.DBO.tb_aluno SET NOME = '" + Nome + "', CADASTRO ='" + DataCadastro + "', ULTIMOACESSO ='" + DataAcesso + "', ID_TURMA = '" + Turma2 + "',num_chamada = '" + NumChamada + "', status = '" + Ativo + "' WHERE RM_Aluno = " + Rm;

                SqlCommand comm = new SqlCommand(SQL, conn);
                int x = comm.ExecuteNonQuery();
                if (x == 1)
                {
                    MessageBox.Show("ALUNO ALTERADO COM SUCESSO");
                    Select();
                }
                conn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
            //try
            //{

            //    BDC.Aluno adm = new BDC.Aluno();
            //    BDC.Login login = new BDC.Login();

            //    Aluno.frmAlterarAlu falt = new Aluno.frmAlterarAlu();
            //    SqlDataReader dr, dr2;

            //    adm.Rm = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value);
            //    login.Usuario = Convert.ToString(this.dgv.CurrentRow.Cells["LOGIN"].Value); ;

            //    dr = adm.Consultar();
            //    dr2 = login.Consultar();
            //    dr.Read();
            //    dr2.Read();
            //    if (dr.HasRows)
            //    {
            //        falt.txtRM.Text = Convert.ToInt32(this.dgv.CurrentRow.Cells["RM_ALUNO"].Value).ToString();
            //        falt.txtNome.Text = Convert.ToString(this.dgv.CurrentRow.Cells["NOME"].Value).ToString();
            //        //   falt.comboTurma.Text = Convert.ToString(this.dgv.CurrentRow.Cells["TURMA_AlU"].Value).ToString();
            //        falt.maskedCadastro.Text = dr["CADASTRO"].ToString();
            //        falt.maskedAcesso.Text = dr["ULTIMOACESSO"].ToString();
            //        if (dr["STATUS"].ToString() == "1")
            //        {
            //            falt.chkAtivo.Checked = true;
            //        }
            //        else if (dr["STATUS"].ToString() == "0")
            //        {
            //            falt.chkAtivo.Checked = false;
            //        }


            //        falt.txtUsuario.Text = dr2["LOGIN"].ToString();
            //        falt.txtSenha.Text = dr2["SENHA"].ToString();




            //    }


            //    falt.ShowDialog();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    //throw ex;
            //}
        }

        private void btnSair_Click(object sender, EventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Select();
        }

        private void dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowindex = e.RowIndex;
            txtNome.Text = dgv.Rows[rowindex].Cells[1].Value.ToString();
            txtRM.Text = dgv.Rows[rowindex].Cells[0].Value.ToString();
            Chamada.Text = dgv.Rows[rowindex].Cells[3].Value.ToString();
            comboTurma.Text = dgv.Rows[rowindex].Cells[2].Value.ToString();
            txtUsuario.Text = dgv.Rows[rowindex].Cells[4].Value.ToString();
            txtSenha.Text = dgv.Rows[rowindex].Cells[5].Value.ToString();
            maskedAcesso.Text = dgv.Rows[rowindex].Cells[7].Value.ToString();
            maskedCadastro.Text = dgv.Rows[rowindex].Cells[6].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void chkAtivo_CheckedChanged(object sender, EventArgs e)
        {
            CarregarGrid();
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
                    sql = "SELECT q.rm_aluno, q.NOME, p.LOGIN,p.Senha,q.CADASTRO,q.ULTIMOACESSO,q.STATUS FROM SistemaP.DBO.TB_aluno AS q INNER JOIN SistemaP.DBO.TB_USER AS p on q.LOGIN = p.LOGIN where q.status =0";

                }
                else if (chkAtivo.Checked == true)
                {
                    sql = "SELECT q.rm_aluno, q.NOME, p.LOGIN,p.Senha,q.CADASTRO,q.ULTIMOACESSO,q.STATUS FROM SistemaP.DBO.tb_aluno AS q INNER JOIN SistemaP.DBO.TB_USER AS p on q.LOGIN = p.LOGIN where q.status =1";

                }
                else
                {
                    sql = "SELECT q.rm_aluno, q.NOME, p.LOGIN,p.Senha,q.CADASTRO,q.ULTIMOACESSO,q.STATUS FROM SistemaP.DBO.tb_aluno AS q INNER JOIN SistemaP.DBO.TB_USER AS p on q.LOGIN = p.LOGIN";
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

        private void chkInativo_CheckedChanged(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void txtRM_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedCadastro_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedAcesso_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
