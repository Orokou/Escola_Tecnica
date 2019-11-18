namespace Escola_Técnica
{
    partial class telaEmailProfessor
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnTrocar = new System.Windows.Forms.Button();
            this.txtEmailNovo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmailAntigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.pbX = new System.Windows.Forms.PictureBox();
            this.pbV = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbV)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(223, 73);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(10, 20);
            this.txtId.TabIndex = 49;
            this.txtId.Visible = false;
            // 
            // btnTrocar
            // 
            this.btnTrocar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTrocar.Location = new System.Drawing.Point(81, 193);
            this.btnTrocar.Name = "btnTrocar";
            this.btnTrocar.Size = new System.Drawing.Size(100, 23);
            this.btnTrocar.TabIndex = 48;
            this.btnTrocar.Text = "Trocar";
            this.btnTrocar.UseVisualStyleBackColor = true;
            this.btnTrocar.Click += new System.EventHandler(this.BtnTrocar_Click);
            // 
            // txtEmailNovo
            // 
            this.txtEmailNovo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtEmailNovo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmailNovo.Location = new System.Drawing.Point(81, 131);
            this.txtEmailNovo.Multiline = true;
            this.txtEmailNovo.Name = "txtEmailNovo";
            this.txtEmailNovo.Size = new System.Drawing.Size(100, 20);
            this.txtEmailNovo.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Email novo";
            // 
            // txtEmailAntigo
            // 
            this.txtEmailAntigo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtEmailAntigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmailAntigo.Location = new System.Drawing.Point(81, 73);
            this.txtEmailAntigo.Multiline = true;
            this.txtEmailAntigo.Name = "txtEmailAntigo";
            this.txtEmailAntigo.Size = new System.Drawing.Size(100, 20);
            this.txtEmailAntigo.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Email antigo";
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(232, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(37, 23);
            this.btnSair.TabIndex = 43;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            this.btnSair.MouseEnter += new System.EventHandler(this.BtnSair_MouseEnter);
            this.btnSair.MouseLeave += new System.EventHandler(this.BtnSair_MouseLeave);
            // 
            // pbX
            // 
            this.pbX.Image = global::Escola_Técnica.Properties.Resources.x_removebg_preview;
            this.pbX.Location = new System.Drawing.Point(206, 66);
            this.pbX.Name = "pbX";
            this.pbX.Size = new System.Drawing.Size(36, 27);
            this.pbX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbX.TabIndex = 51;
            this.pbX.TabStop = false;
            this.pbX.Visible = false;
            // 
            // pbV
            // 
            this.pbV.Image = global::Escola_Técnica.Properties.Resources.v_removebg_preview;
            this.pbV.Location = new System.Drawing.Point(206, 53);
            this.pbV.Name = "pbV";
            this.pbV.Size = new System.Drawing.Size(45, 40);
            this.pbV.TabIndex = 50;
            this.pbV.TabStop = false;
            this.pbV.Visible = false;
            // 
            // telaEmailProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(268, 279);
            this.Controls.Add(this.pbX);
            this.Controls.Add(this.pbV);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnTrocar);
            this.Controls.Add(this.txtEmailNovo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmailAntigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "telaEmailProfessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "telaEmailProfessor";
            this.Load += new System.EventHandler(this.TelaEmailProfessor_Load);
            this.Leave += new System.EventHandler(this.TelaEmailProfessor_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.pbX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbX;
        private System.Windows.Forms.PictureBox pbV;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnTrocar;
        private System.Windows.Forms.TextBox txtEmailNovo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmailAntigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSair;
    }
}