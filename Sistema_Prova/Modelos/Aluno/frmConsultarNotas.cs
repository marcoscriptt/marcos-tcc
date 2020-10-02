using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Sistema_Prova.Modelos.Aluno
{
    public partial class frmConsultarNotas : Form
    {
        public frmConsultarNotas()
        {
            InitializeComponent();
        }


        private String _TextoTeste;

        public String TextoTeste
        {
            get { return _TextoTeste; }
            set { _TextoTeste = value; }
        }


        public DataTable Select()
        {
            String conn1 =
      @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";

            SqlConnection conn = new SqlConnection(conn1);
            DataTable dt = new DataTable();
            try
            {


                string sql = "SELECT A.RM_ALUNO ,A.NOME, A.NUM_CHAMADA ,T.TURMA_ALU, N.PROVA, N.NOTA  FROM  SistemaP.DBO.TBNOTAS_ALUNO N RIGHT OUTER JOIN SistemaP.DBO.TB_ALUNO A ON N.RM_ALUNO = A.RM_ALUNO INNER JOIN SistemaP.DBO.TB_TURMA T ON A.ID_TURMA = T.ID_TURMA WHERE TURMA_ALU ='"+ TextoTeste +"';";
           

            
                //ARRUMAR SA CACETA


                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return dt;
        }
        private void frmConsultarNotas_Load(object sender, EventArgs e)
        {


            Select();
            try
            {
                this.dgv.Columns[0].HeaderText = "RM";
                this.dgv.Columns[1].HeaderText = "ALUNO";
                this.dgv.Columns[2].HeaderText = "Nº CHAMADA";
                this.dgv.Columns[3].HeaderText = "TURMA";
                this.dgv.Columns[4].HeaderText = "PROVA";
                this.dgv.Columns[5].HeaderText = "NOTA"; 
                BDC.Turma tu = new BDC.Turma();

           

                //------------------------------------

                BDC.Prova tu2 = new BDC.Prova();

                comboBox1.DataSource = tu2.Listar("").Tables[0];
                comboBox1.DisplayMember = "prova";
                comboBox1.ValueMember = "idprova";
                comboBox1.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }

        }


        private void CarregarGrid()
        {
            try
            {

                BDC.Notas alu = new BDC.Notas();
                this.dgv.DataSource = alu.Listar(this.txtPesquisa.Text, this.comboBox1.Text).Tables[0];
                this.dgv.Columns[0].HeaderText = "ALUNO";
                this.dgv.Columns[1].HeaderText = "Nº CHAMADA";
                this.dgv.Columns[2].HeaderText = "TURMA";
                this.dgv.Columns[3].HeaderText = "PROVA";
                this.dgv.Columns[4].HeaderText = "NOTA";

                this.dgv.AutoResizeColumn(1);

                this.txtPesquisa.Focus();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar" + ex.Message);
                //throw;
            }

        }























        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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

        private void txtPesquisa_TextChanged_1(object sender, EventArgs e)
        {
            try
            {


                String conn1 =
                       @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";
                string keyword = txtPesquisa.Text;
                string sql = "SELECT A.RM_ALUNO ,A.NOME, A.NUM_CHAMADA ,T.TURMA_ALU, N.PROVA, N.NOTA  FROM  SistemaP.DBO.TBNOTAS_ALUNO N RIGHT OUTER JOIN SistemaP.DBO.TB_ALUNO A ON N.RM_ALUNO = A.RM_ALUNO INNER JOIN SistemaP.DBO.TB_TURMA T ON A.ID_TURMA = T.ID_TURMA where TURMA_ALU ='" + TextoTeste + "' AND A.nome like'%" + keyword + "%'";


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

        private void cbTurma_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbTurma_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == null)
                {
                    MessageBox.Show("VOCÊ PRECISA SELECIONAR UMA PROVA");
                    return;
                }

                else
                {

                    string keyword = txtPesquisa.Text;


                    string sql = "SELECT A.RM_ALUNO,A.NUM_CHAMADA, A.NOME , N.PROVA, N.NOTA , T.TURMA_ALU FROM  TBNOTAS_ALUNO N RIGHT OUTER JOIN TB_ALUNO A ON N.RM_ALUNO = A.RM_ALUNO INNER JOIN TB_TURMA T ON A.ID_TURMA = T.ID_TURMA where T.TURMA_ALU like'%" + TextoTeste + "%' AND A.nome like'%" + keyword + "%' AND N.PROVA like'%" + comboBox1.Text + "%'";

                    if (comboBox1.Text == "NENHUM")
                    {
                        sql = "SELECT A.RM_ALUNO,A.NUM_CHAMADA, A.NOME , N.PROVA, N.NOTA , T.TURMA_ALU FROM  TBNOTAS_ALUNO N RIGHT OUTER JOIN TB_ALUNO A ON N.RM_ALUNO = A.RM_ALUNO INNER JOIN TB_TURMA T ON A.ID_TURMA = T.ID_TURMA where T.TURMA_ALU like'%" + TextoTeste + "%' AND A.nome like'%" + keyword + "%' AND N.PROVA like'%" + "" + "%'";
                    }
                    else
                    {
                        String conn1 =
                               @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";



                        SqlConnection conn = new SqlConnection(conn1);
                        SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dgv.DataSource = dt;

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            txtPesquisa.Text = null;
            comboBox1.SelectedIndex = -1;

        }
    }
}

