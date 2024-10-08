/*namespace HomeTask_09._10_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintFirstLetter("Hello World");
        }
        static void PrintFirstLetter(string text)
        {
            if (text[0] != ' ')
            {
                Console.Write(text[0]);
            }
            for (int i = 1; i < text.Length; i++)
            {
                if (text[i] != ' ' && text[i-1] == ' ')
                {
                    Console.Write(text[i]);
                }
            }

        }
    }
}
*/