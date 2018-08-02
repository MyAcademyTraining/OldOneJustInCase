using System;


//Write a program to check if in a given expression the(and ) brackets are put correctly.
//Input


//  On the only line you will receive an expression

//Output


//  Print Correct if the brackets are correct

//      Incorrect otherwise

class HW_corectBrackets
{
    static void Main()
    {
        string input = Console.ReadLine();
        int openBrackets = 0;
        bool AlreadyFind = false;
        foreach (char symbol in input)
        {
            if (symbol == '(')
            {
                openBrackets++;
            }
            else if (symbol == ')')
            {
                openBrackets--;
            }
            if (openBrackets < 0)
            {
                Console.WriteLine("Incorrect");
                AlreadyFind = true;
                break;
            }
        }

        if (openBrackets == 0)
        {
            Console.WriteLine("Correct");
        }
        else if (openBrackets != 0 && AlreadyFind == false)
        {
            Console.WriteLine("Incorrect");
        }
    }
}

