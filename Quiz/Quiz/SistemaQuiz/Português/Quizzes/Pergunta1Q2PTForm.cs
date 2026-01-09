/*
 * Created by SharpDevelop.
 * User: jenni
 * Date: 19/10/2025
 * Time: 22:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaQuiz
{
	/// <summary>
	/// Description of Pergunta1Q2PTForm.
	/// </summary>
	public partial class Pergunta1Q2PTForm : Form
	{
		public Pergunta1Q2PTForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public int pontosPT = 0;
		
		private bool respostaSelecionada = false;
			
		void BtnBClick(object sender, EventArgs e)
		{
		    MessageBox.Show("Parabéns! Você acertou a resposta.\n\n+1 ponto.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
		    respostaSelecionada = true;
		    
		    pontosPT++;
		    
		    Pergunta2Q2PTForm Pergunta2Q2PTForm = new Pergunta2Q2PTForm(pontosPT);
			Pergunta2Q2PTForm.Show();
			this.Hide();
		}
		void BtnAClick(object sender, EventArgs e)
		{
		    MessageBox.Show("Não foi dessa vez, mais sorte na próxima!\n\n+0 pontos.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		    respostaSelecionada = true;
		    
		    Pergunta2Q2PTForm Pergunta2Q2PTForm = new Pergunta2Q2PTForm(pontosPT);
			Pergunta2Q2PTForm.Show();
			this.Hide();

		}
		
		void BtnCClick(object sender, EventArgs e)
		{
		    MessageBox.Show("Não foi dessa vez, mais sorte na próxima!\n\n+0 pontos.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		    respostaSelecionada = true;
		    
		    Pergunta2Q2PTForm Pergunta2Q2PTForm = new Pergunta2Q2PTForm(pontosPT);
			Pergunta2Q2PTForm.Show();
			this.Hide();

		}
		
		void BtnDClick(object sender, EventArgs e)
		{
		    MessageBox.Show("Não foi dessa vez, mais sorte na próxima!\n\n+0 pontos.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		    respostaSelecionada = true;

		    Pergunta2Q2PTForm Pergunta2Q2PTForm = new Pergunta2Q2PTForm(pontosPT);
			Pergunta2Q2PTForm.Show();
			this.Hide();
		    
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
    }
}
