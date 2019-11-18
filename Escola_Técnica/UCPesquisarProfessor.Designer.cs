namespace Escola_Técnica
{
    partial class UCPesquisarProfessor
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
            this.dataGridViewProfessor = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.columnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTurma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDataNasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfessor)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProfessor
            // 
            this.dataGridViewProfessor.AllowUserToAddRows = false;
            this.dataGridViewProfessor.AllowUserToDeleteRows = false;
            this.dataGridViewProfessor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProfessor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnId,
            this.columnNome,
            this.columnTurma,
            this.columnCpf,
            this.columnDataNasc,
            this.columnTelefone,
            this.columnCelular,
            this.columnEmail,
            this.columnCidade,
            this.ColumnBairro,
            this.ColumnRua,
            this.columnCep,
            this.columnNumero});
            this.dataGridViewProfessor.Location = new System.Drawing.Point(0, 34);
            this.dataGridViewProfessor.Name = "dataGridViewProfessor";
            this.dataGridViewProfessor.ReadOnly = true;
            this.dataGridViewProfessor.Size = new System.Drawing.Size(929, 501);
            this.dataGridViewProfessor.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(457, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "PROFESSORES";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(3, 5);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 34;
            this.btnCadastrar.Text = "Atualizar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // columnId
            // 
            this.columnId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnId.FillWeight = 30F;
            this.columnId.HeaderText = "ID";
            this.columnId.Name = "columnId";
            this.columnId.ReadOnly = true;
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
            // columnDataNasc
            // 
            this.columnDataNasc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnDataNasc.HeaderText = "Nasc";
            this.columnDataNasc.Name = "columnDataNasc";
            this.columnDataNasc.ReadOnly = true;
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
            // columnCep
            // 
            this.columnCep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnCep.FillWeight = 75F;
            this.columnCep.HeaderText = "Cep";
            this.columnCep.Name = "columnCep";
            this.columnCep.ReadOnly = true;
            // 
            // columnNumero
            // 
            this.columnNumero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnNumero.FillWeight = 60F;
            this.columnNumero.HeaderText = "Número";
            this.columnNumero.Name = "columnNumero";
            this.columnNumero.ReadOnly = true;
            // 
            // UCPesquisarProfessor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewProfessor);
            this.Name = "UCPesquisarProfessor";
            this.Size = new System.Drawing.Size(929, 535);
            this.Load += new System.EventHandler(this.UCPesquisarProfessor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfessor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProfessor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTurma;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDataNasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRua;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCep;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNumero;
    }
}
