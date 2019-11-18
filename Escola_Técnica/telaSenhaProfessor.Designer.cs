namespace Escola_Técnica
{
    partial class telaSenhaProfessor
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
            this.txtI = new System.Windows.Forms.TextBox();
            this.btnTrocar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtSenhaNova = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSenhaAntiga = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbX = new System.Windows.Forms.PictureBox();
            this.pbV = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbV)).BeginInit();
            this.SuspendLayout();
            // 
            // txtI
            // 
            this.txtI.Location = new System.Drawing.Point(230, 67);
            this.txtI.Name = "txtI";
            this.txtI.Size = new System.Drawing.Size(10, 20);
            this.txtI.TabIndex = 37;
            this.txtI.Visible = false;
            // 
            // btnTrocar
            // 
            this.btnTrocar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTrocar.Location = new System.Drawing.Point(79, 182);
            this.btnTrocar.Name = "btnTrocar";
            this.btnTrocar.Size = new System.Drawing.Size(100, 23);
            this.btnTrocar.TabIndex = 36;
            this.btnTrocar.Text = "Trocar";
            this.btnTrocar.UseVisualStyleBackColor = true;
            this.btnTrocar.Click += new System.EventHandler(this.BtnTrocar_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(231, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(37, 23);
            this.btnSair.TabIndex = 35;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            this.btnSair.MouseEnter += new System.EventHandler(this.BtnSair_MouseEnter);
            this.btnSair.MouseLeave += new System.EventHandler(this.BtnSair_MouseLeave);
            // 
            // txtSenhaNova
            // 
            this.txtSenhaNova.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtSenhaNova.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenhaNova.Location = new System.Drawing.Point(79, 126);
            this.txtSenhaNova.Multiline = true;
            this.txtSenhaNova.Name = "txtSenhaNova";
            this.txtSenhaNova.PasswordChar = '*';
            this.txtSenhaNova.Size = new System.Drawing.Size(100, 20);
            this.txtSenhaNova.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Nova senha";
            // 
            // txtSenhaAntiga
            // 
            this.txtSenhaAntiga.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtSenhaAntiga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenhaAntiga.Location = new System.Drawing.Point(79, 68);
            this.txtSenhaAntiga.Multiline = true;
            this.txtSenhaAntiga.Name = "txtSenhaAntiga";
            this.txtSenhaAntiga.PasswordChar = '*';
            this.txtSenhaAntiga.Size = new System.Drawing.Size(100, 20);
            this.txtSenhaAntiga.TabIndex = 31;
            this.txtSenhaAntiga.Leave += new System.EventHandler(this.TxtSenhaAntiga_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Senha antiga";
            // 
            // pbX
            // 
            this.pbX.Image = global::Escola_Técnica.Properties.Resources.x_removebg_preview;
            this.pbX.Location = new System.Drawing.Point(204, 65);
            this.pbX.Name = "pbX";
            this.pbX.Size = new System.Drawing.Size(36, 27);
            this.pbX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbX.TabIndex = 39;
            this.pbX.TabStop = false;
            this.pbX.Visible = false;
            // 
            // pbV
            // 
            this.pbV.Image = global::Escola_Técnica.Properties.Resources.v_removebg_preview;
            this.pbV.Location = new System.Drawing.Point(204, 52);
            this.pbV.Name = "pbV";
            this.pbV.Size = new System.Drawing.Size(45, 40);
            this.pbV.TabIndex = 38;
            this.pbV.TabStop = false;
            this.pbV.Visible = false;
            // 
            // telaSenhaProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(268, 279);
            this.Controls.Add(this.pbX);
            this.Controls.Add(this.pbV);
            this.Controls.Add(this.txtI);
            this.Controls.Add(this.btnTrocar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtSenhaNova);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSenhaAntiga);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "telaSenhaProfessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "telaSenhaProfessor";
            this.Load += new System.EventHandler(this.TelaSenhaProfessor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbX;
        private System.Windows.Forms.PictureBox pbV;
        private System.Windows.Forms.TextBox txtI;
        private System.Windows.Forms.Button btnTrocar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtSenhaNova;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSenhaAntiga;
        private System.Windows.Forms.Label label1;
    }
}