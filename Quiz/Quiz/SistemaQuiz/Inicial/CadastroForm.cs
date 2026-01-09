/*
 * Created by SharpDevelop.
 * User: jenni
 * Date: 28/09/2025
 * Time: 20:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using System.Net.Mail;

namespace SistemaQuiz
{
    public partial class CadastroForm : Form
    {
        public CadastroForm()
        {
            InitializeComponent();
        }
        
        void LblLoginClick(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
        
        void BtnCadastrarClick(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string senha = txtSenha.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (usuario == "" || senha == "" || email == "")
            {
                MessageBox.Show("Preencha todos os campos.", "Campos Obrigatórios", 
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (senha.Length < 6)
            {
                MessageBox.Show("A senha deve ter pelo menos 6 caracteres.", "Senha Inválida", 
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSenha.Focus();
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Por favor, insira um email válido.", "Email Inválido", 
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            // CORREÇÃO: Mudado de SistemQuiz para SistemaQuiz
            bool usuarioExiste = SistemaQuiz.UserManager.UsuarioExiste(usuario);

            if (usuarioExiste)
            {
                MessageBox.Show("Usuário já cadastrado.", "Erro no Cadastro", 
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // CORREÇÃO: Mudado de SistemQuiz para SistemaQuiz
                SistemaQuiz.Usuario novoUsuario = new SistemaQuiz.Usuario(usuario, usuario, senha, email);
                SistemaQuiz.UserManager.AdicionarUsuario(novoUsuario);

                MessageBox.Show("Cadastro realizado com sucesso!\n\nSeu usuário para login é: " + txtUsuario.Text, 
                              "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtSenha.Clear();
                txtUsuario.Clear();
                txtEmail.Clear();

                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
