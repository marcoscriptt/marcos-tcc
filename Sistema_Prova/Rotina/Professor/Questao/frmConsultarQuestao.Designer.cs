namespace Sistema_Prova.Rotina.Professor.Questao
{
    partial class frmConsultarQuestao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarQuestao));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMateria = new System.Windows.Forms.ComboBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.txtResp4 = new System.Windows.Forms.TextBox();
            this.txtResp3 = new System.Windows.Forms.TextBox();
            this.txtResp2 = new System.Windows.Forms.TextBox();
            this.txtResp1 = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtEquit = new System.Windows.Forms.TextBox();
            this.txtResp5 = new System.Windows.Forms.TextBox();
            this.txtMateria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.erro = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtQuestao = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-9, -7);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1150, 83);
            this.panel1.TabIndex = 74;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.AliceBlue;
            this.label8.Location = new System.Drawing.Point(23, 49);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "CONSULTAR NOTAS";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cboMateria);
            this.groupBox2.Controls.Add(this.dgv);
            this.groupBox2.Controls.Add(this.txtPesquisa);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(14, 372);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox2.Size = new System.Drawing.Size(1032, 275);
            this.groupBox2.TabIndex = 77;
            this.groupBox2.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(897, 21);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 92;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(593, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 91;
            this.label1.Text = "Matéria";
            // 
            // cboMateria
            // 
            this.cboMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMateria.FormattingEnabled = true;
            this.cboMateria.Location = new System.Drawing.Point(663, 23);
            this.cboMateria.Name = "cboMateria";
            this.cboMateria.Size = new System.Drawing.Size(149, 24);
            this.cboMateria.TabIndex = 90;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(14, 59);
            this.dgv.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(1004, 210);
            this.dgv.TabIndex = 37;
            this.dgv.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_RowHeaderMouseClick);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(72, 25);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(485, 22);
            this.txtPesquisa.TabIndex = 36;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "Nome";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(734, 310);
            this.button8.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(142, 54);
            this.button8.TabIndex = 75;
            this.button8.Text = "Alterar";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // txtResp4
            // 
            this.txtResp4.Location = new System.Drawing.Point(624, 187);
            this.txtResp4.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtResp4.Multiline = true;
            this.txtResp4.Name = "txtResp4";
            this.txtResp4.Size = new System.Drawing.Size(422, 52);
            this.txtResp4.TabIndex = 80;
            // 
            // txtResp3
            // 
            this.txtResp3.Location = new System.Drawing.Point(624, 128);
            this.txtResp3.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtResp3.Multiline = true;
            this.txtResp3.Name = "txtResp3";
            this.txtResp3.Size = new System.Drawing.Size(422, 52);
            this.txtResp3.TabIndex = 81;
            // 
            // txtResp2
            // 
            this.txtResp2.Location = new System.Drawing.Point(91, 281);
            this.txtResp2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtResp2.Multiline = true;
            this.txtResp2.Name = "txtResp2";
            this.txtResp2.Size = new System.Drawing.Size(422, 52);
            this.txtResp2.TabIndex = 82;
            // 
            // txtResp1
            // 
            this.txtResp1.Location = new System.Drawing.Point(91, 217);
            this.txtResp1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtResp1.Multiline = true;
            this.txtResp1.Name = "txtResp1";
            this.txtResp1.Size = new System.Drawing.Size(422, 52);
            this.txtResp1.TabIndex = 84;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(110, 89);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtTitulo.Multiline = true;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(324, 24);
            this.txtTitulo.TabIndex = 85;
            // 
            // txtEquit
            // 
            this.txtEquit.Location = new System.Drawing.Point(527, 89);
            this.txtEquit.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtEquit.Multiline = true;
            this.txtEquit.Name = "txtEquit";
            this.txtEquit.Size = new System.Drawing.Size(275, 24);
            this.txtEquit.TabIndex = 87;
            // 
            // txtResp5
            // 
            this.txtResp5.Location = new System.Drawing.Point(624, 244);
            this.txtResp5.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtResp5.Multiline = true;
            this.txtResp5.Name = "txtResp5";
            this.txtResp5.Size = new System.Drawing.Size(422, 52);
            this.txtResp5.TabIndex = 88;
            // 
            // txtMateria
            // 
            this.txtMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtMateria.FormattingEnabled = true;
            this.txtMateria.Location = new System.Drawing.Point(886, 89);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(121, 24);
            this.txtMateria.TabIndex = 89;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 220);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 16);
            this.label2.TabIndex = 90;
            this.label2.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 284);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 16);
            this.label3.TabIndex = 91;
            this.label3.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(527, 128);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 16);
            this.label5.TabIndex = 92;
            this.label5.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(527, 187);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 16);
            this.label6.TabIndex = 93;
            this.label6.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(527, 248);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 16);
            this.label7.TabIndex = 94;
            this.label7.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(448, 94);
            this.label9.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 95;
            this.label9.Text = "Etiqueta";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(816, 94);
            this.label10.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 16);
            this.label10.TabIndex = 96;
            this.label10.Text = "Materia";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(58, 92);
            this.label11.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 16);
            this.label11.TabIndex = 97;
            this.label11.Text = "Titulo";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // erro
            // 
            this.erro.ContainerControl = this;
            // 
            // txtQuestao
            // 
            this.txtQuestao.Location = new System.Drawing.Point(91, 153);
            this.txtQuestao.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtQuestao.Multiline = true;
            this.txtQuestao.Name = "txtQuestao";
            this.txtQuestao.Size = new System.Drawing.Size(422, 52);
            this.txtQuestao.TabIndex = 98;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 161);
            this.label12.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 16);
            this.label12.TabIndex = 99;
            this.label12.Text = "Questão";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(12, 91);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(29, 22);
            this.txtId.TabIndex = 100;
            this.txtId.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(990, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button6
            // 
            this.button6.Image = global::Sistema_Prova.Properties.Resources.Trash_empty_icon;
            this.button6.Location = new System.Drawing.Point(890, 308);
            this.button6.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(142, 54);
            this.button6.TabIndex = 76;
            this.button6.Text = "Excluir";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // frmConsultarQuestao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1060, 651);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtQuestao);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMateria);
            this.Controls.Add(this.txtResp5);
            this.Controls.Add(this.txtEquit);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtResp1);
            this.Controls.Add(this.txtResp2);
            this.Controls.Add(this.txtResp3);
            this.Controls.Add(this.txtResp4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button8);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmConsultarQuestao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultarQuestao";
            this.Load += new System.EventHandler(this.frmConsultarQuestao_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView dgv;
        public System.Windows.Forms.TextBox txtPesquisa;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button button6;
        public System.Windows.Forms.Button button8;
        public System.Windows.Forms.TextBox txtResp4;
        public System.Windows.Forms.TextBox txtResp3;
        public System.Windows.Forms.TextBox txtResp2;
        public System.Windows.Forms.TextBox txtResp1;
        public System.Windows.Forms.TextBox txtTitulo;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMateria;
        public System.Windows.Forms.TextBox txtEquit;
        public System.Windows.Forms.TextBox txtResp5;
        private System.Windows.Forms.ComboBox txtMateria;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ErrorProvider erro;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txtQuestao;
        private System.Windows.Forms.TextBox txtId;
    }
}