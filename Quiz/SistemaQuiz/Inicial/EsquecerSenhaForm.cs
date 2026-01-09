/*
 * Created by SharpDevelop.
 * User: Aluno
 * Date: 13/10/2025
 * Time: 14:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaQuiz
{
	/// <summary>
	/// Description of EsquecerSenhaForm.
	/// </summary>
	public partial class EsquecerSenhaForm : Form
	{
		public EsquecerSenhaForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void LblLoginClick(object sender, EventArgs e)
		{
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();			
		}
		
		void BtnConfirmarClick(object sender, EventArgs e)
		{
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();			
		}
	}
}
