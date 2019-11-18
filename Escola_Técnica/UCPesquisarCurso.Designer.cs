namespace Escola_Técnica
{
    partial class UCPesquisarCurso
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
            this.dataGridViewCurso = new System.Windows.Forms.DataGridView();
            this.columnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCargaHoraria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(432, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "CURSOS";
            // 
            // dataGridViewCurso
            // 
            this.dataGridViewCurso.AllowUserToAddRows = false;
            this.dataGridViewCurso.AllowUserToDeleteRows = false;
            this.dataGridViewCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCurso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnId,
            this.columnCurso,
            this.columnCargaHoraria});
            this.dataGridViewCurso.Location = new System.Drawing.Point(0, 29);
            this.dataGridViewCurso.Name = "dataGridViewCurso";
            this.dataGridViewCurso.ReadOnly = true;
            this.dataGridViewCurso.Size = new System.Drawing.Size(929, 506);
            this.dataGridViewCurso.TabIndex = 25;
            // 
            // columnId
            // 
            this.columnId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnId.FillWeight = 45F;
            this.columnId.HeaderText = "ID";
            this.columnId.Name = "columnId";
            this.columnId.ReadOnly = true;
            // 
            // columnCurso
            // 
            this.columnCurso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnCurso.FillWeight = 300F;
            this.columnCurso.HeaderText = "Curso";
            this.columnCurso.Name = "columnCurso";
            this.columnCurso.ReadOnly = true;
            // 
            // columnCargaHoraria
            // 
            this.columnCargaHoraria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnCargaHoraria.HeaderText = "Carga Horária (Horas)";
            this.columnCargaHoraria.Name = "columnCargaHoraria";
            this.columnCargaHoraria.ReadOnly = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(3, 3);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 34;
            this.btnCadastrar.Text = "Atualizar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // UCPesquisarCurso
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewCurso);
            this.Name = "UCPesquisarCurso";
            this.Size = new System.Drawing.Size(929, 535);
            this.Load += new System.EventHandler(this.UCPesquisarCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCurso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCargaHoraria;
        private System.Windows.Forms.Button btnCadastrar;
    }
}
