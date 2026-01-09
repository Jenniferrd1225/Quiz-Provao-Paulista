/*
 * Created by SharpDevelop.
 * User: jenni
 * Date: 28/09/2025
 * Time: 20:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace SistemaQuiz
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        
        void LblCadastreseClick(object sender, EventArgs e)
        {
            CadastroForm cadastroForm = new CadastroForm();
            cadastroForm.Show(); 
            this.Hide();
        }
        
        void LblEsqueceuSenhaClick(object sender, EventArgs e)
        {
            EsquecerSenhaForm esquecersenhaForm = new EsquecerSenhaForm();
            esquecersenhaForm.Show(); 
            this.Hide();
        }
        
        void BtnLoginClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Por favor, preencha o nome de usuário.", "Campo Obrigatório", 
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Por favor, preencha a senha.", "Campo Obrigatório", 
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSenha.Focus();
                return;
            }

            // CORREÇÃO: Mudado de SistemQuiz para SistemaQuiz
            if (SistemaQuiz.UserManager.VerificarLogin(txtUsuario.Text, txtSenha.Text))
            {
                // CORREÇÃO: Mudado de SistemQuiz para SistemaQuiz
                SistemaQuiz.UsuarioSessao.Login(txtUsuario.Text);
                
                string mensagem = "Login realizado com sucesso!\nBem-vindo, " + txtUsuario.Text + "!";
                MessageBox.Show(mensagem, "Bem-vindo", 
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                HomeForm homeForm = new HomeForm();
                homeForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!\n\nCertifique-se de que:\n1. Você já realizou o cadastro\n2. Está usando o usuário e senha corretos.", 
                              "Login Falhou", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}