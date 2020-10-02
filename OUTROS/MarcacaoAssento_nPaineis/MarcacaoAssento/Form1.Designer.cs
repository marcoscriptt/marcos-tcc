namespace MarcacaoAssento
{
    partial class Form1
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
            this.pnl_seats = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_seat = new System.Windows.Forms.Button();
            this.lblLotacao = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDisponivel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnl_seats
            // 
            this.pnl_seats.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_seats.Location = new System.Drawing.Point(12, 70);
            this.pnl_seats.Name = "pnl_seats";
            this.pnl_seats.Size = new System.Drawing.Size(186, 387);
            this.pnl_seats.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "TELA - Marcação de Local";
            // 
            // btn_seat
            // 
            this.btn_seat.Location = new System.Drawing.Point(476, 2);
            this.btn_seat.Name = "btn_seat";
            this.btn_seat.Size = new System.Drawing.Size(107, 26);
            this.btn_seat.TabIndex = 2;
            this.btn_seat.Text = "Confirma o Assento";
            this.btn_seat.UseVisualStyleBackColor = true;
            this.btn_seat.Visible = false;
            this.btn_seat.Click += new System.EventHandler(this.btn_seat_Click);
            // 
            // lblLotacao
            // 
            this.lblLotacao.AutoSize = true;
            this.lblLotacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLotacao.Location = new System.Drawing.Point(342, 0);
            this.lblLotacao.Name = "lblLotacao";
            this.lblLotacao.Size = new System.Drawing.Size(24, 25);
            this.lblLotacao.TabIndex = 3;
            this.lblLotacao.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Capacidade Máxima";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Disponível";
            // 
            // lblDisponivel
            // 
            this.lblDisponivel.AutoSize = true;
            this.lblDisponivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisponivel.Location = new System.Drawing.Point(446, 2);
            this.lblDisponivel.Name = "lblDisponivel";
            this.lblDisponivel.Size = new System.Drawing.Size(24, 25);
            this.lblDisponivel.TabIndex = 6;
            this.lblDisponivel.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(204, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 387);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(396, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 387);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(601, 79);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(210, 270);
            this.panel3.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 534);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDisponivel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLotacao);
            this.Controls.Add(this.btn_seat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnl_seats);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_seats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_seat;
        private System.Windows.Forms.Label lblLotacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDisponivel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;

    }
}

