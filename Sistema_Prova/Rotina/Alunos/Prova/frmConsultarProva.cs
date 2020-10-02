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

namespace Sistema_Prova.Rotina.Alunos.Prova
{
    public partial class frmConsultarProva : Form
    {
        public frmConsultarProva()
        {
            InitializeComponent();
        }



        private String _Turma;

        public String Turma
        {
            get { return _Turma; }
            set { _Turma = value; }
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

        //private void Alterar(object sender, EventArgs e)
        //{
        //    try
        //    {

        //        BDC.Prova adm = new BDC.Prova();


        //        Rotina.Professor.Provas.frmAlterarProva falt = new Rotina.Professor.Provas.frmAlterarProva();
        //        SqlDataReader dr;

        //        adm = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value);

        //        dr = adm.Consultar();

        //        if (dr.Read())
        //        {
        //            falt.txt.Text = dr["Titulo"].ToString();
        //            falt.txtQuestao.Text = dr["Questao"].ToString();
        //            falt.txtRespostaA.Text = dr["RespostaA"].ToString();
        //            falt.txtRespostaB.Text = dr["RespostaB"].ToString();
        //            falt.txtRespostaC.Text = dr["RespostaC"].ToString();
        //            falt.txtRespostaD.Text = dr["RespostaD"].ToString();
        //            falt.txtRespostaCerta.Text = dr["RespostaCerta"].ToString();




        //            if (dr["STATUS"].ToString() == "1")
        //            {
        //                falt.chkAtivo.Checked = true;
        //            }
        //            else if (dr["STATUS"].ToString() == "0")
        //            {
        //                falt.chkAtivo.Checked = false;
        //            }



        //        }


        //        falt.ShowDialog();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Erro ao alterar");
        //        throw ex;
        //    }
        //}



        private void CarregarGrid()
        {
            BDC.Prova adm = new BDC.Prova();
            try
            {
                String conn =
                @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";

                string sql = "select idprova,prova, etiqueta, materia_prova, NOME_PROF FROM SistemaP.DBO.tbprova where prova = '" + txtPesquisa.Text + "'";

                SqlConnection con = new SqlConnection(conn);
                SqlCommand com = new SqlCommand(sql, con);
                try
                {
                    SqlDataAdapter Da = new SqlDataAdapter(com);
                    DataTable dlista = new DataTable();
                    Da.Fill(dlista);
                    if (dlista.Rows.Count == 0)
                    {
                        dgv.Columns.Clear();
                        string sql2 = "select idprova, prova,NOME_PROF, materia_prova, quantidade FROM SistemaP.DBO.tbprova order by prova ";

                        SqlConnection con2 = new SqlConnection(conn);
                        SqlCommand com2 = new SqlCommand(sql2, con2);


                        try
                        {
                            SqlDataAdapter Da2 = new SqlDataAdapter(com2);
                            DataTable dlista2 = new DataTable();
                            Da2.Fill(dlista2);
                            dgv.DataSource = dlista2;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            // throw;
                        }

                    }
                    else
                    {
                        dgv.DataSource = dlista;
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    // throw;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }



        private void AbrirProva()
        {

            // abrir form de prova e inserir questoes e respostas nos botoes
            //  feito!!!



        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            BDC.Prova prova = new BDC.Prova();
            try
            {
                dgv.DataSource = prova.Listar(this.txtPesquisa.Text).Tables[0].ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        //aquiiiiiiiiiiii
        private void button1_Click2(object sender, EventArgs e)
        {
            try
            {

                BDC.Prova prova = new BDC.Prova();
                BDC.Notas confer = new BDC.Notas();

                frmProva falt = new frmProva();
                SqlDataReader dr, dr2;

                prova.IdProva = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value);

                dr = prova.Consultar2();
                confer.Confer = Convert.ToString(this.dgv.CurrentRow.Cells[0].Value);

                dr2 = confer.ConsultarConfer();
                dr2.Read();
                if (dr2.HasRows)
                {
                    MessageBox.Show("PARECE QUE VC JÁ FEZ ESSA PROVA!");
                }
                else
                {

                    if (dr.Read())
                    {





                        falt.lblIdProva.Text = Convert.ToString(this.dgv.CurrentRow.Cells[0].Value);
                        falt.lblMateria.Text = Convert.ToString(dr["MATERIA_PROVA"]).ToUpper();
                        falt.lblProf.Text = Convert.ToString(dr["NOME_PROF"]).ToUpper();
                        falt.Idprova = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value);
                        falt.lblTituloProva.Text =  Convert.ToString(dr["PROVA"].ToString());


                    }
                    
                    falt.button1.Enabled = false;
                    falt.button2.Enabled = false;
                    falt.button3.Enabled = false;
                    falt.button4.Enabled = false;
                    falt.button5.Enabled = false;
                    falt.button6.Enabled = false;
                    falt.button7.Enabled = false;
                    falt.button8.Enabled = false;
                    falt.button9.Enabled = false;
                    falt.button10.Enabled = false;
                    falt.button11.Enabled = false;
                    falt.button12.Enabled = false;
                    falt.button13.Enabled = false;
                    falt.button14.Enabled = false;
                    falt.button15.Enabled = false;
                    falt.button16.Enabled = false;
                    falt.button17.Enabled = false;
                    falt.button18.Enabled = false;
                    falt.button19.Enabled = false;
                    falt.button20.Enabled = false;
                    falt.button21.Enabled = false;
                    falt.button22.Enabled = false;
                    falt.button23.Enabled = false;
                    falt.button24.Enabled = false;
                    falt.button25.Enabled = false;
                    falt.button26.Enabled = false;
                    falt.button27.Enabled = false;
                    falt.button28.Enabled = false;
                    falt.button29.Enabled = false;
                    falt.button30.Enabled = false;
                    falt.button31.Enabled = false;
                    falt.button32.Enabled = false;
                    falt.button33.Enabled = false;
                    falt.button34.Enabled = false;
                    falt.button35.Enabled = false;
                    falt.button36.Enabled = false;
                    falt.button37.Enabled = false;
                    falt.button38.Enabled = false;
                    falt.button39.Enabled = false;
                    falt.button40.Enabled = false;


                    falt.TextoTeste = _TextoTeste;
                    falt.TextoTesteRM = _TextoTesteRM;
                    falt.ShowDialog();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw ex;
            }
        }
        public DataTable Select()
        {
            String conn1 =
      @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";

            SqlConnection conn = new SqlConnection(conn1);
            DataTable dt = new DataTable();
            try
            {
                // string sql = "";

                string sql = "select idprova,prova, etiqueta, materia_prova, NOME_PROF FROM SistemaP.DBO.tbprova where prova = '" + txtPesquisa.Text + "' and status =1";





                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        private void frmConsultarProva_Load(object sender, EventArgs e)
        {
            Select1();
        }

        public DataTable Select1()
        {
            String conn1 =
      @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";

            SqlConnection conn = new SqlConnection(conn1);
            DataTable dt = new DataTable();
            try
            {
                string sql = "select idprova,prova, etiqueta, materia_prova, NOME_PROF FROM SistemaP.DBO.tbprova where turmaatual = '" + _Turma + "'";


   


                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
                dgv.DataSource = dt;

                this.dgv.Columns[0].HeaderText = "ID";
                this.dgv.Columns[1].HeaderText = "PROVA";
                this.dgv.Columns[2].HeaderText = "ETIQUETA";
                this.dgv.Columns[3].HeaderText = "MATERIA";
                this.dgv.Columns[4].HeaderText = "PROFESSOR";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            try
            {


                String conn1 =
                       @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";
                string keyword = txtPesquisa.Text;
                string sql = "select idprova,prova, etiqueta, materia_prova, NOME_PROF FROM SistemaP.DBO.tbprova where prova  like'%" + keyword + "%'";
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
            this.txtPesquisa.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click_1(object sender, EventArgs e)
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














        //    private void btnBuscar_Click(object sender, EventArgs e)
        //    {
        //        try
        //        {
        //            String conn =
        //            @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";

        //            string sql = "select * FROM SistemaP.DBO.tbprova where prova = '" + txtPesquisa.Text + "'";

        //            SqlConnection con = new SqlConnection(conn);
        //            SqlCommand com = new SqlCommand(sql, con);
        //            try
        //            {
        //                SqlDataAdapter Da = new SqlDataAdapter(com);
        //                DataTable dlista = new DataTable();
        //                Da.Fill(dlista);
        //                if (dlista.Rows.Count == 0)
        //                {
        //                    MessageBox.Show("sem registros");
        //                    dgv.Columns.Clear();
        //                    string sql2 = "select * FROM SistemaP.DBO.tbprova order by prova";

        //                    SqlConnection con2 = new SqlConnection(conn);
        //                    SqlCommand com2 = new SqlCommand(sql2, con2);


        //                    try
        //                    {
        //                        SqlDataAdapter Da2 = new SqlDataAdapter(com2);
        //                        DataTable dlista2 = new DataTable();
        //                        Da2.Fill(dlista2);
        //                        dgv.DataSource = dlista2;
        //                    }
        //                    catch (Exception ex)
        //                    {
        //                        MessageBox.Show(ex.Message);
        //                        // throw;
        //                    }

        //                }
        //                else
        //                {
        //                    dgv.DataSource = dlista;
        //                }


        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show(ex.Message);
        //                // throw;
        //            }
        //        }



        //}








    }


}
