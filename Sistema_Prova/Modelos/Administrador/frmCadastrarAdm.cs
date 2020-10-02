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


namespace Sistema_Prova.Modelos.Administrador
{
    public partial class frmCadastrarAdm : Form
    {
        public frmCadastrarAdm()
        {
            InitializeComponent();
            txtUsuario.Enabled = false;
            maskedCadastro.Enabled = false;
            maskedAcesso.Enabled = false;
            maskedAcesso.Text = Convert.ToString(System.DateTime.Today);
            maskedCadastro.Text = Convert.ToString(System.DateTime.Today);

        }


        private static
                string strConexaoOra =
             @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";

        private void proximoControle(System.Windows.Forms.KeyPressEventArgs e)
        {

            //if (e.KeyChar == (char)13)
            //{
            //    SendKeys.Send("{TAB}");
            //}
        }

        private void proximoControle(object o, KeyPressEventArgs e)
        {
            proximoControle(e);
        }



        private void Limpar()
        {
            try
            {
                this.txtNome.Text = null;
                this.txtSenha.Text = null;
                this.txtUsuario.Text = null;
                this.txtRM.Text = null;

                this.txtNome.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ", ex.Message);
                //throw;
            }


        }

        private void LimparC()
        {
            string message = "deseja limpar tudo?";
            string caption = "Error detected in imput";
            DialogResult result;
            MessageBoxButtons button = MessageBoxButtons.YesNo;

            result = MessageBox.Show(message, caption, button);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Limpar();
            }


        }

        private void Limpar(object sender, EventArgs e)
        {
            try
            {
                LimparC();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ", ex.Message);
                //throw;
            }
            txtSenha.Text = "123456";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
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

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void Cadastrar2(object sender, EventArgs e)
        {

        }


        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Enter(object sender, EventArgs e)
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



                Ativo = 1;



                IdNivelAcesso = 1;

                Usuario = this.txtUsuario.Text;

                Senha = this.txtSenha.Text;




                SqlConnection connLogin = new SqlConnection(strConexaoOra);
                connLogin.Open();
                string SQLLogin = "insert  SistemaP.DBO.tb_user values ('" + Usuario + "', '" + Senha + "','" + IdNivelAcesso + "','1')";



                SqlCommand commLogin = new SqlCommand(SQLLogin, connLogin);
                int y = commLogin.ExecuteNonQuery();


                SqlConnection conn = new SqlConnection(strConexaoOra);
                conn.Open();
                string SQL = "INSERT  SistemaP.DBO.TB_ADMIN (RM_ADMIN, NOME,login ,  ULTIMOACESSO, CADASTRO, STATUS) VALUES ('" + Rm + "', '" + Nome + "', '" + Usuario + "','" + DataAcesso + "','" + DataCadastro + "', '" + Ativo + "')";

                SqlCommand comm = new SqlCommand(SQL, conn);
                int x = comm.ExecuteNonQuery();
                if (x == 1)
                {
                    MessageBox.Show("Cadastrado do ADM com Sucesso");
                }

                Limpar();


                conn.Close();
                connLogin.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != string.Empty || txtRM.Text != string.Empty)
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

        private void frmCadastrarAdm_Load(object sender, EventArgs e)
        {
            txtSenha.Text = "123456";
        }

        private void txtRM_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BDC.Administrador adm1 = new BDC.Administrador();

            SqlDataReader dr;
            adm1.Rm = Convert.ToInt32(txtRM.Text);
            dr = adm1.ConsultarRm();
            dr.Read();

            if (dr.HasRows)
            {


                MessageBox.Show("ESTE USUÁRIO JÁ EXISTE");
                this.txtNome.Text = null;
                this.txtUsuario.Text = null;
                this.txtRM.Text = null;

                this.txtNome.Focus();
            }

            else
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



                    Ativo = 1;



                    IdNivelAcesso = 1;

                    Usuario = this.txtUsuario.Text;

                    Senha = this.txtSenha.Text.ToUpper();




                    SqlConnection connLogin = new SqlConnection(strConexaoOra);
                    connLogin.Open();
                    string SQLLogin = "insert  SistemaP.DBO.tb_user values ('" + Usuario.ToUpper() + "', '" + Senha.ToUpper() + "','" + IdNivelAcesso + "','1')";



                    SqlCommand commLogin = new SqlCommand(SQLLogin, connLogin);
                    int y = commLogin.ExecuteNonQuery();


                    SqlConnection conn = new SqlConnection(strConexaoOra);
                    conn.Open();
                    string SQL = "INSERT  SistemaP.DBO.TB_ADMIN (RM_ADMIN, NOME,login ,  ULTIMOACESSO, CADASTRO, STATUS) VALUES ('" + Rm + "', '" + Nome.ToUpper() + "', '" + Usuario.ToUpper() + "','" + DataAcesso + "','" + DataCadastro + "', '" + Ativo + "')";

                    SqlCommand comm = new SqlCommand(SQL, conn);
                    int x = comm.ExecuteNonQuery();
                    if (x == 1)
                    {
                        MessageBox.Show("Cadastrado do ADM com Sucesso");
                    }

                    Limpar();




                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //throw;
                }
            }

        }

        //private void Cadastrar(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (this.txtNome.Text == String.Empty)
        //        {
        //            this.erro.SetError(this.txtNome, "Campo obrigatório");
        //            this.txtNome.Focus();
        //            return;
        //        }
        //        if (this.txtRM.Text == String.Empty)
        //        {
        //            this.erro.SetError(this.txtRM, "Campo obrigatório");
        //            this.txtRM.Focus();
        //            return;
        //        }
        //        if (this.txtSenha.Text == String.Empty)
        //        {
        //            this.erro.SetError(this.txtSenha, "Erro no preenchimento do campo");
        //            this.txtSenha.Focus();
        //            return;
        //        }

        //        //Atribuir os valores dos das caixas nas variaveis
        //        BDC.Administrador adm = new BDC.Administrador();
        //        BDC.Login objLogin = new BDC.Login();

        //        //SqlDataReader dr;
        //        //dr = adm.Consultar();
        //        adm.DataCadastro = maskedCadastro.Text;
        //        adm.DataAcesso = maskedAcesso.Text;

        //        adm.Rm = Convert.ToInt32(this.txtRM.Text);

        //        adm.Nome = this.txtNome.Text;
        //        //if (dr["COD_FUNCIONARIO"] )
        //        //{
        //        if (chkAtivo.Enabled == true)
        //        {

        //            adm.Ativo = 1;

        //            //Executa o metodo de inserção
        //            // objLogin.Incluir();
        //        }
        //        else
        //        {
        //            adm.Ativo = 0;
        //        }
        //        //}
        //        if (checkLogin.Enabled == true)
        //        {

        //            objLogin.Usuario = this.txtUsuario.Text;
        //            objLogin.Senha = this.txtSenha.Text;
        //            objLogin.IdNivelAcesso = 1;

        //            //Executa o metodo de inserção
        //            // objLogin.Incluir();
        //        }

        //        // adm.IncluirStore();
        //        //    objLogin.IncluirStore();
        //        adm.Incluir();
        //        objLogin.Incluir();
        //        Limpar();
        //        MessageBox.Show("ADMIN CADASTRADO COM SUCESSO!");



        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        //throw;
        //    }

        //}
    }
}
