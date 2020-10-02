using System;
using System.Collections;
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
    public partial class frmSistemaAdm : Form
    {
        public frmSistemaAdm()
        {
            InitializeComponent();


        }

        private static
           string strConexaoOra =
     @"Server= DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";

        private String _TextoTeste;

        public String TextoTeste
        {
            get { return _TextoTeste; }
            set { _TextoTeste = value; }
        }

        private String _TextoTesteRM;

        public String TextoTesteRM
        {
            get { return _TextoTesteRM; }
            set { _TextoTesteRM = value; }
        }


        private void PegarNome()
        {
            BDC.Administrador adm = new BDC.Administrador();
            try
            {
   SqlDataReader dr;
            adm.Login = _TextoTeste;
            dr = adm.Consultar2();
            dr.Read();
            //label2.Text = "Nome: " + Convert.ToString(dr["NOME"].ToString()) ;
            TextoTesteRM = Convert.ToString(dr["RM_ADMIN"].ToString());
            //label1.Text = "Rm: " + Convert.ToString(dr["RM_ADMIN"].ToString()) ;
          //  label3.Text = "Ultimo acesso em: " + Convert.ToString(dr["ultimoacesso"].ToString());
          //  toolStripStatusLabel1.Text = "LOGADO COMO ADMINISTRADOR";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
         
        }







        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modelos.Administrador.frmCadastrarAdm a = new Modelos.Administrador.frmCadastrarAdm(); a.ShowDialog();
        }

        private void profToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modelos.Professor.frmCadastrarProf a = new Modelos.Professor.frmCadastrarProf(); a.ShowDialog();
        }

        private void AlunoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Modelos.Aluno.frmCadastrarAlu a = new Modelos.Aluno.frmCadastrarAlu(); a.ShowDialog();
        }

        private void turmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modelos.Turma.frmCadastrarTurma a = new Modelos.Turma.frmCadastrarTurma(); a.ShowDialog();
        }

        private void disciplinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modelos.Materia.frmCadastrarMat a = new Modelos.Materia.frmCadastrarMat(); a.ShowDialog();
        }





        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Modelos.Administrador.frmConsultarAdm a = new Modelos.Administrador.frmConsultarAdm(); a.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Modelos.Professor.frmConsultarProf a = new Modelos.Professor.frmConsultarProf(); a.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Modelos.Aluno.frmConsultarAlu r = new Modelos.Aluno.frmConsultarAlu();

           
            r.ShowDialog(this);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Modelos.Turma.frmConsultarTurma a = new Modelos.Turma.frmConsultarTurma();
            a.textBox1.Visible = false;
            a.button3.Visible = false;
            a.ShowDialog();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Modelos.Materia.frmConsultarMat a = new Modelos.Materia.frmConsultarMat(); a.ShowDialog();
        }

        private void trocarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sistema.frmTrocarSenha a = new frmTrocarSenha(); a.TextoTeste = TextoTeste;
            a.ShowDialog();
        }

        private void testeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rotina.Professor.Questao.frmCadastrarQuestao N = new Rotina.Professor.Questao.frmCadastrarQuestao(); N.ShowDialog();

        }

        private void testeeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rotina.Professor.Provas.frmCadastrarProva N = new Rotina.Professor.Provas.frmCadastrarProva(); N.ShowDialog();

        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Rotina.Alunos.Prova.frmConsultarProva a = new Rotina.Alunos.Prova.frmConsultarProva();
            a.ShowDialog();

        }

        private void aaaaaaaaaaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rotina.Alunos.Prova.frmProva a = new Rotina.Alunos.Prova.frmProva();
            a.ShowDialog();

        }

        private void frmSistemaAdm_Load(object sender, EventArgs e)
        {
            PegarNome();
        }




        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          //  this.posicao1.Text = System.DateTime.Now.ToString();

        }

        private void status_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

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

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            string message = "DESEJA MESMO SAIR?";
            string caption = "Error detected in imput";
            DialogResult result;
            MessageBoxButtons button = MessageBoxButtons.YesNo;

            result = MessageBox.Show(message, caption, button);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
          


            SqlConnection conn = new SqlConnection(strConexaoOra); conn.Open();
       

            string Sql = "UPDATE TB_admin SET ULTIMOACESSO = '" + System.DateTime.Today + "' WHERE rm_admin = " + _TextoTesteRM + " ";



            SqlCommand comm = new SqlCommand(Sql, conn);
            int y = comm.ExecuteNonQuery();

            conn.Close();
            this.Close();
  }
        }

        private void tESTEToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Sistema_Prova.frmTeste A = new frmTeste();
            A.ShowDialog();
        }

        private void opçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

