namespace Escola_Técnica
{
    partial class UCEditarTurma
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTurma = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.rbtnNoite = new System.Windows.Forms.RadioButton();
            this.rbtnTarde = new System.Windows.Forms.RadioButton();
            this.rbtnManha = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxCurso = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxTurma = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTurma
            // 
            this.txtTurma.Location = new System.Drawing.Point(368, 105);
            this.txtTurma.Name = "txtTurma";
            this.txtTurma.Size = new System.Drawing.Size(100, 20);
            this.txtTurma.TabIndex = 121;
            this.txtTurma.Visible = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(438, 311);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 120;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(438, 383);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 119;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Visible = false;
            this.btnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // rbtnNoite
            // 
            this.rbtnNoite.AutoSize = true;
            this.rbtnNoite.Location = new System.Drawing.Point(371, 314);
            this.rbtnNoite.Name = "rbtnNoite";
            this.rbtnNoite.Size = new System.Drawing.Size(50, 17);
            this.rbtnNoite.TabIndex = 118;
            this.rbtnNoite.Text = "Noite";
            this.rbtnNoite.UseVisualStyleBackColor = true;
            this.rbtnNoite.Visible = false;
            // 
            // rbtnTarde
            // 
            this.rbtnTarde.AutoSize = true;
            this.rbtnTarde.Location = new System.Drawing.Point(371, 291);
            this.rbtnTarde.Name = "rbtnTarde";
            this.rbtnTarde.Size = new System.Drawing.Size(53, 17);
            this.rbtnTarde.TabIndex = 116;
            this.rbtnTarde.Text = "Tarde";
            this.rbtnTarde.UseVisualStyleBackColor = true;
            this.rbtnTarde.Visible = false;
            // 
            // rbtnManha
            // 
            this.rbtnManha.AutoSize = true;
            this.rbtnManha.Location = new System.Drawing.Point(371, 268);
            this.rbtnManha.Name = "rbtnManha";
            this.rbtnManha.Size = new System.Drawing.Size(58, 17);
            this.rbtnManha.TabIndex = 115;
            this.rbtnManha.Text = "Manhã";
            this.rbtnManha.UseVisualStyleBackColor = true;
            this.rbtnManha.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 117;
            this.label3.Text = "Turno:";
            this.label3.Visible = false;
            // 
            // cboxCurso
            // 
            this.cboxCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCurso.FormattingEnabled = true;
            this.cboxCurso.Location = new System.Drawing.Point(371, 184);
            this.cboxCurso.Name = "cboxCurso";
            this.cboxCurso.Size = new System.Drawing.Size(201, 21);
            this.cboxCurso.TabIndex = 113;
            this.cboxCurso.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 114;
            this.label2.Text = "Curso:";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 112;
            this.label1.Text = "Turma:";
            this.label1.Visible = false;
            // 
            // cboxTurma
            // 
            this.cboxTurma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTurma.FormattingEnabled = true;
            this.cboxTurma.Location = new System.Drawing.Point(371, 211);
            this.cboxTurma.Name = "cboxTurma";
            this.cboxTurma.Size = new System.Drawing.Size(201, 21);
            this.cboxTurma.TabIndex = 111;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(444, 195);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 110;
            this.label11.Text = "TURMA";
            // 
            // UCEditarTurma
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.txtTurma);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.rbtnNoite);
            this.Controls.Add(this.rbtnTarde);
            this.Controls.Add(this.rbtnManha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboxCurso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxTurma);
            this.Controls.Add(this.label11);
            this.Name = "UCEditarTurma";
            this.Size = new System.Drawing.Size(929, 535);
            this.Load += new System.EventHandler(this.UCEditarTurma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTurma;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.RadioButton rbtnNoite;
        private System.Windows.Forms.RadioButton rbtnTarde;
        private System.Windows.Forms.RadioButton rbtnManha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxCurso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxTurma;
        private System.Windows.Forms.Label label11;
    }
}
