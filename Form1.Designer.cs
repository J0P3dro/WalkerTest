namespace WalkerTest
{
    partial class Form1
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
            this.APRESENTACAO = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ACESSAR = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GRAVAR2 = new System.Windows.Forms.Button();
            this.Senhas = new System.Windows.Forms.TextBox();
            this.Logando = new System.Windows.Forms.TextBox();
            this.SAIR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CADASTRO = new System.Windows.Forms.GroupBox();
            this.Btn_Lista = new System.Windows.Forms.Button();
            this.GRAVAR = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cadastrar_Senha = new System.Windows.Forms.TextBox();
            this.Cadastrar_Login = new System.Windows.Forms.TextBox();
            this.CADASTRAR = new System.Windows.Forms.Button();
            this.LOGAR = new System.Windows.Forms.Button();
            this.APRESENTACAO.SuspendLayout();
            this.ACESSAR.SuspendLayout();
            this.CADASTRO.SuspendLayout();
            this.SuspendLayout();
            // 
            // APRESENTACAO
            // 
            this.APRESENTACAO.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.APRESENTACAO.BackColor = System.Drawing.SystemColors.ControlLight;
            this.APRESENTACAO.Controls.Add(this.label6);
            this.APRESENTACAO.Controls.Add(this.ACESSAR);
            this.APRESENTACAO.Controls.Add(this.SAIR);
            this.APRESENTACAO.Controls.Add(this.label1);
            this.APRESENTACAO.Controls.Add(this.CADASTRO);
            this.APRESENTACAO.Controls.Add(this.CADASTRAR);
            this.APRESENTACAO.Controls.Add(this.LOGAR);
            this.APRESENTACAO.ForeColor = System.Drawing.SystemColors.ControlText;
            this.APRESENTACAO.Location = new System.Drawing.Point(14, 22);
            this.APRESENTACAO.Name = "APRESENTACAO";
            this.APRESENTACAO.Size = new System.Drawing.Size(630, 410);
            this.APRESENTACAO.TabIndex = 0;
            this.APRESENTACAO.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(616, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Olá, eu sou WALKER, seu assistente digital! Em que posso lhe ajudar hoje?";
            // 
            // ACESSAR
            // 
            this.ACESSAR.BackColor = System.Drawing.SystemColors.Control;
            this.ACESSAR.Controls.Add(this.label5);
            this.ACESSAR.Controls.Add(this.label4);
            this.ACESSAR.Controls.Add(this.GRAVAR2);
            this.ACESSAR.Controls.Add(this.Senhas);
            this.ACESSAR.Controls.Add(this.Logando);
            this.ACESSAR.Location = new System.Drawing.Point(323, 149);
            this.ACESSAR.Name = "ACESSAR";
            this.ACESSAR.Size = new System.Drawing.Size(247, 213);
            this.ACESSAR.TabIndex = 5;
            this.ACESSAR.TabStop = false;
            this.ACESSAR.Visible = false;
            this.ACESSAR.Enter += new System.EventHandler(this.ACESSAR_Enter);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 14);
            this.label5.TabIndex = 9;
            this.label5.Text = "SENHA:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "LOGIN:";
            // 
            // GRAVAR2
            // 
            this.GRAVAR2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GRAVAR2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRAVAR2.Location = new System.Drawing.Point(18, 134);
            this.GRAVAR2.Name = "GRAVAR2";
            this.GRAVAR2.Size = new System.Drawing.Size(63, 27);
            this.GRAVAR2.TabIndex = 7;
            this.GRAVAR2.Text = "GRAVAR";
            this.GRAVAR2.UseVisualStyleBackColor = true;
            this.GRAVAR2.Click += new System.EventHandler(this.GRAVAR2_Click);
            // 
            // Senhas
            // 
            this.Senhas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Senhas.Location = new System.Drawing.Point(11, 83);
            this.Senhas.Name = "Senhas";
            this.Senhas.Size = new System.Drawing.Size(157, 20);
            this.Senhas.TabIndex = 6;
            // 
            // Logando
            // 
            this.Logando.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Logando.Location = new System.Drawing.Point(11, 38);
            this.Logando.Name = "Logando";
            this.Logando.Size = new System.Drawing.Size(157, 20);
            this.Logando.TabIndex = 5;
            // 
            // SAIR
            // 
            this.SAIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SAIR.Location = new System.Drawing.Point(218, 92);
            this.SAIR.Name = "SAIR";
            this.SAIR.Size = new System.Drawing.Size(178, 51);
            this.SAIR.TabIndex = 3;
            this.SAIR.Text = "SAIR";
            this.SAIR.UseVisualStyleBackColor = true;
            this.SAIR.Click += new System.EventHandler(this.SAIR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "WALKER";
            // 
            // CADASTRO
            // 
            this.CADASTRO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CADASTRO.BackColor = System.Drawing.SystemColors.Control;
            this.CADASTRO.Controls.Add(this.Btn_Lista);
            this.CADASTRO.Controls.Add(this.GRAVAR);
            this.CADASTRO.Controls.Add(this.label3);
            this.CADASTRO.Controls.Add(this.label2);
            this.CADASTRO.Controls.Add(this.Cadastrar_Senha);
            this.CADASTRO.Controls.Add(this.Cadastrar_Login);
            this.CADASTRO.Location = new System.Drawing.Point(37, 149);
            this.CADASTRO.Name = "CADASTRO";
            this.CADASTRO.Size = new System.Drawing.Size(250, 213);
            this.CADASTRO.TabIndex = 4;
            this.CADASTRO.TabStop = false;
            this.CADASTRO.Visible = false;
            this.CADASTRO.Enter += new System.EventHandler(this.CADASTRO_Enter);
            // 
            // Btn_Lista
            // 
            this.Btn_Lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Lista.Location = new System.Drawing.Point(88, 140);
            this.Btn_Lista.Name = "Btn_Lista";
            this.Btn_Lista.Size = new System.Drawing.Size(76, 26);
            this.Btn_Lista.TabIndex = 5;
            this.Btn_Lista.Text = "LISTA";
            this.Btn_Lista.UseVisualStyleBackColor = true;
            this.Btn_Lista.Click += new System.EventHandler(this.Btn_Lista_Click);
            // 
            // GRAVAR
            // 
            this.GRAVAR.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRAVAR.Location = new System.Drawing.Point(15, 140);
            this.GRAVAR.Name = "GRAVAR";
            this.GRAVAR.Size = new System.Drawing.Size(63, 27);
            this.GRAVAR.TabIndex = 4;
            this.GRAVAR.Text = "GRAVAR";
            this.GRAVAR.UseVisualStyleBackColor = true;
            this.GRAVAR.Click += new System.EventHandler(this.GRAVAR_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "CADASTRAR - SENHA: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "CADASTRAR - LOGIN:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Cadastrar_Senha
            // 
            this.Cadastrar_Senha.Location = new System.Drawing.Point(8, 89);
            this.Cadastrar_Senha.Name = "Cadastrar_Senha";
            this.Cadastrar_Senha.Size = new System.Drawing.Size(157, 20);
            this.Cadastrar_Senha.TabIndex = 1;
            this.Cadastrar_Senha.TextChanged += new System.EventHandler(this.Cadastrar_Senha_TextChanged);
            // 
            // Cadastrar_Login
            // 
            this.Cadastrar_Login.Location = new System.Drawing.Point(8, 44);
            this.Cadastrar_Login.Name = "Cadastrar_Login";
            this.Cadastrar_Login.Size = new System.Drawing.Size(157, 20);
            this.Cadastrar_Login.TabIndex = 0;
            // 
            // CADASTRAR
            // 
            this.CADASTRAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CADASTRAR.Location = new System.Drawing.Point(24, 92);
            this.CADASTRAR.Name = "CADASTRAR";
            this.CADASTRAR.Size = new System.Drawing.Size(178, 51);
            this.CADASTRAR.TabIndex = 1;
            this.CADASTRAR.Text = "CADASTRAR";
            this.CADASTRAR.UseVisualStyleBackColor = true;
            this.CADASTRAR.Click += new System.EventHandler(this.CADASTRAR_Click);
            // 
            // LOGAR
            // 
            this.LOGAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGAR.Location = new System.Drawing.Point(413, 92);
            this.LOGAR.Name = "LOGAR";
            this.LOGAR.Size = new System.Drawing.Size(178, 51);
            this.LOGAR.TabIndex = 2;
            this.LOGAR.Text = "LOGAR";
            this.LOGAR.UseVisualStyleBackColor = true;
            this.LOGAR.Click += new System.EventHandler(this.LOGAR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 450);
            this.Controls.Add(this.APRESENTACAO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.APRESENTACAO.ResumeLayout(false);
            this.APRESENTACAO.PerformLayout();
            this.ACESSAR.ResumeLayout(false);
            this.ACESSAR.PerformLayout();
            this.CADASTRO.ResumeLayout(false);
            this.CADASTRO.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox APRESENTACAO;
        private System.Windows.Forms.GroupBox ACESSAR;
        private System.Windows.Forms.GroupBox CADASTRO;
        private System.Windows.Forms.Button SAIR;
        private System.Windows.Forms.Button LOGAR;
        private System.Windows.Forms.Button CADASTRAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Cadastrar_Senha;
        private System.Windows.Forms.TextBox Cadastrar_Login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GRAVAR;
        private System.Windows.Forms.Button GRAVAR2;
        private System.Windows.Forms.TextBox Senhas;
        private System.Windows.Forms.TextBox Logando;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btn_Lista;
    }
}

