namespace Lektion14;

enum Season { Spring, Summer, Autumn, Winter }

enum MenuOption { StartGame, LoadGame, Settings, Exit }
class Program
{

	static void Main(string[] args)
	{
		// List<SeasonalActivity> list = [new(Season.Spring, "Vårstäda"),
		// 	new(Season.Summer, "Sola och bada"),
		// 	new(Season.Autumn, "Höststäda"),
		// 	new(Season.Winter, "Åka skidor")];

		// foreach (SeasonalActivity s in list) Console.WriteLine(s.ToString());

		// while (true)
		// {
		// 	Console.Write("Välj val: ");
		// 	HandleMenuOption((MenuOption)Enum.Parse(typeof(MenuOption), Console.ReadLine()));
		// }
	}

	static void HandleMenuOption(MenuOption option)
	{
		switch (option)
		{
			case MenuOption.StartGame:
				Console.WriteLine("Start game");
				break;
			case MenuOption.LoadGame:
				Console.WriteLine("Load game");
				break;
			case MenuOption.Settings:
				Console.WriteLine("Settings");
				break;
			case MenuOption.Exit:
				Console.WriteLine("Exit");
				break;
			default:
				Console.WriteLine("Not an option");
				break;
		}
	}
}

class SeasonalActivity
{
	public Season Season { get; set; }
	public string Activity { get; set; }

	public SeasonalActivity(Season s, string a)
	{
		Season = s;
		Activity = a;
	}

	public override string ToString()
	{
		return Season + ": " + Activity;
	}
}

class BlogPost
{
	public string Title { get; set; } = "Untitled";
	public string Content { get; set; } = "No content";

	public BlogPost(string title, string content)
	{
		Title = title;
		Content = content;
	}

	public void Publish()
	{

	}
	public void Archive()
	{

	}
}