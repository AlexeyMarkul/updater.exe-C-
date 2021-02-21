using System;
using System.IO;
using System.Net;



namespace updater
{
    class Program
    {
        static void Main(string[] args)
        {
            string osnova = @"C:\app\osnover\osnova.txt";
            string downloadsr = @"C:\app\upload\update.txt";

            Console.WriteLine("скачивание");

             WebClient webClient = new WebClient();
              {
                   webClient.DownloadFile("https://drive.google.com/uc?export=download&confirm=no_antivirus&id=1SxDb81jxwVpz0503XFpJa1IP5fUFNfUM", @"C:\app\upload\update.txt");
              }

            Console.WriteLine("Скачивание END");

            if (File.ReadAllText(osnova) == File.ReadAllText(downloadsr))
            {
                Console.WriteLine("не требует обновления");

            }

            else
            {
                File.Delete(osnova);
                Console.WriteLine("требует обновления");
                //скачивание приложения
                WebClient gg = new WebClient();
                {
                    gg.DownloadFile("https://drive.google.com/uc?export=download&confirm=no_antivirus&id=1gNkxM3qTti_C0Y2Y7HZeFZq4JUHfgcoh", @"C:\app\cook\10.zip");
                }
                //
                File.Move(@"C:\app\upload\update.txt", @"C:\app\osnover\osnova.txt");

            }
        }       
    }
}