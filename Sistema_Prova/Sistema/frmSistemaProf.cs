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
    public partial class frmSistemaProf : Form
    {
        public frmSistemaProf()
        {
            InitializeComponent();

        }
        private string _TextoTeste;
        public String TextoTeste
        {
            get { return _TextoTeste; }
            set { _TextoTeste = value; }
        }

        private string _TextoTesteRM;
        public String TextoTesteRM
        {
            get { return _TextoTesteRM; }
            set { _TextoTesteRM = value; }
        }


        private string _TextoTesteNome;


        public string TextoTesteNome
        {
            get { return _TextoTesteNome; }
            set { _TextoTesteNome = value; }
        }


        private void PegarNome()
        {

            BDC.Professor adm = new BDC.Professor();

            SqlDataReader dr;
            adm.Login = _TextoTeste;
            dr = adm.Consultar2();
            dr.Read();
            
            label2.Text = "Nome: " + Convert.ToString(dr["NOME"].ToString());
            TextoTesteRM = Convert.ToString(dr["RM_PROFESSOR"].ToString());
            label1.Text = "Rm: " + Convert.ToString(dr["RM_PROFESSOR"].ToString());
            TextoTesteNome = Convert.ToString(dr["NOME"].ToString());
            label3.Text = "Ultimo acesso em: " + Convert.ToString(dr["ULTIMOACESSO"].ToString());
            toolStripStatusLabel1.Text = "LOGADO COMO PROFESSOR";
        }





        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rotina.Professor.Provas.frmCadastrarProva a = new Rotina.Professor.Provas.frmCadastrarProva(); 
            a.RMQUEST = TextoTesteRM;
            a.NomeProf = TextoTesteNome;
            a.ShowDialog();
        }

        private void profToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rotina.Professor.Questao.frmCadastrarQuestao a = new Rotina.Professor.Questao.frmCadastrarQuestao(); a.ShowDialog();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Modelos.Turma.frmConsultarTurma a = new Modelos.Turma.frmConsultarTurma(); 
            a.btnAlterar.Visible = false;
            a.radioButton1.Visible = false;
            a.chkAtivo.Visible = false;
            a.chkInativo.Visible = false;
            a.btnExcluir.Visible = false;
            a.button1.Visible = false;
            a.button2.Visible = false;
            a.ShowDialog();
        }

        private void frmSistemaProf_Load(object sender, EventArgs e)
        {
            PegarNome();
        }

        public void PegarLog()
        {
            frmLogin frmLog = new frmLogin();
            String Login = frmLog.txtUsuario.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Modelos.Aluno.frmConsultarNotas a = new Modelos.Aluno.frmConsultarNotas(); a.ShowDialog();
        }

        private void provaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rotina.Professor.Provas.frmConsultarProva a = new Rotina.Professor.Provas.frmConsultarProva();
            a.Show();
        }

        private void trocarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sistema.frmTrocarSenha a = new frmTrocarSenha(); a.TextoTeste = TextoTeste;
            a.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.posicao1.Text = System.DateTime.Now.ToString();

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void opçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void disponibilizarProvaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sistema_Prova.Rotina.Professor.Provas.frmDisponibiliza a = new Rotina.Professor.Provas.frmDisponibiliza();
            a.ShowDialog();
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


                string Sql = "UPDATE TB_admin SET ULTIMOACESSO = '" + System.DateTime.Today + "' WHERE rm_admin = " + _TextoTesteRM + " ";



                SqlCommand comm = new SqlCommand(Sql, conn);
                int y = comm.ExecuteNonQuery();

                conn.Close();
                this.Close();
            }
          
        }

        private void questaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rotina.Professor.Questao.frmCadastrarQuestao a = new Rotina.Professor.Questao.frmCadastrarQuestao();

            a.RMQUEST = _TextoTesteRM;
            a.ShowDialog();
        }

        private void questaoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Rotina.Professor.Questao.frmConsultarQuestao a = new Rotina.Professor.Questao.frmConsultarQuestao();

          
            a.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
