namespace Escola_Técnica
{
    partial class UCExcluirProfessor
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
            this.cboxProfessor = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cboxTurma2 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(416, 312);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(85, 23);
            this.btnExcluir.TabIndex = 77;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // cboxProfessor
            // 
            this.cboxProfessor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxProfessor.FormattingEnabled = true;
            this.cboxProfessor.Location = new System.Drawing.Point(369, 225);
            this.cboxProfessor.Name = "cboxProfessor";
            this.cboxProfessor.Size = new System.Drawing.Size(201, 21);
            this.cboxProfessor.TabIndex = 106;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(309, 228);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 107;
            this.label13.Text = "Professor:";
            // 
            // cboxTurma2
            // 
            this.cboxTurma2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTurma2.FormattingEnabled = true;
            this.cboxTurma2.Location = new System.Drawing.Point(369, 155);
            this.cboxTurma2.Name = "cboxTurma2";
            this.cboxTurma2.Size = new System.Drawing.Size(201, 21);
            this.cboxTurma2.TabIndex = 104;
            this.cboxTurma2.SelectedIndexChanged += new System.EventHandler(this.CboxTurma2_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(323, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 105;
            this.label11.Text = "Turma:";
            // 
            // UCExcluirProfessor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.cboxProfessor);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cboxTurma2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnExcluir);
            this.Name = "UCExcluirProfessor";
            this.Size = new System.Drawing.Size(929, 535);
            this.Load += new System.EventHandler(this.UCExcluirProfessor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.ComboBox cboxProfessor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboxTurma2;
        private System.Windows.Forms.Label label11;
    }
}
