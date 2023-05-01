using System.Reflection;

namespace TCG_Creator
{
	public partial class Settings : Form
	{
		private bool saved = true;
		private bool loaded = false;
		public Settings()
		{
			InitializeComponent();
			baseItem.Text = Program.settings.baseItem;
			countFrom.Text = Program.settings.countFrom.ToString();
			loaded = true;
		}
		private void save_Click(object sender, EventArgs e)
		{
			saved = true;
			Program.settings.baseItem = baseItem.Text;
			if (int.TryParse(countFrom.Text, out int x))
			{
				Program.settings.countFrom = x;
			}
			Program.settings.Save(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\config.cfg");
			Close();
		}
		private void cancel_Click(object sender, EventArgs e)
		{
			Close();
		}
		private void Settings_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!saved)
			{
				e.Cancel = MessageBox.Show("Exit without saving?", "Alert", MessageBoxButtons.YesNoCancel) != DialogResult.Yes;
			}
		}
		private void countFrom_TextChanged(object sender, EventArgs e)
		{
			if (loaded)
			{
				saved = false;
			}
		}
		private void baseItem_TextChanged(object sender, EventArgs e)
		{
			if (loaded)
			{
				saved = false;
			}
		}
	}
}