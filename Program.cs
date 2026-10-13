namespace Lektion14;

enum Season { Spring, Summer, Autumn, Winter }
class Program
{

	static void Main(string[] args)
	{
		List<SeasonalActivity> list = [new(Season.Spring, "Vårstäda"),
			new(Season.Summer, "Sola och bada"),
			new(Season.Autumn, "Höststäda"),
			new(Season.Winter, "Åka skidor")];

		foreach (SeasonalActivity s in list) Console.WriteLine(s.ToString());
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