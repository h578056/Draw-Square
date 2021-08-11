using System;

namespace DrawSquare
{
    using System;
    using System.Text.RegularExpressions;

    namespace DrawSquare
    {
        static class DrawSquareFromInput
        {
            private static void Main(String[] args)
            {
                DrawSquareFromInput.drawSquare();
                ///DrawSquareFromInput.inputSquareSize();
            }
            public static int inputSquareSize()
            {
                bool positiveWholeNumber = false;
                int inputreturn = -1;
                Console.WriteLine("Type positive number for square size: ");
                string sizeTxt = Console.ReadLine();
                if (sizeTxt != null && Regex.IsMatch(sizeTxt, @"^\d+$"))
                {
                    int size = int.Parse(sizeTxt);
                    inputreturn = size;
                }
                return inputreturn;
            }
            public static void drawSquare()
            {
                bool isWholeNumber = false;
                int squareSize = -1;
                while (!isWholeNumber)
                {
                    squareSize = DrawSquareFromInput.inputSquareSize();
                    if (squareSize >= 0)
                    {
                        isWholeNumber = true;
                    }
                    else
                    {
                        Console.WriteLine("Error please provide whole positive number");
                    }
                }
                DrawSquareFromInput.printSquare(squareSize);
                Console.WriteLine("-----------------------------    ");
                DrawSquareFromInput.printSquaresInsideEachOther(squareSize);

            }
            private static void printSquare(int squareSize)
            {
                int lastRow = squareSize - 1;
                for (int i = 0; i < squareSize; i++)
                {
                    for (int j = 0; j < squareSize; j++)
                    {
                        if (i != 0 && i != lastRow)
                        {
                            if (j == 0 || j == (lastRow))
                            {
                                Console.Write("* ");
                            }
                            else
                            {
                                Console.Write("  ");
                            }
                        }
                        else
                        {
                            Console.Write("* ");
                        }
                    }
                    Console.WriteLine(" ");
                }
            }
            private static void printSquaresInsideEachOther(int squareSize)
            {
                int lastRow = squareSize - 1;
                for (int i = 0; i < squareSize; i++)
                {
                    for (int j = 0; j < squareSize; j++)
                    {
                        if ((i != 0 && i != lastRow))
                        {
                            if ((i != 1 && i != lastRow - 1))
                            {
                                if (j == 0 || j == (lastRow) || j == 1 || j == lastRow - 1)
                                {
                                    Console.Write("* ");
                                }
                                else
                                {
                                    Console.Write("  ");
                                }
                            }

                            else
                            {
                                Console.Write("* ");
                            }
                        }
                        else
                        {
                            Console.Write("* ");
                        }
                    }
                    Console.WriteLine(" ");
                }
            }

        }
    }

}
