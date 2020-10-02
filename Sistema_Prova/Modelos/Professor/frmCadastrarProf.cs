using System;
using System.Collections;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using System.Data.SqlClient;
using System.Windows.Forms;
using System.Web.UI.WebControls;

namespace Sistema_Prova.Modelos.Professor
{
    public partial class frmCadastrarProf : Form
    {

        private static
                string strConexaoOra =
            @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";


        private ArrayList _quest = new ArrayList();

        public ArrayList quest
        {
            get { return _quest; }
            set { _quest = value; }
        }



        private ArrayList _quest2 = new ArrayList();

        public ArrayList quest2
        {
            get { return _quest2; }
            set { _quest2 = value; }
        }

        public frmCadastrarProf()
        {
            InitializeComponent();
            txtUsuario.Enabled = false;

            maskedCadastro.Enabled = false;
            maskedAcesso.Enabled = false;
            maskedAcesso.Text = Convert.ToString(System.DateTime.Today);
            maskedCadastro.Text = Convert.ToString(System.DateTime.Today);
        }
        private void proximoControle(System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
            }
        }


        private void proximoControle(object o, KeyPressEventArgs e)
        {
            proximoControle(e);
        }

        private void Cadastrar(object sender, EventArgs e)
        {
            BDC.Professor prof = new BDC.Professor();

            SqlDataReader dr2;
            prof.Rm = Convert.ToInt32(txtRM.Text);
            dr2 = prof.Consultar();
            dr2.Read();

            if (dr2.HasRows)
            {


                MessageBox.Show("ESTE USUÁRIO JÁ EXISTE");
                this.txtNome.Text = null;
                this.txtUsuario.Text = null;
                this.txtRM.Text = null;
                this.txtNome.Focus();
            }

            else
            {
                try
                {
                    if (this.txtNome.Text == String.Empty)
                    {
                        this.erro.SetError(this.txtNome, "Campo obrigatório");
                        this.txtNome.Focus();
                        return;
                    }
                    if (this.txtRM.Text == String.Empty)
                    {
                        this.erro.SetError(this.txtRM, "Campo obrigatório");
                        this.txtRM.Focus();
                        return;
                    }

                    if (this.txtSenha.Text == String.Empty)
                    {
                        this.erro.SetError(this.txtSenha, "Campo obrigatório");
                        this.txtSenha.Focus();
                        return;
                    }

                    //Atribuir os valores dos das caixas nas variaveis
                    BDC.Professor adm = new BDC.Professor();
                    BDC.Login objLogin = new BDC.Login();

                    int IdNivelAcesso = 0;

                    string Usuario = "";

                    string Senha = "";






                    string DataCadastro = maskedCadastro.Text;
                    string DataAcesso = maskedAcesso.Text;

                    int Rm = Convert.ToInt32(this.txtRM.Text);
                    string Nome = this.txtNome.Text;

                    IdNivelAcesso = 1;

                    Usuario = this.txtUsuario.Text;

                    Senha = this.txtSenha.Text;

                    int Ativo;



                    Ativo = 1;


                    try
                    {


                        IdNivelAcesso = 1;

                        Usuario = this.txtUsuario.Text;

                        Senha = this.txtSenha.Text;


                        SqlConnection connLogin = new SqlConnection(strConexaoOra);
                        connLogin.Open();
                        string SQLLogin = "insert  SistemaP.DBO.tb_user values ('" + Usuario.ToUpper() + "', '" + Senha.ToUpper() + "','" + IdNivelAcesso + "','1')";

                        SqlCommand commLogin = new SqlCommand(SQLLogin, connLogin);
                        int y = commLogin.ExecuteNonQuery();
                        connLogin.Close();


                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message + "login");
                    }




                    SqlConnection conn = new SqlConnection(strConexaoOra);
                    conn.Open();
                    string SQL = "INSERT INTO SistemaP.DBO.tb_Prof (RM_Professor, NOME, login, ULTIMOACESSO, CADASTRO,  STATUS) VALUES ('" + Rm + "', '" + Nome.ToUpper() + "','" + Usuario.ToUpper() + "','" + DataAcesso + "', '" + DataCadastro + "', '" + Ativo + "')";

                    SqlCommand comm = new SqlCommand(SQL, conn);
                    int x = comm.ExecuteNonQuery();
                    conn.Close();






                    int quantidade = checkedListBox1.CheckedItems.Count;

                    conn.Open();

                    try
                    {


                        SqlConnection conn8 = new SqlConnection(strConexaoOra);
                        conn8.Open();
                        foreach (object item in checkedListBox1.CheckedItems)
                        {

                            //  listBox2.Items.Add(item);
                            string SQL2 = "INSERT INTO SistemaP.DBO.PROF_MATERIA (RM_Professor, materia_prof) VALUES ('" + Rm + "', '" + item + "')";
                            SqlCommand comm2 = new SqlCommand(SQL2, conn8);
                            int z = comm2.ExecuteNonQuery();
                        }
                        conn8.Close();


                        //foreach (object item in checkedListBox1.CheckedItems)
                        //{
                        //for (int i = 0; i < quantidade; i++)
                        //    {
                        //  SqlConnection conn2 = new SqlConnection(strConexaoOra);
                        //  conn.Open();
                        //string disc = checkedListBox1.GetItemChecked(1).ToString();

                        //if (z == 1)
                        //{
                        //    MessageBox.Show("<AS MATERIAS TBM FORA CAMDASTRADAS>");
                        //}



                        //for (int i = 0; i < checkedListBox1.Items.Count; i++)
                        //{
                        //    if (checkedListBox1.GetItemCheckState(i) == CheckState.Checked)
                        //    {
                        //        string disc = checkedListBox1.Items[i].ToString();
                        //        string SQL2 = "INSERT INTO SistemaP.DBO.PROF_MATERIA (RM_Professor, materia_prof) VALUES ('" + Rm + "', '" + disc + "')";
                        //        SqlCommand comm2 = new SqlCommand(SQL2, conn);
                        //        int z = comm2.ExecuteNonQuery();
                        //    }

                        //foreach (var item in checkedListBox1.SelectedItem.ToString())
                        //{

                        //    string SQL2 = "INSERT INTO SistemaP.DBO.PROF_MATERIA (RM_Professor, materia_prof) VALUES ('" + Rm + "', '" + item.ToString() + "')";
                        //    SqlCommand comm2 = new SqlCommand(SQL2, conn);
                        //    int z = comm2.ExecuteNonQuery();
                        //}









                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }


                    if (x == 1)
                    {
                        MessageBox.Show("PROF CADASTRADO COM SUCESSO");
                    }




                    //SqlConnection connMateria = new SqlConnection(strConexaoOra);
                    //connLogin.Open();
                    ////foreach (int i = 0; i < length; i++)
                    ////{
                    //// i = "INSERT INTO SistemaP.DBO.materia_Prof (RM_Professor, Materia_prof) VALUES ('" + Rm + "', '" + Materias + "',);";

                    ////}





                    //SqlCommand commMateria = new SqlCommand(SQLMateria, connLogin);
                    //int z = commMateria.ExecuteNonQuery();





                    Limpar();


                    senha();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //throw;
                }
            }
        }

        private void Limpar()
        {
            try
            {
                this.txtNome.Text = null;
                this.txtSenha.Text = null;
                this.txtUsuario.Text = null;
                this.txtRM.Text = null;
                this.txtNome.Focus();
                foreach (int checados in checkedListBox1.CheckedIndices)
                {
                    checkedListBox1.SetItemChecked(checados, false);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ", ex.Message);
                //throw;
            }


        }


        private void LimparC()
        {
            string message = "deseja limpar tudo?";
            string caption = "Error detected in imput";
            DialogResult result;
            MessageBoxButtons button = MessageBoxButtons.YesNo;

            result = MessageBox.Show(message, caption, button);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Limpar();
            }


        }

        private void Limpar(object sender, EventArgs e)
        {
            try
            {
                LimparC();
                foreach (int checados in checkedListBox1.CheckedIndices)
                {
                    checkedListBox1.SetItemChecked(checados, false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ", ex.Message);
                //throw;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            string message = "DESEJA MESMO SAIR?";
        }

        private void PassarTxt(object o, EventArgs e)
        {

            String value = txtNome.Text;
            string[] colunas = value.Split(' ');

            if (colunas[0].Equals(" "))
            {
                txtUsuario.Text = colunas[1] + "_" + txtRM.Text;
            }
            else
            {
                txtUsuario.Text = colunas[0] + "_" + txtRM.Text;

            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void CarregaListBox()
        {
            //instância da conexão 


            try
            {
                BDC.Materia a = new BDC.Materia();

                checkedListBox1.DataSource = a.Listar("").Tables[0];
                checkedListBox1.DisplayMember = "materia_prof";
                checkedListBox1.ValueMember = "id_materia";



            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO>>>>>");

                //  throw ex;
            }


        }





        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void frmCadastrarProf_Load(object sender, EventArgs e)
        {
            senha();
            DataTable tbl = new DataTable();


            SqlConnection conn5 = new SqlConnection(strConexaoOra);
            conn5.Open();
            string cmd = "select materia_prof  from tb_materia  ";

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




        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarregaListBox();
        }
        private void senha()
        {
            txtSenha.Text = "123456";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void checkLogin_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            {
                // if (txtNome.Text != string.Empty || txtRM.Text != string.Empty || txtSenha.Text != string.Empty)
                //{

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
}
