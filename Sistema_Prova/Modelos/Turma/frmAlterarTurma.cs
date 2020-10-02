using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;  using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sistema_Prova.Modelos.Turma
{
    public partial class frmAlterarTurma : Form
    {
        public frmAlterarTurma()
        {
            InitializeComponent();
        }


        private static
                string strConexaoOra =
            @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";


        private void Limpar()
        {
            try
            {
                this.txtNome.Text = null;


                this.txtNome.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ", ex.Message);
                //throw;
            }


        }



        private void cadastrar(object sender, EventArgs e)
        {
             BDC.Turma turma = new BDC.Turma();

            SqlDataReader dr2;
            turma.TurmaAlu = Convert.ToString(txtNome.Text);
            dr2 = turma.Consultar10();
            dr2.Read();

            if (dr2.HasRows)
            {


                MessageBox.Show("ESTA TURMA JÁ EXISTE");
                this.txtNome.Text = null;

                this.txtNome.Focus();
            }

            else
            {
                try
                {
                    String TurmaAlu = txtNome.Text;

                    String IdTurma = txtCod.Text;

                    int Ativo;



                    SqlConnection conn = new SqlConnection(strConexaoOra);
                    conn.Open();
                    String SQL = "UPDATE SistemaP.DBO.tb_turma SET turma_alu = '" + TurmaAlu.ToUpper() + "' WHERE id_turma = " + IdTurma;

                    SqlCommand comm = new SqlCommand(SQL, conn);
                    int x = comm.ExecuteNonQuery();
                    if (x == 1)
                    {
                        MessageBox.Show("TURMA ALTERADA COM SUCESSO!");
                        frmConsultarTurma a = new frmConsultarTurma();
                        a.Select();
                    }
                }
                catch (Exception ex)
                {
                    ;
                    MessageBox.Show(ex.Message);
                    // throw;
                }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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







    }
}
