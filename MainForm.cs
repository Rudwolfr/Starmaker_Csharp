/*
 * Created by SharpDevelop.
 * User: Rodolfo
 * Date: 16/01/2016
 * Time: 11:15 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace StarMaker
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
		
		void MainFormLoad(object sender, EventArgs e)
		{
		
			
			
			
			// C#
			//Para añadir numeros en el comboBox
			//Horas Arco
System.Object[] ItemObject = new System.Object[24];
for (ushort i = 0; i <= 23; i++)
{
   ItemObject[i] = i;
}
comboBox1.Items.AddRange(ItemObject);
comboBox1.SelectedIndex = 0; //Valor predeterminado

//Minutos Arco
System.Object[] ItemObject2 = new System.Object[60];
for (ushort j = 0; j <= 59; j++)
{
   ItemObject2[j] = j;
}
comboBox2.Items.AddRange(ItemObject2);
comboBox4.Items.AddRange(ItemObject2);

comboBox2.SelectedIndex = 0; //Valor predeterminado
comboBox4.SelectedIndex = 0; //Valor predeterminado

//Horas Declinación
//System.Object[] ItemObject3 = new System.Object[180]; AL PARECER NO FUNCIONA CON NÚMEROS NEGATIVOS
//for (short k = -90; k <= 91; k++)
//{
  // ItemObject3[k] = k;
//}
//comboBox3.Items.AddRange(ItemObject3);

comboBox3.Items.Add("");
for (int k = -90; k < 91; k++)
  comboBox3.Items.Add(k);
  
  comboBox3.SelectedItem = 0;//Valor predeterminado

		}
		
		
		
		void BtnCrearClick(object sender, EventArgs e)
		{
			float grados_ar;
			float grados;
		
			double parsec;
			
			const int RSol = 696342;
			
			uint horas_ar = Convert.ToUInt32(comboBox1.SelectedValue);
			//int horas_ar = int.Parse(comboBox1.SelectedIndex.ToString());
			int horas = int.Parse(comboBox3.SelectedIndex.ToString());
			
			uint minutos_ar = Convert.ToUInt32(comboBox2.SelectedValue);
			//int minutos_ar = int.Parse(comboBox2.SelectedItem.ToString());
			int minutos = Convert.ToInt32(comboBox4.SelectedValue);
			//int minutos = int.Parse(comboBox4.SelectedItem.ToString());
		 	
			float segundos_ar = float.Parse(txt_segundosar.Text.Trim());
			float segundos = float.Parse(txt_segundosar.Text.Trim());
			
			float light_years = float.Parse(txtDistancia.Text.Trim());
			float radio = float.Parse(txtDistancia.Text.Trim());
			float radioE;
			
			string nestrella = txtEstrella.Text;
			string espectro = txtTEspectral.Text;
			string otrosnombres = txtOtrosNombres.Text;
			
		
			grados_ar = ((horas_ar*15)+(minutos_ar/4)+(segundos_ar/240));
			grados = ((horas*3600)+(minutos*60)+(segundos))/(3600);//Convierte horas a grados
		 	
			  using (StreamWriter sw = new StreamWriter(nestrella + ".stc"))
			
  {
	
	
	
	if (String.IsNullOrEmpty(txtOtrosNombres.Text))
	{
	sw.WriteLine("\"{0}", nestrella);
	sw.WriteLine("\n");
	}
	else {
	
	sw.WriteLine("\" {0}:{1}\"", nestrella, otrosnombres);
	sw.WriteLine("\n");
	}
	
	sw.WriteLine("{");
	sw.WriteLine("\n");
    sw.WriteLine("\tRA {0}", grados_ar);
    sw.WriteLine("\n");
    sw.WriteLine("\tDec {0}", grados);
    sw.WriteLine("\n");
    
        if (chkParsec.Checked)
    {
        	light_years = float.Parse(txtDistancia.Text.Trim());
    	 	parsec = light_years*3.2616;
    	 	sw.WriteLine("\tDistance {0}", parsec);
        }
    	else if(chkParsec.Checked == false){
    		sw.WriteLine("\tDistance {0}", light_years);
    	}
			sw.WriteLine("\n");
			sw.WriteLine("\tSpectralType {0}",this.txtTEspectral.Text.Trim());
			sw.WriteLine("\n");
			
			if(rdAppmag.Checked)
			  {
				sw.WriteLine("\tAppMag {0}",this.txtMagnitud.Text.Trim());
				sw.WriteLine("\n");
			  }
			
			if(rdAbsMag.Checked)
			  {
				sw.WriteLine("\tAppMag {0}",this.txtMagnitud.Text.Trim());
				sw.WriteLine("\n");
			  }
			
			if (String.IsNullOrEmpty(txtRadio.Text.Trim()))
			    {
			    	
			    }
			
			    else {
			    	
			    	if(chkRSol.Checked)
			{
			radioE=radio*RSol;
			sw.WriteLine("\tRadius {0} # {1} Sol Radius",radioE,RSol);
			}
			else if(chkRSol.Checked == false)
			{
			sw.WriteLine("\tRadius\t {0}",txtRadio.Text.Trim());
			sw.WriteLine("\n");
			}
			    
			    }
			sw.WriteLine("\n");
			sw.WriteLine("}");
			}
			  MessageBox.Show("El archivo "+ nestrella+".stc " +"se ha creado","Archivo creado"); 
		}
		

		void BtnLimpiarClick(object sender, EventArgs e)
		
					{
			   Action<Control.ControlCollection> func = null;

     func = (controls) =>
         {
             foreach (Control control in controls)
                 if (control is TextBox)
                     (control as TextBox).Clear();
                 else
                     func(control.Controls);
         };
     

     func(Controls);
		}
		
		private void soloNumeros_KeyPress(object sender, KeyPressEventArgs e)/*Función que solo acepta numeros en textboxes, ademas de punto punto, no acepta negativos*/
			
		{
char ch =e.KeyChar;

if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(e.KeyChar == ('.') && !(e.KeyChar == '-' )))
{
	e.Handled = true;
	return;
}			
			}
		
		
		void BtnSalirClick(object sender, EventArgs e)
		{
this.Close();
			
		}
		
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		void TxtDistanciaKeyPress(object sender, KeyPressEventArgs e)
		{
			soloNumeros_KeyPress(sender, e);
		}
		
		void TxtRadioKeyPress(object sender, KeyPressEventArgs e)
		{
			soloNumeros_KeyPress(sender, e);
		}
		
		void Txt_segundosarKeyPress(object sender, KeyPressEventArgs e)
		{
			soloNumeros_KeyPress(sender, e);
		}
		
		void TxtsegundosKeyPress(object sender, KeyPressEventArgs e)
		{
			soloNumeros_KeyPress(sender, e);
		}
		void TxtMagnitudTextChanged(object sender, EventArgs e)
		{
	
		}
	}
}
