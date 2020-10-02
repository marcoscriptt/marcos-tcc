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
using System.Data.SqlClient;

namespace Sistema_Prova.Rotina.Professor.Provas
{
    public partial class frmCadastrarProva : Form
    {
        public frmCadastrarProva()
        {
            InitializeComponent();


        }

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



        private ArrayList _quest2 = new ArrayList();

        public ArrayList quest2
        {
            get { return _quest5; }
            set { _quest5 = value; }
        }

        private ArrayList _quest5 = new ArrayList();
        public ArrayList quest5
        {
            get { return _quest5; }
            set { _quest5 = value; }
        }

        private string _NomeProf;

        public string NomeProf
        {
            get { return _NomeProf; }
            set { _NomeProf = value; }
        }
        private static string conn1 =
                @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";
        private void frmCadastrarProva_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();


                SqlConnection conn5 = new SqlConnection(strConexaoOra);
                conn5.Open();
                string cmd = "select Titulo from tbquestao WHERE RM_PROFESSOR =  '" + RMQUEST + "'";

                SqlDataAdapter da = new SqlDataAdapter(cmd, strConexaoOra);

                da.Fill(tbl);

                try
                {

                    foreach (DataRow item in tbl.Rows)
                    {
                        _quest.Add(item[0]);

                    }
                    for (int i = 0; i < tbl.Rows.Count; i++)
                    {
                        //  listBox1.Items.Add(_quest[i].ToString());
                        checkedListBox1.Items.Add(_quest[i].ToString());
                    }



                    conn5.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }














                BDC.Materia tu = new BDC.Materia();


                cboMateriaP.DataSource = tu.Listar("").Tables[0];
                cboMateriaP.DisplayMember = "MATERIA_PROF";
                cboMateriaP.ValueMember = "id_materia";
                cboMateriaP.SelectedIndex = -1;





                listarQ();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO>>>>>");

