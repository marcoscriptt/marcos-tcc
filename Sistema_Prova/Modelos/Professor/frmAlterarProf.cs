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

namespace Sistema_Prova.Modelos.Professor
{
    public partial class frmAlterarProf : Form
    {


        private static
             string strConexaoOra =
         @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";







        public frmAlterarProf()
        {
            InitializeComponent();
            txtUsuario.Enabled = false;
            maskedCadastro.Enabled = false;
            maskedAcesso.Enabled = false;

        }
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
                BDC.Professor adm = new BDC.Professor();
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
                string SQLLogin = "UPDATE SistemaP.DBO.tb_user SET Nivel_acesso = '" + IdNivelAcesso + "',  Senha = '" + Senha + "' WHERE login='" + Usuario + "' ";



                SqlCommand commLogin = new SqlCommand(SQLLogin, connLogin);
                int y = commLogin.ExecuteNonQuery();


                SqlConnection conn = new SqlConnection(strConexaoOra);
                conn.Open();
                string SQL = "UPDATE SistemaP.DBO.tb_prof SET NOME = '" + Nome + "', , CADASTRO ='" + DataCadastro + "' , ULTIMOACESSO = '" + DataAcesso + "', status = '" + Ativo + "' WHERE rm_professor = " + Rm;

                SqlCommand comm = new SqlCommand(SQL, conn);
                int x = comm.ExecuteNonQuery();
                if (x == 1)
                {
                    MessageBox.Show("alteraçao do prof com Sucesso");
                }

              foreach (var item in checkedListBox1.CheckedItems)
	{

	
                    SqlConnection conn2 = new SqlConnection(strConexaoOra);
                    conn.Open();
                    string SQL2 = "update SistemaP.DBO.PROF_MATERIA set materia_prof = '" + item.ToString() + "' where RM_Professor = '" + Rm + "' );";

                    SqlCommand comm2 = new SqlCommand(SQL2, conn2);
                    int z = comm.ExecuteNonQuery();
                    if (z == 1)
                    {
                        MessageBox.Show("cadastro do prof com Sucesso");
                    }
                }











                MessageBox.Show("prof ALTERADO COM SUCESSO!");



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }

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


        private void PassarTxt(object o, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmAlterarProf_Load(object sender, EventArgs e)
        {

            //try
            //{
            //    BDC.Professor a = new BDC.Professor();


            //    checkedListBox1.DataSource = a.Listar("").Tables[0];
            //    checkedListBox1.DisplayMember = "materia_prof";
                
            //}

            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "ERRO>>>>>");

            //    //  throw ex;
            //}
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
