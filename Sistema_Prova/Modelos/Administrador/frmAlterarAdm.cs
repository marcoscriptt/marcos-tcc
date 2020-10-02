﻿using System;
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
    public partial class frmAlterarAdm : Form
    {

        private static
                string strConexaoOra =
            @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";
       
        public frmAlterarAdm()
        {
            InitializeComponent();
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
                string SQLLogin = "UPDATE SistemaP.DBO.tb_user SET id_acesso = '" + IdNivelAcesso + "',  Senha = '" + Senha + "' WHERE login='" + Usuario + "' ";
               


                SqlCommand commLogin = new SqlCommand(SQLLogin, connLogin);
                int y = commLogin.ExecuteNonQuery();
                connLogin.Close();

                SqlConnection conn = new SqlConnection(strConexaoOra);
                conn.Open();
                string SQL = "UPDATE SistemaP.DBO.TB_ADMIN SET NOME = '" + Nome + "', CADASTRO ='" + DataCadastro + "' , ULTIMOACESSO = '" + DataAcesso + "', status = '" + Ativo + "' WHERE RM_ADMIN = " + Rm;

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

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void maskedA2cesso_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void frmAlterarAdm_Load(object sender, EventArgs e)
        {

        }



        // MÉTODO SALVAR, MAS COM O MÉTODO ADM.ALTERAR();



    }
}
