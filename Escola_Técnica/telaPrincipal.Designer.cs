namespace Escola_Técnica
{
    partial class telaPrincipal
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MenuLateral = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEditarNotas = new System.Windows.Forms.Button();
            this.btnLançarNotas = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnVerNotas = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.MenuSuperior = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.MenuLateral.SuspendLayout();
            this.MenuSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "CADASTRAR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 512);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "EXCLUIR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "EDITAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "PESQUISAR";
            // 
            // MenuLateral
            // 
            this.MenuLateral.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.MenuLateral.Controls.Add(this.label7);
            this.MenuLateral.Controls.Add(this.btnEditarNotas);
            this.MenuLateral.Controls.Add(this.btnLançarNotas);
            this.MenuLateral.Controls.Add(this.label6);
            this.MenuLateral.Controls.Add(this.label5);
            this.MenuLateral.Controls.Add(this.btnVerNotas);
            this.MenuLateral.Controls.Add(this.btnCadastrar);
            this.MenuLateral.Controls.Add(this.label4);
            this.MenuLateral.Controls.Add(this.label1);
            this.MenuLateral.Controls.Add(this.btnExcluir);
            this.MenuLateral.Controls.Add(this.btnPesquisar);
            this.MenuLateral.Controls.Add(this.label3);
            this.MenuLateral.Controls.Add(this.label2);
            this.MenuLateral.Controls.Add(this.btnEditar);
            this.MenuLateral.Location = new System.Drawing.Point(1, 0);
            this.MenuLateral.Name = "MenuLateral";
            this.MenuLateral.Size = new System.Drawing.Size(131, 563);
            this.MenuLateral.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "EDITAR NOTAS";
            // 
            // btnEditarNotas
            // 
            this.btnEditarNotas.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEditarNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarNotas.Image = global::Escola_Técnica.Properties.Resources.nota_removebg_preview;
            this.btnEditarNotas.Location = new System.Drawing.Point(6, 302);
            this.btnEditarNotas.Name = "btnEditarNotas";
            this.btnEditarNotas.Size = new System.Drawing.Size(119, 107);
            this.btnEditarNotas.TabIndex = 20;
            this.btnEditarNotas.UseVisualStyleBackColor = true;
            this.btnEditarNotas.Click += new System.EventHandler(this.BtnEditarNotas_Click);
            this.btnEditarNotas.MouseEnter += new System.EventHandler(this.BtnEditarNotas_MouseEnter);
            this.btnEditarNotas.MouseLeave += new System.EventHandler(this.BtnEditarNotas_MouseLeave);
            // 
            // btnLançarNotas
            // 
            this.btnLançarNotas.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLançarNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLançarNotas.Image = global::Escola_Técnica.Properties.Resources.nota_removebg_preview;
            this.btnLançarNotas.Location = new System.Drawing.Point(6, 131);
            this.btnLançarNotas.Name = "btnLançarNotas";
            this.btnLançarNotas.Size = new System.Drawing.Size(119, 107);
            this.btnLançarNotas.TabIndex = 19;
            this.btnLançarNotas.UseVisualStyleBackColor = true;
            this.btnLançarNotas.Click += new System.EventHandler(this.BtnLançarNotas_Click);
            this.btnLançarNotas.MouseEnter += new System.EventHandler(this.BtnLançarNotas_MouseEnter);
            this.btnLançarNotas.MouseLeave += new System.EventHandler(this.BtnLançarNotas_MouseLeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "LANÇAR NOTAS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "VER NOTAS";
            // 
            // btnVerNotas
            // 
            this.btnVerNotas.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnVerNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerNotas.Image = global::Escola_Técnica.Properties.Resources.nota_removebg_preview;
            this.btnVerNotas.Location = new System.Drawing.Point(6, 213);
            this.btnVerNotas.Name = "btnVerNotas";
            this.btnVerNotas.Size = new System.Drawing.Size(119, 107);
            this.btnVerNotas.TabIndex = 18;
            this.btnVerNotas.UseVisualStyleBackColor = true;
            this.btnVerNotas.Click += new System.EventHandler(this.BtnVerNotas_Click);
            this.btnVerNotas.MouseEnter += new System.EventHandler(this.BtnVerNotas_MouseEnter);
            this.btnVerNotas.MouseLeave += new System.EventHandler(this.BtnVerNotas_MouseLeave);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Image = global::Escola_Técnica.Properties.Resources.cadastro_removebg_preview_removebg_preview;
            this.btnCadastrar.Location = new System.Drawing.Point(3, 21);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(119, 107);
            this.btnCadastrar.TabIndex = 13;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            this.btnCadastrar.MouseEnter += new System.EventHandler(this.BtnCadastrar_MouseEnter);
            this.btnCadastrar.MouseLeave += new System.EventHandler(this.BtnCadastrar_MouseLeave);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Image = global::Escola_Técnica.Properties.Resources.excluir_removebg_preview;
            this.btnExcluir.Location = new System.Drawing.Point(3, 402);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(119, 107);
            this.btnExcluir.TabIndex = 19;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            this.btnExcluir.MouseEnter += new System.EventHandler(this.BtnExcluir_MouseEnter);
            this.btnExcluir.MouseLeave += new System.EventHandler(this.BtnExcluir_MouseLeave);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Image = global::Escola_Técnica.Properties.Resources.pesquisa_removebg_preview1;
            this.btnPesquisar.Location = new System.Drawing.Point(3, 150);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(119, 107);
            this.btnPesquisar.TabIndex = 17;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            this.btnPesquisar.MouseEnter += new System.EventHandler(this.BtnPesquisar_MouseEnter);
            this.btnPesquisar.MouseLeave += new System.EventHandler(this.BtnPesquisar_MouseLeave);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Image = global::Escola_Técnica.Properties.Resources.alterar_removebg_preview;
            this.btnEditar.Location = new System.Drawing.Point(6, 276);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(119, 107);
            this.btnEditar.TabIndex = 18;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            this.btnEditar.MouseEnter += new System.EventHandler(this.BtnEditar_MouseEnter);
            this.btnEditar.MouseLeave += new System.EventHandler(this.BtnEditar_MouseLeave);
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(132, 33);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(929, 535);
            this.panelContainer.TabIndex = 24;
            // 
            // MenuSuperior
            // 
            this.MenuSuperior.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.MenuSuperior.Controls.Add(this.btnSair);
            this.MenuSuperior.Controls.Add(this.btnHome);
            this.MenuSuperior.Location = new System.Drawing.Point(132, 0);
            this.MenuSuperior.Name = "MenuSuperior";
            this.MenuSuperior.Size = new System.Drawing.Size(929, 32);
            this.MenuSuperior.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(892, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(37, 23);
            this.btnSair.TabIndex = 26;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            this.btnSair.MouseEnter += new System.EventHandler(this.BtnSair_MouseEnter);
            this.btnSair.MouseLeave += new System.EventHandler(this.BtnSair_MouseLeave);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Image = global::Escola_Técnica.Properties.Resources.homee_removebg_preview;
            this.btnHome.Location = new System.Drawing.Point(863, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(32, 31);
            this.btnHome.TabIndex = 25;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // telaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1062, 563);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.MenuSuperior);
            this.Controls.Add(this.MenuLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "telaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.MenuLateral.ResumeLayout(false);
            this.MenuLateral.PerformLayout();
            this.MenuSuperior.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Panel MenuLateral;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel MenuSuperior;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnVerNotas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLançarNotas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEditarNotas;
    }
}

