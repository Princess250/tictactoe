
using System;

namespace ticex2
{
    class Program
    {
        enum Menu { New = 1, About, Quit }

        static void Main(string[] args)
        {
            Menu k;
            bool quit = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to tic-tac-toe!\n");
                Console.WriteLine("1. New game\n2. About the author\n" +
                       "3. Quit");

                while (!Enum.TryParse<Menu>(Console.ReadKey().KeyChar.ToString(), out k)) ;

                Console.Clear();

                switch (k)
                {
                    case Menu.New:
                        char P1, P2, P3, P4, P5, P6, P7, P8, P9, P = 'X';
                        P1 = P2 = P3 = P4 = P5 = P6 = P7 = P8 = P9 = ' ';
                        int i = 0;
                        bool win = false;

                        do
                        {
                            Console.Clear();
                            Console.WriteLine("\n" + P1 + "|" + P2 + "|" + P3 + "\n-----\n" +
                                                   P4 + "|" + P5 + "|" + P6 + "\n-----\n" +
                                                   P7 + "|" + P8 + "|" + P9 + "\n");

                            if (++i > 9 || win)
                                break;

                            bool ok = false;

                            do
                            {
                                Console.Write(P + "'s move > ");
                                switch (Console.ReadKey().KeyChar)
                                {
                                    case '1':
                                        if (P1 == ' ')
                                        {
                                            P1 = P; ok = true;
                                            win = P2 == P && P3 == P
                                               || P4 == P && P7 == P
                                               || P5 == P && P9 == P;
                                        }
                                        break;
                                    case '2':
                                        if (P2 == ' ')
                                        {
                                            P2 = P; ok = true;
                                            win = P1 == P && P3 == P
                                               || P5 == P && P8 == P;
                                        }
                                        break;
                                    case '3':
                                        if (P3 == ' ')
                                        {
                                            P3 = P; ok = true;
                                            win = P1 == P && P2 == P
                                               || P6 == P && P9 == P
                                               || P5 == P && P7 == P;
                                        }
                                        break;
                                    case '4':
                                        if (P4 == ' ')
                                        {
                                            P4 = P; ok = true;
                                            win = P5 == P && P6 == P
                                               || P1 == P && P7 == P;
                                        }
                                        break;
                                    case '5':
                                        if (P5 == ' ')
                                        {
                                            P5 = P; ok = true;
                                            win = P4 == P && P6 == P
                                               || P2 == P && P8 == P
                                               || P1 == P && P9 == P
                                               || P3 == P && P7 == P;
                                        }
                                        break;
                                    case '6':
                                        if (P6 == ' ')
                                        {
                                            P6 = P; ok = true;
                                            win = P4 == P && P5 == P
                                               || P3 == P && P9 == P;
                                        }
                                        break;
                                    case '7':
                                        if (P7 == ' ')
                                        {
                                            P7 = P; ok = true;
                                            win = P8 == P && P9 == P
                                               || P1 == P && P4 == P
                                               || P3 == P && P5 == P;
                                        }
                                        break;
                                    case '8':
                                        if (P8 == ' ')
                                        {
                                            P8 = P; ok = true;
                                            win = P7 == P && P9 == P
                                               || P2 == P && P5 == P;
                                        }
                                        break;
                                    case '9':
                                        if (P9 == ' ')
                                        {
                                            P9 = P; ok = true;
                                            win = P7 == P && P8 == P
                                               || P3 == P && P6 == P
                                               || P1 == P && P5 == P;
                                        }
                                        break;
                                }
                                if (!ok)
                                    Console.WriteLine(" Move made is illegal! Try again.");
                            } while (!ok);

                            i
                                if (P == 'X')
                                    P = 'O';
                                else
                                    P = 'X';
                        } while (true);

                        if (win)
                            Console.WriteLine(P + "you won!");
                        else
                            Console.WriteLine("Game over!");
                        Console.WriteLine("[Press Enter to return to main menu...]");
                        while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                        break;
                    case Menu.About:
                        Console.WriteLine("About the author.");
                        Console.WriteLine("[Press Enter to return to main menu...]");
                        while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                        break;
                    case Menu.Quit:
                        Console.Write("Quit? [y/n]");
                        if (Console.ReadKey().KeyChar == 'y')
                            quit = true;
                        else
                            Console.Clear();
                        break;
                }
            } while (!quit);
        }
    }
}
