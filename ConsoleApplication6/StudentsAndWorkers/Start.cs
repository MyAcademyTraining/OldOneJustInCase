using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentsAndWorkers
{
    class Start
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            #region AddStudents
            students.Add(new Student("Asen", "Asenov", 3));
            students.Add(new Student("Boris", "Borisov", 4));
            students.Add(new Student("Vasil", "Vasilev", 5));
            students.Add(new Student("Georgi", "Georgiev", 6));
            students.Add(new Student("Delyan", "Delyanov", 3));
            students.Add(new Student("Emiel", "Emilov", 4));
            students.Add(new Student("Ivan", "Ivanov", 5));
            students.Add(new Student("Krasi", "Asenov", 6));
            students.Add(new Student("Lili", "Paklili", 3));
            students.Add(new Student("Milena", "Petrova", 4));
            #endregion

            // Order students by grades and print
            students = students.OrderBy(s => s.Grade).ToList();

            foreach (var stud in students)
            {
                Console.WriteLine(stud);
            }

            Console.WriteLine("---------------------------------------------------");
            List<Worker> workers = new List<Worker>();

            #region AddWorkers
            workers.Add(new Worker("Asen", "Asenov", 3, (decimal)120.2));
            workers.Add(new Worker("Boris", "Borisov", 4, (decimal)130.2));
            workers.Add(new Worker("Vasil", "Vasilev", 5, (decimal)143.0));
            workers.Add(new Worker("Georgi", "Georgiev", 6, (decimal)1232.3));
            workers.Add(new Worker("Delyan", "Delyanov", 3, (decimal)122.3));
            workers.Add(new Worker("Emiel", "Emilov", 4, (decimal)156.4));
            workers.Add(new Worker("Ivan", "Ivanov", 5, (decimal)210.4));
            workers.Add(new Worker("Krasi", "Asenov", 6, (decimal)1231.9));
            workers.Add(new Worker("Lili", "Paklili", 3, (decimal)121.32));
            workers.Add(new Worker("Milena", "Petrova", 4, (decimal)321.23));
            #endregion

            // Order workers by Money per Hour and Print
            workers = workers.OrderByDescending(w => w.MoneyPerH).ToList();
            foreach (var worker in workers)
            {
                Console.WriteLine(worker);
            }

            Console.WriteLine("---------------------------------------------------");

            //  Merging 2 lists
            List<Human> merged = new List<Human>();
            for (int i = 0; i < students.Count; i++)
            {
                merged.Add(students[i]);
            }

            for (int i = 0; i < workers.Count; i++)
            {
                merged.Add(workers[i]);
            }
            
            //OrderBy First Name
            merged = merged.OrderBy(x => x.FirstName).ToList();
            foreach (var human in merged)
            {
                Console.WriteLine(human);
            }

            Console.WriteLine("---------------------------------------------------");

            //OrderBy Last Name
            merged = merged.OrderBy(x => x.LastName).ToList();
            foreach (var human in merged)
            {
                Console.WriteLine(human);
            }

        }
    }
}
