using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static int lengthofSnake, MovesRemain, CurrentRow, CurrentColumn;
        static void WalkingAround(int rows, int columns, int[] entrance, string[] directions, char[,] field)
        {
            int entranceRow = entrance[0];
            int entranceCol = entrance[1];
            CurrentRow = entrance[0];
            CurrentColumn = entrance[1];
            lengthofSnake = 19;
            bool areWeDone = false;
            while (true)
            {
                for (int i = 0; i < directions.Length; i++)
                {
                    // moveUp
                    if (directions[i] == "w")
                    {
                        lengthofSnake--;
                        if (lengthofSnake == 0)
                        {
                            Console.WriteLine("Sneaky is going to starve at [{0},{1}]", CurrentRow, CurrentColumn);
                            areWeDone = true;
                            break;
                        }
                        CurrentRow--;
                        if (field[CurrentRow, CurrentColumn] == '%')
                        {
                            Console.WriteLine("Sneaky is going to hit a rock at [{0},{1}]", CurrentRow, CurrentColumn);
                            areWeDone = true;
                            break;
                        }
                        if (field[CurrentRow, CurrentColumn] == 'e')
                        {
                            Console.WriteLine("Sneaky is going to get out with length {0}", lengthofSnake / 5);
                            areWeDone = true;
                            break;
                        }
                        else if (field[CurrentRow, CurrentColumn] == '@')
                        {
                            lengthofSnake += 5;
                            field[CurrentRow, CurrentColumn] = '-';
                        }
                        continue;
                    }
                    //Move Down
                    if (directions[i] == "s")
                    {
                        if (CurrentRow == rows - 1)
                        {
                            Console.WriteLine("Sneaky is going to be lost into the depths with length {0}", lengthofSnake / 5);
                            areWeDone = true;
                            break;
                        }
                        lengthofSnake--;
                        if (lengthofSnake == 0)
                        {
                            Console.WriteLine("Sneaky is going to starve at [{0},{1}]", CurrentRow, CurrentColumn);
                            areWeDone = true;
                            break;
                        }
                        CurrentRow++;
                        if (field[CurrentRow, CurrentColumn] == '%')
                        {
                            Console.WriteLine("Sneaky is going to hit a rock at [{0},{1}]", CurrentRow, CurrentColumn);
                            areWeDone = true;
                            break;
                        }
                        if (field[CurrentRow, CurrentColumn] == 'e')
                        {
                            Console.WriteLine("Sneaky is going to get out with length {0}", lengthofSnake / 5);
                            areWeDone = true;
                            break;
                        }
                        else if (field[CurrentRow, CurrentColumn] == '@')
                        {
                            lengthofSnake += 5;
                            field[CurrentRow, CurrentColumn] = '-';
                        }
                        continue;
                    }
                    //move Left
                    if (directions[i] == "a")
                    {
                        lengthofSnake--;
                        if (lengthofSnake == 0)
                        {
                            Console.WriteLine("Sneaky is going to starve at [{0},{1}]", CurrentRow, CurrentColumn);
                            areWeDone = true;
                            break;
                        }
                        if (CurrentColumn == 0)
                        {
                            CurrentColumn = columns - 1;
                        }
                        else
                        {
                            CurrentColumn--;
                        }

                        if (field[CurrentRow, CurrentColumn] == '%')
                        {
                            Console.WriteLine("Sneaky is going to hit a rock at [{0},{1}]", CurrentRow, CurrentColumn);
                            areWeDone = true;
                            break;
                        }
                        if (field[CurrentRow, CurrentColumn] == 'e')
                        {
                            Console.WriteLine("Sneaky is going to get out with length {0}", lengthofSnake / 5);
                            areWeDone = true;
                            break;
                        }
                        else if (field[CurrentRow, CurrentColumn] == '@')
                        {
                            lengthofSnake += 5;
                            field[CurrentRow, CurrentColumn] = '-';
                        }
                        continue;
                    }
                    //move right
                    if (directions[i] == "d")
                    {
                        lengthofSnake--;
                        if (lengthofSnake == 0)
                        {
                            Console.WriteLine("Sneaky is going to starve at [{0},{1}]", CurrentRow, CurrentColumn);
                            areWeDone = true;
                            break;
                        }
                        if (CurrentColumn < columns - 1)
                        {
                            CurrentColumn++;
                        }
                        else
                        {
                            CurrentColumn = 0;
                        }

                        if (field[CurrentRow, CurrentColumn] == '%')
                        {
                            Console.WriteLine("Sneaky is going to hit a rock at [{0},{1}]", CurrentRow, CurrentColumn);
                            areWeDone = true;
                            break;
                        }
                        if (field[CurrentRow, CurrentColumn] == 'e')
                        {
                            Console.WriteLine("Sneaky is going to get out with length {0}", lengthofSnake / 5);
                            areWeDone = true;
                            break;
                        }
                        else if (field[CurrentRow, CurrentColumn] == '@')
                        {
                            lengthofSnake += 5;
                            field[CurrentRow, CurrentColumn] = '-';
                        }
                        continue;
                    }
                }

                if (areWeDone == false)
                {

                    Console.WriteLine("Sneaky is going to be stuck in the den at [{0},{1}]", CurrentRow, CurrentColumn);
                }
                break;
            }
        }



        static void Main(string[] args)
        {
            string size = Console.ReadLine();
            string[] temp = size.Split('x');
            int rows = int.Parse(temp[0]);
            int cols = int.Parse(temp[1]);
            char[,] field = new char[rows, cols];
            int[] entranceCord = new int[2];


            for (int i = 0; i < rows; i++)
            {
                char[] current = Console.ReadLine().ToCharArray();
                for (int j = 0; j < cols; j++)
                {
                    field[i, j] = current[j];
                    if (current[j] == 'e')
                    {
                        entranceCord[0] = i;
                        entranceCord[1] = j;
                    }
                }
            }
            string directionsTemp = Console.ReadLine();
            string[] directions = directionsTemp.Split(',').ToArray();

            WalkingAround(rows, cols, entranceCord, directions, field);

        }
    }
}

