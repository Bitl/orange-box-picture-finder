/*
 * Created by SharpDevelop.
 * User: BITL
 * Date: 8/30/2014
 * Time: 8:41 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Orange_Box_Picture_Finder
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
			string imageURL = "http://img.gfx.no/";
			string number = textBox1.Text;
			Random rnd = new Random();
			string randomnumber = rnd.Next(000,999).ToString();
			
			textBox2.Text = imageURL + number + "/" + number + randomnumber + "/i_" + number + randomnumber + ".jpg";
			webBrowser1.Navigate(textBox2.Text);
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			string imageURL = "http://img.gfx.no/";
			string number = textBox1.Text;
			Random rnd = new Random();
			string randomnumber = rnd.Next(000,999).ToString();
			
			textBox2.Text = imageURL + number + "/" + number + randomnumber + "/i_" + number + randomnumber + ".jpg";
			webBrowser1.Navigate(textBox2.Text);
		}
	}
}
