namespace Escola_Técnica
{
    partial class UCVerNotas
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
            this.dataGridViewNotas = new System.Windows.Forms.DataGridView();
            this.columnDisciplina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewNotas
            // 
            this.dataGridViewNotas.AllowUserToAddRows = false;
            this.dataGridViewNotas.AllowUserToDeleteRows = false;
            this.dataGridViewNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnDisciplina,
            this.columnNota});
            this.dataGridViewNotas.Location = new System.Drawing.Point(277, 53);
            this.dataGridViewNotas.Name = "dataGridViewNotas";
            this.dataGridViewNotas.ReadOnly = true;
            this.dataGridViewNotas.Size = new System.Drawing.Size(407, 418);
            this.dataGridViewNotas.TabIndex = 1;
            // 
            // columnDisciplina
            // 
            this.columnDisciplina.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnDisciplina.FillWeight = 200F;
            this.columnDisciplina.HeaderText = "Disciplina";
            this.columnDisciplina.Name = "columnDisciplina";
            this.columnDisciplina.ReadOnly = true;
            // 
            // columnNota
            // 
            this.columnNota.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnNota.FillWeight = 50F;
            this.columnNota.HeaderText = "Nota";
            this.columnNota.Name = "columnNota";
            this.columnNota.ReadOnly = true;
            // 
            // UCVerNotas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.dataGridViewNotas);
            this.Name = "UCVerNotas";
            this.Size = new System.Drawing.Size(929, 535);
            this.Load += new System.EventHandler(this.UCVerNotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewNotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDisciplina;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNota;
    }
}
