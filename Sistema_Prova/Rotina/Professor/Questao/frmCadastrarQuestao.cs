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
using System.Collections;
namespace Sistema_Prova.Rotina.Professor.Questao
{
    public partial class frmCadastrarQuestao : Form
    {


        private static
               string strConexaoOra =
           @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";


        private String _RMQUEST;

        private ArrayList _quest = new ArrayList();

        public ArrayList quest
        {
            get { return _quest; }
            set { _quest = value; }
        }
        public string RMQUEST
        {
            get
            {
                return _RMQUEST;
            }

            set
            {
                _RMQUEST = value;
            }
        }

        private void Limpar()
        {
            try
            {
                this.txtRespostaCerta.Text = null;
                this.txtRespostaA.Text = null;
                this.txtRespostaB.Text = null;
                this.txtRespostaC.Text = null;
                this.txtRespostaD.Text = null;
                this.txtQuestao.Text = null;
                this.txtTitulo.Text = null;
                this.txtEtiqueta.Text = null;
                this.txtTitulo.Text = null;
                cboMateria.SelectedIndex = -1;
                this.txtQuestao.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ", ex.Message);
                //throw;
            }


        }

        public frmCadastrarQuestao()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CadastrarQuest();
        }





        private void CadastrarQuest()
        {
            try
            {
                if (this.txtQuestao.Text == String.Empty)
                {
                    this.erro.SetError(this.txtQuestao, "Campo obrigatório");
                    this.txtQuestao.Focus();
                    return;
                }
                if (this.txtRespostaA.Text == String.Empty)
                {
                    this.erro.SetError(this.txtRespostaA, "Campo obrigatório");
                    this.txtRespostaA.Focus();
                    return;
                }
                if (this.txtRespostaB.Text == String.Empty)
                {
                    this.erro.SetError(this.txtRespostaB, "Erro no preenchimento do campo");
                    this.txtRespostaB.Focus();
                    return;
                }

                if (this.txtRespostaC.Text == String.Empty)
                {
                    this.erro.SetError(this.txtRespostaC, "Erro no preenchimento do campo");
                    this.txtRespostaC.Focus();
                    return;
                }

                if (this.txtRespostaD.Text == String.Empty)
                {
                    this.erro.SetError(this.txtRespostaD, "Erro no preenchimento do campo");
                    this.txtRespostaD.Focus();
                    return;
                }

                if (this.txtRespostaCerta.Text == String.Empty)
                {
                    this.erro.SetError(this.txtRespostaCerta, "Erro no preenchimento do campo");
                    this.txtRespostaCerta.Focus();
                    return;
                }


                BDC.Questoes q = new BDC.Questoes();

                String Titulo = txtQuestao.Text;

                String Questao = txtQuestao.Text;
                String RespostaA = txtRespostaA.Text;
                String RespostaB = txtRespostaB.Text;
                String RespostaC = txtRespostaC.Text;
                String RespostaD = txtRespostaD.Text;
                String RespostaCerta = txtRespostaCerta.Text;
                String Materia = cboMateria.Text;
                String Etiqueta = txtEtiqueta.Text;
              //  int rm = Convert.ToInt16(RMQUEST);

                // string IDQUESTAO = txtIdQuest.Text;
                int Ativo = 0;

             
                //  PEGAR RM DO PROFESSOR DA TELA DE INICIO

                SqlConnection connLogin = new SqlConnection(strConexaoOra);
                connLogin.Open();
                string SQLLogin = "INSERT INTO SistemaP.DBO.tbQuestao(IDQUESTAO, STATUS, TITULO, MATERIA, ETIQUETA, QUESTAO, RESPOSTAA, RESPOSTAB, RESPOSTAC, RESPOSTAD, RESPOSTACERTA, RM_PROFESSOR) values(next value for seq_questao,  '" + Ativo + "', '" + Titulo + "',  '" + Materia + "', '" + Etiqueta + "', '" + Questao + "', '" + RespostaA + "', '" + RespostaB + "', '" + RespostaC + "', '" + RespostaD + "', '" + RespostaCerta + "',  '" + RMQUEST + "')";


                SqlCommand comm = new SqlCommand(SQLLogin, connLogin);
                int x = comm.ExecuteNonQuery();
                if (x == 1)
                {
                    MessageBox.Show("QUESTOES CADASTRADAS COM SUCESSO!");
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

        private void frmCadastrarQuestao_Load(object sender, EventArgs e)
        {

            BDC.Materia tu = new BDC.Materia();

            cboMateria.DataSource = tu.Listar("").Tables[0];
            cboMateria.DisplayMember = "MATERIA_PROF";
            cboMateria.ValueMember = "ID_MATERIA";
            cboMateria.SelectedIndex = -1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
