using System.ComponentModel.Design;
using static System.Net.Mime.MediaTypeNames;

namespace ChessBoard_Sami_Harun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Hej! Mata in en siffra för schackbrädan.");

            int size = int.Parse(Console.ReadLine());


            Console.WriteLine("Vad vill du att första tecknet ska vara?");
            string firstSign = Console.ReadLine();

            Console.WriteLine("Vad vill du att andra tecknet ska vara?");
            string secondSign = Console.ReadLine();

            for (int rader = 0; rader < size; rader++)
            {
                for (int kolumner = 0; kolumner < size; kolumner++)
                {
                    if ((rader + kolumner) % 2 == 0)
                    {
                        Console.Write(firstSign);
                    }
                    else
                    {
                        Console.Write(secondSign);
                    }
                }

                Console.WriteLine();
            }







            }
        }
    }


