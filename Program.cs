using Recording;
using System;
using System.Media;

internal class Program
{
    private static void Main(string[] args)
    {
        SoundPlayer player = new SoundPlayer(@"C:\Users\Student\source\repos\yangaCYBORG\recording\YangaCY.wav");

        Logo logo = new Logo();

        logo.DisplayLogo();


        player.Play();

        Console.WriteLine();
        Console.WriteLine("Voice played successfully!");

        ChatBot bot = new ChatBot();
        bot.StartChat();


        Console.ReadKey();
    }
}