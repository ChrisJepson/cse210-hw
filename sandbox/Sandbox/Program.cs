using System;

class Program
{
    static void Main(string[] args)
    {
        BaldEagle joey =  new BaldEagle("Joey", "Screee");
        BaldEagle dragon = new BaldEagle("Dragon", "Rawr");

        joey.MakeSound();
        dragon.MakeSound();
    }
}

