namespace Escola_Técnica
{
    partial class UCPesquisarAluno
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
            this.dataGridViewAluno = new System.Windows.Forms.DataGridView();
            this.cboxTurma = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.columnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTurma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataNasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAluno
            // 
            this.dataGridViewAluno.AllowUserToAddRows = false;
            this.dataGridViewAluno.AllowUserToDeleteRows = false;
            this.dataGridViewAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAluno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnId,
            this.columnNome,
            this.columnTurma,
            this.columnCpf,
            this.ColumnDataNasc,
            this.columnTelefone,
            this.columnCelular,
            this.columnEmail,
            this.columnCidade,
            this.ColumnBairro,
            this.ColumnRua,
            this.ColumnCep,
            this.columnNumero});
            this.dataGridViewAluno.Location = new System.Drawing.Point(0, 30);
            this.dataGridViewAluno.Name = "dataGridViewAluno";
            this.dataGridViewAluno.ReadOnly = true;
            this.dataGridViewAluno.Size = new System.Drawing.Size(929, 505);
            this.dataGridViewAluno.TabIndex = 29;
            // 
            // cboxTurma
            // 
            this.cboxTurma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTurma.FormattingEnabled = true;
            this.cboxTurma.Location = new System.Drawing.Point(368, 3);
            this.cboxTurma.Name = "cboxTurma";
            this.cboxTurma.Size = new System.Drawing.Size(201, 21);
            this.cboxTurma.TabIndex = 31;
            this.cboxTurma.SelectedIndexChanged += new System.EventHandler(this.CboxTurma_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(322, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Turma:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(3, 3);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 33;
            this.btnCadastrar.Text = "Atualizar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // columnId
            // 
            this.columnId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.columnId.FillWeight = 30F;
            this.columnId.Frozen = true;
            this.columnId.HeaderText = "ID";
            this.columnId.Name = "columnId";
            this.columnId.ReadOnly = true;
            this.columnId.Width = 21;
            // 
            // columnNome
            // 
            this.columnNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnNome.HeaderText = "Nome";
            this.columnNome.Name = "columnNome";
            this.columnNome.ReadOnly = true;
            // 
            // columnTurma
            // 
            this.columnTurma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnTurma.FillWeight = 70F;
            this.columnTurma.HeaderText = "Turma";
            this.columnTurma.Name = "columnTurma";
            this.columnTurma.ReadOnly = true;
            // 
            // columnCpf
            // 
            this.columnCpf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnCpf.HeaderText = "CPF";
            this.columnCpf.Name = "columnCpf";
            this.columnCpf.ReadOnly = true;
            // 
            // ColumnDataNasc
            // 
            this.ColumnDataNasc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDataNasc.HeaderText = "Nasc";
            this.ColumnDataNasc.Name = "ColumnDataNasc";
            this.ColumnDataNasc.ReadOnly = true;
            // 
            // columnTelefone
            // 
            this.columnTelefone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnTelefone.HeaderText = "Telefone";
            this.columnTelefone.Name = "columnTelefone";
            this.columnTelefone.ReadOnly = true;
            // 
            // columnCelular
            // 
            this.columnCelular.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnCelular.HeaderText = "Celular";
            this.columnCelular.Name = "columnCelular";
            this.columnCelular.ReadOnly = true;
            // 
            // columnEmail
            // 
            this.columnEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnEmail.HeaderText = "Email";
            this.columnEmail.Name = "columnEmail";
            this.columnEmail.ReadOnly = true;
            // 
            // columnCidade
            // 
            this.columnCidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnCidade.HeaderText = "Cidade";
            this.columnCidade.Name = "columnCidade";
            this.columnCidade.ReadOnly = true;
            // 
            // ColumnBairro
            // 
            this.ColumnBairro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnBairro.HeaderText = "Bairro";
            this.ColumnBairro.Name = "ColumnBairro";
            this.ColumnBairro.ReadOnly = true;
            // 
            // ColumnRua
            // 
            this.ColumnRua.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnRua.HeaderText = "Rua";
            this.ColumnRua.Name = "ColumnRua";
            this.ColumnRua.ReadOnly = true;
            // 
            // ColumnCep
            // 
            this.ColumnCep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnCep.FillWeight = 75F;
            this.ColumnCep.HeaderText = "Cep";
            this.ColumnCep.Name = "ColumnCep";
            this.ColumnCep.ReadOnly = true;
            // 
            // columnNumero
            // 
            this.columnNumero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnNumero.FillWeight = 60F;
            this.columnNumero.HeaderText = "Número";
            this.columnNumero.Name = "columnNumero";
            this.columnNumero.ReadOnly = true;
            // 
            // UCPesquisarAluno
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.cboxTurma);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridViewAluno);
            this.Name = "UCPesquisarAluno";
            this.Size = new System.Drawing.Size(929, 535);
            this.Load += new System.EventHandler(this.UCPesquisarAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAluno;
        private System.Windows.Forms.ComboBox cboxTurma;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTurma;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDataNasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRua;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCep;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNumero;
    }
}
