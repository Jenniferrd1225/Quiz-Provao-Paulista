/*
 * Created by SharpDevelop.
 * User: jenni
 * Date: 01/10/2025
 * Time: 21:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaQuiz
{
	/// <summary>
	/// Description of AssinaturasForm.
	/// </summary>
	public partial class AssinaturasForm : Form
	{
		public AssinaturasForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
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

		void BtnAcessarClick(object sender, EventArgs e)
		{
    string mensagem ="Você está usando o Plano Gratuito.\r\n\r\n" +
                     "Com ele, você pode aproveitar os recursos essenciais do sistema.\r\n\r\n" +
                     "Este plano inclui:\r\n" +
                     "• Acesso a quizzes públicos;\r\n" +
                     "• Visualização básica de resultados;\r\n" +
                     "• Participação em desafios semanais;\r\n\r\n" +
                     "Quer liberar todo o potencial do sistema?\r\n" +
                     "Atualize para o Plano Premium e tenha acesso ilimitado a todas as ferramentas!";

    MessageBox.Show(mensagem, "Comparação de Planos", MessageBoxButtons.OK, MessageBoxIcon.Information);

		}
		void Button1Click(object sender, EventArgs e)
{
    string mensagem = "Parabéns! Agora você tem acesso completo a todas as funcionalidades do sistema.\r\n\r\n" +
                     "Este plano inclui:\r\n" +
                     "• Acesso ilimitado a todos os quizzes;\r\n" +
                     "• Relatórios detalhados de desempenho;\r\n" +
                     "• Criação e personalização de quizzes exclusivos;\r\n" +
                     "• Suporte prioritário;\r\n" +
                     "• Recursos exclusivos e atualizações antecipadas.\r\n\r\n" +
                     "Aproveite ao máximo sua experiência premium!";

    MessageBox.Show(mensagem, "Plano Premium", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
