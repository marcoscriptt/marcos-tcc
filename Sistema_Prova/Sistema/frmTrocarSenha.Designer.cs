namespace Sistema_Prova.Sistema
{
    partial class frmTrocarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrocarSenha));
            this.erro = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNova2 = new System.Windows.Forms.TextBox();
            this.txtNova = new System.Windows.Forms.TextBox();
            this.txtAntiga = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.LBLTEXTO = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.erro)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).BeginInit();
            this.SuspendLayout();
            // 
            // erro
            // 
            this.erro.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNova2);
            this.groupBox1.Controls.Add(this.txtNova);
            this.groupBox1.Controls.Add(this.txtAntiga);
            this.groupBox1.Location = new System.Drawing.Point(12, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 220);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alterar Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Digite Novamente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Senha nova";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Senha atual";
            // 
            // txtNova2
            // 
            this.txtNova2.Location = new System.Drawing.Point(163, 137);
            this.txtNova2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNova2.Name = "txtNova2";
            this.txtNova2.Size = new System.Drawing.Size(222, 26);
            this.txtNova2.TabIndex = 3;
            // 
            // txtNova
            // 
            this.txtNova.Location = new System.Drawing.Point(163, 86);
            this.txtNova.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNova.Name = "txtNova";
            this.txtNova.Size = new System.Drawing.Size(222, 26);
            this.txtNova.TabIndex = 2;
            // 
            // txtAntiga
            // 
            this.txtAntiga.Location = new System.Drawing.Point(163, 34);
            this.txtAntiga.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAntiga.Name = "txtAntiga";
            this.txtAntiga.Size = new System.Drawing.Size(222, 26);
            this.txtAntiga.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(274, 366);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 51);
            this.button2.TabIndex = 3;
            this.button2.Text = "Alterar senha";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AlterarSenha);
            // 
            // LBLTEXTO
            // 
            this.LBLTEXTO.AutoSize = true;
            this.LBLTEXTO.Location = new System.Drawing.Point(27, 89);
            this.LBLTEXTO.Name = "LBLTEXTO";
            this.LBLTEXTO.Size = new System.Drawing.Size(62, 20);
            this.LBLTEXTO.TabIndex = 0;
            this.LBLTEXTO.Text = "LABE1";
            this.LBLTEXTO.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(-2, -4);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 71);
            this.panel1.TabIndex = 60;
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(366, 10);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(55, 51);
            this.btnSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSair.TabIndex = 44;
            this.btnSair.TabStop = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.AliceBlue;
            this.label8.Location = new System.Drawing.Point(12, 41);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "ALTERAR SENHA";
            // 
            // frmTrocarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(431, 428);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.LBLTEXTO);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTrocarSenha";
            this.Load += new System.EventHandler(this.frmTrocarSenha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erro)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider erro;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtNova2;
        public System.Windows.Forms.TextBox txtNova;
        public System.Windows.Forms.TextBox txtAntiga;
        public System.Windows.Forms.Label LBLTEXTO;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.PictureBox btnSair;

    }
}