
using MyMonkeyApp;

/// <summary>
/// Main entry point for the Monkey Console Application.
/// </summary>
class Program
{
	/// <summary>
	/// Application entry method.
	/// </summary>
	static void Main()
	{
		while (true)
		{
			Console.WriteLine("\n=== Monkey Console Application ===");
			Console.WriteLine("1) List all monkeys");
			Console.WriteLine("2) Get details for a specific monkey by name");
			Console.WriteLine("3) Get a random monkey");
			Console.WriteLine("4) Exit");
			Console.Write("Select an option (1-4): ");

			var input = Console.ReadLine();
			Console.WriteLine();
			switch (input)
			{
				case "1":
					ListAllMonkeys();
					break;
				case "2":
					GetMonkeyDetailsByName();
					break;
				case "3":
					ShowRandomMonkey();
					break;
				case "4":
					Console.WriteLine("Goodbye!");
					return;
				default:
					Console.WriteLine("Invalid option. Please try again.");
					break;
			}
		}
	}

	static void ListAllMonkeys()
	{
		var monkeys = MonkeyHelper.GetMonkeys();
		Console.WriteLine("Available Monkeys:");
		foreach (var monkey in monkeys)
		{
			var count = MonkeyHelper.GetAccessCount(monkey.Name);
			Console.WriteLine($"- {monkey.Name} (Accessed {count} times)");
		}
	}

	static void GetMonkeyDetailsByName()
	{
		Console.Write("Enter monkey name: ");
		var name = Console.ReadLine();
		var monkey = MonkeyHelper.GetMonkeyByName(name ?? string.Empty);
		if (monkey == null)
		{
			Console.WriteLine("Monkey not found.");
			return;
		}
		DisplayMonkeyDetails(monkey);
	}

	static void ShowRandomMonkey()
	{
		var monkey = MonkeyHelper.GetRandomMonkey();
		DisplayMonkeyDetails(monkey);
	}

	static void DisplayMonkeyDetails(Monkey monkey)
	{
		Console.WriteLine($"Name: {monkey.Name}");
		Console.WriteLine($"Location: {monkey.Location}");
		Console.WriteLine($"Population: {monkey.Population}");
		Console.WriteLine($"Latitude: {monkey.Latitude}");
		Console.WriteLine($"Longitude: {monkey.Longitude}");
		Console.WriteLine($"Details: {monkey.Details}");
		Console.WriteLine($"Image Path: {monkey.ImagePath}");
		Console.WriteLine($"Accessed: {MonkeyHelper.GetAccessCount(monkey.Name)} times");
		// ASCII art monkey face
		Console.WriteLine("ASCII Art:");
		Console.WriteLine("  .--.  ");
		Console.WriteLine(" (o.o) ");
		Console.WriteLine("  (__)  ");
	}
}
