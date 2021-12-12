/*
 * Created by SharpDevelop.
 * User: Rodolfo
 * Date: 16/01/2016
 * Time: 11:15 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace StarMaker
{
	partial class MainForm
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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.txtDistancia = new System.Windows.Forms.TextBox();
			this.btnCrear = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtMagnitud = new System.Windows.Forms.TextBox();
			this.txtTEspectral = new System.Windows.Forms.TextBox();
			this.txtRadio = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtEstrella = new System.Windows.Forms.TextBox();
			this.txtOtrosNombres = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.chkParsec = new System.Windows.Forms.CheckBox();
			this.chkRSol = new System.Windows.Forms.CheckBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.comboBox4 = new System.Windows.Forms.ComboBox();
			this.txt_segundosar = new System.Windows.Forms.TextBox();
			this.txtsegundos = new System.Windows.Forms.TextBox();
			this.rdAppmag = new System.Windows.Forms.RadioButton();
			this.rdAbsMag = new System.Windows.Forms.RadioButton();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(162, 36);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(100, 21);
			this.comboBox1.TabIndex = 0;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
			// 
			// txtDistancia
			// 
			this.txtDistancia.Location = new System.Drawing.Point(162, 97);
			this.txtDistancia.Name = "txtDistancia";
			this.txtDistancia.Size = new System.Drawing.Size(100, 20);
			this.txtDistancia.TabIndex = 1;
			this.txtDistancia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDistanciaKeyPress);
			// 
			// btnCrear
			// 
			this.btnCrear.Location = new System.Drawing.Point(70, 291);
			this.btnCrear.Name = "btnCrear";
			this.btnCrear.Size = new System.Drawing.Size(75, 23);
			this.btnCrear.TabIndex = 2;
			this.btnCrear.Text = "&Crear";
			this.btnCrear.UseVisualStyleBackColor = true;
			this.btnCrear.Click += new System.EventHandler(this.BtnCrearClick);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(187, 291);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
			this.btnLimpiar.TabIndex = 3;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiarClick);
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(320, 290);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 23);
			this.btnSalir.TabIndex = 4;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(63, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "Ascención Recta";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(63, 71);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 6;
			this.label2.Text = "Declinación";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(63, 100);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "Distancia";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(63, 123);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(75, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "Magnitud";
			// 
			// txtMagnitud
			// 
			this.txtMagnitud.Location = new System.Drawing.Point(162, 123);
			this.txtMagnitud.Name = "txtMagnitud";
			this.txtMagnitud.Size = new System.Drawing.Size(100, 20);
			this.txtMagnitud.TabIndex = 9;
			this.txtMagnitud.TextChanged += new System.EventHandler(this.TxtMagnitudTextChanged);
			// 
			// txtTEspectral
			// 
			this.txtTEspectral.Location = new System.Drawing.Point(162, 149);
			this.txtTEspectral.Name = "txtTEspectral";
			this.txtTEspectral.Size = new System.Drawing.Size(100, 20);
			this.txtTEspectral.TabIndex = 10;
			// 
			// txtRadio
			// 
			this.txtRadio.Location = new System.Drawing.Point(162, 177);
			this.txtRadio.Name = "txtRadio";
			this.txtRadio.Size = new System.Drawing.Size(100, 20);
			this.txtRadio.TabIndex = 11;
			this.txtRadio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRadioKeyPress);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(63, 151);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 12;
			this.label5.Text = "Tipo Espectral";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(63, 177);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(45, 23);
			this.label6.TabIndex = 13;
			this.label6.Text = "Radio";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(63, 205);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(87, 23);
			this.label7.TabIndex = 14;
			this.label7.Text = "Nombre Estrella";
			// 
			// txtEstrella
			// 
			this.txtEstrella.Location = new System.Drawing.Point(162, 203);
			this.txtEstrella.Name = "txtEstrella";
			this.txtEstrella.Size = new System.Drawing.Size(100, 20);
			this.txtEstrella.TabIndex = 15;
			// 
			// txtOtrosNombres
			// 
			this.txtOtrosNombres.Location = new System.Drawing.Point(162, 229);
			this.txtOtrosNombres.Name = "txtOtrosNombres";
			this.txtOtrosNombres.Size = new System.Drawing.Size(100, 20);
			this.txtOtrosNombres.TabIndex = 16;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(63, 228);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(93, 23);
			this.label8.TabIndex = 17;
			this.label8.Text = "Otros nombres";
			// 
			// chkParsec
			// 
			this.chkParsec.Location = new System.Drawing.Point(268, 96);
			this.chkParsec.Name = "chkParsec";
			this.chkParsec.Size = new System.Drawing.Size(104, 24);
			this.chkParsec.TabIndex = 18;
			this.chkParsec.Text = "Parsec";
			this.chkParsec.UseVisualStyleBackColor = true;
			// 
			// chkRSol
			// 
			this.chkRSol.Location = new System.Drawing.Point(271, 177);
			this.chkRSol.Name = "chkRSol";
			this.chkRSol.Size = new System.Drawing.Size(68, 24);
			this.chkRSol.TabIndex = 19;
			this.chkRSol.Text = "RSol";
			this.chkRSol.UseVisualStyleBackColor = true;
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(271, 36);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(100, 21);
			this.comboBox2.TabIndex = 20;
			// 
			// comboBox3
			// 
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(162, 62);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(100, 21);
			this.comboBox3.TabIndex = 21;
			// 
			// comboBox4
			// 
			this.comboBox4.FormattingEnabled = true;
			this.comboBox4.Location = new System.Drawing.Point(272, 63);
			this.comboBox4.Name = "comboBox4";
			this.comboBox4.Size = new System.Drawing.Size(100, 21);
			this.comboBox4.TabIndex = 23;
			// 
			// txt_segundosar
			// 
			this.txt_segundosar.Location = new System.Drawing.Point(388, 36);
			this.txt_segundosar.Name = "txt_segundosar";
			this.txt_segundosar.Size = new System.Drawing.Size(100, 20);
			this.txt_segundosar.TabIndex = 24;
			this.txt_segundosar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_segundosarKeyPress);
			// 
			// txtsegundos
			// 
			this.txtsegundos.Location = new System.Drawing.Point(388, 63);
			this.txtsegundos.Name = "txtsegundos";
			this.txtsegundos.Size = new System.Drawing.Size(100, 20);
			this.txtsegundos.TabIndex = 25;
			this.txtsegundos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtsegundosKeyPress);
			// 
			// rdAppmag
			// 
			this.rdAppmag.Checked = true;
			this.rdAppmag.Location = new System.Drawing.Point(268, 121);
			this.rdAppmag.Name = "rdAppmag";
			this.rdAppmag.Size = new System.Drawing.Size(104, 24);
			this.rdAppmag.TabIndex = 26;
			this.rdAppmag.TabStop = true;
			this.rdAppmag.Text = "AppMag";
			this.rdAppmag.UseVisualStyleBackColor = true;
			// 
			// rdAbsMag
			// 
			this.rdAbsMag.Location = new System.Drawing.Point(355, 121);
			this.rdAbsMag.Name = "rdAbsMag";
			this.rdAbsMag.Size = new System.Drawing.Size(104, 24);
			this.rdAbsMag.TabIndex = 27;
			this.rdAbsMag.Text = "AbsMag";
			this.rdAbsMag.UseVisualStyleBackColor = true;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(162, 9);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 28;
			this.label9.Text = "Horas";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(272, 10);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 23);
			this.label10.TabIndex = 29;
			this.label10.Text = "Minutos";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(388, 9);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(100, 23);
			this.label11.TabIndex = 30;
			this.label11.Text = "Segundos";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(506, 340);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.rdAbsMag);
			this.Controls.Add(this.rdAppmag);
			this.Controls.Add(this.txtsegundos);
			this.Controls.Add(this.txt_segundosar);
			this.Controls.Add(this.comboBox4);
			this.Controls.Add(this.comboBox3);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.chkRSol);
			this.Controls.Add(this.chkParsec);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtOtrosNombres);
			this.Controls.Add(this.txtEstrella);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtRadio);
			this.Controls.Add(this.txtTEspectral);
			this.Controls.Add(this.txtMagnitud);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnCrear);
			this.Controls.Add(this.txtDistancia);
			this.Controls.Add(this.comboBox1);
			this.Name = "MainForm";
			this.Text = "StarMaker";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
			}

		
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.RadioButton rdAbsMag;
		private System.Windows.Forms.RadioButton rdAppmag;
		private System.Windows.Forms.TextBox txtsegundos;
		private System.Windows.Forms.TextBox txt_segundosar;
		private System.Windows.Forms.ComboBox comboBox4;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.CheckBox chkRSol;
		private System.Windows.Forms.CheckBox chkParsec;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtOtrosNombres;
		private System.Windows.Forms.TextBox txtEstrella;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtRadio;
		private System.Windows.Forms.TextBox txtTEspectral;
		private System.Windows.Forms.TextBox txtMagnitud;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnCrear;
		private System.Windows.Forms.TextBox txtDistancia;
		private System.Windows.Forms.ComboBox comboBox1;
	}
}