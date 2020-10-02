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

namespace Sistema_Prova.Sistema
{
    public partial class frmTrocarSenha : Form
    {
        public frmTrocarSenha()
        {
            InitializeComponent();


        }


        private static
              string strConexaoOra =
          @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";

        private string _TextoTeste;

        public String TextoTeste
        {
            get { return _TextoTeste; }
            set { _TextoTeste = value; }
        }

        private int _nivel;

        public int nivel
        {
            get { return _nivel; }
            set { _nivel = value; }
        }


        private void AlterarSenha(object sender, EventArgs e)
        {
            try
            {
                if (nivel == 1)
                {
                    if (this.txtNova.Text == String.Empty)
                    {
                        this.erro.SetError(this.txtAntiga, "Campo obrigatório");
                        this.txtAntiga.Focus();
                        txtNova.Clear();
                        txtNova2.Clear();
                        return;
                    }
                    
                        if (this.txtNova2.Text == String.Empty)
                        {
                            this.erro.SetError(this.txtNova2, "Campo obrigatório");
                            this.txtAntiga.Focus();
                            txtNova.Clear();
                            txtNova2.Clear();


                        }

                        if (txtNova2.Text.Length < 8)
                        {
                         this.erro.SetError(this.txtNova2, "A senha deve conter no mínimo 8 caracteres");
                         return;
                        }

                    if (txtNova.Text == txtNova2.Text)
                    {

                        string senha = txtNova2.Text;
                        string Login = TextoTeste.ToUpper();


                        SqlConnection connLogin = new SqlConnection(strConexaoOra);
                        connLogin.Open();
                        string SQLLogin = "UPDATE SistemaP.DBO.TB_USER SET SENHA = '" + senha + "' WHERE Login = '" + Login + "' ";



                        SqlCommand commLogin = new SqlCommand(SQLLogin, connLogin);
                        int y = commLogin.ExecuteNonQuery();
                        if (y == 1)
                        {
                            MessageBox.Show("SUA SENHA FOI ALTERADA COM SUCESSO!");
                            this.Close();
                        }
                    
                        connLogin.Close();
                    }
                    else
                    {
                        MessageBox.Show("AS SENHAS SÃO DIFERENTES, TENTE NOVAMENTE!");
                    }








                }
                else
                {






                    if (this.txtAntiga.Text == String.Empty)
                    {
                        this.erro.SetError(this.txtAntiga, "Campo obrigatório");
                        this.txtAntiga.Focus();
                        txtNova.Clear();
                        txtNova2.Clear();
                        return;


                    }
                    if (this.txtNova.Text == String.Empty)
                    {
                        this.erro.SetError(this.txtAntiga, "Campo obrigatório");
                        this.txtAntiga.Focus();
                        txtNova.Clear();
                        txtNova2.Clear();
                        return;
                    }
                    

                        if (this.txtNova2.Text == String.Empty)
                        {
                            this.erro.SetError(this.txtNova2, "Campo obrigatório");
                            this.txtAntiga.Focus();
                            txtNova.Clear();
                            txtNova2.Clear();


                        }


                        if (txtNova2.Text.Length < 8)
                        {
                            this.erro.SetError(this.txtNova2, "A senha deve conter no mínimo 8 caracteres");
                            return;
                        }
 
                    //if (txtNova!=txtNova2)
                    //{

                    //    this.erro.SetError(this.txtNova2, "As senhas nao coinscidem");
                    //    this.erro.SetError(this.txtNova2, "As senhas nao coinscidem");
                    //    this.txtAntiga.Focus();

                    //    return;

                    //}
                    //else
                    //{


                    //  TextoTeste = frmlog2.TextoTeste;


                    if (txtNova.Text == txtNova2.Text)
                    {

                        string senha = txtNova2.Text;
                        string Login = TextoTeste.ToUpper();


                        SqlConnection connLogin = new SqlConnection(strConexaoOra);
                        connLogin.Open();
                        string SQLLogin = "UPDATE SistemaP.DBO.TB_USER SET SENHA = '" + senha + "' WHERE Login = '" + Login + "' ";



                        SqlCommand commLogin = new SqlCommand(SQLLogin, connLogin);
                        int y = commLogin.ExecuteNonQuery();
                        if (y == 1)
                        {
                            MessageBox.Show("SUA SENHA FOI ALTERADA COM SUCESSO!");
                        }
                        connLogin.Close();
                    }
                    else
                    {
                        MessageBox.Show("As senhas são diferentes, tente novamente!");
                    }



                }
            }





            //}



            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          string message = "DESEJA MESMO SAIR?";
        }

        private void frmTrocarSenha_Load(object sender, EventArgs e)
        {

        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
          string message = "DESEJA MESMO SAIR?";
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
    }
}
