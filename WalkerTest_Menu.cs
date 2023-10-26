using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WalkerTest
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Sua_Escolha_TextChanged(object sender, EventArgs e)
        {
            Sua_Escolha.ReadOnly = true;
            Sua_Escolha.Enabled = false;
        }

        private void Walker_Escolha_TextChanged(object sender, EventArgs e)
        {
            // Tornar a TextBox2 não editável
            Walker_Escolha.ReadOnly = true;
            Walker_Escolha.Enabled = false;
        }

        private void JOKENPO_Click(object sender, EventArgs e)
        {
            JOGAR_JKP.Visible = true;
            JOGAR_IP.Visible = false;
            JOGAR_ADIVINHA.Visible = false;
        }

        private void ÍMPAR_PAR_Click(object sender, EventArgs e)
        {
            JOGAR_JKP.Visible = false;
            JOGAR_IP.Visible = true;
            JOGAR_ADIVINHA.Visible = false;
        }

        private void ADIVINHAR_Click(object sender, EventArgs e)
        {
            JOGAR_JKP.Visible = false;
            JOGAR_IP.Visible = false;
            JOGAR_ADIVINHA.Visible = true;
        }

        private void Pedra_Click(object sender, EventArgs e)
        {
            string escolhaUsuario = "Pedra";
            Sua_Escolha.Text = escolhaUsuario;

            string[] opcoes = { "Pedra", "Papel", "Tesoura" };
            Random random = new Random();
            int indice = random.Next(opcoes.Length);
            string resultado = opcoes[indice];
            Walker_Escolha.Text = opcoes[indice];

            if (escolhaUsuario == resultado)
            {
                Vitoria.Text = "Empate!";
            }
            else if ((escolhaUsuario == "Pedra" && resultado == "Tesoura") ||
                     (escolhaUsuario == "Papel" && resultado == "Pedra") ||
                     (escolhaUsuario == "Tesoura" && resultado == "Papel"))
            {
                Vitoria.Text = "Você venceu!";
            }
            else
            {
                Vitoria.Text = "Você perdeu!";
            }
        }




        private void Papel_Click(object sender, EventArgs e)
        {
            string escolhaUsuario = "Papel";
            Sua_Escolha.Text = escolhaUsuario;

            string[] opcoes = { "Pedra", "Papel", "Tesoura" };
            Random random = new Random();
            int indice = random.Next(opcoes.Length);
            string resultado = opcoes[indice];
            Walker_Escolha.Text = opcoes[indice];

            if (escolhaUsuario == resultado)
            {
                Vitoria.Text = "Empate!";
            }
            else if ((escolhaUsuario == "Pedra" && resultado == "Tesoura") ||
                     (escolhaUsuario == "Papel" && resultado == "Pedra") ||
                     (escolhaUsuario == "Tesoura" && resultado == "Papel"))
            {
                Vitoria.Text = "Você venceu!";
            }
            else
            {
                Vitoria.Text = "Você perdeu!";
            }
        }

        private void Tesoura_Click(object sender, EventArgs e)
        {
            string escolhaUsuario = "Tesoura";
            Sua_Escolha.Text = escolhaUsuario;

            string[] opcoes = { "Pedra", "Papel", "Tesoura" };
            Random random = new Random();
            int indice = random.Next(opcoes.Length);
            string resultado = opcoes[indice];
            Walker_Escolha.Text = opcoes[indice];

            if (escolhaUsuario == resultado)
            {
                Vitoria.Text = "Empate!";
            }
            else if ((escolhaUsuario == "Pedra" && resultado == "Tesoura") ||
                     (escolhaUsuario == "Papel" && resultado == "Pedra") ||
                     (escolhaUsuario == "Tesoura" && resultado == "Papel"))
            {
                Vitoria.Text = "Você venceu!";
            }
            else
            {
                Vitoria.Text = "Você perdeu!";
            }
        }

        private void Vitoria_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Sair1_Click(object sender, EventArgs e)
        {
            JOGAR_JKP.Visible = false;
            JOGAR_IP.Visible = false;
            JOGAR_ADIVINHA.Visible = false;
            Sua_Escolha.Text = "";
            Walker_Escolha.Text = "";
            Vitoria.Text = "";
        }

        private void DN1_Click(object sender, EventArgs e)
        {
            Sua_Escolha.Text = "";
            Walker_Escolha.Text = "";
            Vitoria.Text = "";
        }

        private void Par_Click(object sender, EventArgs e)
        {
            // Quando o botão "Par" é clicado, permitir apenas números pares no Escolha_IP.
            Escolha_IP.KeyPress += ApenasNumerosPares_KeyPress;

            // Remova o evento KeyPress do txtImpar (caso tenha sido definido anteriormente).
            Escolha_IP.KeyPress -= ApenasNumerosImpares_KeyPress;
        }

        private void Impar_Click(object sender, EventArgs e)
        {
            // Quando o botão "Ímpar" é clicado, permitir apenas números ímpares no Escolha_IP.
            Escolha_IP.KeyPress += ApenasNumerosImpares_KeyPress;

            // Remova o evento KeyPress do txtPar (caso tenha sido definido anteriormente).
            Escolha_IP.KeyPress -= ApenasNumerosPares_KeyPress;
        }

        private void ApenasNumerosPares_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifique se a tecla pressionada é um dígito.
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloqueie a entrada da tecla não numérica.
            }
            else
            {
                // Verifique se o dígito é par (o último bit é 0).
                int numero = int.Parse(Escolha_IP.Text + e.KeyChar);
                if (numero % 2 != 0)
                {
                    e.Handled = true; // Bloqueie a entrada de números ímpares.
                }
            }
        }

        private void ApenasNumerosImpares_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifique se a tecla pressionada é um dígito.
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloqueie a entrada da tecla não numérica.
            }
            else
            {
                // Verifique se o dígito é ímpar (o último bit é 1).
                int numero = int.Parse(Escolha_IP.Text + e.KeyChar);
                if (numero % 2 == 0)
                {
                    e.Handled = true; // Bloqueie a entrada de números pares.
                }
            }
        }




        private void DN2_Click(object sender, EventArgs e)
        {
            Escolha_IP.Text = "";
            W_Escolha_IP.Text = "";
            Vitoria_IP.Text = "";

        }

        private void Sair_IP_Click(object sender, EventArgs e)
        {
            JOGAR_JKP.Visible = false;
            JOGAR_IP.Visible = false;
            JOGAR_ADIVINHA.Visible = false;
            Escolha_IP.Text = "";
            W_Escolha_IP.Text = "";
            Vitoria_IP.Text = "";
        }

        private void Sair_Tudo_Click(object sender, EventArgs e)
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

        private void Escolha_IP_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(Escolha_IP.Text, out int numeroEscolhido))
            {
                if (numeroEscolhido % 2 == 0)
                {
                    
                    int[] numerosImparesPermitidos = { 1, 3, 5, 7, 9 };
                    int numeroAleatorio = numerosImparesPermitidos[new Random().Next(numerosImparesPermitidos.Length)];
                    W_Escolha_IP.Text = numeroAleatorio.ToString();

                }
                else
                {
                    
                    int[] numerosParesPermitidos = { 0, 2, 4, 6, 8 };
                    int numeroAleatorio = numerosParesPermitidos[new Random().Next(numerosParesPermitidos.Length)];
                    W_Escolha_IP.Text = numeroAleatorio.ToString();

                }
            }
            else
            {
                // O conteúdo de Escolha_IP não é um número válido; limpe o conteúdo de W_Escolha_IP.
                W_Escolha_IP.Text = "";
            }
        }

        private void Resultado_Click(object sender, EventArgs e)
        {
            // Recupere os valores dos TextBox W_Escolha_IP e Escolha_IP
            if (int.TryParse(W_Escolha_IP.Text, out int valorW) && int.TryParse(Escolha_IP.Text, out int valorEscolha))
            {
                // Realize a soma dos valores
                int resultado = valorW + valorEscolha;

                // Verifique as condições
                if ((valorEscolha % 2 == 0 && resultado % 2 == 0) || (valorEscolha % 2 != 0 && resultado % 2 != 0))
                {
                    Vitoria_IP.Text = "Você venceu! Soma: " + resultado.ToString();
                }
                else
                {
                    Vitoria_IP.Text = "Você perdeu! Soma: " + resultado.ToString();
                }
            }
            else
            {
                // Lide com um cenário em que a conversão falha (por exemplo, entradas inválidas).
                Vitoria_IP.Text = "Erro";
            }
        }

        private void Sair_Adv_Click(object sender, EventArgs e)
        {
            JOGAR_JKP.Visible = false;
            JOGAR_IP.Visible = false;
            JOGAR_ADIVINHA.Visible = false;
            Adiv_Resultado.Text = "";
            Adivinha.Text = "";
        }

        private void DN3_Click(object sender, EventArgs e)
        {
            Adiv_Resultado.Text = "";
            Adivinha.Text = "";
        }
        private int numeroAleatorio; // Declare a variável para o número aleatório

        private void InicializarJogo()
        {
            numeroAleatorio = new Random().Next(11); // Gere o número aleatório no início do jogo
            Adiv_Resultado.Text = ""; // Limpe o campo de resultado
        }


        private async void Botao_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Adivinha.Text, out int numeroInserido))
            {
                int diferenca = Math.Abs(numeroInserido - numeroAleatorio);

                if (diferenca == 0)
                {
                    Adiv_Resultado.Text = "Você acertou!";
                    await Task.Delay(10000); // Aguarda por 10 segundos de forma assíncrona
                    InicializarJogo();
                }
                else if (diferenca <= 1)
                {
                    Adiv_Resultado.Text = "Você está próximo!";
                }
                else
                {
                    Adiv_Resultado.Text = "Você está longe!";
                }
            }
            else
            {
                Adiv_Resultado.Text = "Insira um número válido!";
            }
        }

    }
}
