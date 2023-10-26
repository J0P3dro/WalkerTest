using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WalkerTest
{
    public partial class Form1 : Form
    {

        public List<string> Logins { get; set; }
        public List<string> Senha { get; set; }

        public string login;
        public string senha;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CADASTRAR_Click(object sender, EventArgs e)
        {
            CADASTRO.Visible = true;
            ACESSAR.Visible = false;
        }

        private void LOGAR_Click(object sender, EventArgs e)
        {
            CADASTRO.Visible = false;
            ACESSAR.Visible = true;
        }

        private void GRAVAR_Click(object sender, EventArgs e)
        {
            login = Cadastrar_Login.Text;
            senha = Cadastrar_Senha.Text;
            if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(senha))
            {
                
                MessageBox.Show($"Login: {login}\nSenha: {senha}", "Informações");
            }
            else
            {
                MessageBox.Show("As informações não foram preenchidas.", "Aviso");
            }

            DialogResult resultado = MessageBox.Show("Cadastro feito! Podemos continuar?", "Atenção!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                CADASTRO.Visible = false;
                ACESSAR.Visible = true;
            }
            else if (resultado == DialogResult.No)
            {
                CADASTRO.Visible = true;
                ACESSAR.Visible = false;
            }
           
        }

        private void GRAVAR2_Click(object sender, EventArgs e)
        {
            string loginAcesso = Logando.Text;
            string senhaAcesso = Senhas.Text;

            // Verifique se as informações de login coincidem com o cadastro
            if (loginAcesso == login && senhaAcesso == senha)
            {
                MessageBox.Show("Login efetuado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Se as informações de login estiverem corretas, você pode abrir o formulário desejado
                Menu formularioSecundario = new Menu();
                formularioSecundario.Show();
            }
            else
            {
                MessageBox.Show("As informações de login não coincidem com o cadastro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }



        private void SAIR_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja sair do sistema?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (resultado == DialogResult.No)
            {
             
            }
            
        }

        private void CADASTRO_Enter(object sender, EventArgs e)
        {
            
        }

        private void ACESSAR_Enter(object sender, EventArgs e)
        {

        }

        private void Btn_Lista_Click(object sender, EventArgs e)
        {
            // Crie uma instância do Form Lista e passe as listas de logins e senhas
            Lista formularioLista = new Lista(Logins, Senha);

            // Mostre o formulário Lista
            formularioLista.Show();
        }


        private void Cadastrar_Senha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
