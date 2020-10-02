using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sistema_Prova.Modelos.Aluno
{
    public partial class frmCadastrarAlu : Form
    {
        public frmCadastrarAlu()
        {
            InitializeComponent();
            txtUsuario.Enabled = false;
            maskedCadastro.Enabled = false;
            maskedAcesso.Enabled = false;
            maskedAcesso.Text = Convert.ToString(System.DateTime.Today);
            maskedCadastro.Text = Convert.ToString(System.DateTime.Today);

        }


        //private static
        //        string strConexaoOra =
        //    @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";

        private static
                string strConexaoOra =
                @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";


        private void proximoControle(System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
            }
        }


        private void proximoControle(object o, KeyPressEventArgs e)
        {
            proximoControle(e);
        }

        private void Cadastrar(object sender, EventArgs e)
        {
             BDC.Aluno aluno1 = new BDC.Aluno();

            SqlDataReader dr2;
            aluno1.Rm = Convert.ToInt32(txtRM.Text);
            dr2 = aluno1.Consultar();
            dr2.Read();

            if (dr2.HasRows)
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

                    string Usuario = "";

                    string Senha = "";


                    string Turma = cbTurma.Text;
                    SqlDataReader dr;
                    turma.TurmaAlu = Turma;
                    dr = turma.Consultar5();

                    dr.Read();


                    string NumChamada = Chamada.Text;

                    string DataCadastro = maskedCadastro.Text;
                    string DataAcesso = maskedAcesso.Text;
                    int Turma2 = Convert.ToInt32(dr["ID_TURMA"]);
                    int Rm = Convert.ToInt32(this.txtRM.Text);
                    string Nome = this.txtNome.Text;

                    int Ativo;

                    if (txtSenha.Text == null)
                    {
                        Senha = "123456";
                    }
                    else
                    {
                        Senha = this.txtSenha.Text;
                    }

                    Ativo = 1;

                    IdNivelAcesso = 3;

                    Usuario = txtUsuario.Text;



                    SqlConnection connLogin = new SqlConnection(strConexaoOra);
                    connLogin.Open();
                    string SQLLogin = "insert  SistemaP.DBO.tb_user values ('" + Usuario.ToUpper() + "', '" + Senha.ToUpper() + "','" + IdNivelAcesso + "','1')";



                    SqlCommand commLogin = new SqlCommand(SQLLogin, connLogin);
                    int y = commLogin.ExecuteNonQuery();


                    SqlConnection conn = new SqlConnection(strConexaoOra);
                    conn.Open();
                    string SQL = "INSERT INTO SistemaP.DBO.tb_aluno (RM_Aluno, NOME, login,  ULTIMOACESSO, CADASTRO,ID_TURMA, NUM_CHAMADA, STATUS) VALUES ('" + Rm + "', '" + Nome.ToUpper() + "','" + Usuario.ToUpper() + "','" + DataAcesso + "','" + DataCadastro + "',  '" + Turma2 + "','" + NumChamada + "','" + Ativo + "')";

                    SqlCommand comm = new SqlCommand(SQL, conn);
                    int x = comm.ExecuteNonQuery();
                    if (x == 1)
                    {
                        MessageBox.Show("Cadastrado do ALUNO com Sucesso");
                    }

                    Limpar();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //throw;
                }
            }
            this.cbTurma.SelectedIndex = -1;
            this.txtSenha.Text = "123456";
        }

        private void Limpar()
        {
            try
            {
                this.txtNome.Text = null;
                this.txtSenha.Text = null;
                this.txtUsuario.Text = null;
                this.txtRM.Text = null;
                this.Chamada.Text = null;
                this.cbTurma.SelectedIndex = -1;
                // this.comboTurma.Text = null;


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



        //public DataTable GetTurma()
        //{
        //    DataTable dataUf = new DataTable("tb_turma");
        //    SqlConnection Connection = new SqlConnection(strConexaoOra);
        //    SqlCommand Command = new SqlCommand("SELECT * FROM SistemaP.DBO.TB_TURMA", Connection);

        //    Connection.Open();
        //    dataUf.Load(Command.ExecuteReader());

        //    return dataUf;
        //}


        private void comboTurma_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        //private void frmCadastrarAlu_Load(object o, EventArgs e)
        //{
        //    //try
        //    //{

        //    //    BDC.Turma a = new BDC.Turma();
        //    //    comboTurma.DataSource = a.Consultar();
        //    //    comboTurma.ValueMember = "ID_TURMA";
        //    //    comboTurma.DisplayMember = "TURMA_ALU";
        //    //    comboTurma.SelectedIndex = -1;
        //    //    //comboTurma.Refresh();
        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    MessageBox.Show(ex.Message);
        //    //    //throw;
        //    //}

        //    carerregarcb(o, e);
        //}





        private void CarregarCboTurma(Object o, EventArgs e)
        {
            txtSenha.Text = "123456"; 
            try
            {
                BDC.Turma tu = new BDC.Turma();

                cbTurma.DataSource = tu.Listar("").Tables[0];
                cbTurma.DisplayMember = "turma_alu";
                cbTurma.ValueMember = "id_turma";
                cbTurma.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbTurma_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void cbTurma_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            {
                if (txtNome.Text != string.Empty || txtRM.Text != string.Empty || txtSenha.Text != string.Empty)
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




            //private void CarregarCboResidente()
            //{
            //    try
            //    {
            //   //     string strConexaoOra =
            //   //"Data Source=DESKTOP-HKS0009;Initial Catalog=SistemaP;User ID=equipe7;Password=123456;Language=Portuguese";

            //   //     //define a instrução Sql
            //   //     string strSql = "SELECT * FROM SistemaP.DBO.tb_turma";

            //   //     //cria a conexão com o banco de dados
            //   //     SqlConnection con = new SqlConnection(strConexaoOra);
            //   //     //cria o objeto command para executar a instruçao Sql
            //   //     SqlCommand cmd = new SqlCommand(strSql, con);

            //   //     //abre a conexao
            //   //     con.Open();

            //   //     //define o tipo do comando 
            //   //     cmd.CommandType = CommandType.Text;
            //   //     //cria um dataadapter
            //   //     SqlDataAdapter da = new SqlDataAdapter(cmd);

            //   //     //cria um objeto datatable
            //   //     DataTable tb_admin = new DataTable();

            //   //     //preenche o datatable via dataadapter
            //   //     da.Fill(tb_admin);

            //   //     //atribui o datatable ao datagridview para exibir o resultado

            //   //     this.comboTurma.DataSource = tb_admin;

            //   //     this.comboTurma.DisplayMember = "turma_alu";
            //   //     this.comboTurma.ValueMember = "id_turma";
            //   //     comboTurma.SelectedIndex = -1;
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //}
















        }
    }
}
