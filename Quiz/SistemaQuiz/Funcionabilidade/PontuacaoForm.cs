/*
 * Created by SharpDevelop.
 * User: jenni
 * Date: 04/10/2025
 * Time: 21:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace SistemaQuiz
{
    public partial class PontuacaoForm : Form
    {
        public PontuacaoForm()
        {
            InitializeComponent();
            CarregarRanking();
        }
        
        private void CarregarRanking()
        {
            // Obter todos os usuários
            List<Usuario> usuarios = UserManager.UsuariosCadastrados;
            
            // Ordenar por pontuação total (decrescente)
            usuarios = usuarios.OrderByDescending(u => u.PontuacaoTotal).ToList();
            
            // Debug: Mostrar quantos usuários temos
            Console.WriteLine("DEBUG: Total de usuários no sistema: {usuarios.Count}");
            foreach (Usuario u in usuarios)
            {
                Console.WriteLine("DEBUG: Usuário: {u.NomeUsuario}, Pontos: {u.PontuacaoTotal}");
            }
            
            // MOSTRAR O TOP 5 DO RANKING
            // Posição 1
            if (usuarios.Count > 0)
            {
                lblNome1.Text = usuarios[0].NomeUsuario;
                lblPontos1.Text = usuarios[0].PontuacaoTotal.ToString() + " pontos";
            }
            else
            {
                lblNome1.Text = "Ainda não cadastrado";
                lblPontos1.Text = "0 pontos";
            }
            
            // Posição 2
            if (usuarios.Count > 1)
            {
                lblNome2.Text = usuarios[1].NomeUsuario;
                lblPontos2.Text = usuarios[1].PontuacaoTotal.ToString() + " pontos";
            }
            else
            {
                lblNome2.Text = "Ainda não cadastrado";
                lblPontos2.Text = "0 pontos";
            }
            
            // Posição 3
            if (usuarios.Count > 2)
            {
                lblNome3.Text = usuarios[2].NomeUsuario;
                lblPontos3.Text = usuarios[2].PontuacaoTotal.ToString() + " pontos";
            }
            else
            {
                lblNome3.Text = "Ainda não cadastrado";
                lblPontos3.Text = "0 pontos";
            }
            
            // Posição 4
            if (usuarios.Count > 3)
            {
                lblNome4.Text = usuarios[3].NomeUsuario;
                lblPontos4.Text = usuarios[3].PontuacaoTotal.ToString() + " pontos";
            }
            else
            {
                lblNome4.Text = "Ainda não cadastrado";
                lblPontos4.Text = "0 pontos";
            }
            
            // Posição 5
            if (usuarios.Count > 4)
            {
                lblNome5.Text = usuarios[4].NomeUsuario;
                lblPontos5.Text = usuarios[4].PontuacaoTotal.ToString() + " pontos";
            }
            else
            {
                lblNome5.Text = "Ainda não cadastrado";
                lblPontos5.Text = "0 pontos";
            }
            
            // MOSTRAR DADOS DO USUÁRIO ATUAL (LOGADO)
            if (UsuarioSessao.EstaLogado)
            {
                Console.WriteLine("DEBUG: Usuário logado: {UsuarioSessao.NomeUsuario}");
                
                Usuario usuarioAtual = UserManager.UsuariosCadastrados
                    .FirstOrDefault(u => u.NomeUsuario == UsuarioSessao.NomeUsuario);
                    
                if (usuarioAtual != null)
                {
                    Console.WriteLine("DEBUG: Usuário atual encontrado: {usuarioAtual.NomeUsuario}");
                    Console.WriteLine("DEBUG: Pontuação total: {usuarioAtual.PontuacaoTotal}");
                    
                    // MOSTRAR NOME E PONTUAÇÃO DO USUÁRIO ATUAL
                    lblSeuNome.Text = usuarioAtual.NomeUsuario;
                    lblSeusPontos.Text = usuarioAtual.PontuacaoTotal.ToString() + " pontos"; // CORRIGIDO: lblSuaPontuacao
                    
                    // Encontrar posição no ranking
                    int posicao = usuarios.FindIndex(u => u.NomeUsuario == usuarioAtual.NomeUsuario) + 1;
                    lblSuaPosicao.Text = posicao.ToString() + "° lugar";
                }
                else
                {
                    Console.WriteLine("DEBUG: ERRO - Usuário atual NÃO encontrado!");
                    lblSeuNome.Text = "Visitante";
                    lblSeusPontos.Text = "0 pontos";
                    lblSuaPosicao.Text = "---";
                }
            }
            else
            {
                // Usuário não logado
                lblSeuNome.Text = "Visitante";
                lblSeusPontos.Text = "0 pontos";
                lblSuaPosicao.Text = "---";
            }
        }
        
        
        void LblAssinaturasClick(object sender, EventArgs e)
        {
            AssinaturasForm assinaturasForm = new AssinaturasForm();
            assinaturasForm.Show();
            this.Hide();
        }
        
        void LblCursosUSPClick(object sender, EventArgs e)
        {
            CursosUSPForm cursosuspForm = new CursosUSPForm();
            cursosuspForm.Show();
            this.Hide();
        }
        
        void LblInfoUnespClick(object sender, EventArgs e)
        {
            InformacoesUnespForm informacoesunespForm = new InformacoesUnespForm();
            informacoesunespForm.Show();
            this.Hide();
        }
        
        void LblCursosUnespClick(object sender, EventArgs e)
        {
            CursosUnespForm cursosunespForm = new CursosUnespForm();
            cursosunespForm.Show();
            this.Hide();
        }
        
        void LblInfoUnicampClick(object sender, EventArgs e)
        {
            InformacoesUnicampForm informacoesunicampForm = new InformacoesUnicampForm();
            informacoesunicampForm.Show();
            this.Hide();
        }
        
        void LblCursosUnicampClick(object sender, EventArgs e)
        {
            CursosUnicampForm cursosunicampForm = new CursosUnicampForm();
            cursosunicampForm.Show();
            this.Hide();
        }
        
        void LblInfoFatecClick(object sender, EventArgs e)
        {
            InformacoesFatecForm informacoesfatecForm = new InformacoesFatecForm();
            informacoesfatecForm.Show();
            this.Hide();
        }
        
        void LblCursosFatecClick(object sender, EventArgs e)
        {
            CursosFatecForm cursosfatecForm = new CursosFatecForm();
            cursosfatecForm.Show();
            this.Hide();
        }
        
        void LblMateriasClick(object sender, EventArgs e)
        {
            MateriasPVForm materiaspvForm = new MateriasPVForm();
            materiaspvForm.Show();
            this.Hide();
        }
        
        void LblInicioClick(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Hide();
        }
        
        void Label23Click(object sender, EventArgs e)
        {
            VestibularesForm vestibularesForm = new VestibularesForm();
            vestibularesForm.Show();
            this.Hide();
        }
        
        void LblHomeClick(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Hide();        
        }

        void LblInfoUSPClick(object sender, EventArgs e)
        {
            InformacoesUSPForm informacoesuspForm = new InformacoesUSPForm();
            informacoesuspForm.Show();
            this.Hide();
        }
    }
}