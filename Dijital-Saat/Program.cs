using System;
using System.Threading;

namespace Dijital_Saat
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;

            int sutun = 0;
            int satir = 0;
            char a = '\u2588';  // █
            Console.SetCursorPosition(24, 4); Console.WriteLine(a);
            Console.SetCursorPosition(24, 6); Console.WriteLine(a);
            Console.SetCursorPosition(51, 4); Console.WriteLine(a);
            Console.SetCursorPosition(51, 6); Console.WriteLine(a);


            while (true)
            {
                // Sonsuz döngüden çıkmak için kullandığım blok
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo tus = Console.ReadKey(true);
                    break;
                }

                System.Threading.Thread.Sleep(1000);
                Console.Clear();
                sutun = 0;

                // Saatin dakika ve saniyeleri arasına çift nokta koymak için kullandığım blok
                Console.SetCursorPosition(24, 4); Console.WriteLine(a);
                Console.SetCursorPosition(24, 6); Console.WriteLine(a);
                Console.SetCursorPosition(51, 4); Console.WriteLine(a);
                Console.SetCursorPosition(51, 6); Console.WriteLine(a);


                // İlk digit ve sonrakiler, ve aralarındaki boşluklar
                Digit(a, DateTime.Now.Hour / 10, sutun, satir);

                sutun = 12;
                Digit(a, DateTime.Now.Hour % 10, sutun, satir);

                sutun = 27;
                Digit(a, DateTime.Now.Minute / 10, sutun, satir);

                sutun = 39;
                Digit(a, DateTime.Now.Minute % 10, sutun, satir);

                sutun = 54;
                Digit(a, DateTime.Now.Second / 10, sutun, satir);

                sutun = 66;
                Digit(a, DateTime.Now.Second % 10, sutun, satir);

            }
        }

        // Rakamların çizdirilmesi için yazdığım switch-case bloğu
        static void Digit(char a, int rakam, int sutun, int satir)
        {
            switch (rakam)
            {
                case 0:
                    YatayDigit(a, sutun + 0, satir + 0);
                    DikeyDigit(a, sutun + 0, satir + 0);
                    DikeyDigit(a, sutun + 9, satir + 0);
                    DikeyDigit(a, sutun + 0, satir + 5);
                    DikeyDigit(a, sutun + 9, satir + 5);
                    YatayDigit(a, sutun + 0, satir + 10);
                    break;
                case 1:
                    DikeyDigit(a, sutun + 9, satir + 0);
                    DikeyDigit(a, sutun + 9, satir + 5);
                    break;
                case 2:
                    YatayDigit(a, sutun + 0, satir + 0);
                    DikeyDigit(a, sutun + 9, satir + 0);
                    YatayDigit(a, sutun + 0, satir + 5);
                    DikeyDigit(a, sutun + 0, satir + 5);
                    YatayDigit(a, sutun + 0, satir + 10);
                    break;
                case 3:
                    YatayDigit(a, sutun + 0, satir + 0);
                    DikeyDigit(a, sutun + 9, satir + 0);
                    YatayDigit(a, sutun + 0, satir + 5);
                    DikeyDigit(a, sutun + 9, satir + 5);
                    YatayDigit(a, sutun + 0, satir + 10);
                    break;
                case 4:
                    DikeyDigit(a, sutun + 0, satir + 0);
                    DikeyDigit(a, sutun + 9, satir + 0);
                    YatayDigit(a, sutun + 0, satir + 5);
                    DikeyDigit(a, sutun + 9, satir + 5);
                    break;
                case 5:
                    YatayDigit(a, sutun + 0, satir + 0);
                    DikeyDigit(a, sutun + 0, satir + 0);
                    YatayDigit(a, sutun + 0, satir + 5);
                    DikeyDigit(a, sutun + 9, satir + 5);
                    YatayDigit(a, sutun + 0, satir + 10);
                    break;
                case 6:
                    YatayDigit(a, sutun + 0, satir + 0);
                    DikeyDigit(a, sutun + 0, satir + 0);
                    YatayDigit(a, sutun + 0, satir + 5);
                    DikeyDigit(a, sutun + 0, satir + 5);
                    DikeyDigit(a, sutun + 9, satir + 5);
                    YatayDigit(a, sutun + 0, satir + 10);
                    break;
                case 7:
                    YatayDigit(a, sutun + 0, satir + 0);
                    DikeyDigit(a, sutun + 9, satir + 0);
                    DikeyDigit(a, sutun + 9, satir + 5);
                    break;
                case 8:
                    YatayDigit(a, sutun + 0, satir + 0);
                    DikeyDigit(a, sutun + 0, satir + 0);
                    DikeyDigit(a, sutun + 9, satir + 0);
                    YatayDigit(a, sutun + 0, satir + 5);
                    DikeyDigit(a, sutun + 0, satir + 5);
                    DikeyDigit(a, sutun + 9, satir + 5);
                    YatayDigit(a, sutun + 0, satir + 10);
                    break;
                case 9:
                    YatayDigit(a, sutun + 0, satir + 0);
                    DikeyDigit(a, sutun + 0, satir + 0);
                    DikeyDigit(a, sutun + 9, satir + 0);
                    YatayDigit(a, sutun + 0, satir + 5);
                    DikeyDigit(a, sutun + 9, satir + 5);
                    YatayDigit(a, sutun + 0, satir + 10);
                    break;
                default:
                    Console.WriteLine("Hata");
                    break;
            }
        }


        // Rakamların yatay ve dikey dijital çizgilerinin her biri için Digit metodunda kullandığım iki ayrı metod
        static void YatayDigit(char a, int sutun, int satir)
        {
            Console.SetCursorPosition(sutun, satir);
            Console.WriteLine(new string(a, 10));
        }

        static void DikeyDigit(char a, int sutun, int satir)
        {
            for (int i = 0; i < 6; i++)
            {
                Console.SetCursorPosition(sutun, satir);
                Console.WriteLine(a);
                satir++;
            }
        }
    }
}

/*  Taslak çizim
              1         2         3         4         5         6         7         8
    012345678901234567890123456789012345678901234567890123456789012345678901234567890
0   ██████████  ██████████     ██████████  ██████████     ██████████  ██████████ 
1   █        █  █        █     █        █  █        █     █        █  █        █
2   █        █  █        █     █        █  █        █     █        █  █        █
3   █        █  █        █     █        █  █        █     █        █  █        █
4   █        █  █        █  █  █        █  █        █  █  █        █  █        █
5   ██████████  ██████████     ██████████  ██████████     ██████████  ██████████
6   █        █  █        █  █  █        █  █        █  █  █        █  █        █
7   █        █  █        █     █        █  █        █     █        █  █        █
8   █        █  █        █     █        █  █        █     █        █  █        █
9   █        █  █        █     █        █  █        █     █        █  █        █
10  ██████████  ██████████     ██████████  ██████████     ██████████  ██████████
*/
