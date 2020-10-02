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

namespace Sistema_Prova.Modelos.Materia
{
    public partial class frmAlterarMat : Form
    {
        public frmAlterarMat()
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
            SqlDataReader dr2;
            BDC.Materia materia = new BDC.Materia();
            materia.MateriaProf = Convert.ToString(txtNome.Text);
            dr2 = materia.Consultar10();
            dr2.Read();

            if (dr2.HasRows)
            {

                MessageBox.Show("ESTA MATÉRIA JÁ EXISTE");
                this.txtNome.Text = null;

                this.txtNome.Focus();
            }

            else
            {
                try
                {
                    string MateriaProf = txtNome.Text;

                    string IdMateria = txtCod.Text;

                    int Ativo;


                    SqlConnection conn = new SqlConnection(strConexaoOra);
                    conn.Open();
                    String SQL = "UPDATE SistemaP.DBO.tb_materia SET materia_prof = '" + MateriaProf.ToUpper() + "' WHERE id_materia = " + IdMateria;

                    SqlCommand comm = new SqlCommand(SQL, conn);
                    int x = comm.ExecuteNonQuery();
                    if (x == 1)
                    {
                        MessageBox.Show("MATEIRA ALTERADA COM SUCESSO!");
                        frmConsultarMat a = new frmConsultarMat();
                        a.Select();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    // throw;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAlterarMat_Load(object sender, EventArgs e)
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
            }
        }





    }
}
