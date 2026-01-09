/*
 * Created by SharpDevelop.
 * User: jenni
 * Date: 12/10/2025
 * Time: 19:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SistemaQuiz
{
	partial class HomeForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblPontuacao;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblFatec;
		private System.Windows.Forms.Label lblInfoFatec;
		private System.Windows.Forms.Label lblCursosFatec;
		private System.Windows.Forms.Label lblVestibulares;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblAssinaturas;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label lblMaterias;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label lblInfoUSP;
		private System.Windows.Forms.Label lblCursosUSP;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label lblInfoUnesp;
		private System.Windows.Forms.Label lblCursosUnesp;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label lblInfoUnicamp;
		private System.Windows.Forms.Label lblCursosUnicamp;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblAssinaturas = new System.Windows.Forms.Label();
			this.lblPontuacao = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.lblMaterias = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.lblInfoUSP = new System.Windows.Forms.Label();
			this.lblCursosUSP = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.lblInfoUnesp = new System.Windows.Forms.Label();
			this.lblCursosUnesp = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.lblInfoUnicamp = new System.Windows.Forms.Label();
			this.lblCursosUnicamp = new System.Windows.Forms.Label();
			this.lblFatec = new System.Windows.Forms.Label();
			this.lblInfoFatec = new System.Windows.Forms.Label();
			this.lblCursosFatec = new System.Windows.Forms.Label();
			this.lblVestibulares = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label22 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(256, 225);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(1050, 177);
			this.label2.TabIndex = 28;
			this.label2.Text = "Bem vindo ao \r\nnosso sistema!";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(256, 369);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(1050, 177);
			this.label3.TabIndex = 29;
			this.label3.Text = "Confira os materiais de estudo no botão dos \r\nvestibulares. Para mais informações" +
			", acesse as abas \r\nlaterais.";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label23
			// 
			this.label23.BackColor = System.Drawing.Color.Transparent;
			this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label23.Location = new System.Drawing.Point(465, 16);
			this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(44, 58);
			this.label23.TabIndex = 27;
			this.label23.Text = "ᐯ";
			this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label23.Click += new System.EventHandler(this.Label23Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DarkRed;
			this.panel1.Controls.Add(this.lblAssinaturas);
			this.panel1.Controls.Add(this.lblPontuacao);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label24);
			this.panel1.Controls.Add(this.label20);
			this.panel1.Controls.Add(this.lblMaterias);
			this.panel1.Controls.Add(this.label17);
			this.panel1.Controls.Add(this.lblInfoUSP);
			this.panel1.Controls.Add(this.lblCursosUSP);
			this.panel1.Controls.Add(this.label14);
			this.panel1.Controls.Add(this.lblInfoUnesp);
			this.panel1.Controls.Add(this.lblCursosUnesp);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.lblInfoUnicamp);
			this.panel1.Controls.Add(this.lblCursosUnicamp);
			this.panel1.Controls.Add(this.lblFatec);
			this.panel1.Controls.Add(this.lblInfoFatec);
			this.panel1.Controls.Add(this.lblCursosFatec);
			this.panel1.Controls.Add(this.lblVestibulares);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.ForeColor = System.Drawing.Color.Transparent;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(225, 775);
			this.panel1.TabIndex = 30;
			// 
			// lblAssinaturas
			// 
			this.lblAssinaturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAssinaturas.Location = new System.Drawing.Point(20, 169);
			this.lblAssinaturas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblAssinaturas.Name = "lblAssinaturas";
			this.lblAssinaturas.Size = new System.Drawing.Size(196, 35);
			this.lblAssinaturas.TabIndex = 32;
			this.lblAssinaturas.Text = "Assinaturas";
			this.lblAssinaturas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblAssinaturas.Click += new System.EventHandler(this.LblAssinaturasClick);
			// 
			// lblPontuacao
			// 
			this.lblPontuacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPontuacao.Location = new System.Drawing.Point(20, 134);
			this.lblPontuacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblPontuacao.Name = "lblPontuacao";
			this.lblPontuacao.Size = new System.Drawing.Size(196, 35);
			this.lblPontuacao.TabIndex = 31;
			this.lblPontuacao.Text = "Pontuação";
			this.lblPontuacao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblPontuacao.Click += new System.EventHandler(this.LblPontuacaoClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(38, 98);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(178, 35);
			this.label1.TabIndex = 24;
			this.label1.Text = "Tela Inicial";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label24
			// 
			this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label24.Location = new System.Drawing.Point(4, 97);
			this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(44, 35);
			this.label24.TabIndex = 23;
			this.label24.Text = "➔ ";
			this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label20
			// 
			this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label20.Location = new System.Drawing.Point(20, 252);
			this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(196, 35);
			this.label20.TabIndex = 29;
			this.label20.Text = "Provão Paulista";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblMaterias
			// 
			this.lblMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMaterias.Location = new System.Drawing.Point(20, 283);
			this.lblMaterias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblMaterias.Name = "lblMaterias";
			this.lblMaterias.Size = new System.Drawing.Size(160, 35);
			this.lblMaterias.TabIndex = 30;
			this.lblMaterias.Text = "• Matérias";
			this.lblMaterias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblMaterias.Click += new System.EventHandler(this.LblMateriasClick);
			// 
			// label17
			// 
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(20, 335);
			this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(160, 35);
			this.label17.TabIndex = 26;
			this.label17.Text = "USP";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblInfoUSP
			// 
			this.lblInfoUSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInfoUSP.Location = new System.Drawing.Point(20, 366);
			this.lblInfoUSP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblInfoUSP.Name = "lblInfoUSP";
			this.lblInfoUSP.Size = new System.Drawing.Size(160, 35);
			this.lblInfoUSP.TabIndex = 27;
			this.lblInfoUSP.Text = "• Informações";
			this.lblInfoUSP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblInfoUSP.Click += new System.EventHandler(this.LblInfoUSPClick);
			// 
			// lblCursosUSP
			// 
			this.lblCursosUSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCursosUSP.Location = new System.Drawing.Point(20, 391);
			this.lblCursosUSP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCursosUSP.Name = "lblCursosUSP";
			this.lblCursosUSP.Size = new System.Drawing.Size(160, 37);
			this.lblCursosUSP.TabIndex = 28;
			this.lblCursosUSP.Text = "• Cursos";
			this.lblCursosUSP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(20, 442);
			this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(160, 35);
			this.label14.TabIndex = 23;
			this.label14.Text = "Unesp";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblInfoUnesp
			// 
			this.lblInfoUnesp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInfoUnesp.Location = new System.Drawing.Point(20, 472);
			this.lblInfoUnesp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblInfoUnesp.Name = "lblInfoUnesp";
			this.lblInfoUnesp.Size = new System.Drawing.Size(160, 35);
			this.lblInfoUnesp.TabIndex = 24;
			this.lblInfoUnesp.Text = "• Informações";
			this.lblInfoUnesp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblInfoUnesp.Click += new System.EventHandler(this.LblInfoUnespClick);
			// 
			// lblCursosUnesp
			// 
			this.lblCursosUnesp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCursosUnesp.Location = new System.Drawing.Point(20, 497);
			this.lblCursosUnesp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCursosUnesp.Name = "lblCursosUnesp";
			this.lblCursosUnesp.Size = new System.Drawing.Size(160, 37);
			this.lblCursosUnesp.TabIndex = 25;
			this.lblCursosUnesp.Text = "• Cursos";
			this.lblCursosUnesp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblCursosUnesp.Click += new System.EventHandler(this.LblCursosUnespClick);
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(20, 551);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(160, 35);
			this.label11.TabIndex = 20;
			this.label11.Text = "Unicamp";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblInfoUnicamp
			// 
			this.lblInfoUnicamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInfoUnicamp.Location = new System.Drawing.Point(20, 582);
			this.lblInfoUnicamp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblInfoUnicamp.Name = "lblInfoUnicamp";
			this.lblInfoUnicamp.Size = new System.Drawing.Size(160, 35);
			this.lblInfoUnicamp.TabIndex = 21;
			this.lblInfoUnicamp.Text = "• Informações";
			this.lblInfoUnicamp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblInfoUnicamp.Click += new System.EventHandler(this.LblInfoUnicampClick);
			// 
			// lblCursosUnicamp
			// 
			this.lblCursosUnicamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCursosUnicamp.Location = new System.Drawing.Point(20, 606);
			this.lblCursosUnicamp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCursosUnicamp.Name = "lblCursosUnicamp";
			this.lblCursosUnicamp.Size = new System.Drawing.Size(160, 37);
			this.lblCursosUnicamp.TabIndex = 22;
			this.lblCursosUnicamp.Text = "• Cursos";
			this.lblCursosUnicamp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblCursosUnicamp.Click += new System.EventHandler(this.LblCursosUnicampClick);
			// 
			// lblFatec
			// 
			this.lblFatec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFatec.Location = new System.Drawing.Point(20, 657);
			this.lblFatec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblFatec.Name = "lblFatec";
			this.lblFatec.Size = new System.Drawing.Size(160, 35);
			this.lblFatec.TabIndex = 17;
			this.lblFatec.Text = "Fatec";
			this.lblFatec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblInfoFatec
			// 
			this.lblInfoFatec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInfoFatec.Location = new System.Drawing.Point(20, 688);
			this.lblInfoFatec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblInfoFatec.Name = "lblInfoFatec";
			this.lblInfoFatec.Size = new System.Drawing.Size(160, 35);
			this.lblInfoFatec.TabIndex = 18;
			this.lblInfoFatec.Text = "• Informações";
			this.lblInfoFatec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblInfoFatec.Click += new System.EventHandler(this.LblInfoFatecClick);
			// 
			// lblCursosFatec
			// 
			this.lblCursosFatec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCursosFatec.Location = new System.Drawing.Point(20, 712);
			this.lblCursosFatec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCursosFatec.Name = "lblCursosFatec";
			this.lblCursosFatec.Size = new System.Drawing.Size(160, 37);
			this.lblCursosFatec.TabIndex = 19;
			this.lblCursosFatec.Text = "• Cursos";
			this.lblCursosFatec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblVestibulares
			// 
			this.lblVestibulares.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVestibulares.Location = new System.Drawing.Point(38, 215);
			this.lblVestibulares.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblVestibulares.Name = "lblVestibulares";
			this.lblVestibulares.Size = new System.Drawing.Size(178, 35);
			this.lblVestibulares.TabIndex = 7;
			this.lblVestibulares.Text = "Vestibulares";
			this.lblVestibulares.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(4, 214);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(44, 35);
			this.label7.TabIndex = 6;
			this.label7.Text = "➔ ";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(28, 5);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(152, 98);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label22
			// 
			this.label22.BackColor = System.Drawing.Color.Transparent;
			this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label22.Location = new System.Drawing.Point(256, 16);
			this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(303, 54);
			this.label22.TabIndex = 26;
			this.label22.Text = "Vestibulares";
			this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// HomeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1316, 777);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label23);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label22);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "HomeForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "HomeForm";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
	}
}
