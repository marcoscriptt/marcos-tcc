using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

using System.Data.SqlClient;

namespace Sistema_Prova
{
    public partial class frmTeste : Form
    {
        public frmTeste()
        {
            InitializeComponent();
        }

        private static
          string strConexaoOra =
      @"Server=DESKTOP-HKS0009    ;Database=SistemaP; User Id=equipe7;Password=123456;";



        private void frmTeste_Load(object sender, EventArgs e)
        {
            try
            {
                BDC.Materia a = new BDC.Materia();

                checkedListBox1.DataSource = a.Listar("").Tables[0];
                checkedListBox1.DisplayMember = "materia_prof";
                checkedListBox1.ValueMember = "id_materia";

                listBox2.DataSource = a.Listar("").Tables[0];
                listBox2.DisplayMember = "materia_prof";
                listBox2.ValueMember = "id_materia";

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO>>>>>");

                //  throw ex;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataTable tbl = new DataTable();

          




                    SqlConnection conn5 = new SqlConnection(strConexaoOra);
                    conn5.Open();
                    string cmd = "SELECT titulo FROM SistemaP.DBO.tbquestao;";

                    SqlDataAdapter da = new SqlDataAdapter(cmd, strConexaoOra);

                    da.Fill(tbl);
                
                    conn5.Close();

            

           
                listBox1.Items.Add(listBox2);
       

            foreach (var item in listBox2.SelectedItems.ToString())
            {
                checkedListBox2.Items.Add(item.ToString());
            }
        }
    }
}
