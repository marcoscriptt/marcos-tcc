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
            //  int rand = _randNum.Next(Quantidade) - 1;

            _rand = randNum.Next(1, Quantidade + 1);
            Quantidade = Quantidade - 1;
            if (_rand == 1)
            {
                _rand = 0;
            }

            if (_rand == 2)
            {
                _rand = 1;
            }

            if (_rand == 3)
            {
                _rand = 2;
            }

            if (_rand == 4)
            {
                _rand = 3;
            }

            if (_rand == 5)
            {
                _rand = 4;
            }

            if (_rand == 6)
            {
                _rand = 5;
            }

            if (_rand == 7)
            {
                _rand = 6;
            }

            if (_rand == 8)
            {
                _rand = 7;
            }

            if (_rand == 9)
            {
                _rand = 8;
            }

            if (_rand == 10)
            {
                _rand = 9;
            }

            if (_rand == 11)
            {
                _rand = 10;
            }

            if (_rand == 12)
            {
                _rand = 11;
            }

            if (_rand == 13)
            {
                _rand = 12;
            }

            if (_rand == 14)
            {
                _rand = 13;
            }

            if (_rand == 15)
            {
                _rand = 14;
            }

            if (_rand == 16)
            {
                _rand = 15;
            }

            if (_rand == 17)
            {
                _rand = 16;
            }

            if (_rand == 18)
            {
                _rand = 17;
            }

            if (_rand == 19)
            {
                _rand = 18;
            }

            if (_rand == 20)
            {
                _rand = 19;
            }

            if (_rand == 21)
            {
                _rand = 20;
            }

            if (_rand == 22)
            {
                _rand = 21;
            }

            if (_rand == 23)
            {
                _rand = 22;
            }

            if (_rand == 24)
            {
                _rand = 23;
            }

            if (_rand == 25)
            {
                _rand = 24;
            }

            if (_rand == 26)
            {
                _rand = 25;
            }

            if (_rand == 27)
            {
                _rand = 26;
            }

            if (_rand == 28)
            {
                _rand = 27;
            }

            if (_rand == 29)
            {
                _rand = 28;
            }

            if (_rand == 30)
            {
                _rand = 29;
            }

            if (_rand == 31)
            {
                _rand = 30;
            }

            if (_rand == 32)
            {
                _rand = 31;
            }

            if (_rand == 33)
            {
                _rand = 32;
            }

            if (_rand == 34)
            {
                _rand = 33;
            }

            if (_rand == 35)
            {
                _rand = 34;
            }

            if (_rand == 36)
            {
                _rand = 35;
            }

            if (_rand == 37)
            {
                _rand = 36;
            }

            if (_rand == 38)
            {
                _rand = 37;
            }

            if (_rand == 39)
            {
                _rand = 38;
            }

            if (_rand == 40)
            {
                _rand = 39;
            }

            if (_rand == 41)
            {
                _rand = 40;
            }

            //ArrayList tds = new ArrayList();
            //tds.Add(_a[_rand]);
            //tds.Add(_b[_rand]);
            //tds.Add(_c[_rand]);
            //tds.Add(_d[_rand]);
            //tds.Add(_certa[_rand]);

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
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    button10.Enabled = false;
                    button11.Enabled = false;
                    button12.Enabled = false;
                    button13.Enabled = false;
                    button14.Enabled = false;
                    button15.Enabled = false;
                    button16.Enabled = false;
                    button17.Enabled = false;
                    button18.Enabled = false;
                    button19.Enabled = false;
                    button20.Enabled = false;
                    button21.Enabled = false;
                    button22.Enabled = false;
                    button23.Enabled = false;
                    button24.Enabled = false;
                    button25.Enabled = false;
                    button26.Enabled = false;
                    button27.Enabled = false;
                    button28.Enabled = false;
                    button29.Enabled = false;
                    button30.Enabled = false;
                    button31.Enabled = false;
                    button32.Enabled = false;
                    button33.Enabled = false;
                    button34.Enabled = false;
                    button35.Enabled = false;
                    button36.Enabled = false;
                    button37.Enabled = false;
                    button38.Enabled = false;
                    button39.Enabled = false;
                    button40.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private static
              string strConexaoOra =
          @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";




        //private void Array()
        //{
        //    try
        //    {
        //        BDC.Prova prov = new BDC.Prova();
        //        BDC.Questoes ques = new BDC.Questoes();

        //        prov.IdProva = Idprova; // mudar rm 

        //        Sql.DataAccess.Client.SqlDataReader dr, dr2, dr3, dr4, dr5, dr6;

        //        // lembrar de pegar varios id de questoes, entao fazer foreach. caso necessario modificar codigo para pegar varias linhas
        //        //   dr4 = prov.ConsultarQuest(); // idquestao da tabela prova_questao
        //        //   dr4.Read();

        //        // int iddaQuestao = Convert.ToInt32(dr4["IDQUESTAO"]);

        //        ques.IdQuestao = IdQuestao;

        //        dr5 = ques.Consultar3();
        //        dr5.Read();




        //        // int Quantidade = 2;



        //        //String[] questoes1 = new String[Quantidade];

        //        //questoes1[0] = Convert.ToString(dr5["QUESTAO"]);
        //        //questoes1[1] = Convert.ToString(dr5["RESPOSTAA"]);
        //        //questoes1[2] = Convert.ToString(dr5["RESPOSTAB"]); ;
        //        //questoes1[3] = Convert.ToString(dr5["RESPOSTAC"]); ;
        //        //questoes1[4] = Convert.ToString(dr5["RESPOSTAD"]); ;
        //        //questoes1[5] = Convert.ToString(dr5["RESPOSTACERTA"]);

        //        for (int i = 0; i < _Quantidade; i++)
        //        {

        //            foreach (var item in dr5)
        //            {



        //          //      string teste = Convert.ToString(this.dataGridView1.Rows[i].Cells[0].Value);

        //                string questao = Convert.ToString(dr5["QUESTAO"]);
        //                string questoes0 = Convert.ToString(dr5["RESPOSTAA"]);
        //                string questao1 = Convert.ToString(dr5["RESPOSTAB"]); ;
        //                string questoes2 = Convert.ToString(dr5["RESPOSTAC"]); ;
        //                string questoes3 = Convert.ToString(dr5["RESPOSTAD"]); ;
        //                string questoes4 = Convert.ToString(dr5["RESPOSTACERTA"]);

        //                //string[,] array2D = new string[1,6]
        //                _Array = new string[,]
        //                {

        //                {
        //                    questao, questoes0, questao1, questoes2, questoes3, questoes4
        //                }

        //                };

        //                lblQuestao.Text = _Array[i, 0].ToString();

        //                radioButton1.Text = _Array[i, 1].ToString();

        //                radioButton2.Text = _Array[i, 2].ToString();

        //                radioButton3.Text = _Array[i, 3].ToString();

        //                radioButton4.Text = _Array[i, 4].ToString();

        //                radioButton5.Text = _Array[i, 5].ToString();


        //            }
        //        }
        //        Quantidadedebtn();
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message, "<ERRO NAS QUESTOES>");
        //    }
        //}


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

            if (_Quantidade <= 1)
            {


                button40.Visible = false; button39.Visible = false;
                button38.Visible = false; button37.Visible = false;
                button36.Visible = false; button35.Visible = false;
                button34.Visible = false; button33.Visible = false;
                button32.Visible = false; button31.Visible = false;
                button30.Visible = false; button29.Visible = false;
                button28.Visible = false; button27.Visible = false;
                button26.Visible = false; button25.Visible = false;
                button24.Visible = false; button23.Visible = false;
                button22.Visible = false; button21.Visible = false;
                button20.Visible = false; button19.Visible = false;
                button18.Visible = false; button17.Visible = false;
                button16.Visible = false; button15.Visible = false;
                button14.Visible = false; button13.Visible = false;
                button12.Visible = false; button11.Visible = false;
                button10.Visible = false; button9.Visible = false;
                button8.Visible = false;
                button7.Visible = false; button6.Visible = false;
                button5.Visible = false; button4.Visible = false;
                button3.Visible = false; button2.Visible = false;

            }
            if (_Quantidade <= 2)
            {
                button40.Visible = false; button39.Visible = false;
                button38.Visible = false; button37.Visible = false;
                button36.Visible = false; button35.Visible = false;
                button34.Visible = false; button33.Visible = false;
                button32.Visible = false; button31.Visible = false;
                button30.Visible = false; button29.Visible = false;
                button28.Visible = false; button27.Visible = false;
                button26.Visible = false; button25.Visible = false;
                button24.Visible = false; button23.Visible = false;
                button22.Visible = false; button21.Visible = false;
                button20.Visible = false; button19.Visible = false;
                button18.Visible = false; button17.Visible = false;
                button16.Visible = false; button15.Visible = false;
                button14.Visible = false; button13.Visible = false;
                button12.Visible = false; button11.Visible = false;
                button10.Visible = false; button9.Visible = false;
                button8.Visible = false;
                button7.Visible = false; button6.Visible = false;
                button5.Visible = false; button4.Visible = false;
                button3.Visible = false;

            }
            if (_Quantidade <= 3)
            {
                button40.Visible = false; button39.Visible = false;
                button38.Visible = false; button37.Visible = false;
                button36.Visible = false; button35.Visible = false;
                button34.Visible = false; button33.Visible = false;
                button32.Visible = false; button31.Visible = false;
                button30.Visible = false; button29.Visible = false;
                button28.Visible = false; button27.Visible = false;
                button26.Visible = false; button25.Visible = false;
                button24.Visible = false; button23.Visible = false;
                button22.Visible = false; button21.Visible = false;
                button20.Visible = false; button19.Visible = false;
                button18.Visible = false; button17.Visible = false;
                button16.Visible = false; button15.Visible = false;
                button14.Visible = false; button13.Visible = false;
                button12.Visible = false; button11.Visible = false;
                button10.Visible = false; button9.Visible = false;
                button8.Visible = false;
                button7.Visible = false; button6.Visible = false;
                button5.Visible = false; button4.Visible = false;

            }
            if (_Quantidade <= 4)
            {
                button40.Visible = false; button39.Visible = false;
                button38.Visible = false; button37.Visible = false;
                button36.Visible = false; button35.Visible = false;
                button34.Visible = false; button33.Visible = false;
                button32.Visible = false; button31.Visible = false;
                button30.Visible = false; button29.Visible = false;
                button28.Visible = false; button27.Visible = false;
                button26.Visible = false; button25.Visible = false;
                button24.Visible = false; button23.Visible = false;
                button22.Visible = false; button21.Visible = false;
                button20.Visible = false; button19.Visible = false;
                button18.Visible = false; button17.Visible = false;
                button16.Visible = false; button15.Visible = false;
                button14.Visible = false; button13.Visible = false;
                button12.Visible = false; button11.Visible = false;
                button10.Visible = false;
                button9.Visible = false; button8.Visible = false;
                button7.Visible = false; button6.Visible = false;
                button5.Visible = false;

            }
            if (_Quantidade <= 5)
            {
                button40.Visible = false; button39.Visible = false;
                button38.Visible = false; button37.Visible = false;
                button36.Visible = false; button35.Visible = false;
                button34.Visible = false; button33.Visible = false;
                button32.Visible = false; button31.Visible = false;
                button30.Visible = false; button29.Visible = false;
                button28.Visible = false; button27.Visible = false;
                button26.Visible = false; button25.Visible = false;
                button24.Visible = false; button23.Visible = false;
                button22.Visible = false; button21.Visible = false;
                button20.Visible = false; button19.Visible = false;
                button18.Visible = false; button17.Visible = false;
                button16.Visible = false; button15.Visible = false;
                button14.Visible = false; button13.Visible = false;
                button12.Visible = false; button11.Visible = false;
                button10.Visible = false; button9.Visible = false;
                button8.Visible = false;
                button7.Visible = false; button6.Visible = false;

            }
            if (_Quantidade <= 6)
            {
                button40.Visible = false; button39.Visible = false;
                button38.Visible = false; button37.Visible = false;
                button36.Visible = false; button35.Visible = false;
                button34.Visible = false; button33.Visible = false;
                button32.Visible = false; button31.Visible = false;
                button30.Visible = false; button29.Visible = false;
                button28.Visible = false; button27.Visible = false;
                button26.Visible = false; button25.Visible = false;
                button24.Visible = false; button23.Visible = false;
                button22.Visible = false; button21.Visible = false;
                button20.Visible = false; button19.Visible = false;
                button18.Visible = false; button17.Visible = false;
                button16.Visible = false; button15.Visible = false;
                button14.Visible = false; button13.Visible = false;
                button12.Visible = false; button11.Visible = false;
                button10.Visible = false; button9.Visible = false;
                button8.Visible = false;
                button7.Visible = false;

            }
            if (_Quantidade <= 7)
            {
                button40.Visible = false; button39.Visible = false;
                button38.Visible = false; button37.Visible = false;
                button36.Visible = false; button35.Visible = false;
                button34.Visible = false; button33.Visible = false;
                button32.Visible = false; button31.Visible = false;
                button30.Visible = false; button29.Visible = false;
                button28.Visible = false; button27.Visible = false;
                button26.Visible = false; button25.Visible = false;
                button24.Visible = false; button23.Visible = false;
                button22.Visible = false; button21.Visible = false;
                button20.Visible = false; button19.Visible = false;
                button18.Visible = false; button17.Visible = false;
                button16.Visible = false; button15.Visible = false;
                button14.Visible = false; button13.Visible = false;
                button12.Visible = false; button11.Visible = false;
                button10.Visible = false; button9.Visible = false;
                button8.Visible = false;

            }
            if (_Quantidade <= 8)
            {
                button40.Visible = false; button39.Visible = false;
                button38.Visible = false; button37.Visible = false;
                button36.Visible = false; button35.Visible = false;
                button34.Visible = false; button33.Visible = false;
                button32.Visible = false; button31.Visible = false;
                button30.Visible = false; button29.Visible = false;
                button28.Visible = false; button27.Visible = false;
                button26.Visible = false; button25.Visible = false;
                button24.Visible = false; button23.Visible = false;
                button22.Visible = false; button21.Visible = false;
                button20.Visible = false; button19.Visible = false;
                button18.Visible = false; button17.Visible = false;
                button16.Visible = false; button15.Visible = false;
                button14.Visible = false; button13.Visible = false;
                button12.Visible = false; button11.Visible = false;
                button10.Visible = false; button9.Visible = false;


            }
            if (_Quantidade <= 9)
            {
                button40.Visible = false; button39.Visible = false;
                button38.Visible = false; button37.Visible = false;
                button36.Visible = false; button35.Visible = false;
                button34.Visible = false; button33.Visible = false;
                button32.Visible = false; button31.Visible = false;
                button30.Visible = false; button29.Visible = false;
                button28.Visible = false; button27.Visible = false;
                button26.Visible = false; button25.Visible = false;
                button24.Visible = false; button23.Visible = false;
                button22.Visible = false; button21.Visible = false;
                button20.Visible = false; button19.Visible = false;
                button18.Visible = false; button17.Visible = false;
                button16.Visible = false; button15.Visible = false;
                button14.Visible = false; button13.Visible = false;
                button12.Visible = false; button11.Visible = false;
                button10.Visible = false;

            }
            if (_Quantidade <= 10)
            {
                button40.Visible = false; button39.Visible = false;
                button38.Visible = false; button37.Visible = false;
                button36.Visible = false; button35.Visible = false;
                button34.Visible = false; button33.Visible = false;
                button32.Visible = false; button31.Visible = false;
                button30.Visible = false; button29.Visible = false;
                button28.Visible = false; button27.Visible = false;
                button26.Visible = false; button25.Visible = false;
                button24.Visible = false; button23.Visible = false;
                button22.Visible = false; button21.Visible = false;
                button20.Visible = false; button19.Visible = false;
                button18.Visible = false; button17.Visible = false;
                button16.Visible = false; button15.Visible = false;
                button14.Visible = false; button13.Visible = false;
                button12.Visible = false; button11.Visible = false;
            }

            if (_Quantidade <= 11)
            {
                button40.Visible = false; button39.Visible = false;
                button38.Visible = false; button37.Visible = false;
                button36.Visible = false; button35.Visible = false;
                button34.Visible = false; button33.Visible = false;
                button32.Visible = false; button31.Visible = false;
                button30.Visible = false; button29.Visible = false;
                button28.Visible = false; button27.Visible = false;
                button26.Visible = false; button25.Visible = false;
                button24.Visible = false; button23.Visible = false;
                button22.Visible = false; button21.Visible = false;
                button20.Visible = false; button19.Visible = false;
                button18.Visible = false; button17.Visible = false;
                button16.Visible = false; button15.Visible = false;
                button14.Visible = false; button13.Visible = false;
                button12.Visible = false;
            }
            if (_Quantidade <= 12)
            {
                button40.Visible = false; button39.Visible = false;
                button38.Visible = false; button37.Visible = false;
                button36.Visible = false; button35.Visible = false;
                button34.Visible = false; button33.Visible = false;
                button32.Visible = false; button31.Visible = false;
                button30.Visible = false; button29.Visible = false;
                button28.Visible = false; button27.Visible = false;
                button26.Visible = false; button25.Visible = false;
                button24.Visible = false; button23.Visible = false;
                button22.Visible = false; button21.Visible = false;
                button20.Visible = false; button19.Visible = false;
                button18.Visible = false; button17.Visible = false;
                button16.Visible = false; button15.Visible = false;
                button14.Visible = false; button13.Visible = false;
            }
            if (_Quantidade <= 13)
            {
                button40.Visible = false; button39.Visible = false;
                button38.Visible = false; button37.Visible = false;
                button36.Visible = false; button35.Visible = false;
                button34.Visible = false; button33.Visible = false;
                button32.Visible = false; button31.Visible = false;
                button30.Visible = false; button29.Visible = false;
                button28.Visible = false; button27.Visible = false;
                button26.Visible = false; button25.Visible = false;
                button24.Visible = false; button23.Visible = false;
                button22.Visible = false; button21.Visible = false;
                button20.Visible = false; button19.Visible = false;
                button18.Visible = false; button17.Visible = false;
                button16.Visible = false; button15.Visible = false;
                button14.Visible = false;
            }
            if (_Quantidade <= 14)
            {
                button40.Visible = false; button39.Visible = false;
                button38.Visible = false; button37.Visible = false;
                button36.Visible = false; button35.Visible = false;
                button34.Visible = false; button33.Visible = false;
                button32.Visible = false; button31.Visible = false;
                button30.Visible = false; button29.Visible = false;
                button28.Visible = false; button27.Visible = false;
                button26.Visible = false; button25.Visible = false;
                button24.Visible = false; button23.Visible = false;
                button22.Visible = false; button21.Visible = false;
                button20.Visible = false; button19.Visible = false;
                button18.Visible = false; button17.Visible = false;
                button16.Visible = false; button15.Visible = false;

            }
            if (_Quantidade <= 15)
            {
                button40.Visible = false; button39.Visible = false;
                button38.Visible = false; button37.Visible = false;
                button36.Visible = false; button35.Visible = false;
                button34.Visible = false; button33.Visible = false;
                button32.Visible = false; button31.Visible = false;
                button30.Visible = false; button29.Visible = false;
                button28.Visible = false; button27.Visible = false;
                button26.Visible = false; button25.Visible = false;
                button24.Visible = false; button23.Visible = false;
                button22.Visible = false; button21.Visible = false;
                button20.Visible = false; button19.Visible = false;
                button18.Visible = false; button17.Visible = false;
                button16.Visible = false;

            }
            if (_Quantidade <= 16)
            {
                button40.Visible = false; button39.Visible = false;
                button38.Visible = false; button37.Visible = false;
                button36.Visible = false; button35.Visible = false;
                button34.Visible = false; button33.Visible = false;
                button32.Visible = false; button31.Visible = false;
                button30.Visible = false; button29.Visible = false;
                button28.Visible = false; button27.Visible = false;
                button26.Visible = false; button25.Visible = false;
                button24.Visible = false; button23.Visible = false;
                button22.Visible = false; button21.Visible = false;
                button20.Visible = false; button19.Visible = false;
                button18.Visible = false; button17.Visible = false;
            }
            if (_Quantidade <= 17)
            {
                button40.Visible = false; button39.Visible = false;
                button38.Visible = false; button37.Visible = false;
                button36.Visible = false; button35.Visible = false;
                button34.Visible = false; button33.Visible = false;
                button32.Visible = false; button31.Visible = false;
                button30.Visible = false; button29.Visible = false;
                button28.Visible = false; button27.Visible = false;
                button26.Visible = false; button25.Visible = false;
                button24.Visible = false; button23.Visible = false;
                button22.Visible = false; button21.Visible = false;
                button20.Visible = false; button19.Visible = false;
                button18.Visible = false;
            }
            if (_Quantidade <= 18)
            {
                button40.Visible = false; button39.Visible = false;
                button38.Visible = false; button37.Visible = false;
                button36.Visible = false; button35.Visible = false;
                button34.Visible = false; button33.Visible = false;
                button32.Visible = false; button31.Visible = false;
                button30.Visible = false; button29.Visible = false;
                button28.Visible = false; button27.Visible = false;
                button26.Visible = false; button25.Visible = false;
                button24.Visible = false; button23.Visible = false;
                button22.Visible = false; button21.Visible = false;
                button20.Visible = false; button19.Visible = false;

            }
            if (_Quantidade <= 19)
            {
                button40.Visible = false; button39.Visible = false;
                button38.Visible = false; button37.Visible = false;
                button36.Visible = false; button35.Visible = false;
                button34.Visible = false; button33.Visible = false;
                button32.Visible = false; button31.Visible = false;
                button30.Visible = false; button29.Visible = false;
                button28.Visible = false; button27.Visible = false;
                button26.Visible = false; button25.Visible = false;
                button24.Visible = false; button23.Visible = false;
                button22.Visible = false; button21.Visible = false;
                button20.Visible = false;

            }





            if (_Quantidade <= 20)
            {
                button40.Visible = false; button39.Visible = false;
                button38.Visible = false; button37.Visible = false;
                button36.Visible = false; button35.Visible = false;
                button34.Visible = false; button33.Visible = false;
                button32.Visible = false; button31.Visible = false;
                button30.Visible = false; button29.Visible = false;
                button28.Visible = false; button27.Visible = false;
                button26.Visible = false; button25.Visible = false;
                button24.Visible = false; button23.Visible = false;
                button22.Visible = false; button21.Visible = false;
            }

            if (_Quantidade <= 21)
            {
                button40.Visible = false; button39.Visible = false;
                button38.Visible = false; button37.Visible = false;
                button36.Visible = false; button35.Visible = false;
                button34.Visible = false; button33.Visible = false;
                button32.Visible = false; button31.Visible = false;
                button30.Visible = false; button29.Visible = false;
                button28.Visible = false; button27.Visible = false;
                button26.Visible = false; button25.Visible = false;
                button24.Visible = false; button23.Visible = false;
                button22.Visible = false;
            }
            if (_Quantidade <= 22)
            {
                button40.Visible = false; button39.Visible = false;
                button38.Visible = false; button37.Visible = false;
                button36.Visible = false; button35.Visible = false;
                button34.Visible = false; button33.Visible = false;
                button32.Visible = false; button31.Visible = false;
                button30.Visible = false; button29.Visible = false;
                button28.Visible = false; button27.Visible = false;
                button26.Visible = false; button25.Visible = false;
                button24.Visible = false; button23.Visible = false;
            }
            if (_Quantidade <= 23)
            {
                button40.Visible = false; button39.Visible = false;
                button38.Visible = false; button37.Visible = false;
                button36.Visible = false; button35.Visible = false;
                button34.Visible = false; button33.Visible = false;
                button32.Visible = false; button31.Visible = false;
                button30.Visible = false; button29.Visible = false;
                button28.Visible = false; button27.Visible = false;
                button26.Visible = false; button25.Visible = false;
                button24.Visible = false;
            }
            if (_Quantidade <= 24)
            {
                button40.Visible = false; button39.Visible = false;
                button38.Visible = false; button37.Visible = false;
                button36.Visible = false; button35.Visible = false;
                button34.Visible = false; button33.Visible = false;
                button32.Visible = false; button31.Visible = false;
                button30.Visible = false; button29.Visible = false;
                button28.Visible = false; button27.Visible = false;
                button26.Visible = false; button25.Visible = false;
            }
            if (_Quantidade <= 25)
            {
                button40.Visible = false; button39.Visible = false;
                button38.Visible = false; button37.Visible = false;
                button36.Visible = false; button35.Visible = false;
                button34.Visible = false; button33.Visible = false;
                button32.Visible = false; button31.Visible = false;
                button30.Visible = false; button29.Visible = false;
                button28.Visible = false; button27.Visible = false;
                button26.Visible = false;
            }
            if (_Quantidade <= 26)
            {
                button40.Visible = false; button39.Visible = false;
                button38.Visible = false; button37.Visible = false;
                button36.Visible = false; button35.Visible = false;
                button34.Visible = false; button33.Visible = false;
                button32.Visible = false; button31.Visible = false;
                button30.Visible = false; button29.Visible = false;
                button28.Visible = false; button27.Visible = false;

            }
            if (_Quantidade <= 27)
            {
                button40.Visible = false; button39.Visible = false;
                button38.Visible = false; button37.Visible = false;
                button36.Visible = false; button35.Visible = false;
                button34.Visible = false; button33.Visible = false;
                button32.Visible = false; button31.Visible = false;
                button30.Visible = false; button29.Visible = false;
                button28.Visible = false;

            }
            if (_Quantidade <= 28)
            {
                button40.Visible = false; button39.Visible = false;
                button38.Visible = false; button37.Visible = false;
                button36.Visible = false; button35.Visible = false;
                button34.Visible = false; button33.Visible = false;
                button32.Visible = false; button31.Visible = false;
                button30.Visible = false; button29.Visible = false;

            }
            if (_Quantidade <= 29)
            {
                button40.Visible = false; button39.Visible = false;
                button38.Visible = false; button37.Visible = false;
                button36.Visible = false; button35.Visible = false;
                button34.Visible = false; button33.Visible = false;
                button32.Visible = false; button31.Visible = false;
                button30.Visible = false;

            }




            if (_Quantidade <= 30)
            {
                button40.Visible = false; button39.Visible = false;
                button38.Visible = false; button37.Visible = false;
                button36.Visible = false; button35.Visible = false;
                button34.Visible = false; button33.Visible = false;
                button32.Visible = false; button31.Visible = false;
            }
            if (_Quantidade <= 31)
            {
                button40.Visible = false; button39.Visible = false;
                button38.Visible = false; button37.Visible = false;
                button36.Visible = false; button35.Visible = false;
                button34.Visible = false; button33.Visible = false;
                button32.Visible = false;
            }
            if (_Quantidade <= 32)
            {
                button40.Visible = false; button39.Visible = false;
                button38.Visible = false; button37.Visible = false;
                button36.Visible = false; button35.Visible = false;
                button34.Visible = false; button33.Visible = false;

            }
            if (_Quantidade <= 33)
            {
                button40.Visible = false; button39.Visible = false;
                button38.Visible = false; button37.Visible = false;
                button36.Visible = false; button35.Visible = false;
                button34.Visible = false;
            }
            if (_Quantidade <= 34)
            {
                button40.Visible = false; button39.Visible = false;
                button38.Visible = false; button37.Visible = false;
                button36.Visible = false; button35.Visible = false;
            }

            if (_Quantidade <= 35)
            {
                button40.Visible = false; button39.Visible = false;
                button38.Visible = false; button37.Visible = false;
                button36.Visible = false;
            }
            if (_Quantidade <= 36)
            {
                button40.Visible = false; button39.Visible = false;
                button38.Visible = false; button37.Visible = false;
            }

            if (_Quantidade <= 37)
            {
                button40.Visible = false; button39.Visible = false;
                button38.Visible = false;
            }

            if (_Quantidade <= 38)
            {
                button40.Visible = false; button39.Visible = false;

            }

            if (_Quantidade <= 39)
            {
                button40.Visible = false;

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


                    if (radioButton1.Checked == true && radioButton1.Text == certa)
                    {

                        Nota = Nota + ValorQuestao;
                    }

                    if (radioButton2.Checked == true && radioButton2.Text == certa)
                    {
                        Nota = Nota + ValorQuestao;
                    }

                    if (radioButton3.Checked == true && radioButton3.Text == certa)
                    {
                        Nota = Nota + ValorQuestao;
                    }

                    if (radioButton4.Checked == true && radioButton4.Text == certa)
                    {
                        Nota = Nota + ValorQuestao;
                    }

                    if (radioButton5.Checked == true && radioButton5.Text == certa)
                    {
                        Nota = Nota + ValorQuestao;

                    }

                }

                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton5.Checked = false;

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

            if (btn == 1)
            {
                button1.Enabled = false;
                button1.BackColor = Color.Red;
            }

            if (btn == 2)
            {
                button2.Enabled = false;
                button2.BackColor = Color.Red;
            }

            if (btn == 3)
            {
                button3.Enabled = false;
                button3.BackColor = Color.Red;
            }

            if (btn == 4)
            {
                button4.Enabled = false;
                button4.BackColor = Color.Red;
            }

            if (btn == 5)
            {
                button5.Enabled = false;
                button5.BackColor = Color.Red;
            }

            if (btn == 6)
            {
                button6.Enabled = false;
                button6.BackColor = Color.Red;
            }

            if (btn == 7)
            {
                button7.Enabled = false;
                button7.BackColor = Color.Red;
            }

            if (btn == 8)
            {
                button8.Enabled = false;
                button8.BackColor = Color.Red;
            }

            if (btn == 9)
            {
                button9.Enabled = false;
                button9.BackColor = Color.Red;
            }

            if (btn == 10)
            {
                button10.Enabled = false;
                button10.BackColor = Color.Red;
            }

            if (btn == 11)
            {
                button11.Enabled = false;
                button11.BackColor = Color.Red;
            }

            if (btn == 12)
            {
                button12.Enabled = false;
                button12.BackColor = Color.Red;
            }

            if (btn == 13)
            {
                button13.Enabled = false;
                button13.BackColor = Color.Red;
            }

            if (btn == 14)
            {
                button14.Enabled = false;
                button14.BackColor = Color.Red;
            }

            if (btn == 15)
            {
                button15.Enabled = false;
                button15.BackColor = Color.Red;
            }

            if (btn == 16)
            {
                button16.Enabled = false;
                button16.BackColor = Color.Red;
            }

            if (btn == 17)
            {
                button17.Enabled = false;
                button17.BackColor = Color.Red;
            }

            if (btn == 18)
            {
                button18.Enabled = false;
                button18.BackColor = Color.Red;
            }

            if (btn == 19)
            {
                button19.Enabled = false;
                button19.BackColor = Color.Red;
            }

            if (btn == 20)
            {
                button20.Enabled = false;
                button20.BackColor = Color.Red;
            }

            if (btn == 21)
            {
                button21.Enabled = false;
                button21.BackColor = Color.Red;
            }

            if (btn == 22)
            {
                button22.Enabled = false;
                button22.BackColor = Color.Red;
            }

            if (btn == 23)
            {
                button23.Enabled = false;
                button23.BackColor = Color.Red;
            }

            if (btn == 24)
            {
                button24.Enabled = false;
                button24.BackColor = Color.Red;
            }

            if (btn == 25)
            {
                button25.Enabled = false;
                button25.BackColor = Color.Red;
            }

            if (btn == 26)
            {
                button26.Enabled = false;
                button26.BackColor = Color.Red;
            }

            if (btn == 27)
            {
                button27.Enabled = false;
                button27.BackColor = Color.Red;
            }

            if (btn == 28)
            {
                button28.Enabled = false;
                button28.BackColor = Color.Red;
            }

            if (btn == 29)
            {
                button29.Enabled = false;
                button29.BackColor = Color.Red;
            }

            if (btn == 30)
            {
                button30.Enabled = false;
                button30.BackColor = Color.Red;
            }

            if (btn == 31)
            {
                button31.Enabled = false;
                button31.BackColor = Color.Red;
            }

            if (btn == 32)
            {
                button32.Enabled = false;
                button32.BackColor = Color.Red;
            }

            if (btn == 33)
            {
                button33.Enabled = false;
                button33.BackColor = Color.Red;
            }

            if (btn == 34)
            {
                button34.Enabled = false;
                button34.BackColor = Color.Red;
            }

            if (btn == 35)
            {
                button35.Enabled = false;
                button35.BackColor = Color.Red;
            }

            if (btn == 36)
            {
                button36.Enabled = false;
                button36.BackColor = Color.Red;
            }

            if (btn == 37)
            {
                button37.Enabled = false;
                button37.BackColor = Color.Red;
            }

            if (btn == 38)
            {
                button38.Enabled = false;
                button38.BackColor = Color.Red;
            }

            if (btn == 39)
            {
                button39.Enabled = false;
                button39.BackColor = Color.Red;
            }

            if (btn == 40)
            {
                button40.Enabled = false;
                button40.BackColor = Color.Red;
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


// codigo para selecionar o botao

//  String Questao = Convert.ToString(dr["IDQUESTAO"]);

//String RespA = Convert.ToString(dr["RESPOSTAA"]);

//String RespB = Convert.ToString(dr["RESPOSTAB"]);

//String RespC = Convert.ToString(dr["RESPOSTAC"]);

//String RespD = Convert.ToString(dr["RESPOSTAD"]);

//String RespCerta = Convert.ToString(dr["RESPOSTACERTA"]);

//lblQuestao.Text = Questao;

//String[] arr1 = new String[5]; // Crie uma matriz.
//arr1[0] = RespA;
//arr1[1] = RespB;
//arr1[2] = RespC;
//arr1[3] = RespD;
//arr1[4] = RespCerta;

//Random n = new Random();

//radioButton1.Text = arr1[0].ToString();

//radioButton2.Text = arr1[1].ToString();

//radioButton3.Text = arr1[2].ToString();

//radioButton4.Text = arr1[3].ToString();

//radioButton5.Text = arr1[4].ToString();
//public void DesenharLugares()
//{
//    // pnl_seats é um controle Panel
//    pnl_respostas.Controls.Clear();

//    // Aqui armazena uma lista com os botoes para depois chamar (AddRange) no painel
//    BDC.Prova prova = new BDC.Prova();
//    prova.IdProva = Convert.ToInt32(lblIdProva.Text);
//    prova.ConsultarRespostaQuest();
//    var btnsResp = new List<Control>();
//    // Suspende o layout para evitar a Redesenho / Atualização que não é desejado

//    int DimensaoLugar = 300; //pixel Tamanho do botão - formato Quadrado
//    int LinhasHorizontal = 1;
//    int ColunasVertical = 5;

//    this.SuspendLayout();
//    for (int y = 0; y < LinhasHorizontal; y++)
//    {
//        for (int x = 0; x < ColunasVertical; x++)
//        {
//            // Verificar se existe na posição / coordenada
//            if (IsException(x, y))
//                continue;
//            // Constroi o botão com as propriedades desejadas. Dimensao e Lugar é um valor comum para cada botão
//            var btn = new Button
//            {

//                BackColor = Color.LimeGreen,
//                Width = DimensaoLugar,
//                Height = DimensaoLugar,
//                Left = (x * DimensaoLugar),
//                Top = (y * DimensaoLugar),

//                //Text = y + "" + x,

//                Text = Convert.ToChar(65 + y) + "RESPOSTA:" + (x + 1),

//                Tag = y + ";" + x, //Quando se clica no botão a finalidade desta propriedade TAG é lembrar qual é o assento associado botão.

//                Font = new Font(new FontFamily("Microsoft Sans Serif"), 7.5f), //muito pequena a fonte em 6.5
//            };


//            // Verifica se já está reservado o assento
//            if (ExistsReservation(x, y))
//            {
//                btn.Enabled = true;
//            }
//            else
//            {
//                btn.Click += btn_seat_Click; // Adiciona o evento click - o mesmo evento associado ao unico botão 'btn_seat' no formulário. o BOTÃO btn_seat É CRIADO NO FORM POREM COM A PROPRIEDADE VISIBLE true

//            }

//            btnsResp.Add(btn);
//        }
//    }

//    // Como feito antes, adicionando todos os botões em uma única chamada no painel
//    pnl_respostas.Controls.AddRange(btnsResp.ToArray());

//    // retomar a construção do layout
//    this.ResumeLayout();
//}



// Quantidade

//public void DesenhasLugaresButao()
//{

//    // pnl_seats é um controle Panel
//    pnl_seats.Controls.Clear();

//    // Aqui armazena uma lista com os botoes para depois chamar (AddRange) no painel
//    BDC.Prova prova = new BDC.Prova();
//    prova.IdProva = Convert.ToInt32(lblIdProva.Text);

//    Sql.DataAccess.Client.SqlDataReader dr3;
//    dr3 = prova.ConsultarQuantidade();
//    dr3.Read();
//    int Quantidade = Convert.ToInt32(dr3[0]);

//    var btns = new List<Control>();

//    //ArrayList quant = new ArrayList();



//    // Suspende o layout para evitar a Redesenho / Atualização que não é desejado


//    int DimensaoLugar = 50; //pixel Tamanho do botão - formato Quadrado
//    int LinhasHorizontal = 0;
//    int ColunasVertical = 0;
//    if (Quantidade % 2 == 1)
//    {
//        LinhasHorizontal = (Int32)Math.Sqrt(Quantidade) + 1;
//    }
//    else
//    {
//        LinhasHorizontal = (Int32)Math.Sqrt(Quantidade);

//    }
//    if (Quantidade % 2 == 1)
//    {
//        ColunasVertical = (Int32)Math.Sqrt(Quantidade);
//    }
//    else
//    {
//        ColunasVertical = (Int32)Math.Sqrt(Quantidade);

//    }
//    Lotacao = Quantidade;
//    lblLotacao.Text = Lotacao.ToString();

//    Disponivel = Lotacao;
//    lblDisponivel.Text = Disponivel.ToString();

//    this.SuspendLayout();
//    for (int y = 0; y < LinhasHorizontal; y++)
//    {
//        for (int x = 0; x < ColunasVertical; x++)
//        {
//            // Verificar se existe na posição / coordenada
//            if (IsException(x, y))
//                continue;
//            // Constroi o botão com as propriedades desejadas. Dimensao e Lugar é um valor comum para cada botão

//            var btn = new Button
//            {

//                BackColor = Color.Gray,
//                Width = DimensaoLugar,
//                Height = DimensaoLugar,
//                Left = (x * DimensaoLugar),
//                Top = (y * DimensaoLugar),

//                //Text = y + "" + x,
//                Text = Convert.ToChar(65 + y) + "QUESTÃO:" + (x + 1),

//                Tag = y + ";" + x, //Quando se clica no botão a finalidade desta propriedade TAG é lembrar qual é o assento associado botão.

//                Font = new Font(new FontFamily("Microsoft Sans Serif"), 7.5f), //muito pequena a fonte em 6.5
//            };
//            btns.Add(btn);
//            //  Verifica se já está reservado o assento

//            if (ExistsReservation(x, y))
//            {
//                btn.Enabled = true;
//            }
//            else
//            {
//                btn.Click += btn_seat_Click; // Adiciona o evento click - o mesmo evento associado ao unico botão 'btn_seat' no formulário. o BOTÃO btn_seat É CRIADO NO FORM POREM COM A PROPRIEDADE VISIBLE true

//            }






//        }
//    }

//    // Como feito antes, adicionando todos os botões em uma única chamada no painel
//    pnl_seats.Controls.AddRange(btns.ToArray());

//    // retomar a construção do la
//}