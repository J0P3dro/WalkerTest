using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WalkerTest
{
    public partial class Lista : Form1
    {
        public new List<string> Logins { get; set; }
        public new List<string> Senha { get; set; }

        public new string login;'
        public new string senha;
        public Lista(List<string> Login, List<string> Senha)
        {
            InitializeComponent();
        }


        public Lista()
        {
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Form1 formulario2 = Application.OpenForms.OfType<Form1>().FirstOrDefault();

            if (formulario2 == null || formulario2.IsDisposed)
            {
                formulario2 = new Form1(); // Cria uma nova instância apenas se não existe ou foi fechada
            }

            formulario2.Show();
            formulario2.BringToFront(); // Traz o formulário para frente, se estiver minimizado
            this.Close();
        }
        private void Lista_Cad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Lista_Cad.SelectedIndex != -1)
            {
                // Acesse o índice selecionado
                int selectedIndex = Lista_Cad.SelectedIndex;

                // Verifique se o índice está dentro dos limites das listas de logins e senhas
                if (selectedIndex >= 0 && selectedIndex < Logins.Count && selectedIndex < Senha.Count)
                {
                    string loginSelecionado = Logins[selectedIndex];
                    string senhaCorrespondente = Senha[selectedIndex];

                    // Defina o texto nos TextBoxes
                    Inf_Login.Text = loginSelecionado;
                    Inf_Senha.Text = senhaCorrespondente;
                }
            }
        }

        private void Lista_Load(object sender, EventArgs e)
        {
            if (Logins != null)
            {
                foreach (string login in Logins)
                {
                    Lista_Cad.Items.Add(login);
                }
            }
        }



    }
}
