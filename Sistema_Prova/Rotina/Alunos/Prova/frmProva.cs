using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Web;
using System.Data.SqlClient;

using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Web.UI;
namespace Sistema_Prova.Rotina.Alunos.Prova
{
    public partial class frmProva : Form
    {
        public frmProva()
        {
            InitializeComponent();
        }
        private static
              string strConexaoOra =
          @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";

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



        private int _Idprova;

        public int Idprova
        {
            get { return _Idprova; }
            set { _Idprova = value; }

        }



        private int _IdQuestao;

        public int IdQuestao
        {
            get { return _IdQuestao; }
            set { _IdQuestao = value; }

        }

        private int _Quantidade;

        public int Quantidade
        {
            get { return _Quantidade; }
            set { _Quantidade = value; }
        }

        private decimal _Quantidade2;

        public decimal Quantidade2
        {
            get { return _Quantidade2; }
            set { _Quantidade2 = value; }
        }

        private int _bloq;

        public int bloq
        {
            get { return _bloq; }
            set { _bloq = value; }
        }

        private decimal _Nota;

        public decimal Nota
        {
            get { return _Nota; }
            set { _Nota = value; }
        }

        private decimal _ValorQuestao;

        public decimal ValorQuestao
        {
            get { return _ValorQuestao; }
            set { _ValorQuestao = value; }

        }

        private ArrayList _a = new ArrayList();

        public ArrayList a
        {
            get { return _a; }
            set { _a = value; }
        }


        private ArrayList _b = new ArrayList();

        public ArrayList b
        {
            get { return _b; }
            set { _b = value; }
        }


        private ArrayList _c = new ArrayList();

        public ArrayList c
        {
            get { return _c; }
            set { _c = value; }
        }


        private ArrayList _d = new ArrayList();

        public ArrayList d
        {
            get { return _d; }
            set { _d = value; }
        }


        private ArrayList _certa = new ArrayList();

        public ArrayList certa
        {
            get { return _certa; }
            set { _certa = value; }
        }

        private ArrayList _TITULO = new ArrayList();

        public ArrayList TITULO
        {
            get { return _TITULO; }
            set { _TITULO = value; }
        }


        private ArrayList _quest = new ArrayList();

        public ArrayList quest
        {
            get { return _quest; }
            set { _quest = value; }
        }

    Button[] buttons = {
        button1, button2, button3, button4, button5, button6, button7, button8, button9, button10,
        button11, button12, button13, button14, button15, button16, button17, button18, button19, button20,
        button21, button22, button23, button24, button25, button26, button27, button28, button29, button30,
        button31, button32, button33, button34, button35, button36, button37, button38, button39, button40
    };

    
        SqlDataReader dr, dr2, dr3, dr4, dr5, dr6, dr7;


        //baseado no exemplo disponível em https://stackoverflow.com/questions/25058948/how-can-i-instantiate-large-number-of-buttons-in-windows-forms

        BDC.Prova prov = new BDC.Prova();

