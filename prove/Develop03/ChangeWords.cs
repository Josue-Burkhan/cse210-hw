class Changes 
{
    private Random randomWord = new Random();

    public void conditional()
    {
        Console.Clear();
        Scripture vers = new Scripture();
        Scripture title = new Scripture();
        string originalText = vers.MyScripture();
        string titleVers = title.TitleMyVers();

        string[] words = originalText.Split(' ');

        string[] modifiedWords = (string[])words.Clone();
        string quitText = "Press enter to continue or type 'quit' to finish:";

        while (true)
        {
            Console.Clear();
            Console.Write(titleVers);
            Console.WriteLine(string.Join(" ", modifiedWords));
            Console.WriteLine();
            Console.WriteLine(quitText);

            string inputUser = Console.ReadLine();

            if (inputUser == "quit")
                break;

            Replacements(words, modifiedWords, 6);

            if (!modifiedWords.Any(w => !w.All(c => c == '_')))
            {
                Console.Clear();
                Console.Write(titleVers);
                Console.WriteLine(string.Join(" ", modifiedWords));
                Console.WriteLine();
                Console.WriteLine(quitText);
                Console.ReadLine();
                break;
            }
        }
    }

    private void Replacements(string[] originalWords, string[] modifiedWords, int numbersToReplace)
    {
        var available = modifiedWords
            .Select((word, index) => new { word, index })
            .Where(x => !x.word.All(c => c == '_'))
            .Select(x => x.index)
            .ToList();

        int wordsToReplace = Math.Min(numbersToReplace, available.Count);

        for (int i = 0; i < wordsToReplace; i++)
        {
            int randomIndex = available[randomWord.Next(available.Count)];
            modifiedWords[randomIndex] = new string('_', originalWords[randomIndex].Length);

            available.Remove(randomIndex);
        }
    }
}