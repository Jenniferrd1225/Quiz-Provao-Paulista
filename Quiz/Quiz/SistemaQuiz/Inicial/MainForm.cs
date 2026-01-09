/*
 * Created by SharpDevelop.
 * User: jenni
 * Date: 12/10/2025
 * Time: 19:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaQuiz
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            
            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }
		void Timer1Tick(object sender, EventArgs e)
		{
		    timer1.Stop();
		    LoginForm loginForm = new LoginForm();
		    loginForm.Show();
		    this.Hide();
		}
    }
}