        private void Exibir()
        {
            try
            {

                //  var b = (Button)o;

                DialogResult dialogResult = MessageBox.Show("DESEJA INICIAR A PROVA  " + "" + "?", "", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {

                    BDC.Prova prov = new BDC.Prova();
                    BDC.Questoes ques = new BDC.Questoes();

                    prov.IdProva = Idprova; // mudar rm 


                    dr = prov.ConsultarQuantidade();
                    dr2 = prov.ConsultarMateProf();
                    dr3 = prov.ConsultarProf();
                    dr4 = prov.ConsultarQuest();

                    dr.Read();
                    dr2.Read();
                    dr3.Read();
                    dr4.Read();

                    // int Quantidade = 2;
                    Quantidade = Convert.ToInt32(dr["Quantidade"]);

                    lblMateria.Text = Convert.ToString(dr2["materia_prova"]);

                    lblProf.Text = Convert.ToString(dr3["NOME_PROF"]);

                    _IdQuestao = Convert.ToInt32(dr4["idquestao"]);

                    lblIdProva.Text = Idprova.ToString();



                    lblMateria.Visible = true;
                    lblProf.Visible = true;
                    lblIdProva.Visible = true;

                }

                else if (dialogResult == DialogResult.No)
                {
                    //faça algo
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int _rand;

        public int rand
        {
            get { return _rand; }
            set { _rand = value; }
        }


        public void BotoesArray()
        {


            Random randNum = new Random();

            _rand = (randNum.Next(1, Quantidade + 1)) - 1;
            Quantidade = Quantidade - 1;

            _rand == -rand -1
  
            string[] tds = { _a[_rand].ToString(), _b[_rand].ToString(), _c[_rand].ToString(), _d[_rand].ToString(), _certa[_rand].ToString() };

            lblQuestao.Text = _quest[_rand].ToString();



            Array.Sort(tds);


            radioButton1.Text = tds[0].ToString();

            radioButton2.Text = tds[1].ToString();

            radioButton3.Text = tds[2].ToString();

            radioButton4.Text = tds[3].ToString();

            radioButton5.Text = tds[4].ToString();



        }



        private void Exibir2()
        {
            try
            {
                //  var b = (Button)o;

                DialogResult dialogResult = MessageBox.Show("DESEJA INICIAR A PROVA  " + "" + "?", "", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {

                    prov.IdProva = Convert.ToInt32(Idprova); // mudar rm 

                    dr = prov.ConsultarQuantidade();
                    dr.Read();

                    // int Quantidade = 2;
                    _Quantidade = Convert.ToInt32(dr["Quantidade"]);
                    _Quantidade2 = Convert.ToInt32(dr["Quantidade"]);
                    dr2 = prov.ConsultarMateProf();
                    dr2.Read();
                    dr7 = prov.provanome();
                    dr7.Read();
                    lblMateria.Text = dr2["MATERIA_PROVA"].ToString();
                    //  lblProf.Text = dr2["NOME_PROF"].ToString();
                    //  lblTituloProva.Text = dr7["PROVA"].ToString();

                    // TESTAR COM DATATABLE
                    //       dr3 = prov.ConsultarRespostaQuest();



                    //   String questao = dr3["QUESTAO"].ToString();
                    //   String resp1 = dr3["RESPOSTAA"].ToString();
                    //  String resp2 = dr3["RESPOSTAB"].ToString();
                    //  String resp3 = dr3["RESPOSTAC"].ToString();
                    //   String resp4 = dr3["RESPOSTAD"].ToString();
                    //  String resp5 = dr3["RESPOSTACERTA"].ToString();


                    DataTable tbl = new DataTable();


                    SqlConnection conn = new SqlConnection(strConexaoOra);
                    conn.Open();
                    string cmd = "SELECT q.questao,Q.TITULO , q.respostaA,q.respostaB,q.respostaC,q.respostaD,q.respostaCerta FROM SistemaP.DBO.tbquestao q INNER JOIN SistemaP.DBO.tbprova_questao b on q.idquestao = b.idquestao where b.idprova = '" + Idprova + "'";

                    SqlDataAdapter da = new SqlDataAdapter(cmd, strConexaoOra);

                    da.Fill(tbl);




                    //var te = tbl.Rows.Cast<DataRow>().Select( Array => Array[0].ToString() .ToArray());

                    foreach (DataRow item in tbl.Rows)
                    {
                        _quest.Add(item[0]);
                        _TITULO.Add(item[1]);
                        _a.Add(item[2]);
                        _b.Add(item[3]);
                        _c.Add(item[4]);
                        _d.Add(item[5]);
                        _certa.Add(item[6]);
                    }

                    conn.Close();
                    lblMateria.Visible = true;
                    lblProf.Visible = true;
                    lblIdProva.Visible = true;

                    Quantidadedebtn();
                    btnIniciar.Enabled = false;
                    conn.Close();
                }

                else if (dialogResult == DialogResult.No)
                {
                    btnIniciar.Enabled = true;
                   foreach (Button btn in buttons) {
                        btn.Enabled = true;
                    } 
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
        }

        private void btn_seat_Click(Object o, EventArgs e)
        {
            Exibir();
        }

        private void lblDisponivel_Click(object sender, EventArgs e)
        {

        }

        private void frmProva_Load(object sender, EventArgs e)
        {
            if (_btn == 0)
            {
                btnConfirmar.Enabled = false;
            }
            btnConfirmar.Enabled = false;
            //  DesenharLugares();
            // DesenhasLugaresButao();

        }

        private void pnl_seats_Paint(object sender, PaintEventArgs e)
        {

        }

        private void relogio(Object sender, EventArgs e)
        {
            this.posicao1.Text = System.DateTime.Now.ToString();
        }


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void posicao1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button20.Enabled = true;
            button21.Enabled = true;
            button22.Enabled = true;
            button23.Enabled = true;
            button24.Enabled = true;
            button25.Enabled = true;
            button26.Enabled = true;
            button27.Enabled = true;
            button28.Enabled = true;
            button29.Enabled = true;
            button30.Enabled = true;
            button31.Enabled = true;
            button32.Enabled = true;
            button33.Enabled = true;
            button34.Enabled = true;
            button35.Enabled = true;
            button36.Enabled = true;
            button37.Enabled = true;
            button38.Enabled = true;
            button39.Enabled = true;
            button40.Enabled = true;
            btnConfirmar.Enabled = true;

            Exibir2();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void Finalizar(object sender, EventArgs e)
        {
            try
            {
                  DialogResult dialogResult = MessageBox.Show("DESEJA FINALIZAR A PROVA  " + "" + "?", "", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                frmMostrarNota frm = new frmMostrarNota();
                frm.label1.Text = _Nota.ToString();
                BDC.Notas not = new BDC.Notas();
                //not.Nota = Nota;
                //not.Rm = TextoTesteRM;
                //not.Prova = lblTituloProva.Text;
                //not.Incluir();

                string notafinal = Convert.ToString(_Nota);
                SqlConnection conn = new SqlConnection(strConexaoOra);
                conn.Open();
                string SQL = "INSERT INTO SistemaP.DBO.TBnotas_aluno (RM_ALUNO, PROVA, NOTA, idprova) VALUES ('" + TextoTesteRM + "', '" + lblTituloProva.Text + "','" + notafinal + "','" + Idprova + "')";

                SqlCommand comm = new SqlCommand(SQL, conn);
                comm.ExecuteNonQuery();

                conn.Close();



                btnConfirmar.Enabled = false;
                btnIniciar.Enabled = false;
                frm.ShowDialog();





            }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void button6_Click(object sender, EventArgs e)
        {
            _btn = 6;
            BotoesArray();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            _btn = 7;
            BotoesArray();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            _btn = 8;
            BotoesArray();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            _btn = 9;
            BotoesArray();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            _btn = 17;
            BotoesArray();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _btn = 1;
            BotoesArray();
        }

        //private void Grid()
        //{
        //    BDC.Questoes adm = new BDC.Questoes();
        //    try
        //    {
        //        String conn =
        //        @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";

        //        string sql = "SELECT * FROM SistemaP.DBO.TBQuestao ";



        //        SqlConnection con = new SqlConnection(conn);
        //        SqlCommand com = new SqlCommand(sql, con);
        //        try
        //        {
        //            SqlDataAdapter Da = new SqlDataAdapter(com);
        //            DataTable dlista = new DataTable();
        //            Da.Fill(dlista);
        //            if (dlista.Rows.Count == 0)
        //            {
        //                dataGridView1.Columns.Clear();
        //                string sql2 = "SELECT * FROM SistemaP.DBO.TBQuestao where id";

        //                SqlConnection con2 = new SqlConnection(conn);
        //                SqlCommand com2 = new SqlCommand(sql2, con2);


        //                try
        //                {
        //                    SqlDataAdapter Da2 = new SqlDataAdapter(com2);
        //                    DataTable dlista2 = new DataTable();
        //                    Da2.Fill(dlista2);
        //                    dataGridView1.DataSource = dlista2;
        //                }
        //                catch (Exception ex)
        //                {
        //                    MessageBox.Show(ex.Message);
        //                    // throw;
        //                }

        //            }
        //            else
        //            {
        //                dataGridView1.DataSource = dlista;
        //            }





        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //            // throw;
        //        }







        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

        public void Quantidadedebtn()
        {

            ValorQuestao = 10 / Quantidade;

            for (int i = quantidade; i < buttons.Length; i++)
            {
                buttons[i].Visible = false;
            }

        }

        private void button41_Click(object sender, EventArgs e)
        {
            try
            {
                bloq = Quantidade;
                bloq = bloq -1;


                string certa = _certa[_rand].ToString();
                
                decimal x = 10 / Quantidade2;
                _ValorQuestao = x;
                if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false && radioButton4.Checked == false && radioButton5.Checked == false)
                {
                    MessageBox.Show("VOCÊ PRECISA SELECIONAR PELO MENOS UMA RESPOSTA");
                    return;
                }
                else
                {
                var radioButtons = this.Controls.OfType<RadioButton>();

                foreach (var rb in radioButtons)
                {
                    if (rb.Checked && rb.Text == certa)
                    {
                        Nota += ValorQuestao;
                    }
                }
                  }

               foreach (var rb in radioButtons)
                  {  
                     rb.Checked = false; 
                   }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


            _quest.RemoveAt(rand);
            _a.RemoveAt(rand);
            _b.RemoveAt(rand);
            _c.RemoveAt(rand);
            _d.RemoveAt(rand);
            _certa.RemoveAt(rand);



            //     Quantidade = Quantidade - 1;
            notaa.Text = Convert.ToString(_Nota);
            if (bloq == 0)
            {
                btnConfirmar.Enabled = false;
            }

            if (btn >= 1 && btn <= buttons.Length)
            {
                buttons[btn - 1].Enabled = false;
                buttons[btn - 1].BackColor = Color.Red;
            }


            if (btn == 0)
            {
                btnConfirmar.Enabled = false;
            }
        }

        private int _btn;

        public int btn
        {
            get { return _btn; }
            set { _btn = value; }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            _btn = 2;
            BotoesArray();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _btn = 3;
            BotoesArray();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _btn = 4;
            BotoesArray();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _btn = 5;
            BotoesArray();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            _btn = 10;
            BotoesArray();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            _btn = 11;
            BotoesArray();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            _btn = 12;
            BotoesArray();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            _btn = 13;
            BotoesArray();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            _btn = 14;
            BotoesArray();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            _btn = 15;
            BotoesArray();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            _btn = 16;
            BotoesArray();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            _btn = 18;
            BotoesArray();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            _btn = 19;
            BotoesArray();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            _btn = 20;
            BotoesArray();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            _btn = 21;
            BotoesArray();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            _btn = 22;
            BotoesArray();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            _btn = 23;
            BotoesArray();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            _btn = 24;
            BotoesArray();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            _btn = 25;
            BotoesArray();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            _btn = 26;
            BotoesArray();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            _btn = 27;
            BotoesArray();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            _btn = 28;
            BotoesArray();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            _btn = 32;
            BotoesArray();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            _btn = 31;
            BotoesArray();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            _btn = 30;
            BotoesArray();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            _btn = 29;
            BotoesArray();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            _btn = 33;
            BotoesArray();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            _btn = 34;
            BotoesArray();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            _btn = 35;
            BotoesArray();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            _btn = 36;
            BotoesArray();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            _btn = 39;
            BotoesArray();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            _btn = 40;
            BotoesArray();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            _btn = 38;
            BotoesArray();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            _btn = 37;
            BotoesArray();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
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

        private void groupBox3_Enter(object sender, EventArgs e)
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


