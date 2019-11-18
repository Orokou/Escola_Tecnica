namespace Escola_Técnica
{
    partial class UCCadastroTurma
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.rbtnNoite = new System.Windows.Forms.RadioButton();
            this.rbtnTarde = new System.Windows.Forms.RadioButton();
            this.rbtnManha = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxCurso = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(429, 399);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 15;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // rbtnNoite
            // 
            this.rbtnNoite.AutoSize = true;
            this.rbtnNoite.Location = new System.Drawing.Point(383, 312);
            this.rbtnNoite.Name = "rbtnNoite";
            this.rbtnNoite.Size = new System.Drawing.Size(50, 17);
            this.rbtnNoite.TabIndex = 14;
            this.rbtnNoite.TabStop = true;
            this.rbtnNoite.Text = "Noite";
            this.rbtnNoite.UseVisualStyleBackColor = true;
            this.rbtnNoite.CheckedChanged += new System.EventHandler(this.RbtnNoite_CheckedChanged);
            // 
            // rbtnTarde
            // 
            this.rbtnTarde.AutoSize = true;
            this.rbtnTarde.Location = new System.Drawing.Point(383, 289);
            this.rbtnTarde.Name = "rbtnTarde";
            this.rbtnTarde.Size = new System.Drawing.Size(53, 17);
            this.rbtnTarde.TabIndex = 12;
            this.rbtnTarde.TabStop = true;
            this.rbtnTarde.Text = "Tarde";
            this.rbtnTarde.UseVisualStyleBackColor = true;
            this.rbtnTarde.CheckedChanged += new System.EventHandler(this.RbtnTarde_CheckedChanged);
            // 
            // rbtnManha
            // 
            this.rbtnManha.AutoSize = true;
            this.rbtnManha.Location = new System.Drawing.Point(383, 266);
            this.rbtnManha.Name = "rbtnManha";
            this.rbtnManha.Size = new System.Drawing.Size(58, 17);
            this.rbtnManha.TabIndex = 11;
            this.rbtnManha.TabStop = true;
            this.rbtnManha.Text = "Manhã";
            this.rbtnManha.UseVisualStyleBackColor = true;
            this.rbtnManha.CheckedChanged += new System.EventHandler(this.RbtnManha_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Turno:";
            // 
            // cboxCurso
            // 
            this.cboxCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCurso.FormattingEnabled = true;
            this.cboxCurso.Location = new System.Drawing.Point(383, 186);
            this.cboxCurso.Name = "cboxCurso";
            this.cboxCurso.Size = new System.Drawing.Size(201, 21);
            this.cboxCurso.TabIndex = 9;
            this.cboxCurso.SelectedIndexChanged += new System.EventHandler(this.CboxCurso_SelectedIndexChanged);
            this.cboxCurso.Click += new System.EventHandler(this.CboxCurso_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Curso:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(383, 115);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(121, 20);
            this.txtNome.TabIndex = 8;
            // 
            // UCCadastroTurma
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.rbtnNoite);
            this.Controls.Add(this.rbtnTarde);
            this.Controls.Add(this.rbtnManha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboxCurso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Name = "UCCadastroTurma";
            this.Size = new System.Drawing.Size(929, 535);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.RadioButton rbtnNoite;
        private System.Windows.Forms.RadioButton rbtnTarde;
        private System.Windows.Forms.RadioButton rbtnManha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxCurso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
    }
}
