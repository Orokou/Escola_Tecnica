namespace Escola_Técnica
{
    partial class UCExcluirAluno
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
            this.btnExcluir = new System.Windows.Forms.Button();
            this.cboxTurma2 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboxAluno = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(423, 317);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(85, 23);
            this.btnExcluir.TabIndex = 74;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // cboxTurma2
            // 
            this.cboxTurma2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTurma2.FormattingEnabled = true;
            this.cboxTurma2.Location = new System.Drawing.Point(367, 166);
            this.cboxTurma2.Name = "cboxTurma2";
            this.cboxTurma2.Size = new System.Drawing.Size(201, 21);
            this.cboxTurma2.TabIndex = 100;
            this.cboxTurma2.SelectedIndexChanged += new System.EventHandler(this.CboxTurma2_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(321, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 101;
            this.label11.Text = "Turma:";
            // 
            // cboxAluno
            // 
            this.cboxAluno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxAluno.FormattingEnabled = true;
            this.cboxAluno.Location = new System.Drawing.Point(367, 236);
            this.cboxAluno.Name = "cboxAluno";
            this.cboxAluno.Size = new System.Drawing.Size(201, 21);
            this.cboxAluno.TabIndex = 102;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(324, 239);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 103;
            this.label13.Text = "Aluno:";
            // 
            // UCExcluirAluno
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.cboxAluno);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cboxTurma2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnExcluir);
            this.Name = "UCExcluirAluno";
            this.Size = new System.Drawing.Size(929, 535);
            this.Load += new System.EventHandler(this.UCExcluirAluno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.ComboBox cboxTurma2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboxAluno;
        private System.Windows.Forms.Label label13;
    }
}
