/*
 * Created by SharpDevelop.
 * User: jenni
 * Date: 28/09/2025
 * Time: 21:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaQuiz
{
	/// <summary>
	/// Description of MateriasPVForm.
	/// </summary>
	public partial class MateriasPVForm : Form
	{
		public MateriasPVForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnQuizPortClick(object sender, EventArgs e)
		{
			QuizzesPTForm QuizzesPTForm = new QuizzesPTForm();
			QuizzesPTForm.Show();
			this.Hide();
		}
				void BtnResumoPortClick(object sender, EventArgs e)
		{
			ResumosPTForm ResumosPTForm = new ResumosPTForm();
			ResumosPTForm.Show();
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
		void BtnResumoMatClick(object sender, EventArgs e)
		{
	        ResumosMTForm ResumosMTForm = new ResumosMTForm();
            ResumosMTForm.Show();
            this.Hide();
		}
		void BtnQuizMatClick(object sender, EventArgs e)
		{
	        QuizzesMTForm QuizzesMTForm = new QuizzesMTForm();
            QuizzesMTForm.Show();
            this.Hide();
		}
		void BtnResumoHistClick(object sender, EventArgs e)
		{
	        ResumosHIForm ResumosHIForm = new ResumosHIForm();
            ResumosHIForm.Show();
            this.Hide();
		}
		void BtnQuizHistClick(object sender, EventArgs e)
		{
	        QuizzesHIForm QuizzesHIForm = new QuizzesHIForm();
            QuizzesHIForm .Show();
            this.Hide();
		}
		void BtnResumoGeoClick(object sender, EventArgs e)
		{
	        ResumosGEForm ResumosGEForm = new ResumosGEForm();
            ResumosGEForm .Show();
            this.Hide();
		}
		void BtnQuizGeoClick(object sender, EventArgs e)
		{
	        QuizzesGEForm QuizzesGEForm = new QuizzesGEForm();
            QuizzesGEForm .Show();
            this.Hide();
		}
		void BtnResumoBioClick(object sender, EventArgs e)
		{
	        ResumosBIForm ResumosBIForm = new ResumosBIForm();
            ResumosBIForm .Show();
            this.Hide();
		}
		void BtnQuizBioClick(object sender, EventArgs e)
		{
	        QuizzesBIForm QuizzesBIForm = new QuizzesBIForm();
            QuizzesBIForm .Show();
            this.Hide();
		}
		void BtnResumoQuiClick(object sender, EventArgs e)
		{
	        ResumosQUForm ResumosQUForm = new ResumosQUForm();
            ResumosQUForm .Show();
            this.Hide();
		}
		void BtnQuizQuiClick(object sender, EventArgs e)
		{
	        QuizzesQUForm QuizzesQUForm = new QuizzesQUForm();
            QuizzesQUForm .Show();
            this.Hide();
		}
		void BtnResumoFiClick(object sender, EventArgs e)
		{
	        ResumosFIForm ResumosFIForm = new ResumosFIForm();
            ResumosFIForm .Show();
            this.Hide();
		}
		void BtnQuizFiClick(object sender, EventArgs e)
		{
	        QuizzesFIForm QuizzesFIForm = new QuizzesFIForm();
            QuizzesFIForm .Show();
            this.Hide();
		}
		void BtnQuizIngClick(object sender, EventArgs e)
		{
	        QuizzesINForm QuizzesINForm = new QuizzesINForm();
            QuizzesINForm .Show();
            this.Hide();
		}
		void BtnResumoIngClick(object sender, EventArgs e)
		{
	        MessageBox.Show("Página ainda em planejamento.\nSerá lançada em breve!");
		}
    }
}