                //  throw ex;
            }
        }


        private void Cadastrar(object sender, EventArgs e)
        {


            try
            {

                if (this.txtTitulo.Text == String.Empty)
                {
                    this.erro.SetError(this.txtTitulo, "Campo obrigatório");
                    this.txtTitulo.Focus();
                    return;
                }
                if (this.cboMateriaP.Text == String.Empty)
                {
                    this.erro.SetError(this.cboMateriaP, "Erro no preenchimento do campo");
                    this.cboMateriaP.Focus();
                    return;
                }





                //  int Id = Convert.ToInt32(this.txtId.Text);
                int quantidade = checkedListBox1.CheckedItems.Count;
                String Titulo = this.txtTitulo.Text;
                String Categoria = this.cboMateriaP.Text;



                int Ativo = 0;




                SqlConnection conn = new SqlConnection(strConexaoOra);
                conn.Open();
                string SQL = "INSERT INTO SistemaP.DBO.tbprova (idprova, prova,ETIQUETA, nome_prof,materia_prova,status, QUANTIDADE) VALUES (next value for SistemaP.DBO.SEQ_PROVA, '" + Titulo + "','" + txtEtiqueta.Text + "','" + NomeProf
                    + "', '" + Categoria + "', '" + Ativo + "', '" + quantidade + "')";

                SqlCommand comm = new SqlCommand(SQL, conn);
                int x = comm.ExecuteNonQuery();

                conn.Close();

                SqlDataReader dr;

                BDC.Prova pr = new BDC.Prova();

                dr = pr.ConsultarSeq();
                dr.Read();
                string seq = Convert.ToString(dr["current_value"]);

                ArrayList quest = new ArrayList();

                BDC.Questoes a = new BDC.Questoes();

                DataTable tbl = new DataTable();


                SqlConnection conn5 = new SqlConnection(strConexaoOra);
                conn5.Open();
                //    string cmd = "select Titulo from tbquestao WHERE RM_PROFESSOR =  '" + RMQUEST + "'";

                //   SqlDataAdapter da = new SqlDataAdapter(cmd, strConexaoOra);

                //    da.Fill(tbl);
                string sql2 = "";


                foreach (object item in checkedListBox1.CheckedItems)
                {
                    sql2 = "SELECT IDQUESTAO FROM SistemaP.DBO.TBQUESTAO where titulo= '" + item + "'";
                    SqlConnection conn2 = new SqlConnection(strConexaoOra);
                    conn2.Open();
                    SqlCommand cmd2 = new SqlCommand(sql2, conn2);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd2);
                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    foreach (DataRow item2 in dt.Rows)
                    {
                        quest.Add(item2[0]);




                        conn2.Close();

                    }


                }


                    foreach (object item3 in quest)
                    {


                        SqlConnection conn0 = new SqlConnection(strConexaoOra);
                        conn0.Open();
                        string SQL2 = "INSERT INTO SistemaP.DBO.TBPROVA_QUESTAO (idProva, IDQUESTAO) VALUES ('" + seq + "', '" + item3 + "')";
                        SqlCommand comm2 = new SqlCommand(SQL2, conn0);
                        int z = comm2.ExecuteNonQuery();
                    }

                conn5.Close();




                MessageBox.Show("prova cadastrada com sucesso");
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
            try
            {
                txtTitulo.Text = null;
                foreach (int checados in checkedListBox1.CheckedIndices)
                {
                    checkedListBox1.SetItemChecked(checados, false);
                }
                this.cboMateriaP.SelectedIndex = -1;
                //  this.txtId.Text = null;
                this.txtTitulo.Text = null;
                //  this.listBox1.Text = null;
                this.txtTitulo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ", ex.Message);
                //throw;
            }


        }







        private void button3_Click(object sender, EventArgs e)
        {
            string message = "DESEJA MESMO SAIR?";
        }






        private void Listar(object sender, EventArgs e)
        {


        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                BDC.Questoes a = new BDC.Questoes();

                //listBox2.DataSource = a.Listar(txtBuscar.Text).Tables[0];
                //listBox2.DisplayMember = "titulo";
                //listBox2.ValueMember = "id_questao";
                //foreach (var item in Listar())
                //{
                //    this.listBox1.Items.Add(item);
                //}
                //listBox2.Refresh();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO>>>>>");

                //  throw ex;
            }

        }
        private void listarQ()
        {
            try
            {

                //BDC.Questoes a = new BDC.Questoes();
                //BDC.Materia b = new BDC.Materia();


                //listBox2.DataSource = a.Listar("").Tables[0];
                //listBox2.DisplayMember = "titulo";
                //listBox2.ValueMember = "id_questao";


                //cboMateriaP.DataSource = b.Listar(txtBuscar.Text).Tables[0];
                //cboMateriaP.DisplayMember = "materia_prof";
                //cboMateriaP.ValueMember = "id_materia";
                //cboMateriaP.SelectedIndex = -1;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                //  throw ex;
            }

        }


        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }



        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabQuestao_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtRespostaB_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabProva_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtAplicador_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtRespostaCerta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtQuestao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRespostaD_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkAtivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtRespostaA_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtRespostaC_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtIdQuest_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtTitulo.Text = null;
            cboMateriaP.SelectedIndex = -1;
            foreach (int checados in checkedListBox1.CheckedIndices)
            {
                checkedListBox1.SetItemChecked(checados, false);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listarQ();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            string message = "DESEJA MESMO SAIR?";
        }

        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
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

        private void button2_Click_2(object sender, EventArgs e)
        {
        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {


                String conn1 =
                       @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";
                string keyword = checkedListBox1.CheckedItems.ToString();
                string sql = "SELECT QUESTAO FROM SistemaP.DBO.TBQUESTAO where TITULO like'%" + keyword + "%'";
                SqlConnection conn = new SqlConnection(conn1);
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                checkedListBox1.DataSource = dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void checkedListBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }
    }
}
