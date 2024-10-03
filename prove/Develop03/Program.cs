using System;

class Scripture 
{
    public string MyScripture()
    {
        string Myvers = "But behold, all things have been done in the wisdom of him who knoweth all things. Adam fell that men might be; and men are, that they might have joy."; 
        return Myvers;
    }
    public string TitleMyVers()
    {
        string titleVers = "2 Nephie 2:24-25: ";
        return titleVers;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Changes changesWords = new Changes();
        changesWords.conditional();
    }
}
