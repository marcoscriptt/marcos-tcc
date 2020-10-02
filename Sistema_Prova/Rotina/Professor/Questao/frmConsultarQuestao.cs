using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Prova.Rotina.Professor.Questao
{
    public partial class frmConsultarQuestao : Form
    {
        public frmConsultarQuestao()
        {
            InitializeComponent();
        }

        private string _TextoTeste;
        public String TextoTeste
        {
            get { return _TextoTeste; }
            set { _TextoTeste = value; }
        }


        private static
         string strConexaoOra =
       @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void frmConsultarQuestao_Load(object sender, EventArgs e)
        {
            BDC.Materia tu = new BDC.Materia();

            cboMateria.DataSource = tu.Listar("").Tables[0];
            cboMateria.DisplayMember = "MATERIA_PROF";
            cboMateria.ValueMember = "ID_MATERIA";
            cboMateria.SelectedIndex = -1;

            txtMateria.DataSource = tu.Listar("").Tables[0];
            txtMateria.DisplayMember = "MATERIA_PROF";
            txtMateria.ValueMember = "ID_MATERIA";
            txtMateria.SelectedIndex = -1;

            label2.Text = "Resposta" + Environment.NewLine + " Incorreta";

            label3.Text = "Resposta" + Environment.NewLine + " Incorreta";

            label5.Text = "Resposta" + Environment.NewLine + " Incorreta";

            label6.Text = "Resposta" + Environment.NewLine + " Incorreta";

            label7.Text = "Resposta" + Environment.NewLine + " correta";


            CarregarGridQues();
        }

        private void CarregarGridQues()
        {
            BDC.Questoes adm = new BDC.Questoes();
            try
            {
                String conn1 =
                @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";

                string sql = "select IDQUESTAO, titulo,etiqueta,materia, questao, RESPOSTAA,RESPOSTAb,RESPOSTAc,RESPOSTAd,RESPOSTAcerta from SistemaP.DBO.TBQUESTAO ";



                SqlConnection conn = new SqlConnection(conn1);
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                conn.Open();
                adapter.Fill(dt);
                if (dt.Rows == null)
                {
                    MessageBox.Show("Não há registros");
                }
                else
                {
                    dgv.DataSource = dt;
                
                    }

                this.dgv.Columns[0].HeaderText = "ID";
                this.dgv.Columns[1].HeaderText = "TITULO";
                this.dgv.Columns[2].HeaderText = "ETIQUETA";
                this.dgv.Columns[3].HeaderText = "MATERIA";
                this.dgv.Columns[4].HeaderText = "QUESTÃO";
                this.dgv.Columns[5].HeaderText = "RESPOSTA 1";
                this.dgv.Columns[6].HeaderText = "RESPOSTA 2";
                this.dgv.Columns[7].HeaderText = "RESPOSTA 3";
                this.dgv.Columns[8].HeaderText = "RESPOSTA 4";
                this.dgv.Columns[9].HeaderText = "RESPOSTA CERTA";

            }
            catch (Exception)
            {

                throw;
            }
        }



        private void button8_Click(object sender, EventArgs e)
        {

            try
            {
                if (this.txtTitulo.Text == String.Empty)
                {
                    this.erro.SetError(this.txtTitulo, "Campo obrigatório");
                    this.txtTitulo.Focus();
                    return;
                }
                if (this.txtQuestao.Text == String.Empty)
                {
                    this.erro.SetError(this.txtQuestao, "Campo obrigatório");
                    this.txtQuestao.Focus();
                    return;
                }
                if (this.txtResp1.Text == String.Empty)
                {
                    this.erro.SetError(this.txtResp1, "Campo obrigatório");
                    this.txtResp1.Focus();
                    return;
                }

                if (this.txtResp2.Text == String.Empty)
                {
                    this.erro.SetError(this.txtResp2, "Campo obrigatório");
                    this.txtResp2.Focus();
                    return;
                }

                if (this.txtResp3.Text == String.Empty)
                {
                    this.erro.SetError(this.txtResp3, "Campo obrigatório");
                    this.txtResp3.Focus();
                    return;
                }

                if (this.txtResp4.Text == String.Empty)
                {
                    this.erro.SetError(this.txtResp4, "Campo obrigatório");
                    this.txtResp4.Focus();
                    return;
                }

                if (this.txtResp5.Text == String.Empty)
                {
                    this.erro.SetError(this.txtResp5, "Campo obrigatório");
                    this.txtResp5.Focus();
                    return;
                }

                BDC.Questoes q = new BDC.Questoes();

                String Titulo = txtTitulo.Text;

                String Questao = txtQuestao.Text;
                String RespostaA = txtResp1.Text;
                String RespostaB = txtResp2.Text;
                String RespostaC = txtResp3.Text;
                String RespostaD = txtResp4.Text;
                String RespostaCerta = txtResp5.Text;
                String Materia = txtMateria.Text;
                String Etiqueta = txtEquit.Text;

                // string IDQUESTAO = txtIdQuest.Text;



                //  PEGAR RM DO PROFESSOR DA TELA DE INICIO

                SqlConnection connLogin = new SqlConnection(strConexaoOra);
                connLogin.Open();
                string SQLLogin = "UPDATE SistemaP.DBO.tbQuestao SET TITULO = '" + Titulo + "', MATERIA = '" + Materia + "',ETIQUETA = '" + Etiqueta + "', QUESTAO ='" + Questao + "', RESPOSTAA = '" + RespostaA + "', RESPOSTAB =  '" + RespostaB + "', RESPOSTAC = '" + RespostaC + "', RESPOSTAD =  '" + RespostaD + "', RESPOSTACERTA =  '" + RespostaCerta + "' WHERE IDQUESTAO = '" + txtId.Text + "'";


                SqlCommand comm = new SqlCommand(SQLLogin, connLogin);
                int x = comm.ExecuteNonQuery();
                if (x == 1)
                {
                    MessageBox.Show("QUESTÃO ALTERADA COM SUCESSO!");
                    CarregarGridQues();
                }

                connLogin.Close();



                Limpar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }


        }

        private void Limpar()
        {
            this.txtResp1.Text = null;
            this.txtResp2.Text = null;
            this.txtResp3.Text = null;
            this.txtResp4.Text = null;
            this.txtResp5.Text = null;
            this.txtQuestao.Text = null;
            this.txtTitulo.Text = null;
            this.txtEquit = null;
            cboMateria.SelectedIndex = -1;

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtPesquisa.Text;
   
                String conn1 =
                 @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";

                string sql = "select IDQUESTAO, titulo,etiqueta,materia, questao, RESPOSTAA,RESPOSTAb,RESPOSTAc,RESPOSTAd,RESPOSTAcerta from SistemaP.DBO.TBQUESTAO where TITULO like'%" + keyword + "%' AND materia like'%" + cboMateria.Text + "%'";
             
                SqlConnection conn = new SqlConnection(conn1);
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                conn.Open();
                adapter.Fill(dt);
                if (dt.Rows == null)
                {
                    MessageBox.Show("Não há registros");
                }
                else
                {
                    dgv.DataSource = dt;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {


            try
            {

                if (MessageBox.Show("Tem certeza que deseja excluir o item selecionado?", "Confirmar",
MessageBoxButtons.YesNo, MessageBoxIcon.Question,
MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    int linha = Convert.ToInt16(txtId.Text);

                    SqlConnection connLogin = new SqlConnection(strConexaoOra);
                    connLogin.Open();
                    string SQL = "DELETE FROM SistemaP.DBO.tbquestao WHERE idquestao = " + linha + "";

                    SqlCommand commLogin = new SqlCommand(SQL, connLogin);

                    int y = commLogin.ExecuteNonQuery();


                }
                else
                {

                }



                MessageBox.Show("Questão excluida com sucesso");
                CarregarGridQues();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
                //throw;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MudarAtivo();
        }

        private void MudarAtivo()
        {


            int Valor = 1;
            string id = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value).ToString();
            String conn =
                 @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";
            SqlConnection connAdm = new SqlConnection(conn);
            connAdm.Open();
            string SQL = "UPDATE SistemaP.DBO.tbquestao SET status = '" + Valor + "' WHERE idquestao = " + id;
            SqlCommand commAdm = new SqlCommand(SQL, connAdm);
            int y = commAdm.ExecuteNonQuery();

            connAdm.Close();
            MessageBox.Show("QUESTAO DESATIVADA COM SUCESSO");


        }


        private void MudarInativo()
        {


            int Valor = 0;
            string id = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value).ToString();
            String conn =
                 @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";
            SqlConnection connAdm = new SqlConnection(conn);
            connAdm.Open();
            string SQL = "UPDATE SistemaP.DBO.tbquestao SET status = '" + Valor + "' WHERE idquestao = " + id;
            SqlCommand commAdm = new SqlCommand(SQL, connAdm);
            int y = commAdm.ExecuteNonQuery();

            connAdm.Close();
            MessageBox.Show("QUESTAO DESATIVADA COM SUCESSO");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            MudarInativo();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowindex = e.RowIndex;

            txtId.Text = dgv.Rows[rowindex].Cells[0].Value.ToString();
            txtEquit.Text = dgv.Rows[rowindex].Cells[2].Value.ToString();
            txtTitulo.Text = dgv.Rows[rowindex].Cells[1].Value.ToString();
            txtMateria.Text = dgv.Rows[rowindex].Cells[3].Value.ToString();
            txtQuestao.Text = dgv.Rows[rowindex].Cells[4].Value.ToString();
            txtResp1.Text = dgv.Rows[rowindex].Cells[5].Value.ToString();
            txtResp2.Text = dgv.Rows[rowindex].Cells[6].Value.ToString();
            txtResp3.Text = dgv.Rows[rowindex].Cells[7].Value.ToString();
            txtResp4.Text = dgv.Rows[rowindex].Cells[8].Value.ToString();
            txtResp5.Text = dgv.Rows[rowindex].Cells[9].Value.ToString();
        }
    }
}
