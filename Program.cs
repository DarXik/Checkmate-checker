string[,] table = new string[8, 8];
string[] letters = new string[] {" ", "a", "b", "c", "d", "e", "f", "g", "h"};
string[] numbers = new string[] {"1", "2", "3", "4", "5", "6", "7", "8"};

// K king one step in any direction
// R rook horizontal and vertical
// B bishop diagonal
// Q queen horizontal, vertical and diagonal
// N knight L shape
// P pawn one step forward and diagonal if enemy

while (true)
{
    for (int i = 0; i < 8; i++)
    {
        for (int j = 0; j < 8; j++)
        {
            table[i, j] = ".";
        }
    }

    Console.WriteLine("---Checkmate checker---");
    PrintTable();

    Console.WriteLine("Enter up to max 8 rows with up 8 columns: "); // .. R... .K...  ...

    string input = Console.ReadLine() ?? string.Empty;
    var rows = input.Split(" ");

    for (int i = 0; i < rows.Length; i++)
    {
        for (int j = 0; j < rows[i].Length; j++)
        {
            table[i, j] = rows[i][j].ToString().ToUpper();
        }
    }

    for (int i = 0; i < 8; i++)
    {
        for (int j = 0; j < 8; j++)
        {
            // if (table[i, j] == "K") // check King
            // {
            //     if (i - 1 >= 0 && j - 1 >= 0) // diagonal up left
            //     {
            //         table[i - 1, j - 1] = "X";
            //     }
            //
            //     if (i - 1 >= 0) // up
            //     {
            //         table[i - 1, j] = "X";
            //     }
            //
            //     if (i - 1 >= 0 && j + 1 < 8) // diagonal up right
            //     {
            //         table[i - 1, j + 1] = "X";
            //     }
            //
            //     if (j - 1 >= 0) // left
            //     {
            //         table[i, j - 1] = "X";
            //     }
            //
            //     if (j + 1 < 8) // right
            //     {
            //         table[i, j + 1] = "X";
            //     }
            //
            //     if (i + 1 < 8 && j - 1 >= 0) // diagonal down left
            //     {
            //         table[i + 1, j - 1] = "X";
            //     }
            //
            //     if (i + 1 < 8) // down
            //     {
            //         table[i + 1, j] = "X";
            //     }
            //
            //     if (i + 1 < 8 && j + 1 < 8) // diagonal down right
            //     {
            //         table[i + 1, j + 1] = "X";
            //     }
            // }

            if (table[i, j] == "Q") // Queen
            {
                // diagonal up left
                for (int k = i - 1, l = j - 1; k >= 0 && l >= 0; k--, l--)
                {
                    if (table[k, l] == "K")
                    {
                        Console.WriteLine("King is under attack!");
                        // PrintTable();
                        // return;
                    }
                    else
                    {
                        table[k, l] = @"\";
                    }
                }

                // up
                for (int k = i - 1; k >= 0; k--)
                {
                    if (table[k, j] == "K")
                    {
                        Console.WriteLine("King is under attack!");
                        // PrintTable();
                        // return;
                    }
                    else
                    {
                        table[k, j] = "|";
                    }
                }

                // diagonal up right
                for (int k = i - 1, l = j + 1; k >= 0 && l < 8; k--, l++)
                {
                    if (table[k, l] == "K")
                    {
                        Console.WriteLine("King is under attack!");
                        // PrintTable();
                        // return;
                    }
                    else
                    {
                        table[k, l] = "/";
                    }
                }

                // left
                for (int k = j - 1; k >= 0; k--)
                {
                    if (table[i, k] == "K")
                    {
                        Console.WriteLine("King is under attack!");
                        // PrintTable();
                        // return;
                    }
                    else
                    {
                        table[i, k] = "-";
                    }
                }

                // right
                for (int k = j + 1; k < 8; k++)
                {
                    if (table[i, k] == "K")
                    {
                        Console.WriteLine("King is under attack!");
                        // PrintTable();
                        // return;
                    }
                    else
                    {
                        table[i, k] = "-";
                    }
                }

                // diagonal down left
                for (int k = i + 1, l = j - 1; k < 8 && l >= 0; k++, l--)
                {
                    if (table[k, l] == "K")
                    {
                        Console.WriteLine("King is under attack!");
                        // PrintTable();
                        // return;
                    }
                    else
                    {
                        table[k, l] = "/";
                    }
                }

                // down
                for (int k = i + 1; k < 8; k++)
                {
                    if (table[k, j] == "K")
                    {
                        Console.WriteLine("King is under attack!");
                        // PrintTable();
                        // return;
                    }
                    else
                    {
                        table[k, j] = "|";
                    }
                }

                // diagonal down right
                for (int k = i + 1, l = j + 1; k < 8 && l < 8; k++, l++)
                {
                    if (table[k, l] == "K")
                    {
                        Console.WriteLine("King is under attack!");
                        // PrintTable();
                        // return;
                    }
                    else
                    {
                        table[k, l] = @"\";
                    }
                }
            }

            if (table[i, j] == "R") // Rook
            {
                // up
                for (int k = i - 1; k >= 0; k--)
                {
                    if (table[k, j] == "K")
                    {
                        Console.WriteLine("King is under attack!");
                        // PrintTable();
                        // return;
                    }
                    else
                    {
                        table[k, j] = "|";
                    }
                }

                // down
                for (int k = i + 1; k < 8; k++)
                {
                    if (table[k, j] == "K")
                    {
                        Console.WriteLine("King is under attack!");
                        // PrintTable();
                        // return;
                    }
                    else
                    {
                        table[k, j] = "|";
                    }
                }

                // left
                for (int k = j - 1; k >= 0; k--)
                {
                    if (table[i, k] == "K")
                    {
                        Console.WriteLine("King is under attack!");
                        // PrintTable();
                        // return;
                    }
                    else
                    {
                        table[i, k] = "-";
                    }
                }

                // right
                for (int k = j + 1; k < 8; k++)
                {
                    if (table[i, k] == "K")
                    {
                        Console.WriteLine("King is under attack!");
                        // PrintTable();
                        // return;
                    }
                    else
                    {
                        table[i, k] = "-";
                    }
                }
            }

            if (table[i, j] == "B") // Bishop
            {
                // diagonal up left
                for (int k = i - 1, l = j - 1; k >= 0 && l >= 0; k--, l--)
                {
                    if (table[k, l] == "K")
                    {
                        Console.WriteLine("King is under attack!");
                        // PrintTable();
                        // return;
                    }
                    else
                    {
                        table[k, l] = @"\";
                    }
                }

                // diagonal up right
                for (int k = i - 1, l = j + 1; k >= 0 && l < 8; k--, l++)
                {
                    if (table[k, l] == "K")
                    {
                        Console.WriteLine("King is under attack!");
                        // PrintTable();
                        // return;
                    }
                    else
                    {
                        table[k, l] = "/";
                    }
                }

                // diagonal down left
                for (int k = i + 1, l = j - 1; k < 8 && l >= 0; k++, l--)
                {
                    if (table[k, l] == "K")
                    {
                        Console.WriteLine("King is under attack!");
                        // PrintTable();
                        // return;
                    }
                    else
                    {
                        table[k, l] = "/";
                    }
                }

                // diagonal down right
                for (int k = i + 1, l = j + 1; k < 8 && l < 8; k++, l++)
                {
                    if (table[k, l] == "K")
                    {
                        Console.WriteLine("King is under attack!");
                        // PrintTable();
                        // return;
                    }
                    else
                    {
                        table[k, l] = @"\";
                    }
                }
            }

            // if (table[i, j] == "H") // Horse - Knight
            // {
            //
            // }

            if (table[i, j] == "P") // Pawn
            {
                // diagonal up left
                if (i - 1 >= 0 && j - 1 >= 0)
                {
                    if (table[i - 1, j - 1] == "K")
                    {
                        Console.WriteLine("King is under attack from right!");
                        // PrintTable();
                        // return;
                    }
                    else
                    {
                        table[i - 1, j - 1] = @"\";
                    }
                }

                // diagonal up right
                if (i - 1 >= 0 && j + 1 < 8)
                {
                    if (table[i - 1, j + 1] == "K")
                    {
                        Console.WriteLine("King is under attack from left!");
                        // PrintTable();
                        // return;
                    }
                    else
                    {
                        table[i - 1, j + 1] = "/";
                    }
                }
            }
        }
        // PrintTable();
    }

    PrintTable();
}

void PrintTable()
{
    for (int i = 0; i < 9; i++)
    {
        Console.Write(letters[i] + " ");
    }

    Console.WriteLine();
    Array.Reverse(numbers);
    for (int i = 0; i < 8; i++)
    {
        Console.Write(numbers[i] + " ");
        for (int j = 0; j < 8; j++)
        {
            if (table[i, j] == "K")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(table[i, j] + " ");
                Console.ResetColor();
            }
            else
            {
                Console.Write(table[i, j] + " ");
            }
        }

        Console.WriteLine();
    }
}