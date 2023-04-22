using System.Drawing.Imaging;
using System.Reflection;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Unicode;

namespace TCG_Creator
{
    public partial class Base : Form
    {
        private Dictionary<string, Image> dictionary = new();
        public Base()
        {
            InitializeComponent();
        }
        private void loadImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new()
            {
                Multiselect = true,
                Filter = "PNG (*.png)|*.png|JPEG (*.jpg;*.jpeg;*.jpe;*.jfif)|*.jpg;*.jpeg;*.jpe;*.jfif|All files|*.*"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string value in openFileDialog.FileNames)
                {
                    string tmp = Path.GetFileNameWithoutExtension(value);
                    dictionary.Add(tmp, Image.FromFile(value));
                    list.Items.Add(tmp);
                }
            }
        }
        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list.SelectedIndex >= 0)
            {
                string? selected = list.SelectedItem as string;
                if (!string.IsNullOrEmpty(selected))
                {
                    picture.Image = dictionary[selected];
                }
            }
        }
        private void make_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new()
            {
                ShowHiddenFiles = true,
                ShowNewFolderButton = true
            };
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string path = folderBrowserDialog.SelectedPath;
                if (Directory.EnumerateFileSystemEntries(path).Any())
                {
                    if (MessageBox.Show("Directory exists. Do you want to continue?", "Alert", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    {
                        return;
                    }
                    Directory.Delete(path, true);
                    Directory.CreateDirectory(path);
                }
                Compile(path);
            }
        }
        private void Compile(string path)
        {
            SettingsCore settings = new(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\config.cfg");
            Resource resource = new()
            {
                pack = new Pack()
                {
                    pack_format = 9,
                    description = "§7Made with §c§lTCG creator"
                }
            };
            File.WriteAllText(path + "\\pack.mcmeta", JsonSerializer.Serialize(resource));
            File.WriteAllBytes(path + "\\pack.png", File.ReadAllBytes(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\icon.png"));
            string modelsPath = path + "\\assets\\minecraft\\models\\item";
            string texturesPath = path + "\\assets\\minecraft\\textures\\item";
            Directory.CreateDirectory(modelsPath);
            Directory.CreateDirectory(texturesPath);
            JsonSerializerOptions jsonSerializerOptions = new()
            {
                WriteIndented = false,
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            };
            List<Override> overrides = new();
            int i = settings.countFrom != null ? settings.countFrom.Value : 0;
            foreach (KeyValuePair<string, Image> value in dictionary)
            {
                Model model = new Model()
                {
                    parent = "item/generated",
                    textures = new()
                    {
                        layer0 = "item/" + value.Key
                    },
                    display = DisplayCore.Determine()
                };
                string json = JsonSerializer.Serialize(model, jsonSerializerOptions);
                File.WriteAllText(modelsPath + Path.DirectorySeparatorChar + value.Key + ".json", json);
                value.Value.Save(texturesPath + Path.DirectorySeparatorChar + value.Key + ".png", ImageFormat.Png);
                Override tmp = new()
                {
                    predicate = new()
                    {
                        custom_model_data = i++
                    },
                    model = "item/" + value.Key
                };
                overrides.Add(tmp);
            }
            Model baseModel = new Model()
            {
                parent = "item/generated",
                textures = new()
                {
                    layer0 = "item/" + settings.baseItem
                },
                overrides = overrides
            };
            string temp = JsonSerializer.Serialize(baseModel, jsonSerializerOptions);
            File.WriteAllText(modelsPath + Path.DirectorySeparatorChar + settings.baseItem + ".json", temp);
            MessageBox.Show("Resource pack compiled!");
        }
        private void setDisplayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifyDisplay modifyDisplay = new();
            modifyDisplay.ShowDialog();
        }
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settings = new();
            settings.ShowDialog();
        }
    }
}