using System;

namespace BasicsOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Student pesho = new Student("Pesho");
            pesho.firstName = "Pesho";
            pesho.lastName = "Family of Pesho";

            Student goshko = new Student("Gosho");

            int number = 5;
            ChangeNumber(number);
            Console.WriteLine(number); // Shte printira 5
        }
        static void ChangeNumber(int number)
        {
            number = 35;
        }
    }






    class Student
    {
        public Student(string name) //Konstruktor
        {
            firstName = name;
        }
       public string firstName;

        public string lastName;

        public void ChangeName(string name)
        {
            name = firstName;
        }
    }
}
