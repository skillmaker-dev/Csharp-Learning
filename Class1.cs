using System;

public class Class1
{
	public Class1()
	{
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text");
            var text = Console.ReadLine();

            var textSplit = text.Split(' ');
            var newTextArray = new List<string>();
            foreach (var word in textSplit)
            {
                if (word != " ")
                {
                    newTextArray.Add(word);
                }
            }

            foreach (var word in newTextArray)
            {
                Console.WriteLine(word);
            }
        }
    }
}
