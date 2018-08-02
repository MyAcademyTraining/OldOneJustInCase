using System;

//Write a method that returns the last digit of given integer as an English word.Write a program that reads
//a number and prints the result of the method.
//Input


//   On the first line you will receive a number

//Output

//   Print the last digit of the number as an English word



    class Program
    {
    static string EngDigit(string input)
    {
        string output = "";
        int number = input[input.Length-1] - '0';
        switch (number)
        {
            case 0: output = "zero"; break;
            case 1: output = "one"; break;
            case 2: output = "two"; break;
            case 3: output = "three"; break;
            case 4: output = "four"; break;
            case 5: output = "five"; break;
            case 6: output = "six"; break;
            case 7: output = "seven"; break;
            case 8: output = "eight"; break;
            case 9: output = "nine"; break;
            default:
                break;
        }
        return output;
    }


        static void Main()
        {
        string input = Console.ReadLine();
        Console.WriteLine(EngDigit(input));

        }
    }

