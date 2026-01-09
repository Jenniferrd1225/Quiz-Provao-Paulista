/*
 * Created by SharpDevelop.
 * User: jenni
 * Date: 12/10/2025
 * Time: 19:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SistemaQuiz
{
	partial class LoginForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblCadastrese;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtSenha;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblEsqueceuSenha;
		private System.Windows.Forms.Button btnLogin;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblCadastrese = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblEsqueceuSenha = new System.Windows.Forms.Label();
			this.btnLogin = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(444, 0);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(534, 565);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Controls.Add(this.lblCadastrese);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.txtSenha);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.txtUsuario);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.lblEsqueceuSenha);
			this.panel1.Controls.Add(this.btnLogin);
			this.panel1.ForeColor = System.Drawing.Color.Transparent;
			this.panel1.Location = new System.Drawing.Point(2, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(452, 565);
			this.panel1.TabIndex = 4;
			// 
			// lblCadastrese
			// 
			this.lblCadastrese.ForeColor = System.Drawing.Color.Black;
			this.lblCadastrese.Location = new System.Drawing.Point(273, 95);
			this.lblCadastrese.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCadastrese.Name = "lblCadastrese";
			this.lblCadastrese.Size = new System.Drawing.Size(101, 35);
			this.lblCadastrese.TabIndex = 9;
			this.lblCadastrese.Text = "Cadastre-se";
			this.lblCadastrese.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lblCadastrese.Click += new System.EventHandler(this.LblCadastreseClick);
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(58, 334);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(156, 35);
			this.label5.TabIndex = 7;
			this.label5.Text = "Me manter logado";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtSenha
			// 
			this.txtSenha.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSenha.Location = new System.Drawing.Point(40, 282);
			this.txtSenha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.PasswordChar = '*';
			this.txtSenha.Size = new System.Drawing.Size(333, 26);
			this.txtSenha.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(40, 257);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(216, 28);
			this.label4.TabIndex = 5;
			this.label4.Text = "Senha";
			// 
			// txtUsuario
			// 
			this.txtUsuario.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsuario.Location = new System.Drawing.Point(40, 195);
			this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(333, 26);
			this.txtUsuario.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(78, 95);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(296, 35);
			this.label2.TabIndex = 1;
			this.label2.Text = "Ainda não tem uma conta? ";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.DarkRed;
			this.label1.Location = new System.Drawing.Point(4, 60);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(442, 35);
			this.label1.TabIndex = 0;
			this.label1.Text = "Bem-vindo de volta!";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(40, 171);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(216, 35);
			this.label3.TabIndex = 3;
			this.label3.Text = "Nome de usuário";
			// 
			// lblEsqueceuSenha
			// 
			this.lblEsqueceuSenha.ForeColor = System.Drawing.Color.Black;
			this.lblEsqueceuSenha.Location = new System.Drawing.Point(207, 334);
			this.lblEsqueceuSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblEsqueceuSenha.Name = "lblEsqueceuSenha";
			this.lblEsqueceuSenha.Size = new System.Drawing.Size(166, 35);
			this.lblEsqueceuSenha.TabIndex = 8;
			this.lblEsqueceuSenha.Text = "Esqueceu a senha?";
			this.lblEsqueceuSenha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lblEsqueceuSenha.Click += new System.EventHandler(this.LblEsqueceuSenhaClick);
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.Color.DarkRed;
			this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.ForeColor = System.Drawing.Color.White;
			this.btnLogin.Location = new System.Drawing.Point(134, 411);
			this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(170, 60);
			this.btnLogin.TabIndex = 7;
			this.btnLogin.Text = "LOGIN";
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new System.EventHandler(this.BtnLoginClick);
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(40, 340);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(24, 25);
			this.checkBox1.TabIndex = 10;
			this.checkBox1.Text = "checkBox1";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(978, 565);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel1);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LoginForm";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.CheckBox checkBox1;
	}
}
