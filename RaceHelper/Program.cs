using System;

namespace RunHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ShowInfo();
                var command = Ask("Angi kommando: ")?.ToLower();
                if(command)
            }
        }

        private static void ShowInfo()
        {
            Console.WriteLine("Kommandoer:\r\n - 1 = Meld på deltaker\r\n - 2 = Vis startliste\r\n - 3 = Vis resultatliste\r\n");
        }
    }
}
