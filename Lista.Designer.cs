namespace WalkerTest
{
    partial class Lista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lista_Cad = new System.Windows.Forms.ComboBox();
            this.Inf_Login = new System.Windows.Forms.TextBox();
            this.Inf_Senha = new System.Windows.Forms.TextBox();
            this.Sair = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lista_Cad
            // 
            this.Lista_Cad.FormattingEnabled = true;
            this.Lista_Cad.Location = new System.Drawing.Point(6, 4);
            this.Lista_Cad.Name = "Lista_Cad";
            this.Lista_Cad.Size = new System.Drawing.Size(114, 21);
            this.Lista_Cad.TabIndex = 0;
            this.Lista_Cad.SelectedIndexChanged += new System.EventHandler(this.Lista_Cad_SelectedIndexChanged);
            // 
            // Inf_Login
            // 
            this.Inf_Login.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Inf_Login.Location = new System.Drawing.Point(6, 53);
            this.Inf_Login.Name = "Inf_Login";
            this.Inf_Login.ReadOnly = true;
            this.Inf_Login.Size = new System.Drawing.Size(113, 20);
            this.Inf_Login.TabIndex = 1;
            // 
            // Inf_Senha
            // 
            this.Inf_Senha.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Inf_Senha.Location = new System.Drawing.Point(7, 93);
            this.Inf_Senha.Name = "Inf_Senha";
            this.Inf_Senha.ReadOnly = true;
            this.Inf_Senha.Size = new System.Drawing.Size(113, 20);
            this.Inf_Senha.TabIndex = 2;
            // 
            // Sair
            // 
            this.Sair.Location = new System.Drawing.Point(127, 134);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(89, 25);
            this.Sair.TabIndex = 3;
            this.Sair.Text = "Sair";
            this.Sair.UseVisualStyleBackColor = true;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.Sair);
            this.groupBox1.Controls.Add(this.Inf_Senha);
            this.groupBox1.Controls.Add(this.Inf_Login);
            this.groupBox1.Controls.Add(this.Lista_Cad);
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 178);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 184);
            this.Controls.Add(this.groupBox1);
            this.Name = "Lista";
            this.Text = "Lista";
            this.Load += new System.EventHandler(this.Lista_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Lista_Cad;
        private System.Windows.Forms.TextBox Inf_Login;
        private System.Windows.Forms.TextBox Inf_Senha;
        private System.Windows.Forms.Button Sair;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}