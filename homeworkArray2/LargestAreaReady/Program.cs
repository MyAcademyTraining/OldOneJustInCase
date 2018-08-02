using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class LargestAreaInMa3x
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int rows = int.Parse(input[0]);
        int columns = int.Parse(input[1]);
        int[,] Ma3x = new int[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            string[] temp = Console.ReadLine().Split(' ');
            for (int j = 0; j < columns; j++)
            {
                Ma3x[i, j] = int.Parse(temp[j]);
            }
        }

        bool[,] alreadyStepped = new bool[rows, columns];
        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < columns; c++)
            {
                alreadyStepped[r, c] = false;
            }
        }
        List<int> isChanged = new List<int>();
        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < columns; c++)
            {
                int element = Ma3x[r, c];
                while ((alreadyStepped[r, c] == false))
                {
                    if ((r == 0 || c == 0) && ((r < rows - 1) && (c < columns - 1)))
                    {
                        if (((element == Ma3x[r + 1, c]) || (element == Ma3x[r, c + 1])))
                        {
                            isChanged.Add(element);
                        }
                    }
                    else if ((r == (rows - 1) || c == (columns - 1)) && ((r != 0) && c != 0))
                    {
                        if ((element == Ma3x[r - 1, c]) || (element == Ma3x[r, c - 1]))
                        {
                            isChanged.Add(element);
                        }
                    }
                    else if ((r != 0) && (c != 0) && (r < r + 1) && (c < c + 1))
                    {
                        if ((element == Ma3x[r + 1, c]) || (element == Ma3x[r - 1, c])
                         || (element == Ma3x[r, c + 1]) || (element == Ma3x[r, c - 1]))

                        {
                            isChanged.Add(element);
                        }
                    }
                    alreadyStepped[r, c] = true;
                }
            }
        }
        int maxCountInList = 0;
        int tempCount = 1;
        isChanged.Sort();
        for (int i = 0; i < isChanged.Count - 1; i++)
        {
            if (isChanged[i] == isChanged[i + 1])
            {
                tempCount++;
            }
            else
            {
                tempCount = 1;
            }
            if (tempCount > maxCountInList)
            {
                maxCountInList = tempCount;
            }
        }

        Console.WriteLine(maxCountInList);
    }

}