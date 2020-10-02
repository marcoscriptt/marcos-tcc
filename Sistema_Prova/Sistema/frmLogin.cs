using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using System.Windows.Forms;

namespace Sistema_Prova.Sistema
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {

            InitializeComponent();
        }

        private string _TextoTeste;
        public String TextoTeste
        {
            get { return _TextoTeste; }
            set { _TextoTeste = value; }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void mostrarSenha(Object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                this.txtSenha.PasswordChar = '\0';

            }
            else
            {
                this.txtSenha.PasswordChar = '*';

            }
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








        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Logar(Object o, EventArgs e)
        {
            try
            {
                if (this.txtUsuario.Text.Length > 2 && this.txtSenha.Text.Length > 2)
                {
                    BDC.Login log = new BDC.Login();
                    log.Usuario = this.txtUsuario.Text.ToUpper();
                    log.Senha = this.txtSenha.Text.ToUpper();
                    TextoTeste = this.txtUsuario.Text.ToUpper();
                    //log.Usuario = this.txtUsuario.Text;
                    //log.Senha = this.txtSenha.Text;
                    //  TextoTeste = txtUsuario.Text;
                    if (log.Logar())
                    {

                        if (log.Status == 1)
                        {

                            if (log.IdNivelAcesso == 1)
                            {
                                Sistema.frmTrocarSenha trocar = new frmTrocarSenha();

                                Sistema.frmSistemaAdm fsys = new Sistema.frmSistemaAdm();
                                fsys.TextoTeste = txtUsuario.Text;
                                if (txtSenha.Text == "123456")
                                {
                                    trocar.LBLTEXTO.Text = "PARA O ACESSO AO SISTEMA, DIGITE UMA SENHA (NÃO A ESQUEÇA POIS IRÁ PRECISAR DELA PARA USOS FUTUROS DESTE SISTEMA";
                                    trocar.label1.Visible = false;
                                    trocar.TextoTeste = txtUsuario.Text;
                                    trocar.txtAntiga.Visible = false;
                                    trocar.btnSair.Visible = false;
                                    trocar.nivel = 1;

                                    trocar.ShowDialog();

                                }
                                trocar.Close();
                                fsys.ShowDialog();
                            }

                            if (log.IdNivelAcesso == 3)
                            {
                                Sistema.frmTrocarSenha trocar = new frmTrocarSenha();

                                Sistema.frmSistemaAlu fsys = new Sistema.frmSistemaAlu();
                                fsys.TextoTeste = txtUsuario.Text;

                                if (txtSenha.Text == "123456")
                                {
                                    trocar.LBLTEXTO.Text = "PARA O ACESSO AO SISTEMA, DIGITE UMA SENHA (NÃO A ESQUEÇA POIS IRÁ PRECISAR DELA PARA USOS FUTUROS DESTE SISTEMA";
                                    trocar.label1.Visible = false;
                                    trocar.TextoTeste = txtUsuario.Text;
                                    trocar.txtAntiga.Visible = false;
                                    trocar.btnSair.Visible = false;
                                    trocar.nivel = 1;

                                    trocar.ShowDialog();

                                }
                                trocar.Close();
                                fsys.ShowDialog();
                            }

                            if (log.IdNivelAcesso == 2)
                            {
                                Sistema.frmTrocarSenha trocar = new frmTrocarSenha();

                                Sistema.frmSistemaProf prof = new Sistema.frmSistemaProf();

                                prof.TextoTeste = txtUsuario.Text;


                                if (txtSenha.Text.Equals("123456"))
                                {

                                    trocar.LBLTEXTO.Text = "PARA O ACESSO AO SISTEMA, DIGITE UMA SENHA (NÃO A ESQUEÇA POIS IRÁ PRECISAR DELA PARA USOS FUTUROS DESTE SISTEMA)";
                                    trocar.label1.Visible = false;
                                    trocar.TextoTeste = txtUsuario.Text;
                                    trocar.txtAntiga.Visible = false;
                                    trocar.btnSair.Visible = false;
                                    trocar.nivel = 1;

                                    trocar.ShowDialog();
                                }

                                trocar.Close();
                                prof.ShowDialog();

                            }


                        }
                        else
                        {
                            MessageBox.Show("DESCULPE, MAS ESTE USUARIO ESTÁ DESATIVADO. POR FAVOR, CONTATE OS ADMINISTRADORES");
                        }

                        //this.Hide();
                        Application.Exit();



                        //if (log.IdNvlAcesso != 1)
                        //{

                        //}

                    }
                    else
                    {
                        this.erro.SetError(this.txtUsuario, "Usuario inexistente/Senha incorreta");
                        this.txtSenha.Clear(); this.txtUsuario.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Verifique o preenchimento dos campos"); this.txtSenha.Clear();
                    this.txtUsuario.Focus();
                }



            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw ex;
            }

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
