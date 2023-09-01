// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter any string : ");
var inputText = Console.ReadLine();

if (!string.IsNullOrEmpty(inputText) && !string.IsNullOrWhiteSpace(inputText))
{
    var result = FindCharacterOccurance(inputText);
	if(result != null && result.Count > 0)
	{
		foreach (var item in result)
		{
			Console.WriteLine($"Occurrence of {item.Key} is : {item.Value}");
		}
	}
}
else
{
    Console.WriteLine("Provided text is not valid.");
}




 Dictionary<char, int> FindCharacterOccurance(string Text)
{
	Dictionary<char,int> characterKeyValuePairs = new Dictionary<char,int>();
	foreach (char c in Text)
	{
		characterKeyValuePairs.TryGetValue(c, out int count);
		characterKeyValuePairs[c] = count + 1;
    }
	return characterKeyValuePairs;
}