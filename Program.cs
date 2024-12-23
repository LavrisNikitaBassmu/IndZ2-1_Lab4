using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст:");
        string input = Console.ReadLine();

        char[] inputArray = input.ToCharArray();
        string result = "";
        string currentWord = "";

        for (int i = 0; i < inputArray.Length; i++)
        {
            if (char.IsWhiteSpace(inputArray[i]) || i == inputArray.Length - 1)
            {
                if (i == inputArray.Length - 1 && !char.IsWhiteSpace(inputArray[i]))
                {
                    currentWord += inputArray[i];
                }

                result += ConvertWordToNumber(currentWord) + " ";
                currentWord = "";
            }
            else
            {
                currentWord += inputArray[i];
            }
        }

        Console.WriteLine("Результат: " + result.Trim());
    }

    static string ConvertWordToNumber(string word)
    {
        return word switch
        {
            "one" => "1",
            "two" => "2",
            "three" => "3",
            "four" => "4",
            "five" => "5",
            _ => word
        };
    }
}