namespace Escola_Técnica
{
    partial class UCCadastroCurso
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCurso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(549, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "CADASTRAR DISCIPLINA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "CADASTRAR CURSO";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Escola_Técnica.Properties.Resources.livro_removebg_preview;
            this.button1.Location = new System.Drawing.Point(541, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 107);
            this.button1.TabIndex = 22;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.Button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.Button1_MouseLeave);
            // 
            // btnCurso
            // 
            this.btnCurso.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurso.Image = global::Escola_Técnica.Properties.Resources.turma_removebg_preview21;
            this.btnCurso.Location = new System.Drawing.Point(272, 202);
            this.btnCurso.Name = "btnCurso";
            this.btnCurso.Size = new System.Drawing.Size(119, 107);
            this.btnCurso.TabIndex = 20;
            this.btnCurso.UseVisualStyleBackColor = true;
            this.btnCurso.Click += new System.EventHandler(this.BtnCurso_Click);
            this.btnCurso.MouseEnter += new System.EventHandler(this.BtnCurso_MouseEnter);
            this.btnCurso.MouseLeave += new System.EventHandler(this.BtnCurso_MouseLeave);
            // 
            // UCCadastroCurso
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCurso);
            this.Name = "UCCadastroCurso";
            this.Size = new System.Drawing.Size(929, 535);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCurso;
    }
}
