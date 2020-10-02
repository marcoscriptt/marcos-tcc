namespace Sistema_Prova.Rotina.Alunos.Prova
{
    partial class frmProva
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProva));
            this.lblQuestao = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblProf = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.StatusStrip();
            this.posicao1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblIdProva = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button37 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button40 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button39 = new System.Windows.Forms.Button();
            this.button38 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTituloProva = new System.Windows.Forms.Label();
            this.notaa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.status.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuestao
            // 
            this.lblQuestao.AutoSize = true;
            this.lblQuestao.Location = new System.Drawing.Point(40, 44);
            this.lblQuestao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuestao.Name = "lblQuestao";
            this.lblQuestao.Size = new System.Drawing.Size(48, 16);
            this.lblQuestao.TabIndex = 3;
            this.lblQuestao.Text = "--------";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(1181, 203);
            this.lblMateria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(75, 16);
            this.lblMateria.TabIndex = 3;
            this.lblMateria.Text = "MATERIA";
            // 
            // lblProf
            // 
            this.lblProf.AutoSize = true;
            this.lblProf.Location = new System.Drawing.Point(1169, 141);
            this.lblProf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProf.Name = "lblProf";
            this.lblProf.Size = new System.Drawing.Size(101, 16);
            this.lblProf.TabIndex = 3;
            this.lblProf.Text = "PROFESSOR";
            this.lblProf.Click += new System.EventHandler(this.label7_Click);
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.Color.DarkRed;
            this.status.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.posicao1});
            this.status.Location = new System.Drawing.Point(0, 717);
            this.status.Name = "status";
            this.status.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.status.Size = new System.Drawing.Size(1304, 25);
            this.status.TabIndex = 5;
            this.status.Text = "statusStrip1";
            // 
            // posicao1
            // 
            this.posicao1.ForeColor = System.Drawing.Color.White;
            this.posicao1.Name = "posicao1";
            this.posicao1.Size = new System.Drawing.Size(26, 20);
            this.posicao1.Text = "p1";
            this.posicao1.Click += new System.EventHandler(this.posicao1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.relogio);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // lblIdProva
            // 
            this.lblIdProva.AutoSize = true;
            this.lblIdProva.Location = new System.Drawing.Point(1204, 245);
            this.lblIdProva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdProva.Name = "lblIdProva";
            this.lblIdProva.Size = new System.Drawing.Size(28, 16);
            this.lblIdProva.TabIndex = 3;
            this.lblIdProva.Text = "----";
            this.lblIdProva.Visible = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(23, 19);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(81, 20);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "-----------";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(23, 91);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(81, 20);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "-----------";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(23, 309);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(81, 20);
            this.radioButton4.TabIndex = 10;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "-----------";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(23, 162);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(81, 20);
            this.radioButton5.TabIndex = 10;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "-----------";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(23, 234);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(81, 20);
            this.radioButton3.TabIndex = 10;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "-----------";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button37);
            this.groupBox1.Controls.Add(this.button21);
            this.groupBox1.Controls.Add(this.button13);
            this.groupBox1.Controls.Add(this.button29);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button36);
            this.groupBox1.Controls.Add(this.button28);
            this.groupBox1.Controls.Add(this.button20);
            this.groupBox1.Controls.Add(this.button12);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button27);
            this.groupBox1.Controls.Add(this.button35);
            this.groupBox1.Controls.Add(this.button19);
            this.groupBox1.Controls.Add(this.button33);
            this.groupBox1.Controls.Add(this.button11);
            this.groupBox1.Controls.Add(this.button34);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button40);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button10);
            this.groupBox1.Controls.Add(this.button25);
            this.groupBox1.Controls.Add(this.button26);
            this.groupBox1.Controls.Add(this.button16);
            this.groupBox1.Controls.Add(this.button14);
            this.groupBox1.Controls.Add(this.button30);
            this.groupBox1.Controls.Add(this.button18);
            this.groupBox1.Controls.Add(this.button31);
            this.groupBox1.Controls.Add(this.button17);
            this.groupBox1.Controls.Add(this.button32);
            this.groupBox1.Controls.Add(this.button22);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button23);
            this.groupBox1.Controls.Add(this.button24);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button15);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button39);
            this.groupBox1.Controls.Add(this.button38);
            this.groupBox1.Location = new System.Drawing.Point(11, 96);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(273, 498);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Questões";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(14, 64);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(51, 42);
            this.button5.TabIndex = 10;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button37
            // 
            this.button37.Location = new System.Drawing.Point(14, 437);
            this.button37.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(51, 42);
            this.button37.TabIndex = 31;
            this.button37.Text = "37";
            this.button37.UseVisualStyleBackColor = true;
            this.button37.Click += new System.EventHandler(this.button37_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(14, 251);
            this.button21.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(51, 42);
            this.button21.TabIndex = 33;
            this.button21.Text = "21";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(14, 159);
            this.button13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(51, 42);
            this.button13.TabIndex = 34;
            this.button13.Text = "13";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button29
            // 
            this.button29.Location = new System.Drawing.Point(14, 344);
            this.button29.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(51, 42);
            this.button29.TabIndex = 32;
            this.button29.Text = "29";
            this.button29.UseVisualStyleBackColor = true;
            this.button29.Click += new System.EventHandler(this.button29_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(185, 19);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(51, 42);
            this.button4.TabIndex = 35;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button36
            // 
            this.button36.Location = new System.Drawing.Point(185, 391);
            this.button36.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(51, 42);
            this.button36.TabIndex = 36;
            this.button36.Text = "36";
            this.button36.UseVisualStyleBackColor = true;
            this.button36.Click += new System.EventHandler(this.button36_Click);
            // 
            // button28
            // 
            this.button28.Location = new System.Drawing.Point(185, 298);
            this.button28.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(51, 42);
            this.button28.TabIndex = 37;
            this.button28.Text = "28";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.button28_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(185, 206);
            this.button20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(51, 42);
            this.button20.TabIndex = 38;
            this.button20.Text = "20";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(185, 113);
            this.button12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(51, 42);
            this.button12.TabIndex = 39;
            this.button12.Text = "12";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(128, 19);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 42);
            this.button3.TabIndex = 40;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(128, 298);
            this.button27.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(51, 42);
            this.button27.TabIndex = 42;
            this.button27.Text = "27";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // button35
            // 
            this.button35.Location = new System.Drawing.Point(128, 391);
            this.button35.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(51, 42);
            this.button35.TabIndex = 41;
            this.button35.Text = "35";
            this.button35.UseVisualStyleBackColor = true;
            this.button35.Click += new System.EventHandler(this.button35_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(128, 206);
            this.button19.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(51, 42);
            this.button19.TabIndex = 43;
            this.button19.Text = "19";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button33
            // 
            this.button33.Location = new System.Drawing.Point(14, 390);
            this.button33.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(51, 42);
            this.button33.TabIndex = 30;
            this.button33.Text = "33";
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.button33_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(128, 113);
            this.button11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(51, 42);
            this.button11.TabIndex = 44;
            this.button11.Text = "11";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button34
            // 
            this.button34.Location = new System.Drawing.Point(71, 390);
            this.button34.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(51, 42);
            this.button34.TabIndex = 47;
            this.button34.Text = "34";
            this.button34.UseVisualStyleBackColor = true;
            this.button34.Click += new System.EventHandler(this.button34_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(71, 19);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 42);
            this.button2.TabIndex = 45;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button40
            // 
            this.button40.Location = new System.Drawing.Point(185, 438);
            this.button40.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(51, 42);
            this.button40.TabIndex = 18;
            this.button40.Text = "40";
            this.button40.UseVisualStyleBackColor = true;
            this.button40.Click += new System.EventHandler(this.button40_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 19);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 42);
            this.button1.TabIndex = 46;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(71, 113);
            this.button10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(51, 42);
            this.button10.TabIndex = 16;
            this.button10.Text = "10";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(14, 298);
            this.button25.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(51, 42);
            this.button25.TabIndex = 28;
            this.button25.Text = "25";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(71, 298);
            this.button26.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(51, 42);
            this.button26.TabIndex = 29;
            this.button26.Text = "26";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(185, 159);
            this.button16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(51, 42);
            this.button16.TabIndex = 19;
            this.button16.Text = "16";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(74, 159);
            this.button14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(51, 42);
            this.button14.TabIndex = 26;
            this.button14.Text = "14";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button30
            // 
            this.button30.Location = new System.Drawing.Point(71, 345);
            this.button30.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(51, 42);
            this.button30.TabIndex = 22;
            this.button30.Text = "30";
            this.button30.UseVisualStyleBackColor = true;
            this.button30.Click += new System.EventHandler(this.button30_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(71, 206);
            this.button18.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(51, 42);
            this.button18.TabIndex = 11;
            this.button18.Text = "18";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button31
            // 
            this.button31.Location = new System.Drawing.Point(128, 345);
            this.button31.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(51, 42);
            this.button31.TabIndex = 17;
            this.button31.Text = "31";
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Click += new System.EventHandler(this.button31_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(14, 206);
            this.button17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(51, 42);
            this.button17.TabIndex = 13;
            this.button17.Text = "17";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button32
            // 
            this.button32.Location = new System.Drawing.Point(185, 345);
            this.button32.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(51, 42);
            this.button32.TabIndex = 12;
            this.button32.Text = "32";
            this.button32.UseVisualStyleBackColor = true;
            this.button32.Click += new System.EventHandler(this.button32_Click);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(74, 251);
            this.button22.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(51, 42);
            this.button22.TabIndex = 24;
            this.button22.Text = "22";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(14, 113);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(51, 42);
            this.button9.TabIndex = 21;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(128, 251);
            this.button23.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(51, 42);
            this.button23.TabIndex = 27;
            this.button23.Text = "23";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(185, 251);
            this.button24.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(51, 42);
            this.button24.TabIndex = 14;
            this.button24.Text = "24";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(128, 66);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(51, 42);
            this.button7.TabIndex = 48;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(71, 66);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(51, 42);
            this.button6.TabIndex = 49;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(128, 159);
            this.button15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(51, 42);
            this.button15.TabIndex = 23;
            this.button15.Text = "15";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(185, 66);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(51, 42);
            this.button8.TabIndex = 25;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button39
            // 
            this.button39.Location = new System.Drawing.Point(128, 438);
            this.button39.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(51, 42);
            this.button39.TabIndex = 15;
            this.button39.Text = "39";
            this.button39.UseVisualStyleBackColor = true;
            this.button39.Click += new System.EventHandler(this.button39_Click);
            // 
            // button38
            // 
            this.button38.Location = new System.Drawing.Point(71, 437);
            this.button38.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(51, 42);
            this.button38.TabIndex = 20;
            this.button38.Text = "38";
            this.button38.UseVisualStyleBackColor = true;
            this.button38.Click += new System.EventHandler(this.button38_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Location = new System.Drawing.Point(307, 224);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(836, 376);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alternativas";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblQuestao);
            this.groupBox3.Location = new System.Drawing.Point(307, 116);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(836, 103);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Questão";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(1150, 487);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(140, 43);
            this.btnFinalizar.TabIndex = 7;
            this.btnFinalizar.Text = "FINALIZAR";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.Finalizar);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Image = global::Sistema_Prova.Properties.Resources.sign_check_icon_pequeno;
            this.btnConfirmar.Location = new System.Drawing.Point(307, 604);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(145, 61);
            this.btnConfirmar.TabIndex = 7;
            this.btnConfirmar.Text = "Confirmar Resposta";
            this.btnConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.button41_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Image = global::Sistema_Prova.Properties.Resources.Start_icon;
            this.btnIniciar.Location = new System.Drawing.Point(1150, 425);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(140, 58);
            this.btnIniciar.TabIndex = 7;
            this.btnIniciar.Text = "INICIAR PROVA";
            this.btnIniciar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblTituloProva);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1413, 76);
            this.panel1.TabIndex = 65;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1250, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblTituloProva
            // 
            this.lblTituloProva.AutoSize = true;
            this.lblTituloProva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloProva.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblTituloProva.Location = new System.Drawing.Point(40, 26);
            this.lblTituloProva.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloProva.Name = "lblTituloProva";
            this.lblTituloProva.Size = new System.Drawing.Size(135, 20);
            this.lblTituloProva.TabIndex = 0;
            this.lblTituloProva.Text = "------------------";
            // 
            // notaa
            // 
            this.notaa.AutoSize = true;
            this.notaa.Location = new System.Drawing.Point(1204, 302);
            this.notaa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.notaa.Name = "notaa";
            this.notaa.Size = new System.Drawing.Size(28, 16);
            this.notaa.TabIndex = 66;
            this.notaa.Text = "----";
            this.notaa.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1169, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 67;
            this.label1.Text = "PROFESSOR:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1169, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 67;
            this.label2.Text = "BOA SORTE!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1181, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "MATERIA:";
            // 
            // frmProva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1304, 742);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.notaa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblProf);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblIdProva);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMateria);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmProva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmProva_Load);
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.StatusStrip status;
        public System.Windows.Forms.ToolStripStatusLabel posicao1;
        public System.Windows.Forms.Label lblQuestao;
        public System.Windows.Forms.Label lblMateria;
        public System.Windows.Forms.Label lblProf;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Button btnFinalizar;
        public System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.Label lblIdProva;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Button btnConfirmar;
        public System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label notaa;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button button5;
        public System.Windows.Forms.Button button37;
        public System.Windows.Forms.Button button29;
        public System.Windows.Forms.Button button21;
        public System.Windows.Forms.Button button13;
        public System.Windows.Forms.Button button36;
        public System.Windows.Forms.Button button28;
        public System.Windows.Forms.Button button20;
        public System.Windows.Forms.Button button12;
        public System.Windows.Forms.Button button35;
        public System.Windows.Forms.Button button27;
        public System.Windows.Forms.Button button19;
        public System.Windows.Forms.Button button11;
        public System.Windows.Forms.Button button34;
        public System.Windows.Forms.Button button33;
        public System.Windows.Forms.Button button26;
        public System.Windows.Forms.Button button25;
        public System.Windows.Forms.Button button40;
        public System.Windows.Forms.Button button18;
        public System.Windows.Forms.Button button32;
        public System.Windows.Forms.Button button17;
        public System.Windows.Forms.Button button24;
        public System.Windows.Forms.Button button39;
        public System.Windows.Forms.Button button10;
        public System.Windows.Forms.Button button31;
        public System.Windows.Forms.Button button16;
        public System.Windows.Forms.Button button23;
        public System.Windows.Forms.Button button38;
        public System.Windows.Forms.Button button9;
        public System.Windows.Forms.Button button30;
        public System.Windows.Forms.Button button15;
        public System.Windows.Forms.Button button22;
        public System.Windows.Forms.Button button8;
        public System.Windows.Forms.Button button14;
        public System.Windows.Forms.Button button7;
        public System.Windows.Forms.Button button6;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblTituloProva;
    }
}