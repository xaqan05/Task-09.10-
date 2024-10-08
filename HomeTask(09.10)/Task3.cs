namespace HomeTask_09._10_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string newText = RemoveSpaces("Xaqan    Ismayilov Rasul Rustamli   ");
            Console.WriteLine(newText);
        }

        static string RemoveSpaces(string text)
        {
            string finalText = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ')
                {
                    finalText += text[i];
                }
            }
            return finalText;
        }
    }
}
