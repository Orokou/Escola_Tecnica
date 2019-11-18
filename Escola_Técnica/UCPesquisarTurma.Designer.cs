namespace Escola_Técnica
{
    partial class UCPesquisarTurma
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
            this.dataGridViewTurma = new System.Windows.Forms.DataGridView();
            this.columnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTurma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTurno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTurma)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(441, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "TURMAS";
            // 
            // dataGridViewTurma
            // 
            this.dataGridViewTurma.AllowUserToAddRows = false;
            this.dataGridViewTurma.AllowUserToDeleteRows = false;
            this.dataGridViewTurma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTurma.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnId,
            this.columnTurma,
            this.columnCurso,
            this.columnTurno});
            this.dataGridViewTurma.Location = new System.Drawing.Point(0, 32);
            this.dataGridViewTurma.Name = "dataGridViewTurma";
            this.dataGridViewTurma.ReadOnly = true;
            this.dataGridViewTurma.Size = new System.Drawing.Size(929, 503);
            this.dataGridViewTurma.TabIndex = 26;
            // 
            // columnId
            // 
            this.columnId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnId.FillWeight = 45F;
            this.columnId.HeaderText = "ID";
            this.columnId.Name = "columnId";
            this.columnId.ReadOnly = true;
            // 
            // columnTurma
            // 
            this.columnTurma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnTurma.HeaderText = "Turma";
            this.columnTurma.Name = "columnTurma";
            this.columnTurma.ReadOnly = true;
            // 
            // columnCurso
            // 
            this.columnCurso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnCurso.FillWeight = 300F;
            this.columnCurso.HeaderText = "Curso";
            this.columnCurso.Name = "columnCurso";
            this.columnCurso.ReadOnly = true;
            // 
            // columnTurno
            // 
            this.columnTurno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnTurno.HeaderText = "Turno";
            this.columnTurno.Name = "columnTurno";
            this.columnTurno.ReadOnly = true;
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
            // UCPesquisarTurma
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewTurma);
            this.Name = "UCPesquisarTurma";
            this.Size = new System.Drawing.Size(929, 535);
            this.Load += new System.EventHandler(this.UCPesquisarTurma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTurma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewTurma;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTurma;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTurno;
        private System.Windows.Forms.Button btnCadastrar;
    }
}
