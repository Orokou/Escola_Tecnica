﻿namespace Escola_Técnica
{
    partial class UCEditarProfessor
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
            this.btnAlterar = new System.Windows.Forms.Button();
            this.cboxTurma = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.cboxTurma2 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboxProfessor = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(416, 433);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 123;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Visible = false;
            this.btnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // cboxTurma
            // 
            this.cboxTurma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTurma.FormattingEnabled = true;
            this.cboxTurma.Location = new System.Drawing.Point(596, 366);
            this.cboxTurma.Name = "cboxTurma";
            this.cboxTurma.Size = new System.Drawing.Size(201, 21);
            this.cboxTurma.TabIndex = 121;
            this.cboxTurma.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(550, 369);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 122;
            this.label12.Text = "Turma:";
            this.label12.Visible = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(416, 318);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 110;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // cboxTurma2
            // 
            this.cboxTurma2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTurma2.FormattingEnabled = true;
            this.cboxTurma2.Location = new System.Drawing.Point(360, 161);
            this.cboxTurma2.Name = "cboxTurma2";
            this.cboxTurma2.Size = new System.Drawing.Size(201, 21);
            this.cboxTurma2.TabIndex = 124;
            this.cboxTurma2.SelectedIndexChanged += new System.EventHandler(this.CboxTurma2_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(314, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 125;
            this.label11.Text = "Turma:";
            // 
            // cboxProfessor
            // 
            this.cboxProfessor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxProfessor.FormattingEnabled = true;
            this.cboxProfessor.Location = new System.Drawing.Point(360, 216);
            this.cboxProfessor.Name = "cboxProfessor";
            this.cboxProfessor.Size = new System.Drawing.Size(201, 21);
            this.cboxProfessor.TabIndex = 126;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(300, 219);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 127;
            this.label13.Text = "Professor:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(616, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 13);
            this.label14.TabIndex = 139;
            this.label14.Text = "Data de nascimento:";
            this.label14.Visible = false;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(727, 65);
            this.txtData.Mask = "99/99/9999";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(70, 20);
            this.txtData.TabIndex = 138;
            this.txtData.Visible = false;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(468, 65);
            this.txtCpf.Mask = "999999999-99";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(85, 20);
            this.txtCpf.TabIndex = 129;
            this.txtCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCpf.Visible = false;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(416, 137);
            this.txtCelular.Mask = "(99)999999999";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(84, 20);
            this.txtCelular.TabIndex = 131;
            this.txtCelular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCelular.Visible = false;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(184, 137);
            this.txtTelefone.Mask = "(99)9999-9999";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(81, 20);
            this.txtTelefone.TabIndex = 130;
            this.txtTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtTelefone.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(593, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 137;
            this.label5.Text = "Email:";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 136;
            this.label4.Text = "Celular:";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 135;
            this.label3.Text = "Telefone:";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 134;
            this.label2.Text = "CPF:";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 133;
            this.label1.Text = "Nome:";
            this.label1.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(634, 137);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(163, 20);
            this.txtEmail.TabIndex = 132;
            this.txtEmail.Visible = false;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(184, 65);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(221, 20);
            this.txtNome.TabIndex = 128;
            this.txtNome.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(137, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 145;
            this.label10.Text = "Senha:";
            this.label10.Visible = false;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(184, 217);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 140;
            this.txtSenha.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(131, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 144;
            this.label6.Text = "Número:";
            this.label6.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(141, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 143;
            this.label8.Text = "Bairro:";
            this.label8.Visible = false;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(184, 367);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 142;
            this.txtNumero.Visible = false;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(184, 292);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(251, 20);
            this.txtBairro.TabIndex = 141;
            this.txtBairro.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(551, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 147;
            this.label9.Text = "Rua:";
            this.label9.Visible = false;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(587, 292);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(210, 20);
            this.txtRua.TabIndex = 146;
            this.txtRua.Visible = false;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(416, 366);
            this.txtCep.Mask = "99999-999";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(63, 20);
            this.txtCep.TabIndex = 148;
            this.txtCep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCep.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(381, 369);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 13);
            this.label15.TabIndex = 149;
            this.label15.Text = "Cep:";
            this.label15.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(503, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 151;
            this.label7.Text = "Cidade:";
            this.label7.Visible = false;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(552, 212);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(245, 20);
            this.txtCidade.TabIndex = 150;
            this.txtCidade.Visible = false;
            // 
            // UCEditarProfessor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.cboxProfessor);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cboxTurma2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.cboxTurma);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnConfirmar);
            this.Name = "UCEditarProfessor";
            this.Size = new System.Drawing.Size(929, 535);
            this.Load += new System.EventHandler(this.UCEditarProfessor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.ComboBox cboxTurma;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.ComboBox cboxTurma2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboxProfessor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCidade;
    }
}
