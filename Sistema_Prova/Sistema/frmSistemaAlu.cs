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

namespace Sistema_Prova.Sistema
{
    public partial class frmSistemaAlu : Form
    {
        public frmSistemaAlu()
        {
            InitializeComponent();
        }


        private String _TextoTeste;

        public String TextoTeste
        {
            get { return _TextoTeste; }
            set { _TextoTeste = value; }
        }


        private String _Turma;

        public String Turma
        {
            get { return _Turma; }
            set { _Turma = value; }
        }



        private string _TextoTesteRM;
        public String TextoTesteRM
        {
            get { return _TextoTesteRM; }
            set { _TextoTesteRM = value; }
        }

        private String _TextoTeste2;

        public String TextoTeste2
        {
            get { return _TextoTeste2; }
            set { _TextoTeste2 = value; }
        }



        private void PegarNome()
        {



            BDC.Aluno adm = new BDC.Aluno();

            SqlDataReader dr;
            adm.Login = _TextoTeste;
            dr = adm.Consultar2();
            dr.Read();
            Turma = Convert.ToString(dr["turma_alu"].ToString());
            label2.Text = "Nome: " + Convert.ToString(dr["NOME"].ToString());
            TextoTesteRM = Convert.ToString(dr["RM_ALUNO"].ToString());
            label1.Text = "Rm: " + Convert.ToString(dr["RM_ALUNO"].ToString());
            label3.Text = "Turma : " + Convert.ToString(dr["turma_alu"].ToString());
            label4.Text = "Ultimo acesso em: " + Convert.ToString(dr["ultimoacesso"].ToString());
            toolStrip.Text = "LOGADO COMO ALUNO";

            //  TextoTesteRM = "98765";
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rotina.Alunos.Prova.frmConsultarProva a = new Rotina.Alunos.Prova.frmConsultarProva();
            a.TextoTeste = _TextoTeste;
            a.Turma = Turma;
            a.TextoTesteRM = _TextoTesteRM;
            a.ShowDialog();
        }

        private void frmSistemaAlu_Load(object sender, EventArgs e)
        {
            PegarNome();

        }



        private void profToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modelos.Aluno.Materia.frmNotasAluno a = new Modelos.Aluno.Materia.frmNotasAluno();

            a.TextoTesteRM = TextoTesteRM;


            a.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void trocarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //frmLogin log = new frmLogin();

            Sistema.frmTrocarSenha a = new frmTrocarSenha(); a.TextoTeste = TextoTeste;
            a.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void opçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.posicao1.Text = System.DateTime.Now.ToString();

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string message = "DESEJA MESMO SAIR?";
            string caption = "Error detected in imput";
            DialogResult result;
            MessageBoxButtons button = MessageBoxButtons.YesNo;

            result = MessageBox.Show(message, caption, button);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {



                string strConexaoOra =
         @"Server= DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";
                SqlConnection conn = new SqlConnection(strConexaoOra); conn.Open();


                string Sql = "UPDATE TB_ALUNO SET ULTIMOACESSO = '" + System.DateTime.Today + "' WHERE rm_ALUNO = " + _TextoTesteRM + " ";



                SqlCommand comm = new SqlCommand(Sql, conn);
                int y = comm.ExecuteNonQuery();

                conn.Close();
                this.Close();
            }
        }

        private void toolStripStatusLabel5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string message = "DESEJA MESMO SAIR?";
            string caption = "Error detected in imput";
            DialogResult result;
            MessageBoxButtons button = MessageBoxButtons.YesNo;

            result = MessageBox.Show(message, caption, button);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {



                string strConexaoOra =
         @"Server= DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";
                SqlConnection conn = new SqlConnection(strConexaoOra); conn.Open();


                string Sql = "UPDATE TB_ALUNO SET ULTIMOACESSO = '" + System.DateTime.Today + "' WHERE rm_ALUNO = " + _TextoTesteRM + " ";



                SqlCommand comm = new SqlCommand(Sql, conn);
                int y = comm.ExecuteNonQuery();

                conn.Close();
                this.Close();
            }

        }
    }
}