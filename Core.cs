using System.Reflection;
using System.Text.Json;

namespace TCG_Creator
{
	public class DisplayCore
	{
		public static Display GetDefault()
		{
			return new()
			{
				Fixed = new()
				{
					scale = new() { -1.43f, 2, -2 }
				},
				thirdperson_righthand = new()
				{
					translation = new() { 0, 3.5f, 0 },
					scale = new() { 0.3575f, 0.5f, 1 }
				},
				thirdperson_lefthand = new()
				{
					translation = new() { 0, 3.5f, 0 },
					scale = new() { 0.3575f, 0.5f, 1 }
				},
				firstperson_righthand = new()
				{
					translation = new() { 2.75f, 4, 0 },
					scale = new() { 0.3575f, 0.5f, 1 }
				},
				firstperson_lefthand = new()
				{
					translation = new() { 2.75f, 4, 0 },
					scale = new() { 0.3575f, 0.5f, 1 }
				},
				ground = new()
				{
					scale = new() { 0.715f, 1, 1 }
				}
			};
		}
		public static void SaveDisplay(string path, Display display)
		{
			File.WriteAllText(path, JsonSerializer.Serialize(display));
		}
		public static Display? LoadDisplay(string path)
		{
			return JsonSerializer.Deserialize<Display>(File.ReadAllText(path));
		}
		public static Display Determine()
		{
			string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\display.json";
			if (File.Exists(path))
			{
				Display? display = LoadDisplay(path);
				if (display != null)
				{
					return display;
				}
			}
			return GetDefault();
		}
	}
	public class SettingsCore
	{
		public string? baseItem { get; set; }
		public int? countFrom { get; set; }
		public SettingsCore(string path)
		{
			if (File.Exists(path))
			{
                foreach (string line in File.ReadLines(path))
                {
                    string temp = Core.Crimp(line);
                    if (!temp.StartsWith('#') && temp.Contains('='))
                    {
                        string[] tmp = temp.Split('=');
                        if (tmp[0] == "countFrom" && int.TryParse(tmp[1], out int x))
                        {
                            countFrom = x;
                        }
                        else if (tmp[0] == "baseItem" && tmp[1].StartsWith('"') && tmp[1].EndsWith('"'))
                        {
                            baseItem = tmp[1][1..][..^1];
                        }
                    }
                }
            }
			if (baseItem == null)
			{
				baseItem = "knowledge_book";
            }
            if (countFrom == null)
            {
                countFrom = 0;
            }
        }
		public void Save(string path)
		{
			string[] lines = { "# TCG Creator (Made by TheBlueLines)", "# Created on: " + DateTime.Now, "baseItem = \"" + baseItem + "\"", "countFrom = " + countFrom };
			File.WriteAllLines(path, lines);
		}
	}
	public class Core
	{
		public static string Crimp(string text)
		{
			string resp = string.Empty;
			bool mode = false;
			foreach (char c in text)
			{
				if (c == '"')
				{
					mode = !mode;
				}
				if (mode || c != ' ')
				{
					resp += c;
				}
			}
			return resp;
		}
	}
}