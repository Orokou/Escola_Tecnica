namespace Escola_Técnica
{
    partial class UCEditarNotas
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
            this.cboxMateria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxAluno = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNotaAntiga = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.dataGridViewNotas = new System.Windows.Forms.DataGridView();
            this.ColumnMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // cboxMateria
            // 
            this.cboxMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxMateria.FormattingEnabled = true;
            this.cboxMateria.Location = new System.Drawing.Point(185, 191);
            this.cboxMateria.Name = "cboxMateria";
            this.cboxMateria.Size = new System.Drawing.Size(201, 21);
            this.cboxMateria.TabIndex = 41;
            this.cboxMateria.SelectedIndexChanged += new System.EventHandler(this.CboxMateria_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Matéria:";
            // 
            // cboxAluno
            // 
            this.cboxAluno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxAluno.FormattingEnabled = true;
            this.cboxAluno.Location = new System.Drawing.Point(185, 132);
            this.cboxAluno.Name = "cboxAluno";
            this.cboxAluno.Size = new System.Drawing.Size(201, 21);
            this.cboxAluno.TabIndex = 39;
            this.cboxAluno.SelectedIndexChanged += new System.EventHandler(this.CboxAluno_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Aluno:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Nota antiga:";
            // 
            // txtNotaAntiga
            // 
            this.txtNotaAntiga.Location = new System.Drawing.Point(185, 255);
            this.txtNotaAntiga.Name = "txtNotaAntiga";
            this.txtNotaAntiga.ReadOnly = true;
            this.txtNotaAntiga.Size = new System.Drawing.Size(57, 20);
            this.txtNotaAntiga.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Nota atual:";
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(185, 316);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(57, 20);
            this.txtNota.TabIndex = 45;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(246, 401);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 47;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // dataGridViewNotas
            // 
            this.dataGridViewNotas.AllowUserToAddRows = false;
            this.dataGridViewNotas.AllowUserToDeleteRows = false;
            this.dataGridViewNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMateria,
            this.ColumnNota});
            this.dataGridViewNotas.Location = new System.Drawing.Point(464, 132);
            this.dataGridViewNotas.Name = "dataGridViewNotas";
            this.dataGridViewNotas.ReadOnly = true;
            this.dataGridViewNotas.Size = new System.Drawing.Size(345, 289);
            this.dataGridViewNotas.TabIndex = 48;
            this.dataGridViewNotas.Visible = false;
            // 
            // ColumnMateria
            // 
            this.ColumnMateria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnMateria.FillWeight = 200F;
            this.ColumnMateria.HeaderText = "Matéria";
            this.ColumnMateria.Name = "ColumnMateria";
            this.ColumnMateria.ReadOnly = true;
            // 
            // ColumnNota
            // 
            this.ColumnNota.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNota.FillWeight = 50F;
            this.ColumnNota.HeaderText = "Nota";
            this.ColumnNota.Name = "ColumnNota";
            this.ColumnNota.ReadOnly = true;
            // 
            // UCEditarNotas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.dataGridViewNotas);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNotaAntiga);
            this.Controls.Add(this.cboxMateria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboxAluno);
            this.Controls.Add(this.label1);
            this.Name = "UCEditarNotas";
            this.Size = new System.Drawing.Size(929, 535);
            this.Load += new System.EventHandler(this.UCEditarNotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxMateria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxAluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNotaAntiga;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.DataGridView dataGridViewNotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNota;
    }
}
