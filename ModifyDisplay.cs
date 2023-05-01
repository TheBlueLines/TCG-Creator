using System.Reflection;

namespace TCG_Creator
{
	public partial class ModifyDisplay : Form
	{
		private static bool saved = true;
		private static bool loaded = false;
		public ModifyDisplay()
		{
			InitializeComponent();
			foreach (TextBox control in Controls.OfType<TextBox>())
			{
				control.KeyPress += ValueChanged;
			}
			Display display = DisplayCore.Determine();
			if (display.firstperson_lefthand != null)
			{
				if (display.firstperson_lefthand.translation != null)
				{
					fltx.Text = display.firstperson_lefthand.translation[0].ToString();
					flty.Text = display.firstperson_lefthand.translation[1].ToString();
					fltz.Text = display.firstperson_lefthand.translation[2].ToString();
				}
				if (display.firstperson_lefthand.scale != null)
				{
					flsx.Text = display.firstperson_lefthand.scale[0].ToString();
					flsy.Text = display.firstperson_lefthand.scale[1].ToString();
					flsz.Text = display.firstperson_lefthand.scale[2].ToString();
				}
			}
			if (display.firstperson_righthand != null)
			{
				if (display.firstperson_righthand.translation != null)
				{
					frtx.Text = display.firstperson_righthand.translation[0].ToString();
					frty.Text = display.firstperson_righthand.translation[1].ToString();
					frtz.Text = display.firstperson_righthand.translation[2].ToString();
				}
				if (display.firstperson_righthand.scale != null)
				{
					frsx.Text = display.firstperson_righthand.scale[0].ToString();
					frsy.Text = display.firstperson_righthand.scale[1].ToString();
					frsz.Text = display.firstperson_righthand.scale[2].ToString();
				}
			}
			if (display.thirdperson_lefthand != null)
			{
				if (display.thirdperson_lefthand.translation != null)
				{
					tltx.Text = display.thirdperson_lefthand.translation[0].ToString();
					tlty.Text = display.thirdperson_lefthand.translation[1].ToString();
					tltz.Text = display.thirdperson_lefthand.translation[2].ToString();
				}
				if (display.thirdperson_lefthand.scale != null)
				{
					tlsx.Text = display.thirdperson_lefthand.scale[0].ToString();
					tlsy.Text = display.thirdperson_lefthand.scale[1].ToString();
					tlsz.Text = display.thirdperson_lefthand.scale[2].ToString();
				}
			}
			if (display.thirdperson_righthand != null)
			{
				if (display.thirdperson_righthand.translation != null)
				{
					trtx.Text = display.thirdperson_righthand.translation[0].ToString();
					trty.Text = display.thirdperson_righthand.translation[1].ToString();
					trtz.Text = display.thirdperson_righthand.translation[2].ToString();
				}
				if (display.thirdperson_righthand.scale != null)
				{
					trsx.Text = display.thirdperson_righthand.scale[0].ToString();
					trsy.Text = display.thirdperson_righthand.scale[1].ToString();
					trsz.Text = display.thirdperson_righthand.scale[2].ToString();
				}
			}
			if (display.ground != null && display.ground.scale != null)
			{
				gx.Text = display.ground.scale[0].ToString();
				gy.Text = display.ground.scale[1].ToString();
				gz.Text = display.ground.scale[2].ToString();
			}
			if (display.Fixed != null && display.Fixed.scale != null)
			{
				fx.Text = display.Fixed.scale[0].ToString();
				fy.Text = display.Fixed.scale[1].ToString();
				fz.Text = display.Fixed.scale[2].ToString();
			}
			loaded = true;
		}
		private void ValueChanged(object? sender, KeyPressEventArgs e)
		{
			TextBox? textBox = sender as TextBox;
			if (textBox != null && loaded)
			{
				e.Handled = !(int.TryParse(e.KeyChar.ToString(), out int temp) || e.KeyChar == (char)Keys.Back || (e.KeyChar == ',' && !textBox.Text.Contains(',')));
				saved = false;
			}
		}
		private void save_Click(object sender, EventArgs e)
		{
			Display display = new()
			{
				firstperson_lefthand = new()
				{
					translation = new() { float.Parse(fltx.Text), float.Parse(flty.Text), float.Parse(fltz.Text) },
					scale = new() { float.Parse(flsx.Text), float.Parse(flsy.Text), float.Parse(flsz.Text) }
				},
				firstperson_righthand = new()
				{
					translation = new() { float.Parse(frtx.Text), float.Parse(frty.Text), float.Parse(frtz.Text) },
					scale = new() { float.Parse(frsx.Text), float.Parse(frsy.Text), float.Parse(frsz.Text) }
				},
				thirdperson_lefthand = new()
				{
					translation = new() { float.Parse(tltx.Text), float.Parse(tlty.Text), float.Parse(tltz.Text) },
					scale = new() { float.Parse(tlsx.Text), float.Parse(tlsy.Text), float.Parse(tlsz.Text) }
				},
				thirdperson_righthand = new()
				{
					translation = new() { float.Parse(trtx.Text), float.Parse(trty.Text), float.Parse(trtz.Text) },
					scale = new() { float.Parse(trsx.Text), float.Parse(trsy.Text), float.Parse(trsz.Text) }
				},
				ground = new()
				{
					scale = new() { float.Parse(gx.Text), float.Parse(gy.Text), float.Parse(gz.Text) }
				},
				Fixed = new()
				{
					scale = new() { float.Parse(fx.Text), float.Parse(fy.Text), float.Parse(fz.Text) }
				}
			};
			DisplayCore.SaveDisplay(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\display.json", display);
			saved = true;
			Close();
		}
		private void cancel_Click(object sender, EventArgs e)
		{
			Close();
		}
		private void ModifyDisplay_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!saved)
			{
				e.Cancel = MessageBox.Show("Exit without saving?", "Alert", MessageBoxButtons.YesNoCancel) != DialogResult.Yes;
			}
		}
	}
}