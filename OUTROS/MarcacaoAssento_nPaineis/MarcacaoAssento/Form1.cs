using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarcacaoAssento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); //DesenharLugares();
            IdentificarPaineis();
         

        }


        private void IdentificarPaineis()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is Panel)
                    {
                        DesenharLugaresVariosPaineis(control);

                    }
            };

            func(Controls);
        }



        private int _Lotacao;

        public int Lotacao
        {
            get { return _Lotacao; }
            set { _Lotacao = value; }
        }

        private int _Disponivel;

        public int Disponivel
        {
            get { return _Disponivel; }
            set { _Disponivel = value; }
        }


        //baseado no exemplo disponível em https://stackoverflow.com/questions/25058948/how-can-i-instantiate-large-number-of-buttons-in-windows-forms


        public List<string> _seatsExceptions = new List<string>();
        public List<string> _seatsReservations = new List<string>();

        private void Exibir(Object o)
        {
            try
            {
               
                var b = (Button)o;
             
                DialogResult dialogResult = MessageBox.Show("Confirma o local "+b.Text + "?", "Escolha de Local", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    b.BackColor = Color.Red;
                    b.Enabled = false;
                    Disponivel = Disponivel -1;
                    lblDisponivel.Text = Disponivel.ToString();

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

        public bool IsException(int x, int y)
        {
            string key = x.ToString() + ";" + y.ToString();
            return _seatsExceptions.Contains(key);
        }
       
        public bool ExistsReservation(int x, int y)
        {
            string key = x.ToString() + ";" + y.ToString();
            return _seatsReservations.Contains(key);
        }

        

        public void DesenharLugares()
        {
            // pnl_seats é um controle Panel
            pnl_seats.Controls.Clear();

            // Aqui armazena uma lista com os botoes para depois chamar (AddRange) no painel
            
            var btns = new List<Control>();
            // Suspende o layout para evitar a Redesenho / Atualização que não é desejado
            
            int DimensaoLugar = 35; //pixel Tamanho do botão - formato Quadrado
            int LinhasHorizontal = 11;
            int ColunasVertical = 3;
        
            Lotacao = LinhasHorizontal * ColunasVertical;
            lblLotacao.Text = Lotacao.ToString();
        
            Disponivel = Lotacao;
            lblDisponivel.Text = Disponivel.ToString();

            this.SuspendLayout();
            for (int y = 0; y < LinhasHorizontal; y++) 
            {
                for (int x = 0; x < ColunasVertical; x++) 
                {
                    // Verificar se existe na posição / coordenada
                    if (IsException(x, y))
                        continue;
                    // Constroi o botão com as propriedades desejadas. Dimensao e Lugar é um valor comum para cada botão
                    var btn = new Button
                    {
                        BackColor = Color.LimeGreen,
                        Width = DimensaoLugar,
                        Height = DimensaoLugar,
                        Left = (x * DimensaoLugar),
                        Top = (y * DimensaoLugar),

                        //Text = y + "" + x,
                        Text = Convert.ToChar(65+y) + ""+ (x+1),

                        Tag = y + ";" + x, //Quando se clica no botão a finalidade desta propriedade TAG é lembrar qual é o assento associado botão.

                        Font = new Font(new FontFamily("Microsoft Sans Serif"), 7.5f), //muito pequena a fonte em 6.5
                    };


                    // Verifica se já está reservado o assento
                    if (ExistsReservation(x, y))
                    {
                        btn.Enabled = false;
                    }
                    else
                    {
                        btn.Click += btn_seat_Click; // Adiciona o evento click - o mesmo evento associado ao unico botão 'btn_seat' no formulário. o BOTÃO btn_seat É CRIADO NO FORM POREM COM A PROPRIEDADE VISIBLE FALSE

                    }
                    
                    btns.Add(btn);
                }
            }

            // Como feito antes, adicionando todos os botões em uma única chamada no painel
            pnl_seats.Controls.AddRange(btns.ToArray());

            // retomar a construção do layout
            this.ResumeLayout();
        }



        public void DesenharLugaresVariosPaineis(Object o)
        {
            var pnl = (Panel)o;

            // pnl_seats é um controle Panel
            pnl.Controls.Clear();

            // Aqui armazena uma lista com os botoes para depois chamar (AddRange) no painel

            var btns = new List<Control>();
            // Suspende o layout para evitar a Redesenho / Atualização que não é desejado

            int DimensaoLugar = 35; //pixel Tamanho do botão - formato Quadrado
            int LinhasHorizontal = 10;
            int ColunasVertical = 4;

            Lotacao = LinhasHorizontal * ColunasVertical;
            lblLotacao.Text = Lotacao.ToString();

            Disponivel = Lotacao;
            lblDisponivel.Text = Disponivel.ToString();

            this.SuspendLayout();
            for (int y = 0; y < LinhasHorizontal; y++)
            {
                for (int x = 0; x < ColunasVertical; x++)
                {
                    // Verificar se existe na posição / coordenada
                    if (IsException(x, y))
                        continue;
                    // Constroi o botão com as propriedades desejadas. Dimensao e Lugar é um valor comum para cada botão
                    var btn = new Button
                    {
                        BackColor = Color.LimeGreen,
                        Width = DimensaoLugar,
                        Height = DimensaoLugar,
                        Left = (x * DimensaoLugar),
                        Top = (y * DimensaoLugar),

                        //Text = y + "" + x,
                        Text = Convert.ToChar(65 + y) + "" + (x + 1),

                        Tag = y + ";" + x, //Quando se clica no botão a finalidade desta propriedade TAG é lembrar qual é o assento associado botão.

                        Font = new Font(new FontFamily("Microsoft Sans Serif"), 7.5f), //muito pequena a fonte em 6.5
                    };


                    // Verifica se já está reservado o assento
                    if (ExistsReservation(x, y))
                    {
                        btn.Enabled = false;
                    }
                    else
                    {
                        btn.Click += btn_seat_Click; // Adiciona o evento click - o mesmo evento associado ao unico botão 'btn_seat' no formulário. o BOTÃO btn_seat É CRIADO NO FORM POREM COM A PROPRIEDADE VISIBLE FALSE

                    }

                    btns.Add(btn);
                }
            }

            // Como feito antes, adicionando todos os botões em uma única chamada no painel
            pnl.Controls.AddRange(btns.ToArray());

            // retomar a construção do layout
            this.ResumeLayout();
        }



        private void btn_seat_Click(Object o, EventArgs e)
        {
            Exibir(o);
        }

    }
}
