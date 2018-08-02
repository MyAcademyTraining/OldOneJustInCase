using System;

//Index of letters

//Description

//Write a program that creates an array containing all letters from the alphabet(a-z). Read a word from the console and print the 
//index of each of its letters in the array.

//Input


//On the first line you will receive the word
//Output


//Print the index of each of the word's letters in the array
//Each index should be on a new line
//Constraints

//1 <= word length <= 128
//Word is consisted of lowercase english letters
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests

//Input   Output
//telerikacademy  19
//4
//11
//4
//17
//8
//10
//0
//2
//0
//3
//4
//12
//24


class Program
{
    static void Main()
    {
        char[] alphabet = new char[26];
        int j = 0;
        for (char i = 'a'; i <= 'z'; i++)
        {
            alphabet[j] = i;
            j++;
        }
        string Input = Console.ReadLine();
        char[] inputArray = new char[Input.Length];
        inputArray = Input.ToCharArray();
        for (int i = 0; i < inputArray.Length; i++)
        {
            for (int k = 0; k < alphabet.Length; k++)
            {
                if (inputArray[i] == alphabet[k])
                {
                    Console.WriteLine(k);
                }
            }
        }
    }
}

