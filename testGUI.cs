using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

public class MyForm : Form {
	
	private WebBrowser webBrowser1;
	
	public MyForm() {
		this.Text = "test form";
		Button testButton = new Button();
		testButton.Text = "test button";
		testButton.Left = 10;
		testButton.Top = 10;
		
		webBrowser1 = new WebBrowser();
		this.Load += new EventHandler(Form1_Load);
		
		Controls.Add(webBrowser1);
	}
	
	private void Form1_Load(object sender, EventArgs e)
	{
		webBrowser1.DocumentText = File.ReadAllText("gameWeb.html");
		Size = new Size(Screen.PrimaryScreen.Bounds.Width,Screen.PrimaryScreen.Bounds.Height);
		webBrowser1.Size = new Size(Screen.PrimaryScreen.Bounds.Width,Screen.PrimaryScreen.Bounds.Height);
		
		
		Location = new Point(0,0);
		MaximizeBox = true;
	}
	
	[STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
		MyForm form = new MyForm();
        Application.Run(new MyForm());
    }
}