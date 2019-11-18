namespace Escola_Técnica
{
    partial class UCLancarNotas
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
            this.btnLancar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.cboxMateria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxAluno = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLancar
            // 
            this.btnLancar.Location = new System.Drawing.Point(437, 358);
            this.btnLancar.Name = "btnLancar";
            this.btnLancar.Size = new System.Drawing.Size(75, 23);
            this.btnLancar.TabIndex = 43;
            this.btnLancar.Text = "Lançar";
            this.btnLancar.UseVisualStyleBackColor = true;
            this.btnLancar.Click += new System.EventHandler(this.BtnLancar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Nota:";
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(385, 290);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(75, 20);
            this.txtNota.TabIndex = 41;
            // 
            // cboxMateria
            // 
            this.cboxMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxMateria.FormattingEnabled = true;
            this.cboxMateria.Location = new System.Drawing.Point(385, 225);
            this.cboxMateria.Name = "cboxMateria";
            this.cboxMateria.Size = new System.Drawing.Size(201, 21);
            this.cboxMateria.TabIndex = 37;
            this.cboxMateria.SelectedIndexChanged += new System.EventHandler(this.CboxMateria_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Matéria:";
            // 
            // cboxAluno
            // 
            this.cboxAluno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxAluno.FormattingEnabled = true;
            this.cboxAluno.Location = new System.Drawing.Point(385, 166);
            this.cboxAluno.Name = "cboxAluno";
            this.cboxAluno.Size = new System.Drawing.Size(201, 21);
            this.cboxAluno.TabIndex = 35;
            this.cboxAluno.SelectedIndexChanged += new System.EventHandler(this.CboxAluno_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Aluno:";
            // 
            // UCLancarNotas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.btnLancar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.cboxMateria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboxAluno);
            this.Controls.Add(this.label1);
            this.Name = "UCLancarNotas";
            this.Size = new System.Drawing.Size(929, 535);
            this.Load += new System.EventHandler(this.UCLancarNotas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLancar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.ComboBox cboxMateria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxAluno;
        private System.Windows.Forms.Label label1;
    }
}
