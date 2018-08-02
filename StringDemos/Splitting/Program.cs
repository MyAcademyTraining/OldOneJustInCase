using System;
using System.Linq;

class Splitting
{
    static void Main()
    {
        //string numbers = "1 2 3 4 5 6 7 8 9";
        //string[] separetedNumbers = numbers.Split(' ');
        //int sum = 0;
        //foreach (string n in separetedNumbers)
        //{
        //    sum += int.Parse(n);

        //}
        //Console.WriteLine(sum);

        //Console.WriteLine(numbers.Split(' ').Select(int.Parse).Sum());// Same as above

        //string numbers2 = "1 2 3     4, 5,, 6 7 8 9"; //ako go pusnem bez opciite shte grymne
        //string[] separetedNumbers2 = numbers2.Split(new char[] { ' ',',' },StringSplitOptions.RemoveEmptyEntries);
        // sum = 0;
        //foreach (string n in separetedNumbers2)
        //{
        //    sum += int.Parse(n);

        //}
        //string numbers3 = "1, 2, 3, 4, 5, 6, 7, 8, 9";
        //string[] separetedNumbers3 = numbers3.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
        //sum = 0;
        //foreach (string n in separetedNumbers3)
        //{
        //    sum += int.Parse(n);

        //}
        //Console.WriteLine(sum);

        string sentance = "textThis is some text, there is some text and text  text";
        string[] splitedSentance = sentance.Split(new string[] { "text" }, StringSplitOptions.None);
        foreach (string part in splitedSentance)
        {
            Console.WriteLine(part);
        }
        

        
    }
}

