using System;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.Input;

namespace C1ButtonExample
{
	public class MainForm : Form
	{
		public MainForm()
		{
			// Initialize the C1Button
			var btn = new C1Button
			{
				Text = "Submit",
				Location = new Point(10, 20),
				DialogResult = DialogResult.OK,
				Trimming = StringTrimming.EllipsisCharacter,
			};

			// Add the button to the form
			Controls.Add(btn);

			// Set the form properties
			Text = "C1Button Example";
			Size = new Size(300, 200);

			// Add a handler for the button click event
			btn.Click += (sender, e) =>
			{
				MessageBox.Show("C1Button clicked!");
			};
		}

		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}
