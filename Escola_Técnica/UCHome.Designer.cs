namespace Escola_Técnica
{
    partial class UCHome
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
            this.btnAssistente = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnAluno = new System.Windows.Forms.Button();
            this.btnProfessor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAssistente
            // 
            this.btnAssistente.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAssistente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssistente.Image = global::Escola_Técnica.Properties.Resources.userr_removebg_preview;
            this.btnAssistente.Location = new System.Drawing.Point(352, 163);
            this.btnAssistente.Name = "btnAssistente";
            this.btnAssistente.Size = new System.Drawing.Size(176, 150);
            this.btnAssistente.TabIndex = 16;
            this.btnAssistente.UseVisualStyleBackColor = true;
            this.btnAssistente.Click += new System.EventHandler(this.BtnAssistente_Click);
            this.btnAssistente.MouseEnter += new System.EventHandler(this.BtnAssistente_MouseEnter);
            this.btnAssistente.MouseLeave += new System.EventHandler(this.BtnAssistente_MouseLeave);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(373, 316);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(0, 18);
            this.lblNome.TabIndex = 17;
            // 
            // btnAluno
            // 
            this.btnAluno.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAluno.Image = global::Escola_Técnica.Properties.Resources.userr_removebg_preview;
            this.btnAluno.Location = new System.Drawing.Point(352, 163);
            this.btnAluno.Name = "btnAluno";
            this.btnAluno.Size = new System.Drawing.Size(176, 150);
            this.btnAluno.TabIndex = 18;
            this.btnAluno.UseVisualStyleBackColor = true;
            this.btnAluno.Click += new System.EventHandler(this.BtnAluno_Click);
            this.btnAluno.MouseEnter += new System.EventHandler(this.BtnAluno_MouseEnter);
            this.btnAluno.MouseLeave += new System.EventHandler(this.BtnAluno_MouseLeave);
            // 
            // btnProfessor
            // 
            this.btnProfessor.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnProfessor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfessor.Image = global::Escola_Técnica.Properties.Resources.userr_removebg_preview;
            this.btnProfessor.Location = new System.Drawing.Point(352, 163);
            this.btnProfessor.Name = "btnProfessor";
            this.btnProfessor.Size = new System.Drawing.Size(176, 150);
            this.btnProfessor.TabIndex = 19;
            this.btnProfessor.UseVisualStyleBackColor = true;
            this.btnProfessor.Click += new System.EventHandler(this.BtnProfessor_Click);
            this.btnProfessor.MouseEnter += new System.EventHandler(this.BtnProfessor_MouseEnter);
            this.btnProfessor.MouseLeave += new System.EventHandler(this.BtnProfessor_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 34;
            this.label1.Text = "Assistente@gmail.com";
            // 
            // UCHome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProfessor);
            this.Controls.Add(this.btnAluno);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnAssistente);
            this.Name = "UCHome";
            this.Size = new System.Drawing.Size(929, 535);
            this.Load += new System.EventHandler(this.UCHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAssistente;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnAluno;
        private System.Windows.Forms.Button btnProfessor;
        private System.Windows.Forms.Label label1;
    }
}
