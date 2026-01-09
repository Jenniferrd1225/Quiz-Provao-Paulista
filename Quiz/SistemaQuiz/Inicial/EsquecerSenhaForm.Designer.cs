/*
 * Created by SharpDevelop.
 * User: Aluno
 * Date: 13/10/2025
 * Time: 14:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SistemaQuiz
{
	partial class EsquecerSenhaForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EsquecerSenhaForm));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
			this.labelEmail = new System.Windows.Forms.Label();
			this.btnConfirmar = new System.Windows.Forms.Button();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtRecuperacao = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblLogin = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(443, 0);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(534, 565);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.txtConfirmarSenha);
			this.panel1.Controls.Add(this.labelEmail);
			this.panel1.Controls.Add(this.btnConfirmar);
			this.panel1.Controls.Add(this.txtSenha);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.txtRecuperacao);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.lblLogin);
			this.panel1.ForeColor = System.Drawing.Color.Transparent;
			this.panel1.Location = new System.Drawing.Point(1, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(452, 565);
			this.panel1.TabIndex = 8;
			// 
			// txtConfirmarSenha
			// 
			this.txtConfirmarSenha.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.txtConfirmarSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtConfirmarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtConfirmarSenha.Location = new System.Drawing.Point(40, 349);
			this.txtConfirmarSenha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtConfirmarSenha.Name = "txtConfirmarSenha";
			this.txtConfirmarSenha.PasswordChar = '*';
			this.txtConfirmarSenha.Size = new System.Drawing.Size(333, 26);
			this.txtConfirmarSenha.TabIndex = 7;
			// 
			// labelEmail
			// 
			this.labelEmail.ForeColor = System.Drawing.Color.Black;
			this.labelEmail.Location = new System.Drawing.Point(40, 162);
			this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelEmail.Name = "labelEmail";
			this.labelEmail.Size = new System.Drawing.Size(216, 28);
			this.labelEmail.TabIndex = 8;
			this.labelEmail.Text = "Email de recuperação";

			// 
			// btnConfirmar
			// 
			this.btnConfirmar.BackColor = System.Drawing.Color.DarkRed;
			this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConfirmar.ForeColor = System.Drawing.Color.White;
			this.btnConfirmar.Location = new System.Drawing.Point(126, 411);
			this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnConfirmar.Name = "btnConfirmar";
			this.btnConfirmar.Size = new System.Drawing.Size(170, 60);
			this.btnConfirmar.TabIndex = 6;
			this.btnConfirmar.Text = "CONFIRMAR";
			this.btnConfirmar.UseVisualStyleBackColor = false;
			this.btnConfirmar.Click += new System.EventHandler(this.BtnConfirmarClick);
			// 
			// txtSenha
			// 
			this.txtSenha.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSenha.Location = new System.Drawing.Point(40, 269);
			this.txtSenha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.PasswordChar = '*';
			this.txtSenha.Size = new System.Drawing.Size(333, 26);
			this.txtSenha.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(40, 245);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(216, 28);
			this.label4.TabIndex = 5;
			this.label4.Text = "Senha";
			// 
			// txtRecuperacao
			// 
			this.txtRecuperacao.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.txtRecuperacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtRecuperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRecuperacao.Location = new System.Drawing.Point(40, 195);
			this.txtRecuperacao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtRecuperacao.Name = "txtRecuperacao";
			this.txtRecuperacao.Size = new System.Drawing.Size(333, 26);
			this.txtRecuperacao.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(110, 95);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(168, 35);
			this.label2.TabIndex = 1;
			this.label2.Text = "Lembra a sua senha?";
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
			this.label1.Text = "ALTERAR SENHA";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(40, 322);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(216, 35);
			this.label3.TabIndex = 3;
			this.label3.Text = "Confirmar senha";
			// 
			// lblLogin
			// 
			this.lblLogin.ForeColor = System.Drawing.Color.Black;
			this.lblLogin.Location = new System.Drawing.Point(252, 95);
			this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblLogin.Name = "lblLogin";
			this.lblLogin.Size = new System.Drawing.Size(76, 35);
			this.lblLogin.TabIndex = 9;
			this.lblLogin.Text = "Login";
			this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lblLogin.Click += new System.EventHandler(this.LblLoginClick);
			// 
			// EsquecerSenhaForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(978, 565);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel1);
			this.Name = "EsquecerSenhaForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "EsquecerSenhaForm";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label lblLogin;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtRecuperacao;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtSenha;
		private System.Windows.Forms.Button btnConfirmar;
		private System.Windows.Forms.Label labelEmail;
		private System.Windows.Forms.TextBox txtConfirmarSenha;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
