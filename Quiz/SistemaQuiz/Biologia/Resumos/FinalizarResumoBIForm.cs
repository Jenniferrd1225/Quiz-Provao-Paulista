/*
 * Created by SharpDevelop.
 * User: jenni
 * Date: 29/10/2025
 * Time: 15:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaQuiz
{
	/// <summary>
	/// Description of FinalizarResumoBIForm.
	/// </summary>
	public partial class FinalizarResumoBIForm : Form
	{
		int pontosTotais;
		public FinalizarResumoBIForm(int pontos)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			pontosTotais = pontos;
			lblPontos.Text = pontos.ToString();
			
			        if (UsuarioSessao.EstaLogado)
        {
            UserManager.AtualizarPontuacaoUsuario(UsuarioSessao.NomeUsuario, "BI", pontosTotais);
        }
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
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
        
        void LblPontuacaoClick(object sender, EventArgs e)
            
        {

            PontuacaoForm pontuacaoForm = new PontuacaoForm();
            pontuacaoForm.Show();
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
		void BtnQuizzesClick(object sender, EventArgs e)
		{
            QuizzesBIForm QuizzesBIForm = new QuizzesBIForm();
            QuizzesBIForm.Show();
            this.Hide();
		}
		void BtnResumosClick(object sender, EventArgs e)
		{
            ResumosBIForm ResumosBIForm = new ResumosBIForm();
            ResumosBIForm.Show();
            this.Hide();
		}
    }
}


