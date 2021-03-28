using System;

namespace ConsoleApp47
{
    class Program
    {
        static void Main(string[] args)
        {
            int b1;
            Console.Write("number of box in bucket1:");
            b1 = int.Parse(Console.ReadLine());
            int b2;
            Console.Write("number of box in bucket2:");
            b2 = int.Parse(Console.ReadLine());
            int b3;
            Console.Write("number of box in bucket3:");
            b3 = int.Parse(Console.ReadLine());

            int numbk, rmbk;
            do
            {
                Console.WriteLine("bk1 = {0} || bk2 = {1} || bk3 = {2}",b1, b2, b3);
                Console.Write("A");
                Console.Write("bucket number : ");
                numbk = int.Parse(Console.ReadLine());
                switch (numbk)
                {
                    case 1:
                        Console.Write("number box remove : ");
                        rmbk = int.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        if ((rmbk >= 1 && rmbk < 3))
                        { b1 = b1 - rmbk; }
                        break;
                    case 2:
                        Console.Write("number box remove : ");
                        rmbk = int.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        if ((rmbk >= 1 && rmbk < 3))
                        { b2 = b2 - rmbk; }
                        break;
                    case 3:
                        Console.Write("number box remove : ");
                        rmbk = int.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        if ((rmbk >= 1 && rmbk < 3))
                        { b3 = b3 - rmbk; }
                        break;
                }
                if (b1 == 0 && b2 == 0 && b3 == 0)
                {
                    Console.WriteLine("B WINJA");
                }
                else
                {
                    Console.WriteLine("bk1 = {0}  ||  bk2 = {1}  ||  bk 3 = {2}", b1, b2, b3);
                    Console.Write(" B ");
                    Console.Write("choose bucket number : ");
                    numbk = int.Parse(Console.ReadLine());
                    switch (numbk)
                    {
                        case 1:
                            Console.Write("How many to remove? : ");
                            rmbk = int.Parse(Console.ReadLine());
                            Console.WriteLine("");
                            if ((rmbk >= 1 && rmbk < 3))
                            { b1 = b1 - rmbk; }
                            break;

                        case 2:
                            Console.Write("How many to remove? : ");
                            rmbk = int.Parse(Console.ReadLine());
                            Console.WriteLine("");
                            if ((rmbk >= 1 && rmbk < 3))
                            { b2 = b2 - rmbk; }
                            break;

                        case 3:
                            Console.Write("How many to remove? : ");
                            rmbk = int.Parse(Console.ReadLine());
                            Console.WriteLine("");
                            if ((rmbk >= 1 && rmbk < 3))
                            { b3 = b3 - rmbk; }
                            break;
                    }
                    if (b1 == 0 && b2 == 0 && b3 == 0)
                    {
                        Console.WriteLine("A WINJA");
                    }
                }
            } while (b1 != 0 || b2 != 0 || b3 != 0);
            Console.ReadLine();
        }
    }
}
