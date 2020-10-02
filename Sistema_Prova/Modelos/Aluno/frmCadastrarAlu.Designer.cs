namespace Sistema_Prova.Modelos.Aluno
{
    partial class frmCadastrarAlu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarAlu));
            this.cbTurma = new System.Windows.Forms.ComboBox();
            this.Chamada = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Turma = new System.Windows.Forms.Label();
            this.erro = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.maskedCadastro = new System.Windows.Forms.MaskedTextBox();
            this.maskedAcesso = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtRM = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.erro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTurma
            // 
            this.cbTurma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTurma.FormattingEnabled = true;
            this.cbTurma.Location = new System.Drawing.Point(167, 215);
            this.cbTurma.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbTurma.Name = "cbTurma";
            this.cbTurma.Size = new System.Drawing.Size(102, 24);
            this.cbTurma.TabIndex = 28;
            this.cbTurma.SelectedIndexChanged += new System.EventHandler(this.cbTurma_SelectedIndexChanged_1);
            // 
            // Chamada
            // 
            this.Chamada.Location = new System.Drawing.Point(380, 215);
            this.Chamada.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Chamada.MaxLength = 2;
            this.Chamada.Name = "Chamada";
            this.Chamada.Size = new System.Drawing.Size(102, 22);
            this.Chamada.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(280, 218);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "Nº Chamada";
            // 
            // Turma
            // 
            this.Turma.AutoSize = true;
            this.Turma.Location = new System.Drawing.Point(88, 218);
            this.Turma.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Turma.Name = "Turma";
            this.Turma.Size = new System.Drawing.Size(52, 16);
            this.Turma.TabIndex = 27;
            this.Turma.Text = "Turma";
            // 
            // erro
            // 
            this.erro.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(21, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRAR ALUNO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-9, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 71);
            this.panel1.TabIndex = 54;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.maskedCadastro);
            this.groupBox3.Controls.Add(this.maskedAcesso);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(525, 273);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(194, 148);
            this.groupBox3.TabIndex = 65;
            this.groupBox3.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(479, 29);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.MaxLength = 5;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 22);
            this.textBox1.TabIndex = 2;
            // 
            // maskedCadastro
            // 
            this.maskedCadastro.Location = new System.Drawing.Point(17, 45);
            this.maskedCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.maskedCadastro.Mask = "00/00/0000";
            this.maskedCadastro.Name = "maskedCadastro";
            this.maskedCadastro.Size = new System.Drawing.Size(148, 22);
            this.maskedCadastro.TabIndex = 5;
            this.maskedCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // maskedAcesso
            // 
            this.maskedAcesso.Location = new System.Drawing.Point(17, 97);
            this.maskedAcesso.Margin = new System.Windows.Forms.Padding(4);
            this.maskedAcesso.Mask = "00/00/0000";
            this.maskedAcesso.Name = "maskedAcesso";
            this.maskedAcesso.Size = new System.Drawing.Size(148, 22);
            this.maskedAcesso.TabIndex = 5;
            this.maskedAcesso.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 77);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ultimo Acesso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cadastro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 181);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 55;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 256);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 56;
            this.label3.Text = "Usuario";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(167, 294);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenha.MaxLength = 25;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(208, 22);
            this.txtSenha.TabIndex = 61;
            // 
            // txtRM
            // 
            this.txtRM.Location = new System.Drawing.Point(167, 136);
            this.txtRM.Margin = new System.Windows.Forms.Padding(4);
            this.txtRM.MaxLength = 5;
            this.txtRM.Name = "txtRM";
            this.txtRM.Size = new System.Drawing.Size(102, 22);
            this.txtRM.TabIndex = 62;
            this.txtRM.TextChanged += new System.EventHandler(this.PassarTxt);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(167, 250);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.MaxLength = 55;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(315, 22);
            this.txtUsuario.TabIndex = 59;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(167, 178);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(315, 22);
            this.txtNome.TabIndex = 60;
            this.txtNome.TextChanged += new System.EventHandler(this.PassarTxt);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 300);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 57;
            this.label4.Text = "Senha";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(88, 139);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 16);
            this.label10.TabIndex = 58;
            this.label10.Text = "Rm";
            // 
            // button3
            // 
            this.button3.Image = global::Sistema_Prova.Properties.Resources.Save_icon_pequeno;
            this.button3.Location = new System.Drawing.Point(89, 365);
            this.button3.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 53);
            this.button3.TabIndex = 67;
            this.button3.Text = "Cadastrar";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Cadastrar);
            // 
            // button1
            // 
            this.button1.Image = global::Sistema_Prova.Properties.Resources.Trash_empty_icon;
            this.button1.Location = new System.Drawing.Point(244, 365);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 53);
            this.button1.TabIndex = 63;
            this.button1.Text = "Limpar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Limpar);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(704, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmCadastrarAlu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(762, 482);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtRM);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Chamada);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbTurma);
            this.Controls.Add(this.Turma);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmCadastrarAlu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CarregarCboTurma);
            ((System.ComponentModel.ISupportInitialize)(this.erro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider erro;
        private System.Windows.Forms.ComboBox cbTurma;
        public System.Windows.Forms.TextBox Chamada;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label Turma;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MaskedTextBox maskedCadastro;
        private System.Windows.Forms.MaskedTextBox maskedAcesso;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtSenha;
        public System.Windows.Forms.TextBox txtRM;
        public System.Windows.Forms.TextBox txtUsuario;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Button button1;
    }
}